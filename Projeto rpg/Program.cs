﻿
using NAudio.Wave; // API para reproduzir áudio

namespace Projeto_rpg
{
    public class VariáveisGlobais // VARIÁVEIS GLOBAIS (Podem ser trocadas por uma tabela de banco de dados para armazenar os valores)
    {
        public static bool chamada1_realizada = false,
            cabo_e_chave = false,
            cofre_aberto = false;
        public static int mensagens_nao_respondidas = 9;
    }
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

            Menus.Tela_inicio();

            // Interface

            Ferramentas.Interface();

            // História

            Ferramentas.Escrever("É um dia escuro lá fora." +
                "\nA chuva cai, incessantemente. Está trovejando.");

        inicio:
            // TESTE DB

            Ferramentas.Limpa_Interface();
            Ferramentas.Escrever($"" +
                $"\nMensagens não respondidas: {Banco_de_Dados.Ler_Progresso_Da_História.num_Mensagens_Não_Respondidas()}" +
                $"\nCabo TV: {Banco_de_Dados.Ler_Progresso_Da_História.Cabo_TV()}" +
                $"\nChave Escritório: {Banco_de_Dados.Ler_Progresso_Da_História.Chave_Escritorio()}" +
                $"\nCofre Aberto: {Banco_de_Dados.Ler_Progresso_Da_História.Cofre_Aberto()}" +
                $"\nAtender Desconhecido: {Banco_de_Dados.Ler_Progresso_Da_História.Atender_Desconhecido()}");
            Console.ReadKey();

            //

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
                case 4: // CONTINUAR
                    História.Quarto();
                    goto inicio;
            }
        }
    }
}