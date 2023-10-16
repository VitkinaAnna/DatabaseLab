using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database5
{
    class TypeReal : TypeDB
    {
        public override bool Validation(string value)
        {
            double buf;
            if (double.TryParse(value, out buf)) return true;
            return false;
        }
    }
}
