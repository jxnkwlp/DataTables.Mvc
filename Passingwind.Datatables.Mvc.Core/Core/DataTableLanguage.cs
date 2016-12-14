using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passingwind.Datatables.Mvc
{
    public class DataTableLanguage
    {
        private DataTable _dataTable;

        internal DataTableLanguagePaginate Pagination { get; set; }

        internal IDictionary<string, object> Property { get; }


        public DataTableLanguage(DataTable dataTable)
        {
            this._dataTable = dataTable;

            this.Property = new Dictionary<string, object>();

            _dataTable.Language = this;
        }

        public DataTableLanguage Decimal(string value)
        {
            Property["decimal"] = value;
            return this;
        }

        public DataTableLanguage EmptyTable(string value)
        {
            Property["emptyTable"] = value;
            return this;
        }

        public DataTableLanguage Info(string value)
        {
            Property["info"] = value;
            return this;
        }

        public DataTableLanguage InfoEmpty(string value)
        {
            Property["infoEmpty"] = value;
            return this;
        }

        public DataTableLanguage InfoFiltered(string value)
        {
            Property["infoFiltered"] = value;
            return this;
        }

        public DataTableLanguage InfoPostFix(string value)
        {
            Property["infoPostFix"] = value;
            return this;
        }

        public DataTableLanguage LengthMenu(string value)
        {
            Property["lengthMenu"] = value;
            return this;
        }

        public DataTableLanguage LoadingRecords(string value)
        {
            Property["loadingRecords"] = value;
            return this;
        }

        public DataTableLanguage Processing(string value)
        {
            Property["processing"] = value;
            return this;
        }

        public DataTableLanguage Search(string value)
        {
            Property["search"] = value;
            return this;
        }

        public DataTableLanguage SearchPlaceholder(string value)
        {
            Property["searchPlaceholder"] = value;
            return this;
        }

        public DataTableLanguage Thousands(string value)
        {
            Property["thousands"] = value;
            return this;
        }

        public DataTableLanguage Url(string value)
        {
            Property["url"] = value;
            return this;
        }

        public DataTableLanguage ZeroRecords(string value)
        {
            Property["zeroRecords"] = value;
            return this;
        }


        public DataTableLanguage Paginate(Action<DataTableLanguagePaginate> action)
        {
            action(new DataTableLanguagePaginate(this));

            return this;
        }

    }

    public class DataTableLanguagePaginate
    {
        private DataTableLanguage _language;

        internal IDictionary<string, object> Property { get; }

        public DataTableLanguagePaginate(DataTableLanguage language)
        {
            this.Property = new Dictionary<string, object>();
            this._language = language;

            this._language.Pagination = this;

            //this._language.Property["paginate"] = this;
        }

        public DataTableLanguagePaginate First(string value)
        {
            Property["first"] = value;
            return this;
        }

        public DataTableLanguagePaginate Last(string value)
        {
            Property["last"] = value;
            return this;
        }

        public DataTableLanguagePaginate Next(string value)
        {
            Property["next"] = value;
            return this;
        }

        public DataTableLanguagePaginate Previous(string value)
        {
            Property["previous"] = value;
            return this;
        }
    }
}
