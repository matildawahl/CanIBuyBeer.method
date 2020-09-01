using System;
using System.Data.Common;

namespace CanIBuyBeer.method
{
    class Program
    {

        static bool CanIBuyBeer(int age, string location, decimal promille, string legg)
        {
            bool CanIBuyBeer = false;
            {
            if (legg.ToLower() != "n")
                return false;
                if (promille > 1.0m)
                    return false;
                    if (age > 17 && location.ToLower() == "krogen")
                return true;
            if (age > 19 && location.ToLower() == "systemet")
                return true;
            
                return true;                
        }            
            static void Main(string[] args)

        {
            Console.Write("Hur gammal är du? ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Var är du? ");
            string location = Console.ReadLine();
            Console.Write("Har du leg med dig (J/N)? ");
            string legg = Console.ReadLine();
            Console.Write("Vilken promillehalt? ");
            decimal promille = Convert.ToDecimal(Console.ReadLine());

                if (CanIBuyBeer)
                    Console.WriteLine("Du får köpa öl!");
                else
                    Console.WriteLine("Du får inte köpa öl:(");

                Console.ReadLine();
            }
    }

