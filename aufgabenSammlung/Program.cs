namespace aufgabenSammlung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie alt bist du?");

            string input = Console.ReadLine();

            int alter = Convert.ToInt32(input);

            Console.WriteLine("Nächstes jahr bist du " + (alter + 1) + " jahre alt");
        }
    }
}
