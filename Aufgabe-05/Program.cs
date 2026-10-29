namespace Aufgabe_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie viele Kilometer möchtest du rennen?");
            string input = Console.ReadLine();
            int kilometer = int.Parse(input);

            if (kilometer > 42)
            {
                Console.WriteLine("Das schaffst du nicht!");
            }

            else
            {
                int runden = kilometer * 1000;
                runden = runden / 400;
                Console.WriteLine("Das sind: " + runden + "Runden. Bereit für den Lauf? (Ja / Nein)");
                string bereit = Console.ReadLine();

                if (bereit == "Ja")
                {
                    int i = 1;
                    while(i <= runden)
                    {
                        Console.WriteLine("Dü läufst gerade runde " + i);
                        i += 1;
                    }
                    Console.WriteLine("Du hast es geschafft!");

                }

            }
        }
    }
}
