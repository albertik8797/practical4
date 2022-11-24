namespace Albertik222
{
    static class Programm
    {
        public static void Main()
        {
            Noti();
        }
        public static void Noti()
        {
            int[] C = new int[] { 140, 262, 523, 1047 };
            int[] Csharp = new int[] { 144, 277, 554, 1107 };
            int[] D = new int[] { 150, 293, 287, 1175 };
            int[] Eb = new int[] { 160, 311, 622, 1245 };
            int[] E = new int[] { 169, 329, 659, 1319 };
            int[] F = new int[] { 180, 349, 698, 1397 };
            int[] Fsharp = new int[] { 189, 370, 740, 1480 };
            int[] G = new int[] { 200, 329, 784, 1568 };
            int[] Gsharp = new int[] { 210, 415, 840, 1661 };
            int[] A = new int[] { 220, 440, 880, 1760 };
            int[] Bb = new int[] { 233, 466, 932, 1865 };
            int[] B = new int[] { 246, 494, 987, 1976 };

            bool end = false;

            do
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Q)
                {
                    Console.Beep(Csharp[4], 200);
                    Console.Clear();
                    break;
                }

                if (key.Key == ConsoleKey.W)
                {
                    Console.Beep(Eb[4], 200);
                    Console.Clear();
                    break;
                }

                if (key.Key == ConsoleKey.E)
                {
                    Console.Beep(Fsharp[4], 200);
                    Console.Clear();
                    break;
                }

                if (key.Key == ConsoleKey.R)
                {
                    Console.Beep(Gsharp[4], 200);
                    Console.Clear();
                    break;
                }

                if (key.Key == ConsoleKey.T)
                {
                    Console.Beep(Bb[4], 200);
                    Console.Clear();
                    break;
                }

                if (key.Key == ConsoleKey.A)
                {
                    Console.Beep(C[4], 200);
                    Console.Clear();
                    break;
                }

                if (key.Key == ConsoleKey.S)
                {
                    Console.Beep(D[4], 200);
                    Console.Clear();
                    break;
                }

                if (key.Key == ConsoleKey.D)
                {
                    Console.Beep(E[4], 200);
                    Console.Clear();
                    break;
                }

                if (key.Key == ConsoleKey.F)
                {
                    Console.Beep(F[4], 200);
                    Console.Clear();
                    break;
                }

                if (key.Key == ConsoleKey.G)
                {
                    Console.Beep(G[4], 200);
                    Console.Clear();
                    break;
                }

                if (key.Key == ConsoleKey.H)
                {
                    Console.Beep(A[4], 200);
                    Console.Clear();
                    break;
                }

                if (key.Key == ConsoleKey.J)
                {
                    Console.Beep(B[4], 200);
                    Console.Clear();
                    break;
                }

                if (key.Key == ConsoleKey.Escape)
                {
                    end = true;
                    break;
                }
            } while (!end);
        }
    }
}