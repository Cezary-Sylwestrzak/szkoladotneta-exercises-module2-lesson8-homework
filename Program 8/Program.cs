namespace Program_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TREŚĆ ZADANIA
            // Napisz program, który odwróci wprowadzony przez użytkownika ciąg znaków. Np.
            // Testowe dane:
            // Abcdefg
            // --> Rezultat --> :
            // Gfedcba

            // Określenie danych wejściowych. 
            Console.WriteLine("Wprowadż dane: "); 
            string userInput = Console.ReadLine();

            // Określenie kolejności wypisywania.
            int length = userInput.Length - 1;
            Console.WriteLine(string.Empty);

            // Wypisanie odwróconych wartości.
            Console.WriteLine("Twój wynik to: ");
            
            while (length >= 0)
            {
                Console.Write($"{userInput[length]}");
                length--;
            }

            Console.ReadKey();
        }
    }
}