
using NAudio.Wave; // API para reproduzir áudio

namespace Projeto_rpg
{
    public class Programa
    {
        public static void Main()
        {
            // Cria o Banco de Dados se ele não existe

            Banco_de_Dados.Run();

            // Trilha Sonora

            ControleMúsica.Soundtrack0.Leitor = new AudioFileReader(ControleMúsica.CaminhoTrilha(0));
            ControleMúsica.Soundtrack0.Player.Init(ControleMúsica.Soundtrack0.Leitor);
            ControleMúsica.Soundtrack0.Player.Play();

            // Menu Inicial

            Menus.Tela_inicio(); // COLOCAR AVISO DE MAXIMIZAR JANELA, E DAR OK DE CONFIRMAÇÃO

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
                case 1: // COLOCAR SOUNDTRACK PRO PROGRAMA DA TV
                    História.VerTV();
                    goto inicio;
                case 2: // TELEFONE OK, SÓ FALTAM SOUNDTRACKS DIFERENTES NOS CONTATOS, E CRIAR NOVA TABELA DE LIGAÇÕES JÁ FEITAS, PARA NÃO SEREM ATENDIDAS NOVAMENTE NOS CONTATOS
                    História.Telefone();
                    goto inicio;
                case 3: // FAZER AINDA
                    goto inicio;
                case 4: // FAZER AINDA (COLOCAR COZINHA, ESCRITÓRIO, QUARTO E SAIR DE CASA (O QUE NÃO PERMITE, POIS TEM QUE PEGAR A CHAVE NA COZINHA) // SAIR DE CASA LEVA PRA PARTE 2
                    História.Quarto();
                    goto inicio;
            }
        }
    }
}