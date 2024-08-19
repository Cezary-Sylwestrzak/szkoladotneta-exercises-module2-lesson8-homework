namespace Program_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TREŚĆ ZADANIA
            // Napisz program, który dla liczb od 0 do 20 obliczy sumę wg wzoru:
            // 1 + 1/2 + 1/3 + 1/4 itd.

            // Pętla obliczająca sumę wartości liczb według podanego wzoru.   
            float number = 0; 
            
            do
            {
                number += (1 / ++number);
            }
            while (number < 21);
            
            Console.ReadKey();
        }
    }
}