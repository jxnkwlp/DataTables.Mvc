using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passingwind.Datatables.Mvc
{
    public class DataTableAjax
    {
        private DataTable _dataTable;

        internal IDictionary<string, object> Property { get; }

        public DataTableAjax(DataTable dataTable)
        {
            this._dataTable = dataTable;

            this.Property = new Dictionary<string, object>();

            _dataTable.Ajax = this;
        }

        //public DataTableAjax(string url, string method) : this()
        //{
        //    Property["url"] = url;

        //    if (!string.IsNullOrEmpty(method))
        //        Property["type"] = method;
        //}

        public DataTableAjax Url(string value)
        {
            Property["url"] = value;
            return this;
        }

        public DataTableAjax Method(string method)
        {
            Property["type"] = method;
            return this;
        }

        public DataTableAjax RequestData(object value)
        {
            Property["data"] = value;
            return this;
        }
    }

    //public class DataAjaxBuilder
    //{
    //    private DataTable _dataTable;

    //    public DataAjaxBuilder(DataTable dt)
    //    {
    //        this._dataTable = dt;
    //    }

    //    public DataTableAjax Url(string url)
    //    {
    //        var ajax = new DataTableAjax(url);

    //        _dataTable.Ajax = ajax;

    //        return ajax;
    //    }
    //}
}
