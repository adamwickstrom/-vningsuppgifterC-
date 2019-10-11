using System;

namespace arrayerupg3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] temperatur = { 4.5, 3.2, 6.7, 6.1, 2.1, 1.6, 2.9, };
            Array.Sort(temperatur);
            int hv = temperatur.Length / 2;
            int hvover = temperatur.Length % 2;

            if(hvover==0) 
            {
                double summa = temperatur[hv] + temperatur[hv - 1];
                Console.WriteLine(summa / 2);

            }

            else
            {
                Console.WriteLine("Mediantalet är: " + temperatur[hv]);

            }


        }
    }
}
