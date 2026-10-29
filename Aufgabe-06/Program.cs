namespace Aufgabe_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kleines 1x1");
            int a = 1;
            int rounds = 0;
            int change = 1;

            while (true)
            {
                Console.Write(a);
                Console.Write("\t");
                a = a + change;
                rounds = rounds + 1;
                if (rounds == 10)
                {
                    change = change + 1;
                    rounds = 0;
                    a = change;
                    Console.WriteLine(" ");
                }
                if (change == 11)
                {
                    break;
                }
            }   
        }
    }
}
