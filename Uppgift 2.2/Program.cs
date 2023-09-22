using System;

namespace uppgift
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv hur långt Alma hoppade i meter.");
            string Alma = Console.ReadLine();
            double AlmaHopp = double.Parse(Alma);



            Console.Clear();
            Console.WriteLine("Skriv hur långt Elin hoppade i meter. (längre än Alma)");
            string Elin = Console.ReadLine();
            double ElinHopp = double.Parse(Elin);

            double skillnad = ElinHopp - AlmaHopp;

            Console.Clear();
            Console.WriteLine("Elin hoppade " + skillnad + " meter längre än Alma." ); // --=* GJORD AV NOAH *=--


        }

    }

}