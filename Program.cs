﻿using System;

namespace Measurement_Application_github_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Get length of rectangle 
            //  get width of rectangle
            //  Calculate area and perimeter
            //  display those values
            //  make new github
            //  push to github


            Console.WriteLine("Length?");
            string Length = Console.ReadLine();
            int LengthF = int.Parse(Length);
            Console.WriteLine("Width?");
            string Width = Console.ReadLine();
            int WidthF = int.Parse(Width);
            int area = LengthF * WidthF;
            int peremiter = WidthF * 2 + LengthF * 2;
            Console.WriteLine("Area is " + area );
            Console.WriteLine("Peremiter is " + peremiter);
        }
    }
}