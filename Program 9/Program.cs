using System.Globalization;
using System.Reflection;

namespace Program_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TREŚĆ ZADANIA
            // Napisz program, który zamieni liczbę dziesiętną na liczbę binarną.

            // Deklaracja zmiennych.
            int decimalValue = 50;
            string moduloResults;

            // Pętla z działaniem modulo.  
            for (moduloResults = null; decimalValue > 0; decimalValue /= 2)
            {
                moduloResults += decimalValue % 2;
            }

            // Określenie kolejności wypisywania. 
            int reversedResults = moduloResults.Length - 1;

            // Wypisanie wyniku. 
            while (reversedResults >= 0)
            {
                Console.Write($"{moduloResults[reversedResults]}");
                reversedResults --;
            }
            
            Console.ReadKey();
        }
    }
}