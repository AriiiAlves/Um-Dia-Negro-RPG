using NAudio.Wave; // API para reproduzir áudio
using Projeto_RPG; // Acesso a todo o projeto (Para uso das Variáveis Globais)
using System.Data.SQLite;
using System.Runtime.InteropServices;
using static Funções.ControleMúsica;

namespace Funções
{
    public class Ferramentas
    {
        public static void Interface()//OK
        {
            int Console_Width = Console.WindowWidth;
            int Console_Height = Console.WindowHeight;

            for (int i = 0; i < Console_Width; i++)
            {
                if (i == 0)
                {
                    Console.Write("┌");
                }
                else if (i == Console_Width - 1)
                {
                    Console.Write("┐");
                }
                else
                {
                    Console.Write("─");
                }
            }
            for (int i = 0; i < Console_Height - 2; i++)
            {
                Console.Write("│");
                for (int j = 0; j < Console_Width - 2; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("│");
            }
            for (int i = 0; i < Console_Width; i++)
            {
                if (i == 0)
                {
                    Console.Write("└");
                }
                else if (i == Console_Width - 1)
                {
                    Console.Write("┘");
                }
                else
                {
                    Console.Write("─");
                }
            }
        }

        public static void Limpa_Interface()
        {
            for (int j = 2; j < Console.WindowHeight - 2; j++)
            {
                Console.SetCursorPosition(2, j);
                for (int k = 0; k < Console.WindowWidth - 3; k++)
                {
                    Console.Write(" ");
                }
            }
            Console.SetCursorPosition(2, 2);
        }
        public static void Escrever(string texto, bool escolha = false, bool instantâneo = false) //OK
        {
            char var;

            // Colocando espaço de tempo entre a escrita de cada letra
            // Não deixando as margens do console serem editadas

            Console.SetCursorPosition(2, 2);
            for (int i = 0; i < texto.Length; i++)
            {
                var = texto[i];

                if (Console.CursorLeft == 0 && Console.CursorTop == 0)
                {
                    Console.SetCursorPosition(2, 2);
                }
                else if (Console.CursorLeft == 0)
                {
                    int Linha_atual = Console.CursorTop;
                    Console.SetCursorPosition(2, Linha_atual);
                }
                else if (Console.CursorLeft == Console.WindowWidth - 2)
                {
                    int Linha_atual = Console.CursorTop;
                    Console.SetCursorPosition(2, Linha_atual + 1);
                }
                else if (Console.CursorTop == Console.WindowHeight - 3)
                {
                    if (Console.CursorLeft == Console.WindowWidth - 4 || var == '\n')
                    {
                        Console.Write("...");
                        Console.ReadLine();
                        for (int j = 2; j < Console.WindowHeight - 2; j++)
                        {
                            Console.SetCursorPosition(2, j);
                            for (int k = 0; k < Console.WindowWidth - 3; k++)
                            {
                                Console.Write(" ");
                            }
                        }
                        if (var == '\n')
                        {
                            Console.SetCursorPosition(1, 2);
                        }
                        else
                        {
                            Console.SetCursorPosition(2, 2);
                        }
                    }
                }
                Console.Write(var);

                // Colocando espaço de tempo maior após pontuação final

                if (instantâneo == false)
                {
                    if (var == '.' || var == '?' || var == '!')
                    {
                        Thread.Sleep(250);
                    }
                    Thread.Sleep(10);
                }
            }

            // Readkey para esperar ação do jogador

            if (escolha == false)
            {
                Console.ReadKey();
            }
            Console.WriteLine("");
        }
        public static void ImagemASCII(string texto) //OK
        {
            char var;

            // Colocando espaço de tempo entre a escrita de cada letra
            // Não deixando as margens do console serem editadas

            Limpa_Interface();

            Console.SetCursorPosition(2, 2);
            for (int i = 0; i < texto.Length; i++)
            {
                var = texto[i];

                if (Console.CursorLeft == 0 && Console.CursorTop == 0)
                {
                    Console.SetCursorPosition(2, 2);
                }
                else if (Console.CursorLeft == 0)
                {
                    int Linha_atual = Console.CursorTop;
                    Console.SetCursorPosition(2, Linha_atual);
                }
                else if (Console.CursorLeft == Console.WindowWidth - 2)
                {
                    int Linha_atual = Console.CursorTop;
                    Console.SetCursorPosition(2, Linha_atual + 1);
                }
                else if (Console.CursorTop == Console.WindowHeight - 3)
                {
                    if (Console.CursorLeft == Console.WindowWidth - 4 || var == '\n')
                    {
                        Console.Write("...");
                        Console.ReadLine();
                        for (int j = 2; j < Console.WindowHeight - 2; j++)
                        {
                            Console.SetCursorPosition(2, j);
                            for (int k = 0; k < Console.WindowWidth - 3; k++)
                            {
                                Console.Write(" ");
                            }
                        }
                        if (var == '\n')
                        {
                            Console.SetCursorPosition(1, 2);
                        }
                        else
                        {
                            Console.SetCursorPosition(2, 2);
                        }
                    }
                }
                Console.Write(var);
            }
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
            WaveOutEvent Effect_Player;
            AudioFileReader Effect_Reader;

            Effect_Player = new WaveOutEvent();
            Effect_Reader = new AudioFileReader("Colocar som vazio"); // Colocar som vazio aqui

            switch (n)
            {
                case 1:
                    Effect_Reader = new AudioFileReader(" <Colocar efeito sonoro 1 aqui> "); // Colocar ainda
                    break;
                case 2:
                    Effect_Reader = new AudioFileReader(" <Colocar efeito sonoro 2 aqui> "); // Colocar ainda
                    break;
            }

            Effect_Player.Init(Effect_Reader);
            Effect_Player.Play();
        }

        public static string CaminhoTrilha(int n) // Colocar certinho os caminhos, testar, e colocar mais trilhas
        {
            string temp = Directory.GetCurrentDirectory();
            switch (n)
            {
                case 0:
                    // return ($@"{temp}/Soundtrack/Main Sound.mp3"); // Padrão
                    // return (@"C:\Users\Ariel\Source\Repos\Um-Dia-Negro-RPG\Projeto rpg\Soundtrack\Main Sound.mp3"); // Casa
                    return (@"C:\Users\ariel.asilva2\Source\Repos\Um-Dia-Negro-RPG\Projeto rpg\Soundtrack\Main Sound.mp3"); // Senac
                case 1:
                    // return ($@"{temp}/Soundtrack/Calling Sound.mp3"); // Padrão
                    // return (@"C:\Users\Ariel\Source\Repos\Um-Dia-Negro-RPG\Projeto rpg\Soundtrack\Calling Sound.mp3"); // Casa
                    return (@"C:\Users\ariel.asilva2\Source\Repos\Um-Dia-Negro-RPG\Projeto rpg\Soundtrack\Calling Sound.mp3"); // Senac
                case 2:
                    // return ($@"{temp}/Soundtrack/Call1 Sound.mp3"); // Padrão
                    // return (@"C:\Users\Ariel\Source\Repos\Um-Dia-Negro-RPG\Projeto rpg\Soundtrack\Call1 Sound.mp3"); // Casa
                    return (@"C:\Users\ariel.asilva2\Source\Repos\Um-Dia-Negro-RPG\Projeto rpg\Soundtrack\Call1 Sound.mp3"); // Senac
                default:
                    // return ($@"{temp}/Soundtrack/Main Sound.mp3"); // Padrão
                    // return (@"C:\Users\Ariel\Source\Repos\Um-Dia-Negro-RPG\Projeto rpg\Soundtrack\Main Sound.mp3"); // Casa
                    return (@"C:\Users\ariel.asilva2\Source\Repos\Um-Dia-Negro-RPG\Projeto rpg\Soundtrack\Main Sound.mp3"); // Senac
            }
        }

        // GUIA DE SOUNDTRACKS

        // 0: SOM DECHUVA
        // 1: SOM DE LIGAÇÃO (CHAMANDO)
        // 2: SOM DO CONTATO DESCONHECIDO

        public class Soundtrack0
        {
            public static WaveOutEvent Player = new WaveOutEvent();
            public static AudioFileReader Leitor = new AudioFileReader(CaminhoTrilha(0));
        }
        public class Soundtrack1
        {
            public static WaveOutEvent Player = new WaveOutEvent();
            public static AudioFileReader Leitor = new AudioFileReader(CaminhoTrilha(1));
        }
        public class Soundtrack2
        {
            public static WaveOutEvent Player = new WaveOutEvent();
            public static AudioFileReader Leitor = new AudioFileReader(CaminhoTrilha(2));
        }
    }

