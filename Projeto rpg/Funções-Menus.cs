﻿namespace Projeto_rpg
{
    public class Menus
    {
        public static void Tela_inicio() // OK
        {
            // Essa parte do código só funciona no Windows 10 e apresenta bugs no Windows 11

            //try 
            //{
            //    // Mudando fonte do console (para Roboto)

            //    Configurações.Fonte.SetCurrentFont("Roboto", 20);

            //    // Configurações de visualização da janela (maximizar + buffer definido)

            //    Configurações.Tela.Tela_default();
            //}
            //catch { }

            // Definindo strings da tela de início

            string Aviso_Tela1 = "Maximize essa janela para jogar", Aviso_Tela2 = "Por favor, não mude de tamanho nem minimize a janela para uma melhor experiência", Título = "UM DIA NEGRO", Aviso1 = "Um jogo por AlvzDevelopment", Aviso2 = "Pressione qualquer tecla para jogar.";

            // Declarando variáveis de altura e largura do console

            int Largura_Janela = 0;
            int Altura_Janela = 0;

            // Mensagem para maximizar janela

            while (true)
            {
                if ((Altura_Janela <= Console.LargestWindowHeight - 12))
                {
                    if (Altura_Janela != Console.WindowHeight || Largura_Janela != Console.WindowWidth)
                    {
                        Ferramentas.LimpaTela();

                        // Desabilitando barra de escrita

                        Console.CursorVisible = false;

                        // Obtendo a largura e altura do console

                        Largura_Janela = Console.WindowWidth;
                        Altura_Janela = Console.WindowHeight;

                        // Centralizando o texto (Aviso de Tela 1)

                        for (int i = 0; i < Altura_Janela / 2 - 1; i++)
                        {
                            Console.WriteLine(" ");
                        }
                        for (int i = 0; i < Largura_Janela / 2 - Aviso_Tela1.Length / 2; i++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write($"{Aviso_Tela1}");
                    }
                }
                else
                {
                    Ferramentas.LimpaTela();
                    break;
                }
            }

            // Desabilitando novamente a barra de escrita

            Console.CursorVisible = false;

            // Obtendo novamente a largura e altura do console

            Largura_Janela = Console.WindowWidth;
            Altura_Janela = Console.WindowHeight;

            // Centralizando o texto (Aviso de Tela 2)

            for (int i = 0; i < Altura_Janela / 2 - 1; i++)
            {
                Console.WriteLine(" ");
            }
            for (int i = 0; i < Largura_Janela / 2 - Aviso_Tela2.Length / 2; i++)
            {
                Console.Write(" ");
            }
            Console.Write($"{Aviso_Tela2}");
            Console.ReadLine();
            Ferramentas.LimpaTela();

            // Coletando dados da altura e largura do console

            VariávelGlobal.InitialWindowWidth = Console.WindowWidth;
            VariávelGlobal.InitialWindowHeight = Console.WindowHeight;

            // Delimitando buffer de acordo com o tamanho da tela maximizada

            Configurações.Tela.Limitar_Tela();

            // Obtendo novamente a largura e altura do console

            Largura_Janela = Console.WindowWidth;
            Altura_Janela = Console.WindowHeight;

            // Centralizando o texto (Tela de início)

            for (int i = 0; i < Altura_Janela / 2 - 4; i++)
            {
                Console.WriteLine(" ");
            }
            for (int i = 0; i < Largura_Janela / 2 - Título.Length / 2 + 1; i++)
            {
                Console.Write(" ");
            }
            Console.Write($"{Título}\n\n");
            for (int i = 0; i < Largura_Janela / 2 - Aviso1.Length / 2 + 1; i++)
            {
                Console.Write(" ");
            }
            Console.Write($"{Aviso1}\n\n");
            for (int i = 0; i < Largura_Janela / 2 - Aviso2.Length / 2 + 1; i++)
            {
                Console.Write(" ");
            }
            Console.Write($"{Aviso2}");
            Console.ReadLine();

            // Limpando tela

            Ferramentas.LimpaTela();
        }
    }
}
