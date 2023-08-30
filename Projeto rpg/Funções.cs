using NAudio.Wave; // API para reproduzir áudio
using Projeto_RPG; // Acesso a todo o projeto (Para uso das Variáveis Globais)

namespace Funções
{
    public class Ferramentas
    {
        public static void Escrever(string texto, bool escolha = false) // Tentar centralizar qualquer escrita no centro da tela depois (copiando o que fiz no Tela_inicio) // NÃO OK
        {
            char var;

            // Desabilitando barra de escrita

            Console.CursorVisible = false;

            // Colocando espaço de tempo entre a escrita de cada letra

            for (int i = 0; i < texto.Length; i++)
            {
                var = texto[i];
                Console.Write(var);

                // Colocando espaço de tempo maior após pontuação final

                if (var == '.' || var == '?' || var == '!')
                {
                    Thread.Sleep(250);
                }
                Thread.Sleep(10);
            }

            // Readkey para esperar ação do jogador

            if (escolha == false)
            {
                Console.ReadLine();
            }
            Console.WriteLine("");

            // Habilitando barra de escrita

            Console.CursorVisible = true;
        }

        public static void LimpaTela() // OK
        {
            Console.Clear();
            Thread.Sleep(15);
        }
    }
    public class ControleMúsica
    {
        public void Efeito_Sonoro(int n)
        {
            WaveOutEvent Player;
            AudioFileReader Leitor;

            Player = new WaveOutEvent();
            Leitor = new AudioFileReader("Colocar som vazio"); // Colocar som vazio aqui

            switch(n)
            {
                case 1:
                    Leitor = new AudioFileReader(" <Colocar efeito sonoro 1 aqui> "); // Colocar ainda
                    break;
                case 2:
                    Leitor = new AudioFileReader(" <Colocar efeito sonoro 2 aqui> "); // Colocar ainda
                    break;
        }

            Player.Init(Leitor);
            Player.Play();
        }

        public static string CaminhoTrilha(int n) // Colocar certinho os caminhos, testar, e colocar mais trilhas
        {
            string temp = Directory.GetCurrentDirectory();

            switch (n)
            {
                case 0:
                    // return ($@"{temp}/Soundtrack/Main Sound.mp3");
                    return (@"C:\Users\Ariel\source\repos\Projeto rpg\Projeto rpg\Soundtrack\Main Sound.mp3");
                case 1:
                    // return ($@"{temp}/Soundtrack/Calling Sound.mp3");
                    return (@"C:\Users\Ariel\source\repos\Projeto rpg\Projeto rpg\Soundtrack\Calling Sound.mp3");
                case 2:
                    // return ($@"{temp}/Soundtrack/Call1 Sound.mp3");
                    return (@"C:\Users\Ariel\source\repos\Projeto rpg\Projeto rpg\Soundtrack\Call1 Sound.mp3");
                default:
                    // return ($@"{temp}/Soundtrack/Main Sound.mp3");
                    return (@"C:\Users\Ariel\source\repos\Projeto rpg\Projeto rpg\Soundtrack\Main Sound.mp3");
            }
        }
    }

    public class Ações
    {
        public static int Escolha(int quant_opcoes) // Função de escolha (Não permite a resposta ser diferente do número de opções) // OK
        {
            Console.Write("\n: ");

        responder:
            int resposta;
            try
            {
                resposta = int.Parse(Console.ReadLine());
                if (resposta < 1 || resposta > quant_opcoes)
                {
                    Console.SetCursorPosition(2, Console.CursorTop - 1);
                    Console.Write(new string(' ', Console.WindowWidth));
                    Console.SetCursorPosition(2, Console.CursorTop - 1);
                    goto responder;
                }
                return resposta;
            }
            catch
            {
                Console.SetCursorPosition(2, Console.CursorTop - 1);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(2, Console.CursorTop - 1);
                goto responder;
            }
        }
    }

