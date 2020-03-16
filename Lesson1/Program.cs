using System;
namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Hello World!");

            /*
            int x = 10; 
            int y = -10;
            */

            //1 байт 
            //byte b = 255;

            sbyte sb = 127;
            sbyte sbminus = -127;

            //2 байта
            short s = short.MaxValue;
            ushort us = ushort.MaxValue;
            
            //4 байта
            int i = int.MaxValue;
            uint ui = uint.MaxValue;

            //8 байт
            long l = long.MaxValue;
            ulong ul = ulong.MaxValue;

            double sum = 100;
            double div = sum/3;

            //4 байта
            float f = float.MaxValue;

            //8 байт
            //double d = double.MaxValue;

            Console.WriteLine($"Введите коэффициенты квадратного уравнения ax^2 + bx + c = 0");

            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());

            double d = b * b - 4 * a * c;
            Console.WriteLine($"Дискриминант = {d}");

            double x1 = (-b - Math.Sqrt(d))/2 * a;
            double x2 = (-b + Math.Sqrt(d)) / 2 * a;
            
            Console.WriteLine($"Корни уравнения  x1 = {x1}, x2 = {x2}");

            
        }
    }
}
