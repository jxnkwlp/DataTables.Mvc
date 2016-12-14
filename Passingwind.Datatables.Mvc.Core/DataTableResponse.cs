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
    public class DataTableResponse
    {
        public int Draw { get; private set; }

        public int recordsTotal { get; private set; }

        public int recordsFiltered { get; private set; }

        /// <summary>
        /// 数据
        /// </summary>
        public object data { get; private set; }

        public DataTableResponse(object data, int recordsTotal, int draw = 1)
        {
            this.Draw = draw;
            this.data = data;
            this.recordsTotal = recordsTotal;
            this.recordsFiltered = recordsTotal;
        }
    }
}
