namespace Projeto_rpg
{
    public class Menus
    {
        public static void Tela_inicio() // NÃO OK
        {
            // Mudando fonte do console (para Roboto)

            // Configurações.Fonte.SetCurrentFont("Roboto", 20); // Só funciona no computador do Senac !!!!!

            // Configurações de visualização da janela (maximizar + buffer definido)

            // Configurações.Tela.Tela_default(); // Só funciona no computador do Senac !!!!!

            // Obtendo altura e largura do console

            int Largura_Janela = Console.WindowWidth;
            int Altura_Janela = Console.WindowHeight;

            // Definindo strings da tela de início

            string Aviso_Tela_Cheia = "Por favor, não mude de tamanho ou minimize a janela para uma melhor experiência. Resolução mínima para jogar: 1920x1080", Título = "UM DIA NEGRO", Aviso1 = "Um jogo por AlvzDevelopment", Aviso2 = "Pressione qualquer tecla para jogar.";

            // Desabilitando barra de escrita

            Console.CursorVisible = false;

            // Centralizando o texto (Aviso de tela cheia)

            for (int i = 0; i < Altura_Janela / 2 - 1; i++)
            {
                Console.WriteLine(" ");
            }
            for (int i = 0; i < Largura_Janela / 2 - Aviso_Tela_Cheia.Length / 2; i++)
            {
                Console.Write(" ");
            }
            Console.Write($"{Aviso_Tela_Cheia}");
            Console.ReadLine();
            Ferramentas.LimpaTela();

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
