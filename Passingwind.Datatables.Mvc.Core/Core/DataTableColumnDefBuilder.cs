using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passingwind.Datatables.Mvc
{
    public class DataTableColumnDefBuilder
    {
        private DataTable _dataTable;

        public DataTableColumnDefBuilder(DataTable dt)
        {
            this._dataTable = dt;

        }

        public DataTableColumuDef TargetAll()
        {
            var columuDef = new DataTableColumuDef();

            columuDef.TargetAll();

            _dataTable.ColumuDefs.Add(columuDef);

            return columuDef;
        }

        public DataTableColumuDef Targets(params int[] targets)
        {
            var columuDef = new DataTableColumuDef(targets);

            _dataTable.ColumuDefs.Add(columuDef);

            return columuDef;
        }

    }
}
