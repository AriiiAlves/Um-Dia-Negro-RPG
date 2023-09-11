
// VISÃO GERAL //

// Parte 1 Completa

// Falta testar o jogo inteiro para corrigir possíveis bugs

// Nota: Jogo não abre em computadores que não tenham .NET instalado

// Consegui colocar os arquivos "publish" como dlls a mais para rodar em ambientes que não tenham o .NET, mas a interface do game
// buga e o jogo fica lento...

using System;
using NAudio.Wave; // API para reproduzir áudio

namespace Projeto_rpg
{
    public class Programa
    {
        public static void Main()
        {
            // Cria o Banco de Dados se ele não existe

            Banco_de_Dados.Run();

            if (Banco_de_Dados.Ler_Progresso_Da_História.Parte1_História() == false)
            {
                // Trilha Sonora

                ControleMúsica.Soundtrack0.Leitor = new AudioFileReader(ControleMúsica.CaminhoTrilha(0));
                ControleMúsica.Soundtrack0.Player.Init(ControleMúsica.Soundtrack0.Leitor);
                ControleMúsica.Soundtrack0.Player.Play();
                ControleMúsica.Soundtrack0.Player.Volume = 0.5f;

                // Desativando cursor visível

                Console.CursorVisible = false;

                // Menu Inicial

                Menus.Tela_inicio();

                // Desativando cursor visível

                Console.CursorVisible = false;

                // Interface

                Ferramentas.Interface();

                // História

                Ferramentas.Escrever("É um dia escuro lá fora." +
                    "\nA chuva cai, incessantemente. Está trovejando.");

            inicio:

                // Conferindo Trilha Sonora

                ControleMúsica.Conferir_Trilha_de_Fundo();

                Ferramentas.Limpa_Interface();
                Ferramentas.Escrever("O que você quer fazer?" +
                    "\n\n[1] Ir ver TV" +
                    "\n[2] Checar celular" +
                    "\n[3] Ler um livro" +
                    "\n[4] Explorar casa", true);
                switch (Ações.Escolha(4))
                {
                    case 1: // OK
                        História.VerTV();
                        goto inicio;
                    case 2: // OK 
                        História.Telefone();
                        goto inicio;
                    case 3: // OK
                        História.Ler_Livro();
                        goto inicio;
                    case 4: // OK
                        História.Explorar_casa();
                        goto inicio;
                }
            }
            else // Aqui seria a parte 2
            {
            creditos:

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

                Console.CursorVisible = false;

                Ferramentas.LimpaTela();
                Ferramentas.Interface();
                Ferramentas.Escrever("" +
                    "Parte 1 Completa! (Parte 2 ainda não foi desenvolvida)" +
                    $"\n\nPorcentagem do jogo explorado: {Math.Round(n, 1)}%" +
                    "\n\nObrigado por jogar!" +
                    "\n\nDesenvolvedor: Ariel Alves da Silva" +
                    "\nGitHub: https://github.com/AriiiAlves" +
                    "\n\nDeseja jogar novamente? (O jogo será resetado)" +
                    "\n\n[1] Sim" +
                    "\n[2] Não", escolha: true);
                switch (Ações.Escolha(2))
                {
                    case 1:
                        Ferramentas.Limpa_Interface();
                        Ferramentas.Escrever("Tem certeza?" +
                            "\n\n[1] Sim" +
                            "\n[2] Não", escolha: true);
                        switch (Ações.Escolha(2))
                        {
                            case 1:
                                try
                                {
                                    string temp = Directory.GetCurrentDirectory();
                                    Directory.Delete($@"{temp}\Database", true);
                                    Ferramentas.Limpa_Interface();
                                    Ferramentas.Escrever("Jogo resetado com sucesso!");
                                    Environment.Exit(0);
                                }
                                catch
                                {
                                    Ferramentas.Limpa_Interface();
                                    Ferramentas.Escrever("Não foi possível resetar o jogo. Se a pasta Database já tiver sido excluída, feche o jogo e abra novamente.");
                                    goto creditos;
                                }
                                break;
                            case 2:
                                break;
                        }
                        break;
                    case 2:
                        break;
                }
            }
        }
    }
}