    public class Ações
    {
        public static int Escolha(int quant_opcoes) // OK
        {
            int Linha_atual = Console.CursorTop;

            Console.SetCursorPosition(2, Linha_atual + 1);
            Console.Write(new string(": "));

        responder:
            int resposta;
            try
            {
                Console.CursorVisible = true;
                resposta = int.Parse(Console.ReadLine());
                Console.CursorVisible = false;
                if (resposta < 1 || resposta > quant_opcoes)
                {
                    Console.SetCursorPosition(4, Console.CursorTop - 1);
                    Console.Write(new string(' ', Console.WindowWidth - 6));
                    Console.SetCursorPosition(4, Console.CursorTop);
                    goto responder;
                }
                return resposta;
            }
            catch
            {
                Console.SetCursorPosition(4, Console.CursorTop - 1);
                Console.Write(new string(' ', Console.WindowWidth - 6));
                Console.SetCursorPosition(4, Console.CursorTop);
                goto responder;
            }
        }
    }

    public class História
    {        
        public static void VerTV() // NÃO OK
        {
            if (VariáveisGlobais.cabo_e_chave) // Continuar
            {
                Ferramentas.Limpa_Interface();
                Ferramentas.Escrever("");
            }
            else
            {
                Ferramentas.Limpa_Interface();
                Ferramentas.Escrever("Você senta no sofá, e pega o controle para ligar a TV." +
                    "\nMas ela não está ligando." +
                    "\n\nO que fazer?" +
                    "\n\n[1] Descobrir o problema" +
                    "\n[2] Fazer outra coisa", true);
                switch (Ações.Escolha(2))
                {
                    case 1:
                        Ferramentas.Limpa_Interface();
                        Ferramentas.Escrever("Você mexe atrás da TV para encontrar o problema, com dificuldade." +
                            "\nParece que ela está sem o cabo de energia." +
                            "\n\nPor onde começar a procurar?" +
                            "\n\n[1] Escritório" +
                            "\n[2] Quarto", true);
                        switch (Ações.Escolha(2))
                        {
                            case 1:
                                Ferramentas.Limpa_Interface();
                                Ferramentas.Escrever("Você vai até a porta de seu escritório, e gira a maçaneta." +
                                    "\nEstá trancado." +
                                    "\n\nProcurar a chave no quarto?" +
                                    "\n\n[1] Sim" +
                                    "\n[2] n̰̝̹̳͊͒̂̉̀ ̸̣̘̭̻̼̊ͥ͑ ͖́͝ͅǒ̷̹̱̳̘̣̦̮̲͂̍ͦ", true);
                                Ações.Escolha(2);
                                goto case 2;
                            case 2:
                                História.Quarto();
                                break;
                        }
                        break;
                    case 2:
                        Ferramentas.Limpa_Interface();
                        Ferramentas.Escrever("Você pode ouvir o som do vento batendo nas janelas.");
                        break;
                }
            }
        }

