﻿using System;

namespace metoder2
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("skriv in ett flyttal: ");
            double tal1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("skriv in ett flyttal: ");
            double tal2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("skriv in ett flyttal: ");
            double tal3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(Medel(tal1, tal2, tal3));
        }


        static double Medel(double t1, double t2, double t3) {

            return (t1 + t2 + t3) / 3;


        }
    }
}
