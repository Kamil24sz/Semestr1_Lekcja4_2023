using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semestr1_Lekcja4_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 16Gb = 16 000Mb    1Gb = 1000Mb
            // 1GB = 1024MB
            Console.WriteLine("Podaj pojemność dysku deklarowaną przez producenta");
            double pojemnoscProducenta = double.Parse(Console.ReadLine());
            double pojemnoscFizyczna = pojemnoscProducenta * Math.Pow(1000,3);
            double pojemnoscFaktyczna = pojemnoscFizyczna / Math.Pow(1024,3);
            Console.WriteLine("Pojemność rzeczywista dysku to: " + Math.Round(pojemnoscFaktyczna, 2) + "GB");
            Console.ReadLine();
        }
    }
}
