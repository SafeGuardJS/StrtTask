using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            double alpha, beta, z1, z2;
            Console.WriteLine("Enter alpha and beta");
            alpha = Convert.ToDouble(Console.ReadLine()) * Math.PI / 180;
            beta = Convert.ToDouble(Console.ReadLine()) * Math.PI / 180;
            Console.WriteLine($"sin({alpha}) = {Math.Sin(alpha)}, Cos({alpha}) = {Math.Cos(alpha)}\n" + $"sin({beta}) = {Math.Sin(beta)}, Cos({beta}) = {Math.Cos(beta)}\n");

            z1 = Math.Pow(Math.Cos(alpha) - Math.Cos(beta), 2) - Math.Pow(Math.Sin(alpha) - Math.Sin(beta), 2);
            z2 = -4 * Math.Pow(Math.Sin((alpha - beta) / 2), 2) * Math.Cos(alpha + beta);

            Console.WriteLine($"z1 = {z1}, z2 = {z2}");
        }
    }
}
