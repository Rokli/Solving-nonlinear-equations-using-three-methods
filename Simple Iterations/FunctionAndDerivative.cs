﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Iterations
{
    public abstract class FunctionAndDerivative
    {
        public float NoDir(float x)
        {
            return 2 * (float)Math.Pow(x, 4) - 24 * (float)Math.Pow(x, 2) - x + 8;
        }
        public float Dir(float x)
        {
            return 8 * (float)Math.Pow(x, 3) - 48 * x - 1;
        }
    }
}
