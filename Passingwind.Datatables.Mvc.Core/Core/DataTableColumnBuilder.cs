using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Passingwind.Datatables.Mvc
{
    public class DataTableColumnBuilder
    {
        internal DataTable _dataTable;

        public DataTableColumnBuilder(DataTable dt)
        {
            this._dataTable = dt;
        }

        public DataTableColumn Add(string columeName)
        {
            var columu = new DataTableColumn(columeName);

            _dataTable.Columns.Add(columu);

            return columu;
        }

    }

    public class DataTableColumnBuilder<TModel> : DataTableColumnBuilder
    {
        public DataTableColumnBuilder(DataTable dt) : base(dt)
        {
        }

        public DataTableColumn ModelFor<TProperty>(Expression<Func<TModel, TProperty>> expression)
        {
            var name = ExpressionHelper.GetExpressionText(expression);

            var columu = new DataTableColumn(name);

            columu.Property["data"] = name;

            _dataTable.Columns.Add(columu);

            return columu;

        }
    }


}
