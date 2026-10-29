namespace Aufgabe_04
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            string[] monat = { "Januar", "Februar", "März", "April", "Mai", "Juni", "July", "August", "September", "Oktober", "November", "Dezember" };
            Console.Write("Zahl eingeben: ");
            string input = Console.ReadLine();
            int zahl = int.Parse(input);
            zahl -= 1;

            if (zahl <= 11 && zahl >= 0)
            {
                Console.WriteLine(monat[zahl]);
            }
            

            else
            {
                Console.WriteLine("Fehler. Gib eine gültige Zahl ein.");
            }
        }
    }
}
