using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Passingwind.Datatables.Mvc
{
    public static class HtmlExtensions
    {
        public static DataTableScripts DataTables(this HtmlHelper html, string id)
        {
            return new DataTableScripts(new DataTable(id));
        }

        public static DataTableScripts<TModel> DataTablesFor<TModel>(this HtmlHelper<TModel> html, string id)
        {
            return new DataTableScripts<TModel>(new DataTable(id));
        }
    }
}

