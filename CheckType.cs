using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database5
{
    public class CheckType
    {
        private List<string> EnableTypes = new List<string> { "Integer", "Real", "Char", "String", "StringInvl", "HTML" };
        string curType;

        public CheckType(string type)
        {
            if (EnableTypes.Contains(type))
            {
                curType = type;
            }
            else
            {
                curType = EnableTypes[3];
            }
        }

        public bool Validation(string value)
        {
            switch (curType)
            {
                case "dg":
                    break;
            }

            return true;
        }
    }
}
