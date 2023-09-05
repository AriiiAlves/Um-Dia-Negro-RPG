using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_rpg
{
    public class Ações
    {
        public static int Escolha(int quant_opcoes) // OK
        {
            int Linha_atual = Console.CursorTop;

            Console.SetCursorPosition(2, Linha_atual + 1);
            Console.Write(new string(": "));

        responder:
            int resposta;
            try
            {
                Console.CursorVisible = true;
                resposta = int.Parse(Console.ReadLine());
                Console.CursorVisible = false;
                if (resposta < 1 || resposta > quant_opcoes)
                {
                    Console.SetCursorPosition(4, Console.CursorTop - 1);
                    Console.Write(new string(' ', Console.WindowWidth - 6));
                    Console.SetCursorPosition(4, Console.CursorTop);
                    goto responder;
                }
                return resposta;
            }
            catch
            {
                Console.SetCursorPosition(4, Console.CursorTop - 1);
                Console.Write(new string(' ', Console.WindowWidth - 6));
                Console.SetCursorPosition(4, Console.CursorTop);
                goto responder;
            }
        }
    }
}