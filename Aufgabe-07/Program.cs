namespace Aufgabe_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zahlen zwichen 1 und 30, die durch 5 und/oder 3 ohne Rest teilbar sind:");
            int a = 1;

            while (a != 31)
            { 
                if (a % 3  == 0 || a % 5 == 0 )
                {
                    if (a==30)
                    {
                        Console.Write(a);
                    }
                    else
                    {
                        Console.Write(a + ", ");
                    }

                }
                a = a + 1;





            }
        }
    }
}
