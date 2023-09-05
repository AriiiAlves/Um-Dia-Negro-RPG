using NAudio.Wave;
using static Projeto_rpg.ControleMúsica;

namespace Projeto_rpg
{
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
            if (Banco_de_Dados.Ler_Progresso_Da_História.Atender_Desconhecido())
            {
            Telefone:

                Ferramentas.Limpa_Interface();
                if (Banco_de_Dados.Ler_Progresso_Da_História.num_Mensagens_Não_Respondidas() == 0)
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
                        Ferramentas.Escrever($"Há {Banco_de_Dados.Ler_Progresso_Da_História.num_Mensagens_Não_Respondidas() == 0} mensagens não respondidas\n\n" +
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
                            Banco_de_Dados.Alterar_Progresso_da_História.Atender_Desconhecido(true);
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
                            Banco_de_Dados.Alterar_Progresso_da_História.Atender_Desconhecido(true);
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
                        if (Banco_de_Dados.Ler_Progresso_Da_História.Cofre_Aberto())
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
                                        Ferramentas.Escrever("Digite SAIR para sair.\n\nSenha: ", escolha: true, instantâneo: true);
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
                                            Banco_de_Dados.Alterar_Progresso_da_História.Abrir_Cofre(true);
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
                                if (Banco_de_Dados.Ler_Progresso_Da_História.Cabo_TV() && Banco_de_Dados.Ler_Progresso_Da_História.Chave_Escritorio())
                                {
                                    Ferramentas.Escrever("Não há nada aqui.");
                                }
                                else
                                {
                                    Ferramentas.Escrever("As gavetas guardavam um cabo de energia e uma chave. Você coletou os 2 itens.");
                                    Banco_de_Dados.Coletar_item.Cabo_TV(true);
                                    Banco_de_Dados.Coletar_item.Chave_Escritório(true);
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
}
