namespace Aufgabe_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gib einen netten Kommentar ein:");
            Console.WriteLine();

            string[] forbiddenWords = { "viagra", "sex", "porno", "fick", "schlampe", "arsch" };

            string input = Console.ReadLine();
            string kommentar = input.ToLower();

            int count1 = 0;
            int count2 = 0;
            int anzahlWörter = forbiddenWords.Length;

            while (count1 < anzahlWörter)
            {
                bool ergebnis = kommentar.Contains(forbiddenWords[count1]);
                count1 += 1;
                if (ergebnis == true)
                {
                    count2 += 1;
                    ergebnis = false;
                }
                
            }
            if (count2 > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Dein Kommentar ist nicht gültig. Du hast " + count2 + " verbotene/s Wort/Wörter verwendet");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Danke für deinen Kommentar.");
            }
        }
    }
}
