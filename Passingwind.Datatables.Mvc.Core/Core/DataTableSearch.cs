using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passingwind.Datatables.Mvc
{
    public class DataTableSearch
    {
        private DataTable _dataTable;

        internal IDictionary<string, object> Property { get; }


        public DataTableSearch(DataTable dataTable)
        {
            this._dataTable = dataTable;

            this.Property = new Dictionary<string, object>();

            _dataTable.Search = this;

        }

        public DataTableSearch Search(string value)
        {
            Property["search"] = value;
            return this;
        }

        public DataTableSearch Regex(bool value)
        {
            Property["regex"] = value;
            return this;
        }

        public DataTableSearch CaseInsensitive(bool value)
        {
            Property["caseInsensitive"] = value;
            return this;
        }

        public DataTableSearch Smart(bool value)
        {
            Property["smart"] = value;
            return this;
        }

    }

    //public class DataTableSearchBuilder
    //{
    //    private DataTable _dataTable;

    //    public DataTableSearchBuilder(DataTable dt)
    //    {
    //        this._dataTable = dt;
    //    }

    //    public DataTableSearch Url(string url)
    //    {
    //        var ajax = new DataAjax(url);

    //        _dataTable.Ajax = ajax;

    //        return ajax;
    //    }
    //}
}
