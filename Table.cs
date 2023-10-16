using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database5
{
    public class Table
    {
        public string TableName;
        public List<Column> TableColumnsList;
        public List<Row> TableRowsList;

        public Table(string tablename)
        {
            TableName = tablename;
            TableColumnsList = new List<Column>();
            TableRowsList = new List<Row>();
        }
    }
}
