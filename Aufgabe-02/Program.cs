namespace Aufgabe_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie viele Tage hat der Monat, für den Sie die Sekundenzahl berechnen wollen?");
            string input = Console.ReadLine();
            int zahl1;

            if (int.TryParse(input, out zahl1) == true)
            {
                if (zahl1 <= 31 && zahl1 >= 28)
                {
                    Console.WriteLine("Dein Monat hat " + (zahl1 * 24 * 60 * 60) + " Sekunden");
                }

                else if (zahl1 <= 27)
                {
                    Console.WriteLine("Es gibt keinen Monat mit " + zahl1 + " Tagen");
                }
                else if (zahl1 >= 32)
                {
                    Console.WriteLine("Es gibt keinen Monat mit " + zahl1 + " Tagen");
                }
            }

            else
            {
                Console.WriteLine("Eingabefehler. Bitte gib eine Zahl ein");
            }

         

                


        }
    }
}
