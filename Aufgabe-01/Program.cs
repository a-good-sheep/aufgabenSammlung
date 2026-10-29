namespace Aufgabe_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string zahl1;
            string zahl2;

            Console.WriteLine("Gib eine Zahl ein.");
            zahl1 = Console.ReadLine();

               Console.WriteLine("Gib noch eine Zahl ein.");
            zahl2 = Console.ReadLine();

            int number1 = Int32.Parse(zahl1);
            int number2 = Int32.Parse(zahl2);

            Console.WriteLine("Summe: " + (number1 + number2));



        }
    }
}
