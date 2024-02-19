using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Iterations
{
    public class HalfDivisionMethod: FunctionAndDerivative
    {
        public void Start(float start, float end) 
        {
            this.start = start;
            this.end = end;
            if(NoDir(start) * NoDir(end) < 0) CalculateOne();
        }
        public void CalculateOne()
        {
            float[] array = [start, end];
            int counter = 0;
            do
            {
                X = (array[0] + array[1]) / 2;
                array = SelectingNextIteration(array[0], X) == 0 ? [array[0], X] : [X, array[1]];
                counter++;
            } while (Math.Abs(array[1] - array[0]) >  2*eps);
            Console.WriteLine("Корень:" + X + " " + "Количество итераций:" + counter);
        }
        public void CalculateTwo()
        {

        }
        public int SelectingNextIteration(float start,float x)
        {
            if ((NoDir(start) > 0 && NoDir(x) < 0) || (NoDir(start) < 0 && NoDir(x) > 0)) return 0;
            else return 1;
        }
    }
}
