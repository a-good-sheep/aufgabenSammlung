namespace Aufgabe_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wie breit soll der Stamm sein?   ");
            int stammbreite = Convert.ToInt32(Console.ReadLine());

            Console.Write("Wie hoch soll der Stamm sein?   ");
            int stammhoehe = Convert.ToInt32(Console.ReadLine());

            Console.Write("Wie hoch soll die Krone sein?   ");
            int kronenhoehe = Convert.ToInt32(Console.ReadLine());


            int sterne = 1;
            int leerzeichen = (kronenhoehe-1);

            for (int b = 0; b < kronenhoehe; b++)
            {
                
                for (int i = 0; i < (leerzeichen); i++)
                {
                    Console.Write(" ");
                    
                }

                leerzeichen -= 1;

                for (int a = 0; a < sterne; a++)
                {
                    Console.Write("*");
                    

                }
                Console.WriteLine(" ");
                sterne += 2;
            }

            for (int d = 0; d < stammhoehe; d++)
            {

            }


        }
    }
}
