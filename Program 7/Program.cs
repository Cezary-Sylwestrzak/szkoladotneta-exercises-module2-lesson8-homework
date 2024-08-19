using System.Text;

namespace Program_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TREŚĆ ZADANIA
            // Napisz program, który dla liczby zadanej przez użytkownika narysuje diament o krótszej
            // przekątnej o długości wprowadzonej przez użytkownika i wg wzoru:
            //     *
            //    ***
            //   *****
            //  *******
            // *********
            //  *******
            //   *****
            //    ***
            //     *

            // Deklaracja zmiennych oraz pętla pobierająca od użytkownika długość środka struktury. 
            int shorterDiagonalLength;                             
            int numberOfLevel = 0;                                   
            bool userInput = false;
            
            do
            {
                Console.WriteLine("Podaj liczbę nieparzystą która będzie wyznaczała długość krótszej przekątnej struktury:");
                Console.WriteLine(string.Empty);

                userInput = int.TryParse(Console.ReadLine(), out shorterDiagonalLength); 
                Console.WriteLine(string.Empty);

                if (!userInput || (shorterDiagonalLength % 2 == 0 || shorterDiagonalLength < 0))  
                {
                    Console.WriteLine("Wprowadzono błędne dane, ponów próbę.");
                    Console.WriteLine(string.Empty);
                }
            }
            while (!userInput || (shorterDiagonalLength % 2 == 0 || shorterDiagonalLength < 0));

            // Deklaracja zmiennych które liczą wypisywane znaki oraz pętla wypisująca wartości w postaci diamentu.
            int starsCountdown = 1;
            int whiteSignCountdown = (shorterDiagonalLength - 1) / 1 / 2;

            do
            {
                string repeatedWhiteSign = new string(' ', whiteSignCountdown);
                string repeatedStar = new string('*', starsCountdown);
                Console.WriteLine(repeatedWhiteSign + repeatedStar);

                if (numberOfLevel < shorterDiagonalLength / 1/2)
                {
                    starsCountdown += 2;
                    whiteSignCountdown -= 1;
                }
                else
                {
                    starsCountdown -= 2;
                    whiteSignCountdown += 1;
                }
                    
                numberOfLevel++;
            }
            while (numberOfLevel < shorterDiagonalLength && (whiteSignCountdown >= 0 && starsCountdown <= shorterDiagonalLength)); 
            
            Console.ReadKey();
        }
    }
}