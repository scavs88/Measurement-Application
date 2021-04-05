using System;

namespace Measurement_Application_github_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // User inputs length and width, program calculates area and peremiter






            Console.WriteLine("Length of rectangle?");
            string Length = Console.ReadLine();
            double LengthF = double.Parse(Length);
            Console.WriteLine("Width of rectangle?");
            string Width = Console.ReadLine();
            double WidthF = double.Parse(Width);
            double area = LengthF * WidthF;
            double peremiter = WidthF * 2 + LengthF * 2;
            Console.WriteLine("Area is " + area );
            Console.WriteLine("Peremiter is " + peremiter);
        }
    }
}
