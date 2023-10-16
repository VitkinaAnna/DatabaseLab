using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database5
{
    public class Database
    {
        public string DBName;
        public List<Table> DBTablesList;

        public Database(string dbname)
        {
            DBName = dbname;
            DBTablesList = new List<Table>();
        }
    }
}
