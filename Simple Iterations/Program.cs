using Simple_Iterations;
using System.ComponentModel.Design;
using static System.Net.Mime.MediaTypeNames;

namespace Main
{
    
    internal static class Program 
    {
        static void Main()
        {
            int[][] array = [[3, 4], [-4, -3], [-1, 0], [0,1]];
            Iterations iterations = new Iterations();
            HalfDivisionMethod halfDivisionMethod = new HalfDivisionMethod();
            Nuton nuton = new Nuton();
            Console.WriteLine("Метод простейших итераций:");
            foreach (int[] i in array)
            {
                iterations.Start(i[0], i[1]);
            }
            Console.WriteLine("\nМетод половинного деления:");
            foreach (int[] i in array)
            {
                halfDivisionMethod.Start(i[0], i[1]);
            }
            Console.WriteLine("\nМетод Ньютона:");
            foreach (int[] i in array)
            {
                nuton.Start(i[0], i[1]);
            }

        }
    }
}
