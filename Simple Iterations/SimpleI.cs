using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Iterations
{
    public class Iterations // простые итерации
    {
        public float X {  get; set; } 
        float prevX { get; set; }
        public float eps { get; set; } = 0.00001f;
        public float lambda { get; set; }
        public float start { get; set; }
        public float end { get; set; }
        public Iterations(float a, float b)
        {
            start = a;
            end = b;
            float tmp = Check(a, b);
            if (tmp == 0)
                CalculateTwo(a);
            
            else
                CalculateOne(tmp);
            
        }
        private float Check(float a, float b)
        {
            if (Math.Abs(FiDir(a)) < 1)
                return a;
            else
                if (Math.Abs(FiDir(b)) < 1) return b;
            else
                return 0;

        }
        private void CalculateOne(float x)
        {
            float x0 = x;
            float x1 = Fi(x0);
            while (Math.Abs(x1 - x0) > eps)
            {
                x0 = x1;
                x1 = Fi(x0);
            }
            Console.WriteLine(x1);
        }
        private void CalculateTwo(float x)
        {
            FindLambda();
            X = x;
            int inter = 0;
            do
            {
                prevX = X;
                X = prevX + lambda * NoDir(prevX);
                inter++;
            } while (Math.Abs(prevX - X) > eps);
            Console.WriteLine("Корень:" + X + " " + "Количество итераций:" +inter);
        }
        public void FindLambda()
        {
            float interValue = start;
            float maxValue = Math.Abs(Dir(start));
            for (float i = start; i <= end; i += 0.001f)
            {
                if (Math.Abs(Dir(i)) > Math.Abs(maxValue))
                {
                    maxValue = Math.Abs(Dir(i));
                    interValue = i;
                }
            }
            lambda = 1 / maxValue * CheckPlus(interValue);
        }
        private int CheckPlus(float intervalue)
        {
            if (Dir(intervalue) > 0) return -1;
            else return 1;
        }
        private float NoDir(float x)
        {
            return 2 * (float)Math.Pow(x, 4) - 24 * (float)Math.Pow(x, 2) - x + 8;
        }
        private float Dir(float x)
        {
            return 8 * (float)Math.Pow(x, 3) - 48 * x - 1;
        }
        private float Fi(float x)
        {
            return 2 * (float)Math.Pow(x, 4) - 24 * (float)Math.Pow(x, 2) + 8;
        }
        private float FiDir(float x)
        {
            return 8 * (float)Math.Pow(x, 3) - 48 * x;
        }
    }
}
