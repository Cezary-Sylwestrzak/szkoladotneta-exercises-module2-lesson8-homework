namespace Program_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TREŚĆ ZADANIA
            // Napisz program, w którym za pomocą pętli do…while znajdziesz wszystkie liczby parzyste z zakresu 0 – 1000.

            // Deklaracja zmiennej oraz pętla która znajduje liczby parzyste z interesującego nas zakresu. 
            int numbersToCheck = 0;

            do
            {
                if (numbersToCheck % 2 == 0)  
                {
                    Console.WriteLine($"Liczba {numbersToCheck} jest liczbą parzystą.");
                    numbersToCheck++;
                }
                else
                {
                    numbersToCheck++;
                }
            } while (numbersToCheck < 1001);
            
            Console.ReadKey();
        }
    }
}