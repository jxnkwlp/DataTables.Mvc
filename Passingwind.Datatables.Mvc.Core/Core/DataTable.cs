using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebPages;
using Newtonsoft.Json.Linq;

namespace Passingwind.Datatables.Mvc
{
    public class DataTable
    {
        internal string Id { get; }

        internal IDictionary<string, object> Features { get; }

        internal IDictionary<string, object> Options { get; }

        internal IList<DataTableColumn> Columns { get; }

        internal IList<DataTableColumuDef> ColumuDefs { get; }

        internal DataTableAjax Ajax { get; set; }

        internal DataTableSearch Search { get; set; }

        internal DataTableSelect Select { get; set; }

        internal DataTableLanguage Language { get; set; }


        #region Features

        /// <summary>
        /// Feature control DataTables' smart column width handling
        /// </summary>
        public DataTable AutoWidth(bool value)
        {
            Features["autoWidth"] = value;

            return this;
        }

        /// <summary>
        /// Feature control deferred rendering for additional speed of initialisation.
        /// </summary>
        public DataTable DeferRender(bool value)
        {
            Features["deferRender"] = value;

            return this;
        }
        /// <summary>
        /// Feature control table information display field
        /// </summary>
        public DataTable Info(bool value)
        {
            Features["info"] = value;

            return this;
        }
        /// <summary>
        /// Use markup and classes for the table to be themed by jQuery UI ThemeRoller.
        /// </summary>
        public DataTable JQueryUI(bool value)
        {
            Features["jQueryUI"] = value;

            return this;
        }
        /// <summary>
        /// Feature control the end user's ability to change the paging display length of the table.
        /// </summary>
        public DataTable LengthChange(bool value)
        {
            Features["lengthChange"] = value;

            return this;
        }
        /// <summary>
        /// Feature control ordering (sorting) abilities in DataTables.
        /// </summary>
        public DataTable Ordering(bool value)
        {
            Features["ordering"] = value;

            return this;
        }
        /// <summary>
        /// Enable or disable table pagination.
        /// </summary>
        public DataTable Paging(bool value)
        {
            Features["paging"] = value;

            return this;
        }
        /// <summary>
        /// Feature control the processing indicator.
        /// </summary>
        public DataTable Processing(bool value)
        {
            Features["processing"] = value;

            return this;
        }
        /// <summary>
        /// Horizontal scrolling
        /// </summary>
        public DataTable ScrollX(bool value)
        {
            Features["scrollX"] = value;

            return this;
        }
        /// <summary>
        /// Vertical scrolling
        /// </summary>
        public DataTable ScrollY(string value)
        {
            Features["scrollY"] = value;

            return this;
        }
        /// <summary>
        /// Feature control search (filtering) abilities
        /// </summary>
        public DataTable Searching(bool value)
        {
            Features["searching"] = value;

            return this;
        }
        /// <summary>
        /// Feature control DataTables' server-side processing mode.
        /// </summary>
        public DataTable ServerSide(bool value)
        {
            Features["serverSide"] = value;

            return this;
        }
        /// <summary>
        /// State saving - restore table state on page reload
        /// </summary>
        public DataTable StateSave(bool value)
        {
            Features["stateSave"] = value;

            return this;
        }


        #endregion

        #region Data

        public DataTable Data(object value)
        {
            Options["data"] = value;
            return this;
        }
        public DataTable Data(Func<object, HelperResult> func)
        {
            if (func != null)
                Options["data"] = new JRaw(func(0).ToHtmlString());
            return this;
        }

        #endregion

        #region Options


        public DataTable DeferLoading(string value)
        {
            Options["deferLoading"] = value;
            return this;
        }

        public DataTable Destroy(bool value)
        {
            Options["destroy"] = value;
            return this;
        }

        public DataTable DisplayStart(bool value)
        {
            Options["displayStart"] = value;
            return this;
        }

        public DataTable Dom(string value)
        {
            Options["dom"] = value;
            return this;
        }

        public DataTable LengthMenu(params object[] value)
        {
            Options["lengthMenu"] = value;
            return this;
        }

        public DataTable Order(params string[] value)
        {
            Options["order"] = value;
            return this;
        }

        public DataTable OrderCellsTop(bool value)
        {
            Options["orderCellsTop"] = value;
            return this;
        }

        public DataTable OrderClasses(bool value)
        {
            Options["orderClasses"] = value;
            return this;
        }

        public DataTable OrderFixed(params string[] value)
        {
            Options["orderFixed"] = value;
            return this;
        }

        public DataTable OrderMulti(string value)
        {
            Options["orderMulti"] = value;
            return this;
        }

        public DataTable PageLength(int value)
        {
            Options["pageLength"] = value;
            return this;
        }

        public DataTable PagingType(string value)
        {
            Options["pagingType"] = value;
            return this;
        }

        public DataTable Renderer(object value)
        {
            Options["renderer"] = value;
            return this;
        }

        public DataTable Retrieve(bool value)
        {
            Options["retrieve"] = value;
            return this;
        }

        public DataTable RowId(string value)
        {
            Options["rowId"] = value;
            return this;
        }

        public DataTable ScrollCollapse(bool value)
        {
            Options["scrollCollapse"] = value;
            return this;
        }

        public DataTable SearchDelay(int value)
        {
            Options["searchDelay"] = value;
            return this;
        }

        public DataTable StateDuration(int value)
        {
            Options["stateDuration"] = value;
            return this;
        }

        public DataTable StripeClasses(params string[] value)
        {
            Options["stripeClasses"] = value;
            return this;
        }

        public DataTable TabIndex(int value)
        {
            Options["tabIndex"] = value;
            return this;
        }


        #endregion


        public DataTable(string id)
        {
            this.Id = id;

            this.Features = new Dictionary<string, object>();
            this.Options = new Dictionary<string, object>();

            this.Columns = new List<DataTableColumn>();
            this.ColumuDefs = new List<DataTableColumuDef>();

        }

    }

    public class DataTable<TModel> : DataTable
    {
        internal new IList<DataTableColumn<TModel>> Columns { get; }

        public DataTable(string id) : base(id)
        {
        }

    }

}