        public static void Atender_Telefone() // NÃO OK (FALTA BANCO DE DADOS)
        {
            Ferramentas.Limpa_Interface();
            if (VariáveisGlobais.chamada1_realizada)
            {
                Telefone:

                Ferramentas.Limpa_Interface();
                if (VariáveisGlobais.mensagens_nao_respondidas == 0)
                {
                    Ferramentas.Escrever("Você pega o celular e checa as notificações." +
                "\n\nNão há novas notificações." +
                "\n\nO que deseja fazer?" +
                "\n\n[1] Checar mensagens" +
                "\n[2] Checar contatos" +
                "\n[3] Checar galeria", true);
                }
                else
                {
                    Ferramentas.Escrever("Você pega o celular e checa as notificações." +
                "\n\nHá mensagens não respondidas." +
                "\n\nO que deseja fazer?" +
                "\n\n[1] Checar mensagens" +
                "\n[2] Checar contatos" +
                "\n[3] Checar galeria", true);
                }

                switch (Ações.Escolha(3)) // CONTINUAR
                {
                    case 1: // Continuar Mensagens (nota: a cada mensagem respondida o banco subtrai 1 mensagem não respondida)
                        Ferramentas.Limpa_Interface();
                        Ferramentas.Escrever($"Há {VariáveisGlobais.mensagens_nao_respondidas} mensagens não respondidas\n\n" +
                            "[1] Responder mensagens" +
                            "[2] Sair");
                        switch (Ações.Escolha(2))
                        {
                            case 1:
                                Mensagens();
                                break;
                            case 2:
                                goto Telefone;
                        }
                        break;
                    case 2: // OK
                        contatos:
                        Ferramentas.Limpa_Interface();
                        Ferramentas.Escrever("Lista de contatos de Tiago\n\n" +
                            "Mãe\n" +
                            "Pai\n" +
                            "Thomas\n" +
                            "Rafael Brother\n" +
                            "CSP\n" +
                            "Sofia Filha ♥\n\n[1] Ligar para um contato\n" +
                            "[2] Sair", true);
                        switch (Ações.Escolha(2))
                        {
                            case 1:
                                Ferramentas.Limpa_Interface();
                                Ferramentas.Escrever("Ligar para qual contato?\n\n" +
                                    "[1] Mãe\n" +
                                    "[2] Pai\n" +
                                    "[3] Thomas\n" +
                                    "[4] Rafael Brother\n" +
                                    "[5] CSP\n" +
                                    "[6] Sofia Filha ♥", true);
                                switch (Ações.Escolha(6))
                                {
                                    case 1:
                                        Contatos(1);
                                        goto contatos;
                                    case 2:
                                        Contatos(2);
                                        goto contatos;
                                    case 3:
                                        Contatos(3);
                                        goto contatos;
                                    case 4:
                                        Contatos(4);
                                        goto contatos;
                                    case 5:
                                        Contatos(5);
                                        goto contatos;
                                    case 6:
                                        Contatos(6);
                                        goto contatos;
                                }
                                break;
                            case 2:
                                Ferramentas.Limpa_Interface();
                                Ferramentas.Escrever("De pouco em pouco tempo, súbitas e rápidas quedas de energia atingem a casa.");
                                break;
                        }
                        break;
                    case 3: // FAZER
                        break;
                }
            }
            else
            {
                {
                    Ferramentas.Escrever("Você pega o celular e checa as notificações." +
                    "\n\n1 chamada(s) não atendida(s) - Número desconhecido" +
                    "\n\nLigar de volta?" +
                    "\n\n[1] Sim" +
                    "\n[2] Não", true);
                    switch (Ações.Escolha(2))
                    {
                        case 1:
                            Ferramentas.Limpa_Interface();

                            Ligação(0, 3);

                            Ferramentas.Limpa_Interface();
                            VariáveisGlobais.chamada1_realizada = true;
                            Ferramentas.Escrever("Ninguém atende." +
                                "\n\nLigar novamente?" +
                                "\n\n[1] Sim" +
                                "\n[2] Não", true);
                            switch (Ações.Escolha(2))
                            {
                                case 1:
                                    Ferramentas.Limpa_Interface();

                                    Contatos(0);

                                    Ferramentas.Limpa_Interface();
                                    Ferramentas.Escrever("O histórico de chamadas foi limpo subitamente. O número desconhecido não está mais disponível.");
                                    Ferramentas.Limpa_Interface();
                                    Ferramentas.Escrever("O frescor da ventania molhada passa pelo seu corpo em rajadas. Você se sente confortável.");
                                    break;
                                case 2:
                                    Ferramentas.Limpa_Interface();
                                    Ferramentas.Escrever("Você pode ouvir a água correndo pelas canaletas de chuva.");
                                    break;
                            }
                            break;
                        case 2:
                            VariáveisGlobais.chamada1_realizada = true;
                            Ferramentas.Limpa_Interface();
                            Ferramentas.Escrever("Os trovões lá fora soam e se esvaem subitamente.");
                            break;
                    }
                }
            }
        }

