using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passingwind.Datatables.Mvc
{
    public class DataTableColumn
    {
        internal IDictionary<string, object> Property { get; }


        public DataTableColumn(string name)
        {
            this.Property = new Dictionary<string, object>();

            this.Property["name"] = name;
        }

        public DataTableColumn Field(string value)
        {
            this.Property["data"] = value;

            return this;
        }


        public DataTableColumn CellType(string value)
        {
            this.Property["cellType"] = value;

            return this;
        }

        public DataTableColumn ClassName(string value)
        {
            this.Property["className"] = value;

            return this;
        }

        public DataTableColumn ContentPadding(string value)
        {
            this.Property["contentPadding"] = value;

            return this;
        }

        public DataTableColumn Data(object data)
        {
            this.Property["data"] = data;

            return this;
        }

        public DataTableColumn DefaultContent(string value)
        {
            this.Property["defaultContent"] = value;

            return this;
        }

        public DataTableColumn Orderable(bool value)
        {
            this.Property["orderable"] = value;

            return this;
        }

        public DataTableColumn OrderData(params int[] value)
        {
            this.Property["orderData"] = value;

            return this;
        }

        public DataTableColumn OrderDataType(string value)
        {
            this.Property["orderDataType"] = value;

            return this;
        }

        public DataTableColumn OrderSequence(params string[] value)
        {
            this.Property["orderSequence"] = value;

            return this;
        }

        public DataTableColumn Searchable(bool value)
        {
            this.Property["searchable"] = value;

            return this;
        }

        public DataTableColumn Title(string value)
        {
            this.Property["title"] = value;

            return this;
        }

        public DataTableColumn Type(string value)
        {
            this.Property["type"] = value;

            return this;
        }

        public DataTableColumn Visible(bool value)
        {
            this.Property["visible"] = value;

            return this;
        }

        public DataTableColumn Width(string value)
        {
            this.Property["width"] = value;

            return this;
        }

    }

    public class DataTableColumn<TModel> : DataTableColumn
    {
        public DataTableColumn(string name) : base(name)
        {
        }
    }
}