    public class História
    {
        public static void VerTV() // NÃO OK
        {
            if (VariáveisGlobais.cabo_e_chave)
            {
                // Fazer
            }
            else
            {
                Ferramentas.LimpaTela();
                Ferramentas.Escrever("Você senta no sofá, e pega o controle para ligar a TV." +
                    "\nMas ela não está ligando." +
                    "\n\nO que fazer?" +
                    "\n\n[1] Descobrir o problema" +
                    "\n[2] Fazer outra coisa", true);
                switch (Ações.Escolha(2))
                {
                    case 1:
                        Ferramentas.LimpaTela();
                        Ferramentas.Escrever("Você mexe atrás da TV para encontrar o problema, com dificuldade." +
                            "\nParece que ela está sem o cabo de energia." +
                            "\n\nPor onde começar a procurar?" +
                            "\n\n[1] Escritório" +
                            "\n[2] Quarto", true);
                        switch (Ações.Escolha(2))
                        {
                            case 1:
                                Ferramentas.LimpaTela();
                                Ferramentas.Escrever("Você vai até a porta de seu escritório, e gira a maçaneta." +
                                    "\nEstá trancado." +
                                    "\n\nProcurar a chave no quarto?" +
                                    "\n\n[1] Sim" +
                                    "\n[2] n̰̝̹̳͊͒̂̉̀�̸̣̘̭̻̼̊ͥ͑�͖́͝ͅǒ̷̹̱̳̘̣̦̮̲͂̍ͦ", true);
                                Ações.Escolha(2);
                                goto case 2;
                            case 2:
                                História.Quarto();
                                break;
                        }
                        break;
                    case 2:
                        Ferramentas.LimpaTela();
                        Ferramentas.Escrever("Você pode ouvir o som do vento batendo nas janelas.");
                        break;
                }
            }
        }

        public static void Atender_Telefone() // NÃO OK
        {
            Ferramentas.LimpaTela();
            if (VariáveisGlobais.chamada1_realizada == false) // Tirar esse false depois
            {
                Ferramentas.Escrever("Você pega o celular e checa as notificações." +
                "\n\n1 chamada(s) não atendida(s) - Número desconhecido" +
                "\n\nLigar de volta?" +
                "\n\n[1] Sim" +
                "\n[2] Não", true);
                switch (Ações.Escolha(2))
                {
                    case 1:
                        Ferramentas.LimpaTela();
                        // Parar música de fundo
                        História.Ligação1();
                        // Voltar música de fundo
                        Ferramentas.LimpaTela();
                        VariáveisGlobais.chamada1_realizada = true;
                        Ferramentas.Escrever("Ninguém atende." +
                            "\n\nLigar novamente?" +
                            "\n\n[1] Sim" +
                            "\n[2] Não", true);
                        switch (Ações.Escolha(2))
                        {
                            case 1:
                                Ferramentas.LimpaTela();
                                // Parar música de fundo
                                História.Ligação1();
                                História.Ligação1_atendida();
                                // Voltar música de fundo
                                Ferramentas.LimpaTela();
                                Ferramentas.Escrever("O histórico de chamadas foi limpo subitamente. O número desconhecido não está mais disponível.");
                                Ferramentas.LimpaTela();
                                Ferramentas.Escrever("O frescor da ventania molhada passa pelo seu corpo em rajadas. Você se sente confortável.");
                                break;
                            case 2:
                                Ferramentas.LimpaTela();
                                Ferramentas.Escrever("Você pode ouvir a água correndo pelas canaletas de chuva.");
                                break;
                        }
                        break;
                    case 2:
                        Ferramentas.LimpaTela();
                        Ferramentas.Escrever("Os trovões lá fora soam e se esvaem subitamente.");
                        break;
                }
            }
            else
            {
                Ferramentas.Escrever("Você pega o celular e checa as notificações." +
                "\n\nNão há novas notificações." +
                "\n\nO que deseja fazer?" +
                "\n\n[1] Checar mensagens" +
                "\n[2] Checar contatos" +
                "\n[3] Checar galeria", true);
                switch (Ações.Escolha(3)) // CONTINUAR
                {
                    case 1:
                        Ferramentas.LimpaTela();

                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                }
            }
        }

