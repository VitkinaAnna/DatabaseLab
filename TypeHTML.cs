using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database5
{
    public class TypeHTML : TypeDB
    {
        public override bool Validation(string value)
        {
            if (value.EndsWith(".html", StringComparison.OrdinalIgnoreCase))
            {
                if (File.Exists(value))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
