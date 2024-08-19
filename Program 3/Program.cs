namespace Program_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TREŚĆ ZADANIA
            // Napisz program, który zaimplementuje ciąg Fibonacciego i wyświetli go na ekranie.

            // Deklaracja zmiennych oraz pętla implementująca ciąg Fibonacciego dla wyrazów ciągu w zakresie 0 - 11. 
            int evenEarlierValueOfAWord = 0;
            int earlierValueOfAWord = 1;
            int currentValueOfAWord = 0;
            int positionOfAWord = 0;
            
            for (positionOfAWord = 0; positionOfAWord < 11; positionOfAWord++)
            {
                if (positionOfAWord == 0)
                {
                    Console.WriteLine($"Wyraz numer \"{positionOfAWord}\" ciągu, ma wartość: \"{evenEarlierValueOfAWord}\".");
                }
                else if (positionOfAWord == 1)
                {
                    Console.WriteLine($"Wyraz numer \"{positionOfAWord}\" ciągu, ma wartość: \"{earlierValueOfAWord}\".");
                }
                else if (positionOfAWord > 1)
                {
                    // Obliczanie wartości dla kolejnego wyrazu.
                    currentValueOfAWord = evenEarlierValueOfAWord + earlierValueOfAWord;
                    
                    Console.WriteLine($"Wyraz numer \"{positionOfAWord}\" ciągu, ma wartość: \"{currentValueOfAWord}\".");

                    // Aktualizacja wartości wyrazów.  
                    evenEarlierValueOfAWord = earlierValueOfAWord;
                    earlierValueOfAWord = currentValueOfAWord;
                }
            }

            Console.ReadKey();
        }
    }
}