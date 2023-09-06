namespace Projeto_rpg
{
    public class Efeitos // TUDO OK
    {
        public static void Digitando(int n_repetições, bool pular_linha = true) // OK
        {
            if (pular_linha)
            {
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine("");
            }

            int Linha = Console.CursorTop;

            Console.SetCursorPosition(2, Linha);

            for (int i = 0; i < n_repetições; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(".");
                    Thread.Sleep(750);
                }
                Console.SetCursorPosition(2, Linha);
                Console.Write("   ");
                Console.SetCursorPosition(2, Linha);
            }
        }
    }
}
