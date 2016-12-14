using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passingwind.Datatables.Mvc
{
    public class DataTable
    {
        public IList<Column> Columns { get; set; }

        public DataTable()
        {
            this.Columns = new List<Column>();
        }
    }

    public class DataTableBuilder
    {
        //public DataTable Columns<TColumns>(Func<ColumnBuilder, TColumns> columnsAction)
        //{
        //    return this;
        //}

        public DataTable DataTable { get; }

        public DataTableBuilder(DataTable dataTable)
        {
            this.DataTable = dataTable;
        }


        public DataTableBuilder Columns(Action<ColumnBuilder> columnsAction)
        {
            columnsAction(new ColumnBuilder(DataTable));

            return this;
        }


        //public DataTable()
        //{
        //    //Columns((c) => new
        //    //{
        //    //    id = c.Add("1212"),
        //    //    name = c.Add("12")
        //    //});

        //    Columns(c =>
        //    {
        //        c.Add("1");
        //        c.Add("2");
        //    });
        //}

    }

    //public class ColumnBuilder
    //{
    //    public void Add(object columns)
    //    { }
    //}

    public class ColumnBuilder
    {
        private DataTable _dataTable;

        public ColumnBuilder(DataTable dt)
        {
            this._dataTable = dt;
        }

        //public Column Add(string name)
        //{
        //    return new Column(name);
        //}

        public void Add(Column colume)
        {
            _dataTable.Columns.Add(colume);
        }
    }
}
