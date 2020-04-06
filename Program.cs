using System.Security.Cryptography.X509Certificates;
using System.Collections.Specialized;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System;

namespace Hw1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Rectangle reg = new Rectangle();
            Console.WriteLine("Введие первое число:");
            double s1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            double s2 = double.Parse(Console.ReadLine());
            reg.side1 = s1;
            reg.side2 = s2;
            Console.WriteLine($"Area:{reg.Area}\nPerimeter{reg.Perimeter}");

            Console.WriteLine("Продолжите");

            Console.ReadKey();

            Console.Clear();




            Console.WriteLine("Добавьте новую книгу !");

            Console.WriteLine("Напишите название вашей книги:");
            string title1 = Console.ReadLine();

            Console.WriteLine("Автор бессцелера:");
            string author1 = Console.ReadLine();

            Console.WriteLine("Описание:");
            string content1 = Console.ReadLine();


        }
    class Rectangle
    {
        public double side1 { get; set; }
        public double side2 { get; set; }
        public double Area { get { return AreaCalculator(); } }
        public double Perimeter { get { return PerimeterCalculator(); } }
        public Rectangle()
        {

        }
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public double AreaCalculator()
        {
            return side1 * side2;
        }
        public double PerimeterCalculator()
        {
            return 2 * (side1 + side2);
        }
    }
    
}
