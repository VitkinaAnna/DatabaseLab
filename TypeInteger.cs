﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database5
{
    class TypeInteger : TypeDB
    {
        public override bool Validation(string value)
        {
            int buf;
            if (int.TryParse(value, out buf)) return true;
            return false;
        }
    }
}
