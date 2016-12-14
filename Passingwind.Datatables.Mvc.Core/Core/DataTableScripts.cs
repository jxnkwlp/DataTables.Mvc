using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Passingwind.Datatables.Mvc
{
    /// <summary>
    ///  datatables scripts
    /// </summary>
    public class DataTableScripts : IHtmlString
    {
        internal DataTable _dt;
        private bool formattingIndented = false;

        public DataTableScripts(DataTable dt)
        {
            this._dt = dt;
        }

        public DataTableScripts FormattingIndented(bool value)
        {
            formattingIndented = value;
            return this;
        }

        public DataTableScripts DataTable(Action<DataTable> action)
        {
            action(_dt);

            return this;
        }

        public DataTableScripts Search(Action<DataTableSearch> action)
        {
            action(new DataTableSearch(_dt));

            return this;
        }

        public DataTableScripts Select(Action<DataTableSelect> action)
        {
            action(new DataTableSelect(_dt));

            return this;
        }

        public DataTableScripts Language(Action<DataTableLanguage> action)
        {
            action(new DataTableLanguage(_dt));

            return this;
        }

        public DataTableScripts Ajax(Action<DataTableAjax> action)
        {
            action(new DataTableAjax(_dt));

            return this;
        }





        public DataTableScripts Columns(Action<DataTableColumnBuilder> columnsAction)
        {
            var columnBuilder = new DataTableColumnBuilder(_dt);
            columnsAction(columnBuilder);

            return this;
        }

        public DataTableScripts ColumnDefs(Action<DataTableColumnDefBuilder> columnsAction)
        {
            columnsAction(new DataTableColumnDefBuilder(_dt));

            return this;
        }

        public string ToHtmlString()
        {
            var builder = new DataTableScriptsBuilder(_dt);

            builder.formattingIndented = this.formattingIndented;

            return builder.ToString();
        }
    }

    public class DataTableScripts<TModel> : DataTableScripts
    {
        public DataTableScripts(DataTable dt) : base(dt)
        {
        }

        public DataTableScripts ColumnsFor(Action<DataTableColumnBuilder<TModel>> columnsAction)
        {
            columnsAction(new DataTableColumnBuilder<TModel>(_dt));

            return this;
        }
    }
}