        public static void Quarto() // NÃO OK
        {
            string stemp;

            while (true)
            {
            quarto:
                Ferramentas.LimpaTela();
                Ferramentas.Escrever("Você está no seu quarto, e ele é bem grande. O que você quer explorar?" +
                    "\n\n[1] Armário" +
                    "\n[2] Criado-mudo" +
                    "\n[3] Escrivaninha" +
                    "\n[4] Caixa de lembranças" +
                    "\n[5] Diário" +
                    "\n[6] Sair", true);
                switch (Ações.Escolha(6))
                {
                    case 1:
                        Ferramentas.LimpaTela();
                        Ferramentas.Escrever("O armário contém roupas masculinas, e uma pequena pilha de roupas infantis.");
                        goto quarto;
                    case 2:
                        if (VariáveisGlobais.cofre_aberto == false) // Tirar esse false depois
                        {
                            Ferramentas.LimpaTela();
                            Ferramentas.Escrever("O criado-mudo possui um cofre embutido, que aceita caracteres alfanuméricos." +
                                "\n\nHá uma nota adesiva: \"A senha está no passado.\"" +
                                "\n\nTentar abrir o cofre?" +
                                "\n\n[1] Sim" +
                                "\n[2] Não", true);
                            switch (Ações.Escolha(2))
                            {
                                case 1:
                                    while (true)
                                    {
                                        Ferramentas.LimpaTela();
                                        Console.Write("Digite SAIR para sair.\n\nSenha: ");
                                        stemp = Console.ReadLine();
                                        if (stemp == "12112016")
                                        {
                                            Ferramentas.LimpaTela();
                                            Ferramentas.Escrever("O cofre abriu." +
                                                "\n\nDentro dele há uma anotação:" +
                                                "\n\nAES-128-ECB" +
                                                "\nChave: 7855");
                                            VariáveisGlobais.cofre_aberto = true;
                                            goto quarto;
                                        }
                                        else if (stemp == "SAIR")
                                        {
                                            goto quarto;
                                        }
                                        else
                                        {
                                            Ferramentas.LimpaTela();
                                            Console.CursorVisible = false;
                                            Console.WriteLine("SENHA INCORRETA");
                                            Console.ReadLine();
                                            Console.CursorVisible = true;
                                        }
                                    }
                                case 2:
                                    goto quarto;
                            }
                        }
                        else
                        {
                            Ferramentas.LimpaTela();
                            Ferramentas.Escrever("O cofre está aberto." +
                                "\n\nDentro dele há uma anotação:" +
                                "\n\nAES-128-ECB" +
                                "\nChave: 7855");
                            goto quarto;
                        }
                        break;
                    case 3:
                    escrivaninha:
                        Ferramentas.LimpaTela();
                        Ferramentas.Escrever("Uma escrivaninha de madeira maciça, com um vidro na parte de cima. Possui 2 gavetas, com uma carta comum na superfície." +
                            "\n\n[1] Olhar carta" +
                            "\n[2] Olhar gavetas" +
                            "\n[3] Sair", true);
                        switch (Ações.Escolha(3))
                        {
                            case 1:
                                Ferramentas.LimpaTela();
                                Console.CursorVisible = false;
                                Console.WriteLine("\"Caro Thiago" +
                                    "\n\n   Escrevo com pesar, e lamento muito o ocorrido. As coisas realmente não eram para terminarem desse jeito." +
                                    "\n   As buscas duraram 19 dias, e mesmo em uma área tão pequena e rasa, não conseguimos encontrar nada. " +
                                    "Devido à falta de evidências para comprovar a situação do corpo, o caso ainda vai permanecer em aberto " +
                                    "com a situação de \"Desaparecimento\"." +
                                    "\n   Ainda não desistimos. Enquanto não houver evidências da morte, continuaremos procurando.\"" +
                                    "\n\nAss: Capitão Victor Gabriel Santos");
                                Console.ReadLine();
                                Console.CursorVisible = true;
                                goto escrivaninha;
                            case 2:
                                Ferramentas.LimpaTela();
                                if (VariáveisGlobais.cabo_e_chave)
                                {
                                    Ferramentas.Escrever("Não há nada aqui.");
                                }
                                else
                                {
                                    Ferramentas.Escrever("As gavetas guardavam um cabo de energia e uma chave. Você coletou os 2 itens.");
                                    VariáveisGlobais.cabo_e_chave = true;
                                }
                                goto escrivaninha;
                            case 3:
                                goto quarto;
                        }
                        break;
                    case 4:
                    caixa_de_lembrancas:
                        Ferramentas.LimpaTela();
                        Ferramentas.Escrever("A caixa de lembranças contém alguns brinquedos, uma foto e um poema." +
                            "\n\n[1] Ver foto" +
                            "\n[2] Ver poema" +
                            "\n[3] Sair", true);
                        switch (Ações.Escolha(3))
                        {
                            case 1:
                                Ferramentas.LimpaTela();
                                Console.CursorVisible = false;
                                Console.WriteLine("\n\n\n\n" +
                                    "               ***********************###*********************************************" +
                                    "\n               *******************+#%%%%%%%#******************************************" +
                                    "\n               ********************%%%%%%%%%%*+*++++++++++++++**+++++++***************" +
                                    "\n               ****************+++*%%%%%%%%%#*++++++++++++++++++++++++++++++++++******" +
                                    "\n               ******+++++*+++++**#%%%%%%%%%+++++++++++++++++++++++++++++++++++++++++*" +
                                    "\n               *+++++++++++**#%%%%%%%%%%%%%*++++++++++++++++++++++++++++++++++++++++++" +
                                    "\n               ++++++++++#%%%%%%%%%%%%%%%%%#*+++++++++++++++++++++++++++++++++++++++++" +
                                    "\n               +++++++++%%%%%%%%%%%%%%%%%%%%%%*+++++++++++++++++++++++++++++++++++++++" +
                                    "\n               ++++++++%%%%%%%%%%%%%%%%%%%%%%%%#++++++++++++++++++++++++++++++++++++++" +
                                    "\n               +++++++#%%%%%%%%%%%%%%%%%%%%%%%%%#====+++++++++++++++++++++++++++++++++" +
                                    "\n               ++++++#%%%%%%%%%%%%%%%%%%%%%%%%%%%*===============================+++++" +
                                    "\n               +++++*%%%%%%%%%%%%%%%%%%%%%%%%%%%%%====================================" +
                                    "\n               ++++*%%%%%%%%%%%%%%%%%%%%%%%%#%%%%%%===================================" +
                                    "\n               ++=+%%%%%%%%%%%%%%%%%%%%%%%%%=#%%%%%#==================================" +
                                    "\n               +++#%%%%%%+%%%%%%%%%%%%%%%%%%*=#%%%%%*=================================" +
                                    "\n               ==+%%%%%#==#%%%%%%%%%%%%%%%%%#==#%%%%%=---------------=--=#%%%%*=======" +
                                    "\n               ==#%%%%#+=*%%%%%%%%%%%%%%%%%%*--=%%%%%#------------------*%%%%%%%=--=--" +
                                    "\n               ==%%%%#====+%%%%%%%%%%%%%%%%%+---=*%%%%=----------------+%%%%%%%%*=----" +
                                    "\n               ==%%%*=====*%%%%%%%%%%%%%%%%*------+%%%+:---------::---:+#%%%%%%+=%#---" +
                                    "\n               -+%%#----==#%%%%%%%%%%%%%%%%%-::::::=%%%-:::::::::::::::-=#%%%=-:+%#---" +
                                    "\n               -=%%#------+%%%%%%%%%%%%%%%%*:::::::-%%%+:::::::::::=+#%%%%%%%%*==%#-:-" +
                                    "\n               -+%+#------+%%%%%%%%%%%%%%%%-:::::::*%%%%-:::.:::=*%%%%%%%%%%%%%%#-#=::" +
                                    "\n               -=#*=------*%%%%%%%%%%%%%%%%-:::::::==#****#**##%%%%%%%%%%%%%%%%%%+::::" +
                                    "\n               ---==------+%%%%%%%%%%%%%%%#:.::::::.......:-+#%%%%%%%%%%%%%%%%%%%%-.:." +
                                    "\n               =-------::::%%%%%%%%%%%%%%%=...::::::::........::::::-+%%%%%%%%%%%%*..." +
                                    "\n               ===---::::.:*%%%%%%%%%%%%%*............................#%%%%%%%%#%%%:.." +
                                    "\n               ===---------=%%%%%%%%%%%%%-............................#%%%%%%%%##%*..." +
                                    "\n               ==========--=%%%%%%%%%%%%*............................-%%%%%%%%%%=#+..." +
                                    "\n               =====--------#%%%%%%%%%%%=..:...........           ...#%%%%%%%%%%#++..." +
                                    "\n               ========-----%%%%%%%%%%%%:............               :#%%%%%%%%%%%#* .." +
                                    "\n               --===--------%%%%%%%%%%%*..........                  +#%%%%%%%%%%%#*. ." +
                                    "\n               ==-=======--=%%%%%%%%%%%=...............  ....    . .#%%%%%%%%%%%%*:..." +
                                    "\n               =-----------=%%%%%%%%%%%:.........        .       ..-#%%%%%%%%%%%%#...." +
                                    "\n               ============+%%%%%%%%%%#::::::::::::----------::::::*%%%%%%%%%%%%#*-:::" +
                                    "\n               ++++========+%%%%%%%%%%*--:::::::::::::::::::::::::.:=+#%%#%%%=-:......" +
                                    "\n               ++++++++++=++%%%%%%%%%%*=========------::::::::::::::::*%%-*%%:........" +
                                    "\n               #####********%%%%%%%%%%+=================-------------:+%%=#%%-::::::::" +
                                    "\n               %%%%%%%%%%%%%%%%%%%%%%%##********+++++==+++**+==========%%+#%#-====----" +
                                    "\n\n               \"Data da foto: 12/11/2016\"");
                                Console.ReadLine();
                                Console.CursorVisible = true;
                                goto caixa_de_lembrancas;
                            case 2:
                                Ferramentas.LimpaTela();
                                Console.WriteLine("\"Papai," +
                                    "\n\n   Obrigado"); // Carta de dia dos pais, mostrando que a menina já tem 12 anos
                                Console.ReadLine();
                                goto caixa_de_lembrancas;
                            case 3:
                                goto quarto;
                        }
                        break;
                    case 5:
                        Ferramentas.LimpaTela();
                        Ferramentas.Escrever("O diário está rasgado, mas uma das folhas restantes possui uma anotação:" +
                            "\n\nOaP4SNhWFhiFF/IUjdD+NAMpLP19MR82TOV6/HxAUIaFGSaBJ2gPd2Tky9Pn9O5Jo3mPRedrPXkVSt+7LUIRQwb3C+0dPUXFMTpvj9RoE6jz2WIGAqH2cUylL++IWs3n");
                        goto quarto;
                    case 6:
                        Ferramentas.LimpaTela();
                        Ferramentas.Escrever("Você percebe que o relógio de parede parou de funcionar. Ele está parado em 20:52 já faz algum tempo.");
                        break;
                }
                break;
            }
        }
        public static void Ligação1() // OK
        {
            // Tocando áudio de ligação (chamando)

            Soundtrack.Player.Stop();
            Soundtrack.Leitor = new AudioFileReader(ControleMúsica.CaminhoTrilha(1)); // 1: Calling Soundtrack
            Soundtrack.Player.Init(Soundtrack.Leitor);
            Soundtrack.Player.Play();

            // Desabilitando barra de escrita

            Console.CursorVisible = false;

            // Desenho do telefone ligando

            for (int i = 0; i < 2; i++)
            {
                Ferramentas.LimpaTela();
                Console.WriteLine
                    ("\n\n\n\n" +
                    "                  ┌══════════════════════════┐\n" +
                    "                  │           o ═══          │\n" +
                    "                  │ ┌──────────────────────┐ │\n" +
                    "                  │ │                20:52 │ │\n" +
                    "                  │ ├──────────────────────┤ │\n" +
                    "                  │ │                      │ │\n" +
                    "                  │ │                      │ │\n" +
                    "                  │ │       Chamando.      │ │\n" +
                    "                  │ │                      │ │\n" +
                    "                  │ │                      │ │\n" +
                    "                  │ │        .'¯¯¯'.       │ │\n" +
                    "                  │ │        |  ?  |       │ │\n" +
                    "                  │ │        '.___.'       │ │\n" +
                    "                  │ │                      │ │\n" +
                    "                  │ │     Desconhecido     │ │\n" +
                    "                  │ │                      │ │\n" +
                    "                  │ │                      │ │\n" +
                    "                  │ │                      │ │\n" +
                    "                  │ │                      │ │\n" +
                    "                  │ │                      │ │\n" +
                    "                  │ └──────────────────────┘ │\n" +
                    "                  │             O            │\n" +
                    "                  └══════════════════════════┘");
                Thread.Sleep(2000);
                Ferramentas.LimpaTela();
                Console.WriteLine
                    ("\n\n\n\n" +
                    "                  ┌══════════════════════════┐\n" +
                    "                  │           o ═══          │\n" +
                    "                  │ ┌──────────────────────┐ │\n" +
                    "                  │ │                20:52 │ │\n" +
                    "                  │ ├──────────────────────┤ │\n" +
                    "                  │ │                      │ │\n" +
                    "                  │ │                      │ │\n" +
                    "                  │ │       Chamando..     │ │\n" +
                    "                  │ │                      │ │\n" +
                    "                  │ │                      │ │\n" +
                    "                  │ │        .'¯¯¯'.       │ │\n" +
                    "                  │ │        |  ?  |       │ │\n" +
                    "                  │ │        '.___.'       │ │\n" +
                    "                  │ │                      │ │\n" +
                    "                  │ │     Desconhecido     │ │\n" +
                    "                  │ │                      │ │\n" +
                    "                  │ │                      │ │\n" +
                    "                  │ │                      │ │\n" +
                    "                  │ │                      │ │\n" +
                    "                  │ │                      │ │\n" +
                    "                  │ └──────────────────────┘ │\n" +
                    "                  │             O            │\n" +
                    "                  └══════════════════════════┘");
                Thread.Sleep(2000);
                Ferramentas.LimpaTela();
                Console.WriteLine
                    ("\n\n\n\n" +
                    "                  ┌══════════════════════════┐\n" +
                    "                  │           o ═══          │\n" +
                    "                  │ ┌──────────────────────┐ │\n" +
                    "                  │ │                20:52 │ │\n" +
                    "                  │ ├──────────────────────┤ │\n" +
                    "                  │ │                      │ │\n" +
                    "                  │ │                      │ │\n" +
                    "                  │ │       Chamando...    │ │\n" +
                    "                  │ │                      │ │\n" +
                    "                  │ │                      │ │\n" +
                    "                  │ │        .'¯¯¯'.       │ │\n" +
                    "                  │ │        |  ?  |       │ │\n" +
                    "                  │ │        '.___.'       │ │\n" +
                    "                  │ │                      │ │\n" +
                    "                  │ │     Desconhecido     │ │\n" +
                    "                  │ │                      │ │\n" +
                    "                  │ │                      │ │\n" +
                    "                  │ │                      │ │\n" +
                    "                  │ │                      │ │\n" +
                    "                  │ │                      │ │\n" +
                    "                  │ └──────────────────────┘ │\n" +
                    "                  │             O            │\n" +
                    "                  └══════════════════════════┘");
                Thread.Sleep(2000);
                Ferramentas.LimpaTela();
            }

            // Encerrando som de ligação (chamando)

            Soundtrack.Player.Stop();
            Soundtrack.Leitor = new AudioFileReader(ControleMúsica.CaminhoTrilha(0)); // 0: Main Soundtrack
            Soundtrack.Player.Init(Soundtrack.Leitor);
            Soundtrack.Player.Play();

            // Habilitando barra de escrita

            Console.CursorVisible = true;
        }
        public static void Ligação1_atendida() // OK
        {
            // Tocando áudio de ligação (chamando)

            Soundtrack.Player.Stop();
            Soundtrack.Leitor = new AudioFileReader(ControleMúsica.CaminhoTrilha(2)); // 2: Call1 Soundtrack
            Soundtrack.Player.Init(Soundtrack.Leitor);
            Soundtrack.Player.Play();

            // Desabilitando barra de escrita

            Console.CursorVisible = false;

            // Mudando as cores do terminal

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Ferramentas.LimpaTela();

            // Desenho do telefone com a chamada online

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine
                    ("\n\n\n\n" +
                    "                  ┌══════════════════════════┐\n" +
                    "                  │           o ═══          │\n" +
                    "                  │ ┌──────────────────────┐ │\n" +
                    "                  │ │                20:52 │ │\n" +
                    "                  │ ├──────────────────────┤ │\n" +
                    "                  │ │                      │ │\n" +
                    "                  │ │                      │ │\n" +
                    $"                  │ │         00:{i:00}        │ │\n" +
                    "                  │ │                      │ │\n" +
                    "                  │ │                      │ │\n" +
                    "                  │ │        .'¯¯¯'.       │ │\n" +
                    "                  │ │        |  ?  |       │ │\n" +
                    "                  │ │        '.___.'       │ │\n" +
                    "                  │ │                      │ │\n" +
                    "                  │ │     Desconhecido     │ │\n" +
                    "                  │ │                      │ │\n" +
                    "                  │ │                      │ │\n" +
                    "                  │ │                      │ │\n" +
                    "                  │ │                      │ │\n" +
                    "                  │ │                      │ │\n" +
                    "                  │ └──────────────────────┘ │\n" +
                    "                  │             O            │\n" +
                    "                  └══════════════════════════┘");
                Thread.Sleep(1000);
                Ferramentas.LimpaTela();
            }

