namespace Program_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TREŚĆ ZADANIA
            // Napisz program, który sprawdzi ile jest liczb pierwszych w zakresie 0 – 100.

            // Deklaracja zmiennych od których będziemy rozpoczynali sprawdzanie. 
            int digitBeingChecked = 2;
            int divider = 2;

            // Pętla sprawdzająca czy liczby w podanym przedziale są liczbami pierwszymi. 
            for (digitBeingChecked = 2; digitBeingChecked < 101; divider = 2)
            {
                while (divider < digitBeingChecked)
                {
                    while (digitBeingChecked % divider == 0)
                    {
                        digitBeingChecked++;
                        divider = 2;
                    }

                    divider++;
                }
                while (divider == digitBeingChecked && digitBeingChecked < 101)
                {
                    Console.WriteLine($"Liczba \"{digitBeingChecked}\" jest liczbą pierwszą.");
                    digitBeingChecked++;
                }
            }
            
            // Wstawione tylko po to aby wygodniej było sprawdzać. 
            Console.ReadKey();
        }
    }
}