using System;

namespace arrayersovning1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] v = new int[5];

            for (int i = 0; i < v.Length; i++)
            {
                Console.Write("skriv heltal: " );
                v[i]=int.Parse(Console.ReadLine());
            }

            for(int i=v.Length-1;i>=0;i--)
                Console.WriteLine(v[i]);


        }
    }
}
