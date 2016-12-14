using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebPages;
using Newtonsoft.Json.Linq;

namespace Passingwind.Datatables.Mvc
{
    public class DataTableColumuDef
    {
        internal IDictionary<string, object> Property { get; }


        public DataTableColumuDef()
        {
            Property = new Dictionary<string, object>();
        }

        public DataTableColumuDef(params int[] targets) : this()
        {
            if (targets != null)
            {
                Property["targets"] = targets;
            }
        }

        public DataTableColumuDef TargetAll()
        {
            Property["targets"] = "_all";

            return this;
        }


        public DataTableColumuDef Visible(bool value)
        {
            Property["visible"] = value;

            return this;
        }

        public DataTableColumuDef ClassName(string value)
        {
            Property["className"] = value;

            return this;
        }

        public DataTableColumuDef RenderString(string value)
        {
            Property["render"] = value;

            return this;
        }


        public DataTableColumuDef Render(Func<object, HelperResult> func)
        {
            if (func != null)
            {
                Property["render"] = new JRaw(func(0).ToHtmlString());
            }

            return this;
        }

    }
}
