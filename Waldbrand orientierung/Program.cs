using System;
using System.Threading;

namespace WaldbrandSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // UTF-8 für korrekte Emoji-Darstellung in der Konsole
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== WALDBRAND SIMULATION ===");
            Console.WriteLine("Bitte legen Sie die Parameter fest:\n");

            // Benutzereingaben für Größe und Wahrscheinlichkeiten
            Console.Write("Breite des Waldes (z.B. 30): ");
            int breite = int.Parse(Console.ReadLine());

            Console.Write("Tiefe/Höhe des Waldes (z.B. 15): ");
            int hoehe = int.Parse(Console.ReadLine());

            Console.Write("Wahrscheinlichkeit z für Funkenentzündung in % (z.B. 1): ");
            double z = double.Parse(Console.ReadLine()) / 100.0;

            Console.Write("Wahrscheinlichkeit w für Baumwachstum in % (z.B. 5): ");
            double w = double.Parse(Console.ReadLine()) / 100.0;

            // Spielfeld initialisieren
            char[,] grid = new char[hoehe, breite];
            Random rand = new Random();

            // Initiale zufällige Verteilung (z.B. 60% Baum, 15% Stein, 25% leerer Boden)
            for (int y = 0; y < hoehe; y++)
            {
                for (int x = 0; x < breite; x++)
                {
                    int r = rand.Next(1, 101);
                    if (r <= 60)
                        grid[y, x] = 'B'; // Baum
                    else if (r <= 75)
                        grid[y, x] = 'S'; // Stein
                    else
                        grid[y, x] = '-'; // Leerer Boden
                }
            }

            Console.Clear();
            Console.CursorVisible = false;

            int zeitschritt = 0;

            // Simulationsschleife läuft bis zum Tastendruck
            while (!Console.KeyAvailable)
            {
                Console.SetCursorPosition(0, 0);
                Console.WriteLine($"=== WALDBRAND SIMULATION (Zeitschritt t = {zeitschritt}) ===");
                Console.WriteLine("Legende: 🌲 Baum | 🪨 Stein | ⬛ Humus | 🔥 Feuer | 🪵 Verglüht");
                Console.WriteLine("Drücke eine beliebige Taste zum Beenden...\n");

                // Wald zeichnen
                DrawGrid(grid, breite, hoehe);

                // Nächsten Zustand (t + 1) berechnen
                grid = ComputeNextState(grid, breite, hoehe, z, w, rand);

                zeitschritt++;
                Thread.Sleep(1000); // 1 Sekunde Pause pro Zeitschritt
            }

            // Tastendruck konsumieren, damit er nicht in der Konsole hängen bleibt
            Console.ReadKey(true);
            Console.CursorVisible = true;
            Console.WriteLine("\nSimulation wurde beendet.");
        }

        // Methode zum Zeichnen des Spielfelds mit Emojis
        static void DrawGrid(char[,] grid, int breite, int hoehe)
        {
            for (int y = 0; y < hoehe; y++)
            {
                for (int x = 0; x < breite; x++)
                {
                    switch (grid[y, x])
                    {
                        case 'B': Console.Write("🌲 "); break;
                        case 'S': Console.Write("🪨 "); break;
                        case '-': Console.Write("⬛ "); break;
                        case 'F': Console.Write("🔥 "); break;
                        case 'f': Console.Write("🪵 "); break;
                        default: Console.Write("? "); break;
                    }
                }
                Console.WriteLine();
            }
        }

        // Methode zur Berechnung des Folgeschutzes (Zustandsübergänge)
        static char[,] ComputeNextState(char[,] current, int breite, int hoehe, double z, double w, Random rand)
        {
            char[,] next = new char[hoehe, breite];

            for (int y = 0; y < hoehe; y++)
            {
                for (int x = 0; x < breite; x++)
                {
                    char cell = current[y, x];

                    switch (cell)
                    {
                        case 'S':
                            // Steine bleiben unverändert
                            next[y, x] = 'S';
                            break;

                        case '-':
                            // Auf leerem Boden wächst mit Wahrscheinlichkeit w ein neuer Baum
                            if (rand.NextDouble() < w)
                                next[y, x] = 'B';
                            else
                                next[y, x] = '-';
                            break;

                        case 'f':
                            // Verglühter Baum wird zu Humus (-)
                            next[y, x] = '-';
                            break;

                        case 'F':
                            // Brennender Baum brennt aus und wird im nächsten Schritt zu verglüht (f)
                            next[y, x] = 'f';
                            break;

                        case 'B':
                            // Prüfen, ob ein Nachbar brennt (4 oder 8 Nachbarn; hier 8er Nachbarschaft)
                            if (HasBurningNeighbor(current, x, y, breite, hoehe))
                            {
                                next[y, x] = 'F'; // Entzündet sich durch Nachbarn
                            }
                            else if (rand.NextDouble() < z)
                            {
                                next[y, x] = 'F'; // Spontane Entzündung (Blitz/Funke)
                            }
                            else
                            {
                                next[y, x] = 'B'; // Bleibt heiler Baum
                            }
                            break;
                    }
                }
            }

            return next;
        }

        // Hilfsmethode zur Überprüfung der umliegenden Nachbarn (Moore-Nachbarschaft)
        static bool HasBurningNeighbor(char[,] grid, int x, int y, int breite, int hoehe)
        {
            int[] dx = { -1, 0, 1, -1, 1, -1, 0, 1 };
            int[] dy = { -1, -1, -1, 0, 0, 1, 1, 1 };

            for (int i = 0; i < 8; i++)
            {
                int nx = x + dx[i];
                int ny = y + dy[i];

                if (nx >= 0 && nx < breite && ny >= 0 && ny < hoehe)
                {
                    if (grid[ny, nx] == 'F')
                        return true;
                }
            }
            return false;
        }
    }
}