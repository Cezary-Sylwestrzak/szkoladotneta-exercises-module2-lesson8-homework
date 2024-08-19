namespace Program_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TREŚĆ ZADANIA
            // Napisz program, który po podaniu liczby całkowitej wyświetli piramidę liczb od 1 do podanej
            // liczby w formie jak poniżej:
            // 1
            // 2 3
            // 4 5 6
            // 7 8 9 10

            // Deklaracja zmiennych oraz pętla pobierająca wartość końcową piramidy od użytkownika.
            int endNumber; 
            int printedNumber = 1;
            int numberOfDigitsOnSingleLevel = 0;
            int numberOfLevel = 0;
            bool userInput = false;

            do
            {
                Console.WriteLine("Podaj liczbę całkowitą na której ma się zakończyć konstrukcja piramidy wartości:");
                Console.WriteLine(string.Empty);

                userInput = int.TryParse(Console.ReadLine(), out endNumber);
                Console.WriteLine(string.Empty);

                if (!userInput) 
                {
                    Console.WriteLine("Wprowadzona wartość nie jest wartością liczbową, ponów próbę używając w tym celu wartości liczbowych.");
                    Console.WriteLine(string.Empty);
                }
            }
            while (!userInput); 

            // Pętla wypisująca wartości w postaci piramidy. 
            do
            {
                while (numberOfDigitsOnSingleLevel < numberOfLevel && printedNumber <= endNumber) 
                {
                    Console.Write($"{printedNumber} ");

                    numberOfDigitsOnSingleLevel++;

                    printedNumber++;
                }
                while (numberOfDigitsOnSingleLevel == numberOfLevel)
                {
                    Console.WriteLine($"{printedNumber} ");

                    numberOfDigitsOnSingleLevel++;

                    printedNumber++;
                }

                numberOfDigitsOnSingleLevel = 0;

                numberOfLevel++;
            }
            while (printedNumber <= endNumber); 
            
            Console.ReadKey();
        }
    }
}