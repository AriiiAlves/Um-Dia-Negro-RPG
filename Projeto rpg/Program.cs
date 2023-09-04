
using NAudio.Wave; // API para reproduzir áudio
using Funções; // Classe com Funções do Jogo
using System.Runtime.InteropServices;
using static Funções.ControleMúsica;

namespace Projeto_RPG
{
    public class VariáveisGlobais // VARIÁVEIS GLOBAIS (Podem ser trocadas por uma tabela de banco de dados para armazenar os valores)
    {
        public static bool chamada1_realizada = false,
            cabo_e_chave = false,
            cofre_aberto = false;
    }
    public class Programa
    {
        public static void Main()
        {
            // Desabilitando barra de escrita

            Console.CursorVisible = false;

            // Trilha Sonora (TEM QUE ALTERAR OS CAMINHOS DOS ARQUIVOS NA HORA TE COMPILAR, E TESTAR PARA VER SE ESTÁ OK)

            Soundtrack0.Leitor = new AudioFileReader(ControleMúsica.CaminhoTrilha(0)); // 0: Main Soundtrack
            Soundtrack0.Player.Init(Soundtrack0.Leitor);
            Soundtrack0.Player.Play();

            // Menu Inicial

            História.Contatos(0);
            História.Contatos(1);

            Menus.Tela_inicio();

            // Interface

            Ferramentas.Interface();

            // História

            Ferramentas.Escrever("É um dia escuro lá fora." +
                "\nA chuva cai, incessantemente. Está trovejando.");

        inicio:
            Ferramentas.Limpa_Interface();
            Ferramentas.Escrever("O que você quer fazer?" +
                "\n\n[1] Ir ver TV" +
                "\n[2] Checar celular" +
                "\n[3] Ler um livro" +
                "\n[4] Explorar casa", true);
            switch (Ações.Escolha(4))
            {
                case 1:
                    História.VerTV();
                    goto inicio;
                case 2:
                    História.Atender_Telefone();
                    goto inicio;
                case 3: // CONTINUAR
                    goto inicio;
                case 4:
                    História.Quarto();
                    goto inicio;
            }
        }
    }
}