        public static void Quarto() // OK (SÓ FALTA BANCO DE DADOS)
        {
            string stemp;

            while (true)
            {
            quarto:
                Ferramentas.Limpa_Interface();
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
                        Ferramentas.Limpa_Interface();
                        Ferramentas.Escrever("O armário contém roupas masculinas, e uma pequena pilha de roupas infantis.");
                        goto quarto;
                    case 2:
                        if (VariáveisGlobais.cofre_aberto)
                        {
                            Ferramentas.Limpa_Interface();
                            Ferramentas.Escrever("O cofre está aberto." +
                                "\n\nDentro dele há uma anotação:" +
                                "\n\nAES-128-ECB" +
                                "\nChave: 7855");
                            goto quarto;
                        }
                        else
                        {
                            Ferramentas.Limpa_Interface();
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
                                        Ferramentas.Limpa_Interface();
                                        Ferramentas.Escrever("Digite SAIR para sair.\n\nSenha: ", escolha: true,instantâneo: true);
                                        Console.SetCursorPosition(9, 4);
                                        Console.CursorVisible = true;
                                        stemp = Console.ReadLine();
                                        Console.CursorVisible = false;
                                        if (stemp == "12112016")
                                        {
                                            Ferramentas.Limpa_Interface();
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
                                            Ferramentas.Limpa_Interface();
                                            Console.WriteLine("SENHA INCORRETA");
                                            Console.ReadLine();
                                        }
                                    }
                                case 2:
                                    goto quarto;
                            }
                        }
                        break;
                    case 3:
                    escrivaninha:
                        Ferramentas.Limpa_Interface();
                        Ferramentas.Escrever("Uma escrivaninha de madeira maciça, com um vidro na parte de cima. Possui 2 gavetas, com uma carta comum na superfície." +
                            "\n\n[1] Olhar carta" +
                            "\n[2] Olhar gavetas" +
                            "\n[3] Sair", true);
                        switch (Ações.Escolha(3))
                        {
                            case 1:
                                Ferramentas.Limpa_Interface();
                                Ferramentas.Escrever("\"Caro Thiago" +
                                    "\n\n   Escrevo com pesar, e lamento muito o ocorrido. As coisas realmente não eram para terminarem desse jeito." +
                                    "\n   As buscas já completam 2 dias, e como a área é muito grande e a floresta densa, não conseguimos encontrar nada ainda. " +
                                    "Devido à falta de evidências para comprovar a situação do corpo, o caso ainda vai permanecer em aberto " +
                                    "com a situação de \"Desaparecimento\"." +
                                    "\n   Ainda não desistimos. Enquanto ainda houver esperança de que ela esteja viva, continuaremos procurando.\"" +
                                    "\n\nAss: Capitão Victor Gabriel Santos", instantâneo: true);
                                goto escrivaninha;
                            case 2:
                                Ferramentas.Limpa_Interface();
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
                        Ferramentas.Limpa_Interface();
                        Ferramentas.Escrever("A caixa de lembranças contém alguns brinquedos, uma foto e um poema." +
                            "\n\n[1] Ver foto" +
                            "\n[2] Ver poema" +
                            "\n[3] Sair", true);
                        switch (Ações.Escolha(3))
                        {
                            case 1:
                                Ferramentas.ImagemASCII("\n" +
                                    "           ***********************###*********************************************" +
                                    "\n           *******************+#%%%%%%%#******************************************" +
                                    "\n           ********************%%%%%%%%%%*+*++++++++++++++**+++++++***************" +
                                    "\n           ****************+++*%%%%%%%%%#*++++++++++++++++++++++++++++++++++******" +
                                    "\n           ******+++++*+++++**#%%%%%%%%%+++++++++++++++++++++++++++++++++++++++++*" +
                                    "\n           *+++++++++++**#%%%%%%%%%%%%%*++++++++++++++++++++++++++++++++++++++++++" +
                                    "\n           ++++++++++#%%%%%%%%%%%%%%%%%#*+++++++++++++++++++++++++++++++++++++++++" +
                                    "\n           +++++++++%%%%%%%%%%%%%%%%%%%%%%*+++++++++++++++++++++++++++++++++++++++" +
                                    "\n           ++++++++%%%%%%%%%%%%%%%%%%%%%%%%#++++++++++++++++++++++++++++++++++++++" +
                                    "\n           +++++++#%%%%%%%%%%%%%%%%%%%%%%%%%#====+++++++++++++++++++++++++++++++++" +
                                    "\n           ++++++#%%%%%%%%%%%%%%%%%%%%%%%%%%%*===============================+++++" +
                                    "\n           +++++*%%%%%%%%%%%%%%%%%%%%%%%%%%%%%====================================" +
                                    "\n           ++++*%%%%%%%%%%%%%%%%%%%%%%%%#%%%%%%===================================" +
                                    "\n           ++=+%%%%%%%%%%%%%%%%%%%%%%%%%=#%%%%%#==================================" +
                                    "\n           +++#%%%%%%+%%%%%%%%%%%%%%%%%%*=#%%%%%*=================================" +
                                    "\n           ==+%%%%%#==#%%%%%%%%%%%%%%%%%#==#%%%%%=---------------=--=#%%%%*=======" +
                                    "\n           ==#%%%%#+=*%%%%%%%%%%%%%%%%%%*--=%%%%%#------------------*%%%%%%%=--=--" +
                                    "\n           ==%%%%#====+%%%%%%%%%%%%%%%%%+---=*%%%%=----------------+%%%%%%%%*=----" +
                                    "\n           ==%%%*=====*%%%%%%%%%%%%%%%%*------+%%%+:---------::---:+#%%%%%%+=%#---" +
                                    "\n           -+%%#----==#%%%%%%%%%%%%%%%%%-::::::=%%%-:::::::::::::::-=#%%%=-:+%#---" +
                                    "\n           -=%%#------+%%%%%%%%%%%%%%%%*:::::::-%%%+:::::::::::=+#%%%%%%%%*==%#-:-" +
                                    "\n           -+%+#------+%%%%%%%%%%%%%%%%-:::::::*%%%%-:::.:::=*%%%%%%%%%%%%%%#-#=::" +
                                    "\n           -=#*=------*%%%%%%%%%%%%%%%%-:::::::==#****#**##%%%%%%%%%%%%%%%%%%+::::" +
                                    "\n           ---==------+%%%%%%%%%%%%%%%#:.::::::.......:-+#%%%%%%%%%%%%%%%%%%%%-.:." +
                                    "\n           =-------::::%%%%%%%%%%%%%%%=...::::::::........::::::-+%%%%%%%%%%%%*..." +
                                    "\n           ===---::::.:*%%%%%%%%%%%%%*............................#%%%%%%%%#%%%:.." +
                                    "\n           ===---------=%%%%%%%%%%%%%-............................#%%%%%%%%##%*..." +
                                    "\n           ==========--=%%%%%%%%%%%%*............................-%%%%%%%%%%=#+..." +
                                    "\n           =====--------#%%%%%%%%%%%=..:...........           ...#%%%%%%%%%%#++..." +
                                    "\n           ========-----%%%%%%%%%%%%:............               :#%%%%%%%%%%%#* .." +
                                    "\n           --===--------%%%%%%%%%%%*..........                  +#%%%%%%%%%%%#*. ." +
                                    "\n           ==-=======--=%%%%%%%%%%%=...............  ....    . .#%%%%%%%%%%%%*:..." +
                                    "\n           =-----------=%%%%%%%%%%%:.........        .       ..-#%%%%%%%%%%%%#...." +
                                    "\n           ============+%%%%%%%%%%#::::::::::::----------::::::*%%%%%%%%%%%%#*-:::" +
                                    "\n           ++++========+%%%%%%%%%%*--:::::::::::::::::::::::::.:=+#%%#%%%=-:......" +
                                    "\n           ++++++++++=++%%%%%%%%%%*=========------::::::::::::::::*%%-*%%:........" +
                                    "\n           #####********%%%%%%%%%%+=================-------------:+%%=#%%-::::::::" +
                                    "\n           %%%%%%%%%%%%%%%%%%%%%%%##********+++++==+++**+==========%%+#%#-====----" +
                                    "\n\n           \"Data da foto: 12/11/2016\"");
                                Console.ReadKey();
                                goto caixa_de_lembrancas;
                            case 2:
                                Ferramentas.Limpa_Interface();
                                Ferramentas.Escrever("\"Papai," +
                                    "\n\n   Queria te agradecer por tudo que fez e que faz por mim. Você sempre cuidou de mim como se eu fosse uma pedrinha preciosa, " +
                                    "e nunca deixou de se importar comigo... seja qual você a situação, você estava lá... em todas as minhas alegrias, em todas as minhas " +
                                    "tristezas, em todas as minhas fases de bebê, criança e adolescente... O mínimo que eu posso fazer é agradecer. Te amo muuuuito, e " +
                                    "feliz dia dos pais!\"" +
                                    "\n\n Obs: deixei um presentinho pra você na mesa", instantâneo: true);
                                goto caixa_de_lembrancas;
                            case 3:
                                goto quarto;
                        }
                        break;
                    case 5:
                        Ferramentas.Limpa_Interface();
                        Ferramentas.Escrever("O diário está rasgado, mas uma das folhas restantes possui uma anotação:" +
                            "\n\nOaP4SNhWFhiFF/IUjdD+NAMpLP19MR82TOV6/HxAUIakparXa7HCL9ANjPgwoo2xkCLAZMv+b7yZDCGZK0zTimmf1NtW+DUrbtNVIQ0lXbDz2WIGAqH2cUylL++IWs3n");
                        goto quarto;
                    case 6:
                        Ferramentas.Limpa_Interface();
                        Ferramentas.Escrever("Você percebe que o relógio de parede parou de funcionar. Ele está parado em 20:52 já faz algum tempo.");
                        Ferramentas.Limpa_Interface();
                        break;
                }
                break;
            }
        }
        public static void Ligação(int n_contato, int n_repetição_toque) // OK
        {
            // Tocando áudio de ligação (chamando)

            Soundtrack0.Player.Pause();
            Soundtrack1.Leitor = new AudioFileReader(CaminhoTrilha(1));
            Soundtrack1.Player.Init(Soundtrack1.Leitor);
            Soundtrack1.Player.Play();

            // Desenho do telefone ligando

            Ferramentas.Limpa_Interface();

            switch (n_contato)
            {
                case 0:
                    Ferramentas.ImagemASCII("\n" +
                        "           ┌══════════════════════════┐\n" +
                        "           │           o ═══          │\n" +
                        "           │ ┌──────────────────────┐ │\n" +
                        "           │ │                20:52 │ │\n" +
                        "           │ ├──────────────────────┤ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │       Chamando.      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │        .'¯¯¯'.       │ │\n" +
                        "           │ │        |  ?  |       │ │\n" +
                        "           │ │        '.___.'       │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │     Desconhecido     │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ └──────────────────────┘ │\n" +
                        "           │             O            │\n" +
                        "           └══════════════════════════┘");
                    break;
                case 1:
                    Ferramentas.ImagemASCII("\n" +
                        "           ┌══════════════════════════┐\n" +
                        "           │           o ═══          │\n" +
                        "           │ ┌──────────────────────┐ │\n" +
                        "           │ │                20:52 │ │\n" +
                        "           │ ├──────────────────────┤ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │       Chamando.      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │        .'¯¯¯'.       │ │\n" +
                        "           │ │        |  ☺  |       │ │\n" +
                        "           │ │        '.___.'       │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │          Mãe         │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ └──────────────────────┘ │\n" +
                        "           │             O            │\n" +
                        "           └══════════════════════════┘");
                    break;
                case 2:
                    Ferramentas.ImagemASCII("\n" +
                        "           ┌══════════════════════════┐\n" +
                        "           │           o ═══          │\n" +
                        "           │ ┌──────────────────────┐ │\n" +
                        "           │ │                20:52 │ │\n" +
                        "           │ ├──────────────────────┤ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │       Chamando.      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │        .'¯¯¯'.       │ │\n" +
                        "           │ │        |  ☺  |       │ │\n" +
                        "           │ │        '.___.'       │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │          Pai         │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ └──────────────────────┘ │\n" +
                        "           │             O            │\n" +
                        "           └══════════════════════════┘");
                    break;
                case 3:
                    Ferramentas.ImagemASCII("\n" +
                        "           ┌══════════════════════════┐\n" +
                        "           │           o ═══          │\n" +
                        "           │ ┌──────────────────────┐ │\n" +
                        "           │ │                20:52 │ │\n" +
                        "           │ ├──────────────────────┤ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │       Chamando.      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │        .'¯¯¯'.       │ │\n" +
                        "           │ │        |  ☺  |       │ │\n" +
                        "           │ │        '.___.'       │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │         Thomas       │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ └──────────────────────┘ │\n" +
                        "           │             O            │\n" +
                        "           └══════════════════════════┘");
                    break;
                case 4:
                    Ferramentas.ImagemASCII("\n" +
                        "           ┌══════════════════════════┐\n" +
                        "           │           o ═══          │\n" +
                        "           │ ┌──────────────────────┐ │\n" +
                        "           │ │                20:52 │ │\n" +
                        "           │ ├──────────────────────┤ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │       Chamando.      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │        .'¯¯¯'.       │ │\n" +
                        "           │ │        |  ☺  |       │ │\n" +
                        "           │ │        '.___.'       │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │     Rafael Brother   │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ └──────────────────────┘ │\n" +
                        "           │             O            │\n" +
                        "           └══════════════════════════┘");
                    break;
                case 5:
                    Ferramentas.ImagemASCII("\n" +
                        "           ┌══════════════════════════┐\n" +
                        "           │           o ═══          │\n" +
                        "           │ ┌──────────────────────┐ │\n" +
                        "           │ │                20:52 │ │\n" +
                        "           │ ├──────────────────────┤ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │       Chamando.      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │        .'¯¯¯'.       │ │\n" +
                        "           │ │        |  ®  |       │ │\n" +
                        "           │ │        '.___.'       │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │          CSP         │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ └──────────────────────┘ │\n" +
                        "           │             O            │\n" +
                        "           └══════════════════════════┘");
                    break;
                case 6:
                    Ferramentas.ImagemASCII("\n" +
                        "           ┌══════════════════════════┐\n" +
                        "           │           o ═══          │\n" +
                        "           │ ┌──────────────────────┐ │\n" +
                        "           │ │                20:52 │ │\n" +
                        "           │ ├──────────────────────┤ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │       Chamando.      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │        .'¯¯¯'.       │ │\n" +
                        "           │ │        |  ♥  |       │ │\n" +
                        "           │ │        '.___.'       │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │    Sofia Filha ♥     │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ └──────────────────────┘ │\n" +
                        "           │             O            │\n" +
                        "           └══════════════════════════┘");
                    break;
            }
            
            for (int i = 0; i < n_repetição_toque; i++)
            {
                Console.SetCursorPosition(32, 10);
                Console.Write(new string("  "));
                Thread.Sleep(2000);
                Console.SetCursorPosition(32, 10);
                Console.Write(new string("."));
                Thread.Sleep(2000);
                Console.SetCursorPosition(32, 10);
                Console.Write(new string(".."));
                Thread.Sleep(2000);
            }

            Ferramentas.Limpa_Interface();

            // Encerrando som de ligação (chamando)

            Soundtrack1.Player.Stop();
            Soundtrack0.Player.Play();
        }
        public static void Ligação_atendida(int n_contato) // NÃO OK (FALTA ÁUDIOS DIFERENTES, E CORRIGIR FATO DA TRILHA SÓ PODER SER TOCADA UMA VEZ)
        {
            // Limpando Interface

            Ferramentas.Limpa_Interface();

            switch (n_contato)
            {
                case 0:
                    // Tocando áudio de ligação (Atendida)

                    Soundtrack0.Player.Pause();
                    Soundtrack2.Player.Init(Soundtrack2.Leitor);
                    Soundtrack2.Player.Play();

                    // Mudando as cores do terminal

                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Clear();

                    // Desenho do telefone com a chamada online

                    Ferramentas.ImagemASCII("\n" +
                            "           ┌══════════════════════════┐\n" +
                            "           │           o ═══          │\n" +
                            "           │ ┌──────────────────────┐ │\n" +
                            "           │ │                20:52 │ │\n" +
                            "           │ ├──────────────────────┤ │\n" +
                            "           │ │                      │ │\n" +
                            "           │ │                      │ │\n" +
                            $"           │ │                      │ │\n" +
                            "           │ │                      │ │\n" +
                            "           │ │                      │ │\n" +
                            "           │ │        .'¯¯¯'.       │ │\n" +
                            "           │ │        |  ?  |       │ │\n" +
                            "           │ │        '.___.'       │ │\n" +
                            "           │ │                      │ │\n" +
                            "           │ │     Desconhecido     │ │\n" +
                            "           │ │                      │ │\n" +
                            "           │ │                      │ │\n" +
                            "           │ │                      │ │\n" +
                            "           │ │                      │ │\n" +
                            "           │ │                      │ │\n" +
                            "           │ └──────────────────────┘ │\n" +
                            "           │             O            │\n" +
                            "           └══════════════════════════┘");

                    for (int i = 0; i < 10; i++)
                    {
                        Console.SetCursorPosition(25, 10);
                        Console.Write(new string($"00:{i:00}"));
                        Thread.Sleep(1000);
                    }

                    // Voltando as cores ao normal

                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    Ferramentas.Interface();

                    // Encerrando som da ligação (Desconhecido)

                    Soundtrack2.Player.Stop();
                    Soundtrack0.Player.Play();
                    break;
                case 1:
                    // Tocando áudio de ligação (Atendida)

                    Soundtrack0.Player.Pause();
                    Soundtrack2.Player.Init(Soundtrack2.Leitor);
                    Soundtrack2.Player.Play();

                    // Desenho do telefone com a chamada online

                    Ferramentas.ImagemASCII("\n" +
                        "           ┌══════════════════════════┐\n" +
                        "           │           o ═══          │\n" +
                        "           │ ┌──────────────────────┐ │\n" +
                        "           │ │                20:52 │ │\n" +
                        "           │ ├──────────────────────┤ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │        .'¯¯¯'.       │ │\n" +
                        "           │ │        |  ☺  |       │ │\n" +
                        "           │ │        '.___.'       │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │          Mãe         │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ └──────────────────────┘ │\n" +
                        "           │             O            │\n" +
                        "           └══════════════════════════┘");

                    for (int i = 0; i < 10; i++)
                    {
                        Console.SetCursorPosition(25, 10);
                        Console.Write(new string($"00:{i:00}"));
                        Thread.Sleep(1000);
                    }

                    // Limpando Interface

                    Ferramentas.Limpa_Interface();

                    // Encerrando som da ligação (Desconhecido)

                    Soundtrack2.Player.Stop();
                    Soundtrack0.Player.Play();
                    break;
                case 2:
                    // Tocando áudio de ligação (Atendida)

                    Soundtrack0.Player.Pause();
                    Soundtrack2.Player.Init(Soundtrack2.Leitor);
                    Soundtrack2.Player.Play();

                    // Desenho do telefone com a chamada online

                    Ferramentas.ImagemASCII("\n" +
                        "           ┌══════════════════════════┐\n" +
                        "           │           o ═══          │\n" +
                        "           │ ┌──────────────────────┐ │\n" +
                        "           │ │                20:52 │ │\n" +
                        "           │ ├──────────────────────┤ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │        .'¯¯¯'.       │ │\n" +
                        "           │ │        |  ☺  |       │ │\n" +
                        "           │ │        '.___.'       │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │          Pai         │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ └──────────────────────┘ │\n" +
                        "           │             O            │\n" +
                        "           └══════════════════════════┘");

                    for (int i = 0; i < 10; i++)
                    {
                        Console.SetCursorPosition(25, 10);
                        Console.Write(new string($"00:{i:00}"));
                        Thread.Sleep(1000);
                    }

                    // Limpando Interface

                    Ferramentas.Limpa_Interface();

                    // Encerrando som da ligação (Desconhecido)

                    Soundtrack2.Player.Stop();
                    Soundtrack0.Player.Play();
                    break;
                case 3:
                    // Tocando áudio de ligação (Atendida)

                    Soundtrack0.Player.Pause();
                    Soundtrack2.Player.Init(Soundtrack2.Leitor);
                    Soundtrack2.Player.Play();

                    // Desenho do telefone com a chamada online

                    Ferramentas.ImagemASCII("\n" +
                        "           ┌══════════════════════════┐\n" +
                        "           │           o ═══          │\n" +
                        "           │ ┌──────────────────────┐ │\n" +
                        "           │ │                20:52 │ │\n" +
                        "           │ ├──────────────────────┤ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │        .'¯¯¯'.       │ │\n" +
                        "           │ │        |  ☺  |       │ │\n" +
                        "           │ │        '.___.'       │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │         Thomas       │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ └──────────────────────┘ │\n" +
                        "           │             O            │\n" +
                        "           └══════════════════════════┘");

                    for (int i = 0; i < 10; i++)
                    {
                        Console.SetCursorPosition(25, 10);
                        Console.Write(new string($"00:{i:00}"));
                        Thread.Sleep(1000);
                    }

                    // Limpando Interface

                    Ferramentas.Limpa_Interface();

                    // Encerrando som da ligação (Desconhecido)

                    Soundtrack2.Player.Stop();
                    Soundtrack0.Player.Play();
                    break;
                case 4:
                    // Tocando áudio de ligação (Atendida)

                    Soundtrack0.Player.Pause();
                    Soundtrack2.Player.Init(Soundtrack2.Leitor);
                    Soundtrack2.Player.Play();

                    // Desenho do telefone com a chamada online

                    Ferramentas.ImagemASCII("\n" +
                        "           ┌══════════════════════════┐\n" +
                        "           │           o ═══          │\n" +
                        "           │ ┌──────────────────────┐ │\n" +
                        "           │ │                20:52 │ │\n" +
                        "           │ ├──────────────────────┤ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │        .'¯¯¯'.       │ │\n" +
                        "           │ │        |  ☺  |       │ │\n" +
                        "           │ │        '.___.'       │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │     Rafael Brother   │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ └──────────────────────┘ │\n" +
                        "           │             O            │\n" +
                        "           └══════════════════════════┘");

                    for (int i = 0; i < 10; i++)
                    {
                        Console.SetCursorPosition(25, 10);
                        Console.Write(new string($"00:{i:00}"));
                        Thread.Sleep(1000);
                    }

                    // Limpando Interface

                    Ferramentas.Limpa_Interface();

                    // Encerrando som da ligação (Desconhecido)

                    Soundtrack2.Player.Stop();
                    Soundtrack0.Player.Play();
                    break;
                case 5:
                    // Tocando áudio de ligação (Atendida)

                    Soundtrack0.Player.Pause();
                    Soundtrack2.Player.Init(Soundtrack2.Leitor);
                    Soundtrack2.Player.Play();

                    // Desenho do telefone com a chamada online

                    Ferramentas.ImagemASCII("\n" +
                        "           ┌══════════════════════════┐\n" +
                        "           │           o ═══          │\n" +
                        "           │ ┌──────────────────────┐ │\n" +
                        "           │ │                20:52 │ │\n" +
                        "           │ ├──────────────────────┤ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │        .'¯¯¯'.       │ │\n" +
                        "           │ │        |  ®  |       │ │\n" +
                        "           │ │        '.___.'       │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │          CSP         │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ └──────────────────────┘ │\n" +
                        "           │             O            │\n" +
                        "           └══════════════════════════┘");

                    for (int i = 0; i < 10; i++)
                    {
                        Console.SetCursorPosition(25, 10);
                        Console.Write(new string($"00:{i:00}"));
                        Thread.Sleep(1000);
                    }

                    // Limpando Interface

                    Ferramentas.Limpa_Interface();

                    // Encerrando som da ligação (Desconhecido)

                    Soundtrack2.Player.Stop();
                    Soundtrack0.Player.Play();
                    break;
                case 6:
                    // Tocando áudio de ligação (Atendida)

                    Soundtrack0.Player.Pause();
                    Soundtrack2.Player.Init(Soundtrack2.Leitor);
                    Soundtrack2.Player.Play();

                    // Desenho do telefone com a chamada online

                    Ferramentas.ImagemASCII("\n" +
                        "           ┌══════════════════════════┐\n" +
                        "           │           o ═══          │\n" +
                        "           │ ┌──────────────────────┐ │\n" +
                        "           │ │                20:52 │ │\n" +
                        "           │ ├──────────────────────┤ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │        .'¯¯¯'.       │ │\n" +
                        "           │ │        |  ♥  |       │ │\n" +
                        "           │ │        '.___.'       │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │     Sofia Filha ♥    │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ │                      │ │\n" +
                        "           │ └──────────────────────┘ │\n" +
                        "           │             O            │\n" +
                        "           └══════════════════════════┘");

                    for (int i = 0; i < 10; i++)
                    {
                        Console.SetCursorPosition(25, 10);
                        Console.Write(new string($"00:{i:00}"));
                        Thread.Sleep(1000);
                    }

                    // Limpando Interface

                    Ferramentas.Limpa_Interface();

                    // Encerrando som da ligação (Desconhecido)

                    Soundtrack2.Player.Stop();
                    Soundtrack0.Player.Play();
                    break;
            }
        }
        public static void Contatos(int n_contato) // OK
        {
            switch (n_contato)
            {
                case 0:
                    Ligação(0, 2);
                    Ligação_atendida(0);
                    break;
                case 1:
                    Ligação(1, 1);
                    Ligação_atendida(1);
                    break;
                case 2:
                    Ligação(2, 1);
                    Ligação_atendida(2);
                    break;
                case 3:
                    Ligação(3, 3);
                    Ligação_atendida(3);
                    break;
                case 4:
                    Ligação(4, 2);
                    Ligação_atendida(4);
                    break;
                case 5:
                    Ligação(5, 4);
                    Ligação_atendida(5);
                    break;
                case 6:
                    Ligação(6, 1);
                    Ligação_atendida(6);
                    break;
            }
        }
        
