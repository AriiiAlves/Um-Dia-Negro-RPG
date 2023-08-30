
using NAudio.Wave; // API para reproduzir áudio
using Funções; // Classe com Funções do Jogo

namespace Projeto_RPG
{
    public class VariáveisGlobais // VARIÁVEIS GLOBAIS (Podem ser trocadas por uma tabela de banco de dados para armazenar os valores)
    {
        public static bool chamada1_realizada = false,
            cabo_e_chave = false,
            cofre_aberto = false;     
    }
    public class Soundtrack 
    {
        public static WaveOutEvent Player = new WaveOutEvent();
        public static AudioFileReader Leitor;
    }
    public class Programa
    {
        public static void Main()
        {
            // VARIÁVEL LOCAL MULTIUSO

            object temp;

            // Trilha Sonora (TEM QUE ALTERAR OS CAMINHOS DOS ARQUIVOS NA HORA TE COMPILAR, E TESTAR PARA VER SE ESTÁ OK)

            Soundtrack.Leitor = new AudioFileReader(ControleMúsica.CaminhoTrilha(0)); // 0: Main Soundtrack
            Soundtrack.Player.Init(Soundtrack.Leitor);
            Soundtrack.Player.Play();

            // Menu Inicial

            Menus.Tela_inicio();

            // História

            Ferramentas.Escrever("É um dia escuro lá fora." +
                "\nA chuva cai, incessantemente. Está trovejando.");

        inicio:
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
                    goto inicio;
            }
        }
    }
}