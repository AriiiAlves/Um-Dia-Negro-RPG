
using NAudio.Wave; // API para reproduzir áudio
using Funções; // Classe com Funções do Jogo
using System.Runtime.InteropServices;

namespace Projeto_RPG
{
    public class VariáveisGlobais // VARIÁVEIS GLOBAIS (Podem ser trocadas por uma tabela de banco de dados para armazenar os valores)
    {
        public static bool chamada1_realizada = false,
            cabo_e_chave = false,
            cofre_aberto = false;     
    }
    public class Soundtrack // CORRIGIR PROBLEMA PRA REINICIALIZAR O ÁUDIO (TOCAR OUTRA FAIXA)
    {
        public static WaveOutEvent Player = new WaveOutEvent();
        public static AudioFileReader Leitor;

        public static void Tocar(int n_trilha)
        {
            Leitor = new AudioFileReader(ControleMúsica.CaminhoTrilha(n_trilha));
            if (Player.PlaybackState == PlaybackState.Playing)
            {
                Player.Pause();
                Player.Init(Leitor);
                Player.Play();
            }
            else
            {
                Player.Init(Leitor);
                Player.Play();
            }
        }
    }
    public class Programa
    {
        // Configuração para maximizar janela

        

        public static void Main()
        {
            // Trilha Sonora (TEM QUE ALTERAR OS CAMINHOS DOS ARQUIVOS NA HORA TE COMPILAR, E TESTAR PARA VER SE ESTÁ OK)

            Soundtrack.Tocar(0); // 0: Main Soundtrack

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