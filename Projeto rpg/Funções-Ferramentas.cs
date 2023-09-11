namespace Projeto_rpg
{
    public class Ferramentas // TUDO OK
    {
        public static void Interface() //OK
        {
            int Console_Width = Console.WindowWidth;
            int Console_Height = Console.WindowHeight;

            for (int i = 0; i < Console_Width; i++)
            {
                if (i == 0)
                {
                    Console.Write("┌");
                }
                else if (i == Console_Width - 1)
                {
                    Console.Write("┐");
                }
                else
                {
                    Console.Write("─");
                }
            }
            for (int i = 0; i < Console_Height - 2; i++)
            {
                Console.Write("│");
                for (int j = 0; j < Console_Width - 2; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("│");
            }
            for (int i = 0; i < Console_Width; i++)
            {
                if (i == 0)
                {
                    Console.Write("└");
                }
                else if (i == Console_Width - 1)
                {
                    Console.Write("┘");
                }
                else
                {
                    Console.Write("─");
                }
            }
        }
        public static void Limpa_Interface() //OK
        {
            // Gambiarra pra conferir se a janela está do mesmo tamanho

            Configurações.Tela.Conferir_Tela();

            // Limpa interface

            for (int j = 1; j < Console.WindowHeight - 1; j++)
            {
                Console.SetCursorPosition(2, j);
                for (int k = 0; k < Console.WindowWidth - 3; k++)
                {
                    Console.Write(" ");
                }
            }
            Console.SetCursorPosition(2, 2);
        }
        public static void Escrever(string texto, bool escolha = false, bool instantâneo = false, bool pausa_pontuacao = true) //OK
        {
            char var;

            // Colocando espaço de tempo entre a escrita de cada letra
            // Não deixando as margens do console serem editadas

            Console.SetCursorPosition(2, 2);

            for (int i = 0; i < texto.Length; i++)
            {
                var = texto[i];

                if (Console.CursorLeft == 0 && Console.CursorTop == 0)
                {
                    Console.SetCursorPosition(2, 2);
                }
                else if (Console.CursorLeft == 0)
                {
                    int Linha_atual = Console.CursorTop;
                    Console.SetCursorPosition(2, Linha_atual);
                }
                else if (Console.CursorTop == Console.WindowHeight - 3)
                {
                    if (Console.CursorLeft == Console.WindowWidth - 4 || var == '\n')
                    {
                        Console.Write("...");
                        while (Console.KeyAvailable)
                        {
                            Console.ReadKey(true);
                        }
                        Console.ReadKey();
                        for (int j = 2; j < Console.WindowHeight - 2; j++)
                        {
                            Console.SetCursorPosition(2, j);
                            for (int k = 0; k < Console.WindowWidth - 3; k++)
                            {
                                Console.Write(" ");
                            }
                        }
                        if (var == '\n')
                        {
                            Console.SetCursorPosition(2, 1);
                        }
                        else
                        {
                            Console.SetCursorPosition(2, 2);
                        }
                    }
                }
                else if (Console.CursorLeft == Console.WindowWidth - 2)
                {
                    int Linha_atual = Console.CursorTop;
                    Console.SetCursorPosition(2, Linha_atual + 1);
                }

                Console.Write(var);

                // Colocando espaço de tempo maior após pontuação final, e eliminando tempo caso o usuário pressione alguma tecla

                if (instantâneo == false)
                {
                    if (Console.KeyAvailable == false)
                    {
                        if (var == '.' || var == '?' || var == '!')
                        {
                            if (pausa_pontuacao == true)
                            {
                                Thread.Sleep(250);
                            }
                        }
                        Thread.Sleep(10);
                    }
                }
            }

            // Readkey para esperar ação do jogador

            if (escolha == false)
            {
                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }
                Thread.Sleep(500);
                Console.ReadKey();
            }
            Console.WriteLine("");
        }
        public static void Escrever_Mensagem(string texto)
        {
            char var;

            for (int i = 0; i < texto.Length; i++)
            {
                var = texto[i];

                if (Console.CursorLeft == 0 && Console.CursorTop == 0)
                {
                    Console.SetCursorPosition(2, 2);
                }
                else if (Console.CursorLeft == 0)
                {
                    int Linha_atual = Console.CursorTop;
                    Console.SetCursorPosition(2, Linha_atual);
                }
                else if (Console.CursorLeft == Console.WindowWidth - 2)
                {
                    int Linha_atual = Console.CursorTop;
                    Console.SetCursorPosition(2, Linha_atual + 1);
                }
                else if (Console.CursorTop == Console.WindowHeight - 3)
                {
                    if (Console.CursorLeft == Console.WindowWidth - 4 || var == '\n')
                    {
                        Console.Write("...");
                        Console.ReadLine();
                        for (int j = 2; j < Console.WindowHeight - 2; j++)
                        {
                            Console.SetCursorPosition(2, j);
                            for (int k = 0; k < Console.WindowWidth - 3; k++)
                            {
                                Console.Write(" ");
                            }
                        }
                        if (var == '\n')
                        {
                            Console.SetCursorPosition(1, 2);
                        }
                        else
                        {
                            Console.SetCursorPosition(2, 2);
                        }
                    }
                }
                Console.Write(var);
            }
        }
        public static void ImagemASCII(string texto) //OK
        {
            char var;

            // Colocando espaço de tempo entre a escrita de cada letra
            // Não deixando as margens do console serem editadas

            Limpa_Interface();

            Console.SetCursorPosition(2, 2);
            for (int i = 0; i < texto.Length; i++)
            {
                var = texto[i];

                if (Console.CursorLeft == 0 && Console.CursorTop == 0)
                {
                    Console.SetCursorPosition(2, 2);
                }
                else if (Console.CursorLeft == 0)
                {
                    int Linha_atual = Console.CursorTop;
                    Console.SetCursorPosition(2, Linha_atual);
                }
                else if (Console.CursorLeft == Console.WindowWidth - 2)
                {
                    int Linha_atual = Console.CursorTop;
                    Console.SetCursorPosition(2, Linha_atual + 1);
                }
                else if (Console.CursorTop == Console.WindowHeight - 3)
                {
                    if (Console.CursorLeft == Console.WindowWidth - 4 || var == '\n')
                    {
                        Console.Write("...");
                        Console.ReadLine();
                        for (int j = 2; j < Console.WindowHeight - 2; j++)
                        {
                            Console.SetCursorPosition(2, j);
                            for (int k = 0; k < Console.WindowWidth - 3; k++)
                            {
                                Console.Write(" ");
                            }
                        }
                        if (var == '\n')
                        {
                            Console.SetCursorPosition(1, 2);
                        }
                        else
                        {
                            Console.SetCursorPosition(2, 2);
                        }
                    }
                }
                Console.Write(var);
            }
        }
        public static void LimpaTela() // OK
        {
            Console.Clear();
            Thread.Sleep(15);
        }
        public static double VerificarProgresso() 
        {
            double n = 0;

            if (Banco_de_Dados.Ler_Progresso_Da_História.Cabo_TV())
            {
                n += 8.34;
            }
            if (Banco_de_Dados.Ler_Progresso_Da_História.Chave_Escritorio())
            {
                n += 8.34;
            }
            if (Banco_de_Dados.Ler_Progresso_Da_História.Chave_Porta())
            {
                n += 8.34;
            }
            if (Banco_de_Dados.Ler_Progresso_Da_História.Faca() || Banco_de_Dados.Ler_Progresso_Da_História.Isqueiro())
            {
                n += 8.34;
            }
            if (Banco_de_Dados.Ler_Progresso_Da_História.Cofre_Aberto())
            {
                n += 8.34;
            }
            if (Banco_de_Dados.Ler_Progresso_Da_História.Memórias())
            {
                n += 8.34;
            }
            if (Banco_de_Dados.Ler_Progresso_Da_História.Atender_Desconhecido())
            {
                n += 8.34;
            }
            if (Banco_de_Dados.Ler_Progresso_Da_História.Atender_Rafael_Brother())
            {
                n += 8.34;
            }
            if (Banco_de_Dados.Ler_Progresso_Da_História.Atender_Thomas())
            {
                n += 8.34;
            }
            if (Banco_de_Dados.Ler_Progresso_Da_História.Atender_CSP())
            {
                n += 8.34;
            }
            if (Banco_de_Dados.Ler_Progresso_Da_História.Atender_Sofia())
            {
                n += 8.34;
            }
            if (Banco_de_Dados.Ler_num_Mensagens.Todas_Não_Respondidas() == 0)
            {
                n += 8.34;
            }
            if (n > 100)
            {
                n = 100;
            }

            return n;
        }
    }
}
