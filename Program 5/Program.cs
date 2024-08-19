using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net.NetworkInformation;

namespace Program_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TREŚĆ ZADANIA
            // Napisz program, który dla liczb od 1 do 20 wyświetli na ekranie ich 3 potęgę.

            // Deklaracja zmiennej oraz pętla podnosząca liczbę do potęgi. 
            int digitBeingMultiplied = 1;
            
            for (digitBeingMultiplied = 1; digitBeingMultiplied < 21 ; digitBeingMultiplied++)
            {
                Console.WriteLine($"Trzecią potęgą liczby {digitBeingMultiplied} jest {digitBeingMultiplied * digitBeingMultiplied * digitBeingMultiplied}.");
            }

            Console.ReadKey();
        }
    }
}