using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database5
{
    public class Column
    {
        public string ColumnName;
        public TypeDB ColumnType;
        public string TypeName;

        public Column(string columnname, string columntype)
        {
            ColumnName = columnname;
            TypeName = columntype;

            switch (columntype)
            {
                case "Integer":
                    ColumnType = new TypeInteger();
                    break;
                case "Real":
                    ColumnType = new TypeReal();
                    break;
                case "Char":
                    ColumnType = new TypeChar();
                    break;
                case "String":
                    ColumnType = new TypeString();
                    break;
                case "HTLM":
                    ColumnType = new TypeHTML();
                    break;
                case "StringInvl":
                    ColumnType = new TypeStringInvl();
                    break;
                default:
                    ColumnType = new TypeString();
                    break;
            }
        }
    }
}
