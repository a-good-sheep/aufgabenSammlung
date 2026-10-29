using System.Data.SqlTypes;

namespace Aufgabe_09
{
    internal class Program
    {
        static void Main(string[] args)

            
        {

            while (true)

                
            {
                Console.WriteLine("Ganzzahlige Dezimalzahl (q to Quit):   ");
                string input = Console.ReadLine();
                if(input == "q")
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Programm beendet!");
                    break;
                }


                int zahl = int.Parse(input);
                int binär;
                string code = " ";

                while (zahl > 0)
                {
                    binär = zahl % 2;
                    zahl = zahl / 2;
                    string text = Convert.ToString(binär);
                    code = text + code;
                }
                Console.WriteLine("Binär: " + code);
                Console.WriteLine(" ");

            }
        }
    }
}
