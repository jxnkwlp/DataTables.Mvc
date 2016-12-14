using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passingwind.Datatables.Mvc
{
    /// <summary>
    ///
    /// </summary>
    public class DataTableRequest
    {
        /// <summary>
        ///  列
        /// </summary>
        public class RequestColumn
        {

            public string Data { get; set; }

            public string Name { get; set; }

            public bool Searchable { get; set; }

            public bool Orderable { get; set; }

            public RequestSearch Search { get; set; }
        }

        /// <summary>
        ///  搜索
        /// </summary>
        public class RequestSearch
        {
            public bool Regex { get; set; }

            public string Value { get; set; }
        }

        /// <summary>
        ///  排序
        /// </summary>
        public class RequestOrder
        {
            public int Column { get; set; }

            public string Dir { get; set; }
        }

        public int Draw { get; set; }

        public int Start { get; set; }

        public int Length { get; set; }

        public IList<RequestColumn> Columns { get; set; }

        public IList<RequestOrder> Order { get; set; }

        public RequestSearch Search { get; set; }


        public int GetPageNumber()
        {
            return this.Start % this.Length;
        }
    }
}
