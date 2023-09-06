﻿using NAudio.Wave;
using static Projeto_rpg.ControleMúsica;

namespace Projeto_rpg
{
    public class História // Continuar
    {
        public static void VerTV() // NÃO OK (Continuar)
        {
            if (Banco_de_Dados.Ler_Progresso_Da_História.Cabo_TV() && Banco_de_Dados.Ler_Progresso_Da_História.Chave_Escritorio()) // Continuar
            {
                Ferramentas.Limpa_Interface();
                Ferramentas.Escrever("");
            }
            else // OK
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
                                Quarto();
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
        public static void Telefone() // OK
        {
            Ferramentas.Limpa_Interface();
            if (Banco_de_Dados.Ler_Progresso_Da_História.Atender_Desconhecido())
            {
            Telefone:

                Ferramentas.Limpa_Interface();
                if (Banco_de_Dados.Ler_num_Mensagens.Todas_Não_Respondidas() == 0)
                {
                    Ferramentas.Escrever("Você pega o celular e checa as notificações." +
                "\n\nNão há novas notificações." +
                "\n\nO que deseja fazer?" +
                "\n\n[1] Checar mensagens" +
                "\n[2] Checar contatos" +
                "\n[3] Checar galeria" +
                "\n[4] Sair", true);
                }
                else
                {
                    Ferramentas.Escrever("Você pega o celular e checa as notificações." +
                $"\n\nHá {Banco_de_Dados.Ler_num_Mensagens.Todas_Não_Respondidas()} mensagens não respondidas." +
                "\n\nO que deseja fazer?" +
                "\n\n[1] Checar mensagens" +
                "\n[2] Checar contatos" +
                "\n[3] Checar galeria" +
                "\n[4] Sair", true);
                }

                switch (Ações.Escolha(4)) // CONTINUAR
                {
                    case 1: // OK
                        Mensagens();
                        goto Telefone;
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
                    case 3: // OK
                        int tempgaleria = 2, tempfoto = 0;

                        Galeria:

                        switch (tempgaleria)
                        {
                            case 1:
                                goto Telefone;
                            case 2:
                                if(tempfoto > 0)
                                {
                                    tempfoto -= 1;
                                }
                                break;
                            case 3:
                                if (tempfoto < 3)
                                {
                                    tempfoto += 1;
                                }
                                break;
                        }

                        Ferramentas.Limpa_Interface();
                        switch (tempfoto)
                        {
                            case 0:
                                Ferramentas.ImagemASCII("" +
                                    "┌───────────────────────────────────────────────────────┐\n" +
                                    "│///////////////////////////////////////////////////////│\n" +
                                    "│////////////__..--''``---....___   _..._    __/////////│\n" +
                                    "│ /// //_.-'    .-/\";  `        ``<._  ``.''_ `. / /////│\n" +
                                    "│///_.-' _..--.'_    \\                    `( ) ) // ////│\n" +
                                    "│/ (_..-' // (< _     ;_..__               ; `' / // ///│\n" +
                                    "│ / // // //  `-._,_)' // / ``--...____..-' /// / //////│\n" +
                                    "│///////////////////////////////////////////////////////│\n" +
                                    "└───────────────────────────────────────────────────────┘\n");
                                Ferramentas.Escrever("\n\n\n\n\n\n\n\n\n\n[1] para SAIR\n" +
                                    "[2] para ANTERIOR\n" +
                                    "[3] para PRÓXIMO", escolha: true, instantâneo: true);
                                tempgaleria = Ações.Escolha(3);
                                goto Galeria;
                            case 1:
                                Ferramentas.ImagemASCII("" +
                                    "┌──────────────────────────────┐\n" +
                                    "│          _   ____  _.-\"-._   │\n" +
                                    "│        .' `;'    ':.      '-.│\n" +
                                    "│       /  ./     .'`\\`-...-'` │\n" +
                                    "│      /  /|D_  .O    |        │\n" +
                                    "│     /  / |=\\/`=     |        │\n" +
                                    "│    |_.'  |  |       |        │\n" +
                                    "│           \\  \\   _ /_        │\n" +
                                    "│           /`---'}_()_{       │\n" +
                                    "│          /`'---' //\\\\\\       │\n" +
                                    "│         /;      (/\\ \\)\\      │\n" +
                                    "│        / |         \\   \\     │\n" +
                                    "│       /  |         |   |     │\n" +
                                    "│      /  / .     _ /   /      │\n" +
                                    "│      \\_|   '. .'  '-'|       │\n" +
                                    "│        \\    .-|     /        │\n" +
                                    "│     _.-'   /  |    /         │\n" +
                                    "│    (      /  / .--;          │\n" +
                                    "│     '-.__/   |    /          │\n" +
                                    "│              \\__.            │\n" +
                                    "└──────────────────────────────┘");
                                Ferramentas.Escrever("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n[1] para SAIR\n" +
                                    "[2] para ANTERIOR\n" +
                                    "[3] para PRÓXIMO", escolha: true, instantâneo: true);
                                tempgaleria = Ações.Escolha(3);
                                goto Galeria;
                            case 2:
                                Ferramentas.ImagemASCII("" +
                                    "┌─────────────────────────────────────────────────────────────────────┐\n" +
                                    "│               *    *                                                │\n" +
                                    "│   *         '       *       .  *   '     .           * *            │\n" +
                                    "│                                                               '     │\n" +
                                    "│       *                *'          *          *        '            │\n" +
                                    "│   .           *               |               /                     │\n" +
                                    "│               '.         |    |      '       |   '     *            │\n" +
                                    "│                 \\*        \\   \\             /                       │\n" +
                                    "│       '          \\     '* |    |  *        |*                *  *   │\n" +
                                    "│            *      `.       \\   |     *     /    *      '            │\n" +
                                    "│  .                  \\      |   \\          /               *         │\n" +
                                    "│     *'  *     '      \\      \\   '.       |                          │\n" +
                                    "│        -._            `                  /         *                │\n" +
                                    "│  ' '      ``._   *                           '          .      '    │\n" +
                                    "│   *           *\\*          * .   .      *                           │\n" +
                                    "│*  '        *    `-._                       .         _..:='        *│\n" +
                                    "│             .  '      *       *    *   .       _.:--'               │\n" +
                                    "│          *           .     .     *         .-'         *            │\n" +
                                    "│   .               '             . '   *           *         .       │\n" +
                                    "│  *       ___.-=--..-._     *                '               '       │\n" +
                                    "│                                  *       *                          │\n" +
                                    "│                *        _.'  .'       `.        '  *             *  │\n" +
                                    "│     *              *_.-'   .'            `.               *         │\n" +
                                    "│                   .'                       `._             *  '     │\n" +
                                    "│   '       '                        .       .  `.     .              │\n" +
                                    "│       .                      *                  `                   │\n" +
                                    "│               *        '             '                          .   │\n" +
                                    "│     .                          *        .           *  *            │\n" +
                                    "│             *        .                                    '         │\n" +
                                    "└─────────────────────────────────────────────────────────────────────┘");
                                Ferramentas.Escrever("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n[1] para SAIR\n" +
                                    "[2] para ANTERIOR\n" +
                                    "[3] para PRÓXIMO", escolha: true, instantâneo: true);
                                tempgaleria = Ações.Escolha(3);
                                goto Galeria;
                            case 3:
                                Ferramentas.ImagemASCII("" +
                                    "┌───────────────────────────────────────────────────┐\n" +
                                    "│                       _____                       │\n" +
                                    "│     ^                |_CSP_|                      │\n" +
                                    "│   ^     ^  ^        _|__|__|_           ^   ^     │\n" +
                                    "│     ___________    _|  | |  |_    ___________   ^ │\n" +
                                    "│    (__IXIXIXIXI___|_|__|_|__|_|___IXIXIXIXI__)    │\n" +
                                    "│    (__|\"|\"|\"|\"| [=][=] [=] [=][=] |\"|\"|\"|\"|__)    │\n" +
                                    "│    (__|\"|\"|\"|\"| [=][=] [=] [=][=] |\"|\"|\"|\"|__)    │\n" +
                                    "│    (__|\"|\"|\"|\"| [=][=] [=] [=][=] |\"|\"|\"|\"|__)    │\n" +
                                    "│    (__|\"|\"|\"|\"| [=][=] [=] [=][=] |\"|\"|\"|\"|__)    │\n" +
                                    "│    (__|\"|\"|\"|\"| [=][=] [=] [=][=] |\"|\"|\"|\"|__)    │\n" +
                                    "│  /)(__|\"|\"|\"|\"| [=][=] [=] [=][=] |\"|\"|\"|\"|__)    │\n" +
                                    "│_/ )(__|\"|\"|\"|\"| [=][=] [=] [=][=] |\"|\"|\"|\"|__)_/)_│\n" +
                                    "│ ~^^(__|\"|\"|\"|\"| [=][=] [=] [=][=] |\"|\"|\"|\"|__) ~~^│\n" +
                                    "│^~~ (__|\"|\"|\"|\"| [=][=] [=] [=][=] |\"|\"|\"|\"|__)~~^ │\n" +
                                    "│\"\"\"\"\"IXI~IXI~IXI~IXI~=I=I=I=I=~IXI~IXI~IXI~IXI\"\"\"\"\"│\n" +
                                    "│     \"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"|   |\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"      │\n" +
                                    "└───────────────────────────────────────────────────┘");
                                Ferramentas.Escrever("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n[1] para SAIR\n" +
                                    "[2] para ANTERIOR\n" +
                                    "[3] para PRÓXIMO", escolha: true, instantâneo: true);
                                tempgaleria = Ações.Escolha(3);
                                goto Galeria;
                        }
                        break;
                    case 4: // OK
                        break;
                }
            }
            else //OK 
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
        public static void Quarto() // OK
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
        public static void Ligação_atendida(int n_contato) // NÃO OK (FALTAM ÁUDIOS DIFERENTES, E CORRIGIR FATO DA TRILHA SÓ PODER SER TOCADA UMA VEZ)
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
        public static void Contatos(int n_contato) // OK (COLOCAR VARIÁVEL DE <LIGAÇÃO JÁ FEITA> NO BANCO DE DADOS, E COLOCAR QUE NÃO ATENDE DEPOIS)
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
        public static void Mensagens() // OK
        {
            Mensagens:

            Ferramentas.Limpa_Interface();
            Ferramentas.ImagemASCII("\n" +
                        "           ┌════════════════════════════════┐\n" +
                        "           │               o ═══            │\n" +
                        "           │ ┌────────────────────────────┐ │\n" +
                        "           │ │                      20:52 │ │\n" +
                        "           │ ├────────────────────────────┤ │\n" +
                        "           │ │                    _       │ │\n" +
                        "           │ │                 __(.)<     │ │\n" +
                        "           │ │       BirdChat  \\___)      │ │\n" +
                        "           │ ├────────────────────────────┤ │\n" +
                        "           │ │                            │ │\n" +
                        $"           │ │    • Rafael Brother ({Banco_de_Dados.Ler_num_Mensagens.Rafael_Brother()})     │ │\n" +
                        "           │ │                            │ │\n" +
                        "           │ ├────────────────────────────┤ │\n" +
                        "           │ │                            │ │\n" +
                        $"           │ │    • CSP ({Banco_de_Dados.Ler_num_Mensagens.CSP()})                │ │\n" +
                        "           │ │                            │ │\n" +
                        "           │ ├────────────────────────────┤ │\n" +
                        "           │ │                            │ │\n" +
                        $"           │ │    • Sofia Filha ({Banco_de_Dados.Ler_num_Mensagens.Sofia_Filha()})        │ │\n" +
                        "           │ │                            │ │\n" +
                        "           │ ├────────────────────────────┤ │\n" +
                        "           │ │                            │ │\n" +
                        $"           │ │    • Chefe Bruno ({Banco_de_Dados.Ler_num_Mensagens.Chefe_Bruno()})        │ │\n" +
                        "           │ │                            │ │\n" +
                        "           │ └────────────────────────────┘ │\n" +
                        "           │                 O              │\n" +
                        "           └════════════════════════════════┘\n" +
                        "\n" +
                        "Responder quem?\n\n" +
                        $"[1] Rafael Brother ({Banco_de_Dados.Ler_num_Mensagens.Rafael_Brother()})\n" +
                        $"[2] CSP ({Banco_de_Dados.Ler_num_Mensagens.CSP()})\n" +
                        $"[3] Sofia Filha ({Banco_de_Dados.Ler_num_Mensagens.Sofia_Filha()})\n" +
                        $"[4] Chefe Bruno ({Banco_de_Dados.Ler_num_Mensagens.Chefe_Bruno()})\n" +
                        $"[5] SAIR\n");
            switch (Ações.Escolha(5))
            {
                case 1:

                    if (Banco_de_Dados.Ler_num_Mensagens.Rafael_Brother() != 0)
                    {
                        Banco_de_Dados.Alterar_num_Mensagens.Todas_Não_Respondidas(n_subtrair: Banco_de_Dados.Ler_num_Mensagens.Rafael_Brother());
                        Banco_de_Dados.Alterar_num_Mensagens.Rafael_Brother(n_subtrair: Banco_de_Dados.Ler_num_Mensagens.Rafael_Brother());

                        Ferramentas.Limpa_Interface();
                        Ferramentas.Escrever_Mensagem("\u001b[34m\u001b[1mRafael Brother\u001b[0m: Eae parceiro, como vc tá? Você deu uma " +
                            "sumida nos últimos dias... Fiquei preocupado.");
                        Ferramentas.Escrever_Mensagem("" +
                            "\n\n[1] Tô bem cara, agradeço a preocupação. E tudo bem contigo?" +
                            "\n[2] Você sabe muito bem como eu estou. Não sabe?\n");
                        switch (Ações.Escolha(2))
                        {
                            case 1:
                                Ferramentas.Limpa_Interface();
                                Ferramentas.Escrever_Mensagem("\u001b[34m\u001b[1mRafael Brother\u001b[0m: Eae parceiro, como vc tá? Você deu uma " +
                                    "sumida nos últimos dias... Fiquei preocupado.");
                                Efeitos.Digitando(1);
                                Ferramentas.Escrever_Mensagem("\u001b[1mVocê\u001b[0m: Tô bem cara, agradeço a preocupação. E tudo bem contigo?");
                                Efeitos.Digitando(3);
                                Ferramentas.Escrever_Mensagem("\u001b[34m\u001b[1mRafael Brother\u001b[0m: Que bom, fico feliz por ti." +
                                    "\n\u001b[34m\u001b[1mRafael Brother\u001b[0m: Qualquer coisa, eu...");
                                Efeitos.Digitando(4, false);
                                Ferramentas.Escrever_Mensagem("\u001b[34m\u001b[1mRafael Brother\u001b[0m: Brother, acho que essa pode ser a minha última chance de falar alguma coisa.");
                                Efeitos.Digitando(4, false);
                                Ferramentas.Escrever_Mensagem("\u001b[34m\u001b[1mRafael Brother\u001b[0m: Não sei se vou aguentar por muito tempo, mas é o seguinte... Não se deixa enganar. " +
                                    "Não hesite em matar. Ele vai querer te enganar, assim como fez comigo. E agora estou sofrendo as consequências.");
                                Efeitos.Digitando(4, false);
                                Ferramentas.Escrever_Mensagem("\u001b[34m\u001b[1mRafael Brother\u001b[0m: Adeus, amigo.");
                                Efeitos.Digitando(4, false);
                                Ferramentas.Escrever_Mensagem("\u001b[34m\u001b[1mRafael Brother\u001b[0m: REGENERATUS CIBUS");
                                Efeitos.Digitando(5, false);
                                Ferramentas.Escrever_Mensagem("\u001b[34m\u001b[1mRafael Brother\u001b[0m: CONSCIENTIA COMMUNIS");
                                Efeitos.Digitando(3, false);
                                Ferramentas.Escrever_Mensagem("\u001b[34m\u001b[1mRafael Brother\u001b[0m: INTRA CAPUT TUUM");
                                Efeitos.Digitando(7, false);
                                Ferramentas.Escrever_Mensagem("\u001b[34m\u001b[1mRafael Brother\u001b[0m: NON VERUS NON VERUS NON VERUS NON VERUS NON VERUS");
                                Ferramentas.Escrever_Mensagem("" +
                                    "\n\n[1] Negar" +
                                    "\n[2] Negar\n");
                                Ações.Escolha(2);

                                Ferramentas.Limpa_Interface();
                                Ferramentas.Escrever("O aplicativo parou de funcionar. É preciso abrir novamente.");
                                break;
                            case 2:
                                Ferramentas.Limpa_Interface();
                                Ferramentas.Escrever_Mensagem("\u001b[34m\u001b[1mRafael Brother\u001b[0m: Eae parceiro, como vc tá? Você deu uma " +
                                    "sumida nos últimos dias... Fiquei preocupado.");
                                Efeitos.Digitando(1);
                                Ferramentas.Escrever_Mensagem("\u001b[1mVocê\u001b[0m: Você sabe muito bem como eu estou. Não sabe?");
                                Efeitos.Digitando(7);
                                Ferramentas.Escrever_Mensagem("\u001b[34m\u001b[1mRafael Brother\u001b[0m: É, eu sei... Eu sinto muito pela sua filha cara, as coisas " +
                                    "não eram pra terminarem assim. A gente sabia disso. Foi um acidente, ninguém tem culpa. Muito menos você!");
                                Ferramentas.Escrever_Mensagem("" +
                                    "\n\n[1] Ela NÃO morreu. Eu sei disso." +
                                    "\n[2] A culpa é toda minha...\n");

                                switch (Ações.Escolha(2))
                                {
                                    case 1:
                                        Ferramentas.Limpa_Interface();
                                        Ferramentas.Escrever_Mensagem("\u001b[34m\u001b[1mRafael Brother\u001b[0m: Eae parceiro, como vc tá? Você deu uma " +
                                            "sumida nos últimos dias... Fiquei preocupado.");
                                        Ferramentas.Escrever_Mensagem("\n\n\u001b[1mVocê\u001b[0m: Você sabe muito bem como eu estou. Não sabe?");
                                        Ferramentas.Escrever_Mensagem("\n\n\u001b[34m\u001b[1mRafael Brother\u001b[0m: É, eu sei... Eu sinto muito pela sua filha cara, as coisas" +
                                            "não eram pra terminarem assim. A gente sabia disso. Foi um acidente, ninguém tem culpa. Muito menos você!");
                                        Efeitos.Digitando(3);
                                        Ferramentas.Escrever_Mensagem("\u001b[1mVocê\u001b[0m: Ela NÃO morreu. Eu sei disso.");
                                        Efeitos.Digitando(5);
                                        Ferramentas.Escrever_Mensagem("\u001b[34m\u001b[1mRafael Brother\u001b[0m: Foi mal, mas você sabe que aquela ##### pegou ela. E sabemos muito bem do que aquilo é capaz de fazer... " +
                                            "Se ela não morreu, então provavelmente não é mais a mesma.");
                                        Efeitos.Digitando(5);
                                        Ferramentas.Escrever_Mensagem("\u001b[31m\u001b[1m???\u001b[0m: NÃO ME MENCIONE");
                                        Thread.Sleep(2000);
                                        Ferramentas.Escrever_Mensagem("\n\u001b[31m\u001b[1m???\u001b[0m: NÃO ME MENCIONE");
                                        Thread.Sleep(2000);
                                        Ferramentas.Escrever_Mensagem("\n\u001b[31m\u001b[1m???\u001b[0m: NÃO ME MENCIONE");
                                        Thread.Sleep(2000);

                                        Ferramentas.Limpa_Interface();
                                        Ferramentas.Escrever("O aplicativo parou de funcionar. É preciso abrir novamente.");
                                        break;
                                    case 2:
                                        Ferramentas.Limpa_Interface();
                                        Ferramentas.Escrever_Mensagem("\u001b[34m\u001b[1mRafael Brother\u001b[0m: Eae parceiro, como vc tá? Você deu uma " +
                                            "sumida nos últimos dias... Fiquei preocupado.");
                                        Ferramentas.Escrever_Mensagem("\n\n\u001b[1mVocê\u001b[0m: Você sabe muito bem como eu estou. Não sabe?");
                                        Ferramentas.Escrever_Mensagem("\n\n\u001b[34m\u001b[1mRafael Brother\u001b[0m: É, eu sei... Eu sinto muito pela sua filha cara, as coisas" +
                                            "não eram pra terminarem assim. A gente sabia disso. Foi um acidente, ninguém tem culpa. Muito menos você!");
                                        Efeitos.Digitando(3);
                                        Ferramentas.Escrever_Mensagem("\u001b[1mVocê\u001b[0m: A culpa é toda minha.");
                                        Efeitos.Digitando(5);
                                        Ferramentas.Escrever_Mensagem("\u001b[34m\u001b[1mRafael Brother\u001b[0m: Não é não, você sabe disso. A CSP tem grande parte nisso. " +
                                            "Se eles tivessem dado ouvidos à todas as suas suas recomendações de segurança, isso não teria acontecido...");
                                        Efeitos.Digitando(3, false);
                                        Ferramentas.Escrever_Mensagem("\u001b[34m\u001b[1mRafael Brother\u001b[0m: E agora, quem paga o preço? A gente.");
                                        Efeitos.Digitando(5, false);
                                        Ferramentas.Escrever_Mensagem("\u001b[34m\u001b[1mRafael Brother\u001b[0m: Aí, o celular tá descarregando. Depois eu volto. Mas fica " +
                                            "melhor, viu? Alguma hora vou aí te visitar.");
                                        Ferramentas.Escrever_Mensagem("\n\n[1] Okks\n");
                                        Ações.Escolha(1);
                                        goto Mensagens;
                                }
                                break;
                        }
                    }
                    else
                    {
                        Ferramentas.Limpa_Interface();
                        Ferramentas.Escrever("Todas as mensagens de \"Rafael Brother\" já foram lidas.");
                        goto Mensagens;
                    }
                    break;
                case 2:

                    Ferramentas.Limpa_Interface();

                    if (Banco_de_Dados.Ler_num_Mensagens.CSP() != 0)
                    {
                        Banco_de_Dados.Alterar_num_Mensagens.Todas_Não_Respondidas(n_subtrair: Banco_de_Dados.Ler_num_Mensagens.CSP());
                        Banco_de_Dados.Alterar_num_Mensagens.CSP(n_subtrair: Banco_de_Dados.Ler_num_Mensagens.CSP());

                        Ferramentas.Escrever_Mensagem("\u001b[35m\u001b[1mCSP\u001b[0m: Este é um aviso programado da Cientific Solutions for Pandemics.\n" +
                            "\u001b[35m\u001b[1mCSP\u001b[0m: Pedimos que permaneça em silêncio judicial. Você será justificado por todo o ocorrido, e esperamos " +
                            "que os assuntos extraoficiais possam ser resolvidos o mais rápido possível para a manifestação da sua indenização.");
                        Ferramentas.Escrever_Mensagem("\n\n[1] Ok\n");
                        Ações.Escolha(1);
                    }
                    else
                    {
                        Ferramentas.Escrever("Todas as mensagens de \"CSP\" já foram lidas.");
                    }
                    goto Mensagens;
                case 3:
                    Ferramentas.Limpa_Interface();

                    if (Banco_de_Dados.Ler_num_Mensagens.Sofia_Filha() != 0)
                    {
                        Banco_de_Dados.Alterar_num_Mensagens.Todas_Não_Respondidas(n_subtrair: Banco_de_Dados.Ler_num_Mensagens.Sofia_Filha());
                        Banco_de_Dados.Alterar_num_Mensagens.Sofia_Filha(n_subtrair: Banco_de_Dados.Ler_num_Mensagens.Sofia_Filha());

                        Ferramentas.Limpa_Interface();
                        Ferramentas.Escrever_Mensagem("\u001b[31m\u001b[1mSofia Filha\u001b[0m: Pai?");
                        Ferramentas.Escrever_Mensagem("\n\n[1] FILHA?????? VOCÊ ESTÁ BEM????\n");
                        Ações.Escolha(1);

                        Ferramentas.Limpa_Interface();
                        Ferramentas.Escrever_Mensagem("\u001b[31m\u001b[1mSofia Filha\u001b[0m: Pai?");
                        Efeitos.Digitando(2);
                        Ferramentas.Escrever_Mensagem("\u001b[1mVocê\u001b[0m: FILHA?????? VOCÊ ESTÁ BEM????");
                        Efeitos.Digitando(6);
                        Ferramentas.Escrever_Mensagem("\u001b[31m\u001b[1mSofia Filha\u001b[0m: Ele quer resolver as coisas com você pessoalmente. " +
                            "Venha para o laboratório.");
                        Ferramentas.Escrever_Mensagem("" +
                            "\n\n[1] Quem?? O laboratório foi fechado depois do acidente. E por que você está aí?" +
                            "\n[2] Para de falar besteiras filha! Você sumiu faz 3 dias sem deixar rastros... Por favor volta pra casa!\n");
                        switch (Ações.Escolha(2))
                        {
                            case 1:
                                Ferramentas.Limpa_Interface();
                                Ferramentas.Escrever_Mensagem("\u001b[31m\u001b[1mSofia Filha\u001b[0m: Pai?");
                                Ferramentas.Escrever_Mensagem("\n\n\u001b[1mVocê\u001b[0m: FILHA?????? VOCÊ ESTÁ BEM????");
                                Ferramentas.Escrever_Mensagem("\n\n\u001b[31m\u001b[1mSofia Filha\u001b[0m: Ele quer resolver as coisas com você pessoalmente. " +
                                    "Venha para o laboratório.");
                                Efeitos.Digitando(4);
                                Ferramentas.Escrever_Mensagem("\u001b[1mVocê\u001b[0m: Quem?? O laboratório foi fechado depois do acidente. E por que você está aí?");
                                Efeitos.Digitando(6);
                                Ferramentas.Escrever_Mensagem("\u001b[31m\u001b[1mSofia Filha\u001b[0m: \u001b[31mVocê sabe muito bem quem.\u001b[0m");
                                Efeitos.Digitando(5);

                                Ferramentas.Limpa_Interface();
                                Ferramentas.Escrever("O aplicativo parou de funcionar. É preciso abrir novamente.");
                                break;
                            case 2:
                                Ferramentas.Limpa_Interface();
                                Ferramentas.Escrever_Mensagem("\u001b[31m\u001b[1mSofia Filha\u001b[0m: Pai?");
                                Ferramentas.Escrever_Mensagem("\n\n\u001b[1mVocê\u001b[0m: FILHA?????? VOCÊ ESTÁ BEM????");
                                Ferramentas.Escrever_Mensagem("\n\n\u001b[31m\u001b[1mSofia Filha\u001b[0m: Ele quer resolver as coisas com você pessoalmente. " +
                                    "Venha para o laboratório.");
                                Efeitos.Digitando(4);
                                Ferramentas.Escrever_Mensagem("\u001b[1mVocê\u001b[0m: Para de falar besteiras filha! Você sumiu faz 3 dias sem deixar rastros... Por favor volta pra casa!");
                                Efeitos.Digitando(6);
                                Ferramentas.Escrever_Mensagem("\u001b[31m\u001b[1mSofia Filha\u001b[0m: \u001b[31mApenas venha.\u001b[0m");
                                Efeitos.Digitando(5);

                                Ferramentas.Limpa_Interface();
                                Ferramentas.Escrever("O aplicativo parou de funcionar. É preciso abrir novamente.");
                                break;
                        }
                    }
                    else
                    {
                        Ferramentas.Limpa_Interface();
                        Ferramentas.Escrever("Todas as mensagens de \"Sofia Filha\" já foram lidas.");
                        goto Mensagens;
                    }
                    break;         
                case 4:
                    if(Banco_de_Dados.Ler_num_Mensagens.Chefe_Bruno() != 0)
                    {
                        Banco_de_Dados.Alterar_num_Mensagens.Todas_Não_Respondidas(n_subtrair: Banco_de_Dados.Ler_num_Mensagens.Chefe_Bruno());
                        Banco_de_Dados.Alterar_num_Mensagens.Chefe_Bruno(n_subtrair: Banco_de_Dados.Ler_num_Mensagens.Chefe_Bruno());                        

                        Ferramentas.Limpa_Interface();
                        Ferramentas.Escrever_Mensagem("\u001b[32m\u001b[1mChefe Bruno\u001b[0m: Olá, bom dia. Lamento o ocorrido dos últimos dias...\n" +
                            "\u001b[32m\u001b[1mChefe Bruno\u001b[0m: Quero pedir somente que me envie, até a semana que vem, aquele aquele relatório do mês de agosto " +
                            "de 2022 que entreguei a você, para finalizar uma papelada, se possível.");
                        Ferramentas.Escrever_Mensagem("" +
                            "\n\n[1] Ok, chefe." +
                            "\n[2] Não estou bem pra trabalhar por agora, Bruno... Preciso de um tempo.\n");

                        switch (Ações.Escolha(2))
                        {
                            case 1:
                                Ferramentas.Limpa_Interface();
                                Ferramentas.Escrever_Mensagem("\u001b[32m\u001b[1mChefe Bruno\u001b[0m: Olá, bom dia. Lamento o ocorrido dos últimos dias...\n" +
                                    "\u001b[32m\u001b[1mChefe Bruno\u001b[0m: Quero pedir somente que me envie, até a semana que vem, aquele relatório do mês de agosto " +
                                    "de 2022 que entreguei a você, para finalizar uma papelada, se possível.");
                                Efeitos.Digitando(4);
                                Ferramentas.Escrever_Mensagem("\u001b[1mVocê\u001b[0m: Ok, chefe.");
                                Efeitos.Digitando(6);
                                Ferramentas.Escrever_Mensagem("\u001b[32m\u001b[1mChefe Bruno\u001b[0m: E espero que a sua situação se resolva logo. Abraços.");
                                Ferramentas.Escrever_Mensagem("" +
                                    "\n\n[1] Obrigado..." +
                                    "\n[2] Sim...");
                                Ações.Escolha(2);
                                goto Mensagens;
                            case 2:
                                Ferramentas.Limpa_Interface();
                                Ferramentas.Escrever_Mensagem("\u001b[32m\u001b[1mChefe Bruno\u001b[0m: Olá, bom dia. Lamento o ocorrido dos últimos dias...\n" +
                                    "\u001b[32m\u001b[1mChefe Bruno\u001b[0m: Quero pedir somente que me envie, até a semana que vem, aquele relatório do mês de agosto" +
                                    "de 2022 que entreguei a você, para finalizar uma papelada, se possível.");
                                Efeitos.Digitando(4);
                                Ferramentas.Escrever_Mensagem("\u001b[1mVocê\u001b[0m: Não estou bem pra trabalhar por agora, Bruno... Preciso de um tempo.");
                                Efeitos.Digitando(4);
                                Ferramentas.Escrever_Mensagem("\u001b[32m\u001b[1mChefe Bruno\u001b[0m: Ah, sim, entendo...");
                                Efeitos.Digitando(10, false);
                                Ferramentas.Escrever_Mensagem("\u001b[32m\u001b[1mChefe Bruno\u001b[0m: Bom, acho que esse relatório pode esperar mais umas 2 semanas.");
                                Efeitos.Digitando(10, false);
                                Ferramentas.Escrever_Mensagem("\u001b[32m\u001b[1mChefe Bruno\u001b[0m: Abraços.");
                                Ferramentas.Escrever_Mensagem("" +
                                    "\n\n[1] Obrigado..." +
                                    "\n[2] Agradeço...");
                                Ações.Escolha(2);
                                goto Mensagens;
                        }
                    }
                    else
                    {
                        Ferramentas.Limpa_Interface();
                        Ferramentas.Escrever("Todas as mensagens de \"Chefe Bruno\" já foram lidas.");
                        goto Mensagens;
                    }

                    break;
                case 5:
                    break;
            }
           
        }
    }
}