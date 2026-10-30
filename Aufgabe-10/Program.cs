namespace Aufgabe_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Von welcher Zahl möchtest du die Quersumme?    ");
                int zahl = Convert.ToInt32(Console.ReadLine());
                int number = zahl;
                int sum = 0;

                while (zahl != 0)
                {
                    sum = sum + (zahl % 10);
                    zahl = zahl / 10;
                }
                Console.WriteLine("Die Quersumme von " + number + " ist: " + sum);
                Console.WriteLine(" ");
            }
        }
    }
}
