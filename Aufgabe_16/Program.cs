namespace Aufgabe_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 101);
            int guess = 0;
            Console.Write("Errate die Zahl (zwischen 1 und 100):    ");
            int anzahlversuche = 0;

            while (number != guess)
            {
                anzahlversuche++;
                guess = Convert.ToInt32(Console.ReadLine());

                if(guess < number)
                {
                    Console.Write("Zahl ist zu klein! Nächster Versuch:   ");

                }
                else if (guess > number)
                {
                    Console.Write("Zahl ist zu gross! Nächster Versuch:   ");

                }
                else if (guess == number)
                {
                    Console.WriteLine("Du hast es geschafft! Die Zahl war " + number + " und du hast " + anzahlversuche + " Versuche gebraucht.");
                }

                

            }









        }
    }
}
