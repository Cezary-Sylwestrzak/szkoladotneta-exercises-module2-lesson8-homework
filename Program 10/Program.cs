namespace Program_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TREŚĆ ZADANIA
            // Napisz program, który znajdzie najmniejszą wspólną wielokrotność dla zadanych 2 liczb.

            // Deklaracja zmiennych.
            int firstNumber = 18;
            int secondNumber = 48;
            int NWD = 0;
            int NWW = firstNumber * secondNumber;
            
            // Obliczanie NWD (dzielenie z resztą). 
            if (secondNumber % firstNumber == 0) 
            {
                NWD = firstNumber;
            }
            else
            {
                while (secondNumber % firstNumber != 0)
                {
                    NWD = secondNumber % firstNumber;

                    secondNumber = firstNumber;

                    firstNumber = NWD;   
                }
            }

            // Obliczanie NWW (przy użyciu NWD).
            NWW /= NWD;
            
            Console.ReadKey();
        }
    }
}