            // Encerrando som de ligação (chamando)

            Soundtrack.Player.Stop();
            Soundtrack.Leitor = new AudioFileReader(ControleMúsica.CaminhoTrilha(0)); // 0: Main Soundtrack
            Soundtrack.Player.Init(Soundtrack.Leitor);
            Soundtrack.Player.Play();

            // Voltando as cores ao normal

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Ferramentas.LimpaTela();

            // Habilitando barra de escrita

            Console.CursorVisible = true;
        }
    }

    public class Configurações
    {

    }

    public class Menus
    {
        static void Tela_default() // REPENSAR
        {
            Console.SetWindowSize(Console.WindowWidth, Console.WindowHeight);
            Console.SetBufferSize(Console.WindowWidth, Console.WindowHeight);
        }
        public static void Tela_inicio() // REPENSAR
        {
            // Obtendo altura e largura do console

            int Largura_Janela = Console.WindowWidth;
            int Altura_Janela = Console.WindowHeight;

            // Definindo strings da tela de início

            string Aviso_Tela_Cheia = "MAXIMIZE ESSA JANELA E PRESSIONE ENTER PARA JOGAR", Título = "UM DIA NEGRO", Aviso1 = "Por favor, não mude o tamanho da janela para uma melhor experiência.", Aviso2 = "Pressione qualquer tecla para jogar.";

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

            for (int i = 0; i < Altura_Janela / 2 - 5; i++)
            {
                Console.WriteLine(" ");
            }
            for (int i = 0; i < Largura_Janela / 2 - Título.Length / 2; i++)
            {
                Console.Write(" ");
            }
            Console.Write($"{Título}\n\n");
            for (int i = 0; i < Largura_Janela / 2 - Aviso1.Length / 2; i++)
            {
                Console.Write(" ");
            }
            Console.Write($"{Aviso1}\n\n");
            for (int i = 0; i < Largura_Janela / 2 - Aviso2.Length / 2; i++)
            {
                Console.Write(" ");
            }
            Console.Write($"{Aviso2}");
            Console.ReadLine();

            // Definindo o buffer do console (limite de linhas) para não ultrapassar o tamanho atual da janela

            Tela_default();

            // Limpando tela

            Ferramentas.LimpaTela();

            // Habilitando barra de escrita

            Console.CursorVisible = true;
        }

    }

    public class Mapa
    {
    }

    public class Luta
    {
    }
}
