using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Iterations
{
    public class Iterations: FunctionAndDerivative // простые итерации
    {
        public float X {  get; set; } 
        float prevX { get; set; }
        public float eps { get; set; } = 0.000001f;
        public float lambda { get; set; }
        public float start { get; set; }
        public float end { get; set; }        

        public void Start(float start, float end)
        {
            this.start = start;
            this.end = end;
            float tmp = Check(start, end);
            if (tmp == -999)
                CalculateTwo(start);
            else
            {
                if(CalculateOne(tmp) == 0)
                {
                    Console.WriteLine("Решим через второй метод");
                    CalculateTwo(start);
                }
            }

        }
        private float Check(float a, float b)
        {
            if (Math.Abs(FiDir(a)) < 1)
                return a;
            else
                if (Math.Abs(FiDir(b)) < 1) return b;
            else
                return -999;

        }
        private int CalculateOne(float x)
        {
            X = x;
            int counter = 0;
            do
            {
                prevX = X;
                X = Fi(prevX);
                if (X < start || X > end)
                {
                    Console.WriteLine("Корней нет или нет возможности выполнить расчет простым методом");
                    return 0;
                }
            } while (Math.Abs(X - prevX) > eps);
            Console.WriteLine("Корень:" + X + " " + "Количество итераций:" + counter);
            return 1;
        }
        private void CalculateTwo(float x)
        {
            FindLambda();
            X = x;
            int counter = 0;
            do
            {
                prevX = X;
                X = prevX + lambda * NoDir(prevX);
                counter++;
            } while (Math.Abs(prevX - X) > eps);
            Console.WriteLine("Корень:" + X + " " + "Количество итераций:" + counter);
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
