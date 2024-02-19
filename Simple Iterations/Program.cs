using Simple_Iterations;
using System.ComponentModel.Design;
using static System.Net.Mime.MediaTypeNames;

namespace Main
{
    
    internal static class Program 
    {
        static void Main()
        {
            Method[] method = [new Iterations(),new HalfDivisionMethod(),new Nuton()];
            int[][] array = [[3, 4], [-4, -3], [-1, 0], [0,1]];
            Console.WriteLine("Метод простейших итераций:");
            foreach (int[] i in array)
            {
                method[0].Start(i[0], i[1]);
            }
            Console.WriteLine("\nМетод половинного деления:");
            foreach (int[] i in array)
            {
                method[1].Start(i[0], i[1]);
            }
            Console.WriteLine("\nМетод Ньютона:");
            foreach (int[] i in array)
            {
                method[1].Start(i[0], i[1]);
            }

        }
    }
}
