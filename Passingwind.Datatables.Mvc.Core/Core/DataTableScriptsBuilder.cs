using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Passingwind.Datatables.Mvc
{
    public class DataTableScriptsBuilder
    {
        private DataTable _dataTable { get; }

        protected IDictionary<string, object> Options { get; set; }

        internal bool formattingIndented = false;

        public DataTableScriptsBuilder(DataTable dataTable)
        {
            this._dataTable = dataTable;

            this.Options = new Dictionary<string, object>();



            //
            SetDataTableOptions();

            SetColumnsOptions();

        }

        private void SetDataTableOptions()
        {
            foreach (var item in _dataTable.Features)
            {
                this.Options[item.Key] = item.Value;
            }

            foreach (var item in _dataTable.Options)
            {
                this.Options[item.Key] = item.Value;
            }

            if (_dataTable.Ajax != null)
                this.Options["ajax"] = _dataTable.Ajax.Property;

            if (_dataTable.Search != null)
                this.Options["search"] = _dataTable.Search.Property;

            if (_dataTable.Select != null)
                this.Options["select"] = _dataTable.Select.Property;

            if (_dataTable.Language != null)
            {
                if (_dataTable.Language.Pagination != null)
                    _dataTable.Language.Property["paginate"] = _dataTable.Language.Pagination.Property;

                this.Options["language"] = _dataTable.Language.Property;
            }

        }

        private void SetColumnsOptions()
        {
            List<IDictionary<string, object>> columnProperties = new List<IDictionary<string, object>>();

            foreach (var item in _dataTable.Columns)
            {
                columnProperties.Add(item.Property);
            }

            if (columnProperties.Count > 0)
                this.Options.Add("columns", columnProperties);


            List<IDictionary<string, object>> columnDefProperties = new List<IDictionary<string, object>>();

            foreach (var item in _dataTable.ColumuDefs)
            {
                columnDefProperties.Add(item.Property);
            }
            if (columnDefProperties.Count > 0)
                this.Options.Add("columnDefs", columnDefProperties);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"$('#{_dataTable.Id}').DataTable(");

            sb.Append(" " + JsonHelper.SerializeObject(this.Options,this.formattingIndented) + ");");

            return sb.ToString();
        }
    }
}
