using System;
using System.Threading.Channels;

namespace Calculator
{

    public class Program
    {
        static void Main(string[] args)
        {
           // Parameter für methode 1
            int a = 5; 
            int b = 10;

            int ergebnis1 = a + b;
            Console.WriteLine(ergebnis1);

            // Parameter für methode 2
            int c = 30;
            int d = 20;
            int ergebnis2 = c - d;
            Console.WriteLine(ergebnis2);
        }

        // Methode für die Plus Berechnung
        public static int PlusBerechnung(int a, int b)
        {
            return a + b;
        }

        // Methode für die Minus Berechnung
        public static int MinusBerechnung(int c, int d)
        {
            return c - d;
        }

    }
}