        public static void Mensagens() // CONTINUAR
        {
            Ferramentas.Limpa_Interface();

            Ferramentas.Escrever("BirdChat ");
        }
    }

    public class Configurações
    {
        public static class Tela
        {
            // Configuração para maximizar janela

            [DllImport("kernel32.dll", ExactSpelling = true)]
            private static extern IntPtr GetConsoleWindow();
            private static IntPtr ThisCon = GetConsoleWindow();

            [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

            private const int HIDE = 0;
            private const int MAXIMIZE = 3;
            private const int MINIMIZE = 6;
            private const int RESTORE = 9;

            public static void Tela_default()
            {
                // Maximizando janela

                ShowWindow(ThisCon, MAXIMIZE);

                System.Console.WindowWidth = Console.LargestWindowWidth;
                System.Console.WindowHeight = Console.LargestWindowHeight;
                System.Console.BufferWidth = Console.LargestWindowWidth;
                System.Console.BufferHeight = Console.LargestWindowHeight;
            }
        }

        public static class Fonte
        {
            private const int FixedWidthTrueType = 54;
            private const int StandardOutputHandle = -11;

            [DllImport("kernel32.dll", SetLastError = true)]
            internal static extern IntPtr GetStdHandle(int nStdHandle);

            [return: MarshalAs(UnmanagedType.Bool)]
            [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
            internal static extern bool SetCurrentConsoleFontEx(IntPtr hConsoleOutput, bool MaximumWindow, ref FontInfo ConsoleCurrentFontEx);

            [return: MarshalAs(UnmanagedType.Bool)]
            [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
            internal static extern bool GetCurrentConsoleFontEx(IntPtr hConsoleOutput, bool MaximumWindow, ref FontInfo ConsoleCurrentFontEx);

            private static readonly IntPtr ConsoleOutputHandle = GetStdHandle(StandardOutputHandle);

            [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
            public struct FontInfo
            {
                internal int cbSize;
                internal int FontIndex;
                internal short FontWidth;
                public short FontSize;
                public int FontFamily;
                public int FontWeight;
                [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
                //[MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.wc, SizeConst = 32)]
                public string FontName;
            }

            public static FontInfo[] SetCurrentFont(string font, short fontSize = 0)
            {
                FontInfo before = new FontInfo
                {
                    cbSize = Marshal.SizeOf<FontInfo>()
                };

                if (GetCurrentConsoleFontEx(ConsoleOutputHandle, false, ref before))
                {

                    FontInfo set = new FontInfo
                    {
                        cbSize = Marshal.SizeOf<FontInfo>(),
                        FontIndex = 0,
                        FontFamily = FixedWidthTrueType,
                        FontName = font,
                        FontWeight = 400,
                        FontSize = fontSize > 0 ? fontSize : before.FontSize
                    };

                    // Get some settings from current font.
                    if (!SetCurrentConsoleFontEx(ConsoleOutputHandle, false, ref set))
                    {
                        var ex = Marshal.GetLastWin32Error();
                        Console.WriteLine("Set error " + ex);
                        throw new System.ComponentModel.Win32Exception(ex);
                    }

                    FontInfo after = new FontInfo
                    {
                        cbSize = Marshal.SizeOf<FontInfo>()
                    };
                    GetCurrentConsoleFontEx(ConsoleOutputHandle, false, ref after);

                    return new[] { before, set, after };
                }
                else
                {
                    var er = Marshal.GetLastWin32Error();
                    Console.WriteLine("Get error " + er);
                    throw new System.ComponentModel.Win32Exception(er);
                }
            }
        }
    }
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
    public class Banco_de_Dados
    {
        public static void Criar_Novo()
        {
            string temp, connectionString, createTableQuery, insertQuery;

            // Criação do banco

            temp = Directory.GetCurrentDirectory();
            Directory.CreateDirectory($@"{temp}\Database");
            SQLiteConnection.CreateFile($@"{temp}\Database\umdianegro.db"); // Cria o arquivo do banco de dados

            // Criação de tabelas

            connectionString = $"Data Source=Database\\umdianegro.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                createTableQuery = @"
            CREATE TABLE IF NOT EXISTS elemento_historia (
                elemento_historia_id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                elemento_historia_nome TEXT NOT NULL,
                elemento_historia_ocorreu BOOL,
                elemento_historia_int INT
            );
            
            CREATE TABLE IF NOT EXISTS item (
                item_id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                item_nome TEXT NOT NULL,
                item_coletado BOOL NOT NULL
            );";

                using (SQLiteCommand command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }

            // INSERTS

            connectionString = $"Data Source=Database\\umdianegro.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // INSERT  elemento_historia

                insertQuery = "INSERT INTO elemento_historia (elemento_historia_nome, elemento_historia_ocorreu, elemento_historia_int) VALUES (@nome, @bool, @int);";

                using (SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@nome", "atender_desconhecido");
                    insertCommand.Parameters.AddWithValue("@bool", false);
                    insertCommand.Parameters.AddWithValue("@int", 0);
                    insertCommand.ExecuteNonQuery();
                    insertCommand.Parameters.Clear();

                    insertCommand.Parameters.AddWithValue("@nome", "cofre_aberto");
                    insertCommand.Parameters.AddWithValue("@bool", false);
                    insertCommand.Parameters.AddWithValue("@int", 0);
                    insertCommand.ExecuteNonQuery();
                    insertCommand.Parameters.Clear();

                    insertCommand.Parameters.AddWithValue("@nome", "mensagens_nao_respondidas");
                    insertCommand.Parameters.AddWithValue("@bool", false);
                    insertCommand.Parameters.AddWithValue("@int", 9);
                    insertCommand.ExecuteNonQuery();
                    insertCommand.Parameters.Clear();
                }

                // INSERT  item

                insertQuery = "INSERT INTO item (item_nome, item_coletado) VALUES (@nome, @bool);";

                using (SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@nome", "cabo_tv");
                    insertCommand.Parameters.AddWithValue("@bool", false);
                    insertCommand.ExecuteNonQuery();
                    insertCommand.Parameters.Clear();

                    insertCommand.Parameters.AddWithValue("@nome", "chave_escritorio");
                    insertCommand.Parameters.AddWithValue("@bool", false);
                    insertCommand.ExecuteNonQuery();
                    insertCommand.Parameters.Clear();
                }

                connection.Close();
            }
        }

        public static class Coletar_item
        {
            public static void Cabo_TV(bool valor)
            {
                string connectionString = $"Data Source=Database\\umdianegro.db;Version=3;";

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string updateQuery = "UPDATE item SET item_coletado = @bool WHERE item_nome = @nome;";

                    using (SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@nome", "cabo_tv");
                        updateCommand.Parameters.AddWithValue("@bool", valor);
                        updateCommand.ExecuteNonQuery();
                    }

                    connection.Close();
                }
            }
            public static void Chave_Escritório(bool valor)
            {
                string connectionString = $"Data Source=Database\\umdianegro.db;Version=3;";

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string updateQuery = "UPDATE item SET item_coletado = @bool WHERE item_nome = @nome;";

                    using (SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@nome", "chave_escritorio");
                        updateCommand.Parameters.AddWithValue("@bool", valor);
                        updateCommand.ExecuteNonQuery();
                    }

                    connection.Close();
                }
            }
        }

        public static class Alterar_Progresso_da_História
        {
            public static void Atender_Desconhecido()
            {
                string connectionString = $"Data Source=Database\\umdianegro.db;Version=3;";

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string updateQuery = "UPDATE elemento_historia SET elemento_historia_ocorreu = @bool WHERE elemento_historia_nome = @nome;";

                    using (SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@nome", "atender_desconhecido");
                        updateCommand.Parameters.AddWithValue("@bool", true);
                        updateCommand.ExecuteNonQuery();
                    }

                    connection.Close();
                }
            }
            public static void Abrir_Cofre()
            {
                string connectionString = $"Data Source=Database\\umdianegro.db;Version=3;";

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string updateQuery = "UPDATE elemento_historia SET elemento_historia_ocorreu = @bool WHERE elemento_historia_nome = @nome;";

                    using (SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@nome", "cofre_aberto");
                        updateCommand.Parameters.AddWithValue("@bool", true);
                        updateCommand.ExecuteNonQuery();
                    }

                    connection.Close();
                }
            }
            public static void num_Mensagens_Não_Respondidas(int n_adicionar = 0, int n_subtrair = 0)
            {
                string connectionString = $"Data Source=Database\\umdianegro.db;Version=3;";

                int n_msg = 0;

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT elemento_historia_int FROM elemento_historia WHERE elemento_historia_nome = \"mensagens_nao_respondidas\";";

                    using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                n_msg = reader.GetInt16(3);
                            }
                        }
                    }

                    n_msg += n_adicionar;
                    n_msg -= n_subtrair;

                    string updateQuery = "UPDATE elemento_historia_int SET elemento_historia_int = @int WHERE elemento_historia_nome = @nome;";

                    using (SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@nome", "mensagens_nao_respondidas");
                        updateCommand.Parameters.AddWithValue("@int", n_msg);
                        updateCommand.ExecuteNonQuery();
                    }

                    connection.Close();
                }
            }
        }

        public static class Ler_Progresso_Da_História
        {
            public static int num_Mensagens_Não_Respondidas()
            {
                string connectionString = $"Data Source=Database\\umdianegro.db;Version=3;";
                int n_msg = 0;

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT elemento_historia_int FROM elemento_historia WHERE elemento_historia_nome = \"mensagens_nao_respondidas\";";

                    using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                n_msg = reader.GetInt32(0);
                            }
                        }
                    }

                    connection.Close();
                }
                return n_msg;
            }
            public static bool Cabo_TV()
            {
                string connectionString = $"Data Source=Database\\umdianegro.db;Version=3;";
                bool temp = false;

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT item_coletado FROM item WHERE item_nome = \"cabo_tv\";";

                    using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                temp = reader.GetBoolean(0);
                            }
                        }
                    }
                    connection.Close();
                }
                return temp;
            }
            public static bool Chave_Escritorio()
            {
                string connectionString = $"Data Source=Database\\umdianegro.db;Version=3;";
                bool temp = false;

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT item_coletado FROM item WHERE item_nome = \"chave_escritorio\";";

                    using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                temp = reader.GetBoolean(0);
                            }
                        }
                    }
                    connection.Close();
                }
                return temp;
            }
            public static bool Cofre_Aberto()
            {
                string connectionString = $"Data Source=Database\\umdianegro.db;Version=3;";
                bool temp = false;

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT elemento_historia_ocorreu FROM elemento_historia WHERE elemento_historia_nome = \"cofre_aberto\";";

                    using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                temp = reader.GetBoolean(0);
                            }
                        }
                    }
                    connection.Close();
                }

                return temp;
            }
            public static bool Atender_Desconhecido()
            {
                string connectionString = $"Data Source=Database\\umdianegro.db;Version=3;";
                bool temp = false;

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT elemento_historia_ocorreu FROM elemento_historia WHERE elemento_historia_nome = \"atender_desconhecido\";";

                    using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                temp = reader.GetBoolean(0);
                            }
                        }
                    }
                    connection.Close();
                }

                return temp;
            }
        }
    }
}
