using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passingwind.Datatables.Mvc
{
    public class DataTableSelect
    {
        private DataTable _dataTable;

        internal IDictionary<string, object> Property { get; }


        public DataTableSelect(DataTable dataTable)
        {
            this._dataTable = dataTable;

            this.Property = new Dictionary<string, object>();

            _dataTable.Select = this;
        }


        public DataTableSelect Style(string value)
        {
            Property["style"] = value;
            return this;
        }

        public DataTableSelect Selector(string value)
        {
            Property["selector"] = value;
            return this;
        }

        public DataTableSelect Items(string value)
        {
            Property["items"] = value;
            return this;
        }

        public DataTableSelect Info(bool value)
        {
            Property["info"] = value;
            return this;
        }

        public DataTableSelect ClassName(string value)
        {
            Property["className"] = value;
            return this;
        }

        public DataTableSelect Blurable(bool value)
        {
            Property["blurable"] = value;
            return this;
        }


    }
}
