using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Iterations
{
    public class Nuton : FunctionAndDerivative
    {
        public void Start(float start, float end)
        {
            this.start = start;
            this.end = end;
            Calculate();
        }
        private float SelectingInterval()
        {
            if (NoDir(start) * DirDir(start) > 0) return start;
            else return end;
        }
        private void Calculate()
        {
            X = SelectingInterval();
            float x_1 = X - NoDir(X) / Dir(X);
            int counter = 0;
            while (Math.Abs(x_1 - X) > eps)
            {
                counter++;
                X = x_1;
                x_1 = X - NoDir(X) / Dir(X);
            }
            Console.WriteLine("Корень:" + X + " " + "Количество итераций:" + counter);
        }

        public float DirDir(float x) 
        {
            return 24 * (float)Math.Pow(x,2) - 48;
        }

    }
}
