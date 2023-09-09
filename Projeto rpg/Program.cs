
// VISÃO GERAL //

// Parte 1 Completa

// Falta colocar efeitos de áudio (opcional)
// Falta ajustar o volume das trilhas com Soundtrack.Player.Volume = 0.5f (vai de 0 a 1)
// Falta colocar menu com o jogador escrevendo ok de confirmação
// Falta colocar menu para o jogador configurar a velocidade de escrita
// Falta testar o jogo inteiro para corrigir possíveis bugs

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

                // Menu Inicial

                Menus.Tela_inicio(); // COLOCAR AVISO DE MAXIMIZAR JANELA, E DAR OK DE CONFIRMAÇÃO

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
                if(n > 100)
                {
                    n = 100;
                }

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
                        Ferramentas.Escrever("Tem certeza?" +
                            "\n\n[1] Sim" +
                            "\n[2] Não", escolha: true);
                        switch (Ações.Escolha(2))
                        {
                            case 1:
                                Banco_de_Dados.Coletar_item.Cabo_TV(false);
                                Banco_de_Dados.Coletar_item.Chave_Escritório(false);
                                Banco_de_Dados.Coletar_item.Chave_Porta(false);
                                Banco_de_Dados.Coletar_item.Faca(false);
                                Banco_de_Dados.Coletar_item.Isqueiro(false);

                                Banco_de_Dados.Alterar_Progresso_da_História.Abrir_Cofre(false);
                                Banco_de_Dados.Alterar_Progresso_da_História.Memórias(false);
                                Banco_de_Dados.Alterar_Progresso_da_História.Atender_Desconhecido(false);
                                Banco_de_Dados.Alterar_Progresso_da_História.Atender_Rafael_Brother(false);
                                Banco_de_Dados.Alterar_Progresso_da_História.Atender_Thomas(false);
                                Banco_de_Dados.Alterar_Progresso_da_História.Atender_CSP(false);
                                Banco_de_Dados.Alterar_Progresso_da_História.Atender_Sofia(false);

                                Banco_de_Dados.Alterar_num_Mensagens.Todas_Não_Respondidas(6);
                                Banco_de_Dados.Alterar_num_Mensagens.Rafael_Brother(1);
                                Banco_de_Dados.Alterar_num_Mensagens.CSP(2);
                                Banco_de_Dados.Alterar_num_Mensagens.Sofia_Filha(1);
                                Banco_de_Dados.Alterar_num_Mensagens.Chefe_Bruno(2);
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