using System;

namespace Opdracht_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string naam;
            DateTime geboortedatum;

            Console.WriteLine("Voer hier uw naam in: ");
            naam = Convert.ToString(Console.ReadLine());
            Console.WriteLine("voer nu uw geboortedatum in ");
            geboortedatum = Convert.ToString(Console.ReadLine());
            Console.Write(DateTime.Now - geboortedatum);


        }
    }
}
