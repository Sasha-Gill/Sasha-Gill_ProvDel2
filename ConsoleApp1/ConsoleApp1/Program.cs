using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        /*static int AntalBilar(int Antal)
        {
            string svar = "";
            bool ValidAmount;

            while (Antal > 0)
            {
                Console.WriteLine("Hur många Bilar ska skapas?");
                svar = Console.ReadLine();
                Console.WriteLine(svar);
                ValidAmount = Int32.TryParse(svar, out Antal);
            }
            return Antal;
        }*/

        static void Main(string[] args)
        {
            //Console.WriteLine();
            //int antal = AntalBilar()
            
            bool ValidAmount;
            int Antal;

                Console.WriteLine("Hur många Bilar ska skapas?");
            string svar = Console.ReadLine();
            ValidAmount = Int32.TryParse(svar, out Antal);
            Console.WriteLine("Du har skapat " + Antal + " bilar.");
            Console.ReadLine();

            int[] AntalBilar = new int[Antal]();

        }
    }
}
