using System;

namespace övning1111111
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv ett tal heltal: ");
            double tal1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Skriv ännu ett heltal");
            double tal2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("talens summa är: ");
            Console.WriteLine(tal1 + tal2);
            Console.WriteLine("talens differens är: ");
            Console.WriteLine(tal1 - tal2);
            Console.WriteLine("talens produkt är: ");
            Console.WriteLine(tal1 * tal2);
            Console.WriteLine("talens kvot är: ");
            Console.WriteLine(tal1 / tal2);
            

        }
    }
}
