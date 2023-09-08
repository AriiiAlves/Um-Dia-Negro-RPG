using System.Data.SQLite;

namespace Projeto_rpg
{
    public class Banco_de_Dados // OK, adicionar mais campos se precisar
    {
        private static void Criar_Banco_de_Dados()
        {
            string temp = Directory.GetCurrentDirectory();

            Directory.CreateDirectory($@"{temp}\Database");
            SQLiteConnection.CreateFile($@"{temp}\Database\umdianegro.db"); // Cria o arquivo do banco de dados
        }
        private static void Criar_Tabelas()
        {
            string connectionString = $"Data Source=Database\\umdianegro.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string createTableQuery = @"
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
            );

            CREATE TABLE IF NOT EXISTS mensagem (
                mensagem_id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                mensagem_nome TEXT NOT NULL,
                mensagem_quantidade INT NOT NULL
            );";

                using (SQLiteCommand command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }
        private static void Fazer_Inserts()
        {
            // INSERTS

            string connectionString = $"Data Source=Database\\umdianegro.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // INSERT  elemento_historia

                string insertQuery = "INSERT INTO elemento_historia (elemento_historia_nome, elemento_historia_ocorreu, elemento_historia_int) VALUES (@nome, @bool, @int);";

                using (SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@nome", "Atender Desconhecido");
                    insertCommand.Parameters.AddWithValue("@bool", false);
                    insertCommand.Parameters.AddWithValue("@int", 0);
                    insertCommand.ExecuteNonQuery();
                    insertCommand.Parameters.Clear();

                    insertCommand.Parameters.AddWithValue("@nome", "Cofre Aberto");
                    insertCommand.Parameters.AddWithValue("@bool", false);
                    insertCommand.Parameters.AddWithValue("@int", 0);
                    insertCommand.ExecuteNonQuery();
                    insertCommand.Parameters.Clear();

                    insertCommand.Parameters.AddWithValue("@nome", "Memórias");
                    insertCommand.Parameters.AddWithValue("@bool", false);
                    insertCommand.Parameters.AddWithValue("@int", 0);
                    insertCommand.ExecuteNonQuery();
                    insertCommand.Parameters.Clear();

                    insertCommand.Parameters.AddWithValue("@nome", "Parte 1 História");
                    insertCommand.Parameters.AddWithValue("@bool", false);
                    insertCommand.Parameters.AddWithValue("@int", 0);
                    insertCommand.ExecuteNonQuery();
                    insertCommand.Parameters.Clear();
                }

                // INSERT  item

                insertQuery = "INSERT INTO item (item_nome, item_coletado) VALUES (@nome, @bool);";

                using (SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@nome", "Cabo TV");
                    insertCommand.Parameters.AddWithValue("@bool", false);
                    insertCommand.ExecuteNonQuery();
                    insertCommand.Parameters.Clear();

                    insertCommand.Parameters.AddWithValue("@nome", "Chave Escritorio");
                    insertCommand.Parameters.AddWithValue("@bool", false);
                    insertCommand.ExecuteNonQuery();
                    insertCommand.Parameters.Clear();

                    insertCommand.Parameters.AddWithValue("@nome", "Chave Porta");
                    insertCommand.Parameters.AddWithValue("@bool", false);
                    insertCommand.ExecuteNonQuery();
                    insertCommand.Parameters.Clear();

                    insertCommand.Parameters.AddWithValue("@nome", "Isqueiro");
                    insertCommand.Parameters.AddWithValue("@bool", false);
                    insertCommand.ExecuteNonQuery();
                    insertCommand.Parameters.Clear();

                    insertCommand.Parameters.AddWithValue("@nome", "Faca");
                    insertCommand.Parameters.AddWithValue("@bool", false);
                    insertCommand.ExecuteNonQuery();
                    insertCommand.Parameters.Clear();
                }

                // INSERT mensagens

                insertQuery = "INSERT INTO mensagem (mensagem_nome, mensagem_quantidade) VALUES (@nome, @int);";

                using (SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@nome", "Todas");
                    insertCommand.Parameters.AddWithValue("@int", 6);
                    insertCommand.ExecuteNonQuery();
                    insertCommand.Parameters.Clear();

                    insertCommand.Parameters.AddWithValue("@nome", "Rafael Brother");
                    insertCommand.Parameters.AddWithValue("@int", 1);
                    insertCommand.ExecuteNonQuery();
                    insertCommand.Parameters.Clear();

                    insertCommand.Parameters.AddWithValue("@nome", "CSP");
                    insertCommand.Parameters.AddWithValue("@int", 2);
                    insertCommand.ExecuteNonQuery();
                    insertCommand.Parameters.Clear();

                    insertCommand.Parameters.AddWithValue("@nome", "Sofia Filha");
                    insertCommand.Parameters.AddWithValue("@int", 1);
                    insertCommand.ExecuteNonQuery();
                    insertCommand.Parameters.Clear();

                    insertCommand.Parameters.AddWithValue("@nome", "Chefe Bruno");
                    insertCommand.Parameters.AddWithValue("@int", 2);
                    insertCommand.ExecuteNonQuery();
                    insertCommand.Parameters.Clear();
                }

                connection.Close();
            }
        }

        /// <summary>
        /// Cria um novo banco de dados (Cria Database, cria Tabelas e Faz os inserts) SOMENTE se o arquivo \Database\umdianegro.db não existir)
        /// </summary>
        public static void Run()
        {
            string temp = Directory.GetCurrentDirectory();

            if (File.Exists($@"{temp}\Database\umdianegro.db") == false) // Verifica se o banco de dados já existe
            {
                Criar_Banco_de_Dados();
                Criar_Tabelas();
                Fazer_Inserts();
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
                        updateCommand.Parameters.AddWithValue("@nome", "Cabo TV");
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
                        updateCommand.Parameters.AddWithValue("@nome", "Chave Escritorio");
                        updateCommand.Parameters.AddWithValue("@bool", valor);
                        updateCommand.ExecuteNonQuery();
                    }

                    connection.Close();
                }
            }
            public static void Chave_Porta(bool valor)
            {
                string connectionString = $"Data Source=Database\\umdianegro.db;Version=3;";

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string updateQuery = "UPDATE item SET item_coletado = @bool WHERE item_nome = @nome;";

                    using (SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@nome", "Chave Porta");
                        updateCommand.Parameters.AddWithValue("@bool", valor);
                        updateCommand.ExecuteNonQuery();
                    }

                    connection.Close();
                }
            }
            public static void Isqueiro(bool valor)
            {
                string connectionString = $"Data Source=Database\\umdianegro.db;Version=3;";

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string updateQuery = "UPDATE item SET item_coletado = @bool WHERE item_nome = @nome;";

                    using (SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@nome", "Isqueiro");
                        updateCommand.Parameters.AddWithValue("@bool", valor);
                        updateCommand.ExecuteNonQuery();
                    }

                    connection.Close();
                }
            }
            public static void Faca(bool valor)
            {
                string connectionString = $"Data Source=Database\\umdianegro.db;Version=3;";

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string updateQuery = "UPDATE item SET item_coletado = @bool WHERE item_nome = @nome;";

                    using (SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@nome", "Faca");
                        updateCommand.Parameters.AddWithValue("@bool", valor);
                        updateCommand.ExecuteNonQuery();
                    }

                    connection.Close();
                }
            }
        }
        public static class Alterar_Progresso_da_História
        {
            /// <summary>
            /// Altera se o progresso ->Atender um desconhecido<- já ocorreu.
            /// </summary>
            /// <param name="valor"> true: já ocorreu / false: não ocorreu</param>
            /// <returns>Retorna true ou false.</returns>
            public static void Atender_Desconhecido(bool valor)
            {
                string connectionString = $"Data Source=Database\\umdianegro.db;Version=3;";

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string updateQuery = "UPDATE elemento_historia SET elemento_historia_ocorreu = @bool WHERE elemento_historia_nome = @nome;";

                    using (SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@nome", "Atender Desconhecido");
                        updateCommand.Parameters.AddWithValue("@bool", valor);
                        updateCommand.ExecuteNonQuery();
                    }

                    connection.Close();
                }
            }
            /// <summary>
            /// Altera se o progresso ->Abrir cofre<- já ocorreu 
            /// </summary>
            /// <param name="valor"> true: já ocorreu / false: não ocorreu</param>
            /// <returns>Retorna true ou false.</returns>
            public static void Abrir_Cofre(bool valor)
            {
                string connectionString = $"Data Source=Database\\umdianegro.db;Version=3;";

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string updateQuery = "UPDATE elemento_historia SET elemento_historia_ocorreu = @bool WHERE elemento_historia_nome = @nome;";

                    using (SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@nome", "Cofre Aberto");
                        updateCommand.Parameters.AddWithValue("@bool", valor);
                        updateCommand.ExecuteNonQuery();
                    }

                    connection.Close();
                }
            }
            public static void Memórias(bool valor)
            {
                string connectionString = $"Data Source=Database\\umdianegro.db;Version=3;";

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string updateQuery = "UPDATE elemento_historia SET elemento_historia_ocorreu = @bool WHERE elemento_historia_nome = @nome;";

                    using (SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@nome", "Memórias");
                        updateCommand.Parameters.AddWithValue("@bool", valor);
                        updateCommand.ExecuteNonQuery();
                    }

                    connection.Close();
                }
            }
            public static void Parte1_História(bool valor)
            {
                string connectionString = $"Data Source=Database\\umdianegro.db;Version=3;";

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string updateQuery = "UPDATE elemento_historia SET elemento_historia_ocorreu = @bool WHERE elemento_historia_nome = @nome;";

                    using (SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@nome", "Parte 1 História");
                        updateCommand.Parameters.AddWithValue("@bool", valor);
                        updateCommand.ExecuteNonQuery();
                    }

                    connection.Close();
                }
            }
        }
        public static class Ler_Progresso_Da_História
        {
            /// <summary>
            /// Verifica se o item ->Cabo da TV<- já foi coletado 
            /// </summary>
            /// <returns>Retorna true ou false.</returns>
            public static bool Cabo_TV()
            {
                string connectionString = $"Data Source=Database\\umdianegro.db;Version=3;";
                bool temp = false;

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT item_coletado FROM item WHERE item_nome = \"Cabo TV\";";

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
            /// <summary>
            /// Verifica se o item ->Chave do escritório<- já foi coletado 
            /// </summary>
            /// <returns>Retorna true ou false.</returns>
            public static bool Chave_Escritorio()
            {
                string connectionString = $"Data Source=Database\\umdianegro.db;Version=3;";
                bool temp = false;

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT item_coletado FROM item WHERE item_nome = \"Chave Escritorio\";";

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
            /// <summary>
            /// Verifica se o item ->Chave da Porta<- já foi coletado 
            /// </summary>
            /// <returns>Retorna true ou false.</returns>
            public static bool Chave_Porta()
            {
                string connectionString = $"Data Source=Database\\umdianegro.db;Version=3;";
                bool temp = false;

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT item_coletado FROM item WHERE item_nome = \"Chave Porta\";";

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
            /// <summary>
            /// Verifica se o item ->Isqueiro<- já foi coletado 
            /// </summary>
            /// <returns>Retorna true ou false.</returns>
            public static bool Isqueiro()
            {
                string connectionString = $"Data Source=Database\\umdianegro.db;Version=3;";
                bool temp = false;

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT item_coletado FROM item WHERE item_nome = \"Isqueiro\";";

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
            /// <summary>
            /// Verifica se o item ->Faca<- já foi coletado 
            /// </summary>
            /// <returns>Retorna true ou false.</returns>
            public static bool Faca()
            {
                string connectionString = $"Data Source=Database\\umdianegro.db;Version=3;";
                bool temp = false;

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT item_coletado FROM item WHERE item_nome = \"Faca\";";

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
            /// <summary>
            /// Verifica se o progresso ->Abrir cofre<- já ocorreu 
            /// </summary>
            /// <returns>Retorna true ou false.</returns>
            public static bool Cofre_Aberto()
            {
                string connectionString = $"Data Source=Database\\umdianegro.db;Version=3;";
                bool temp = false;

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT elemento_historia_ocorreu FROM elemento_historia WHERE elemento_historia_nome = \"Cofre Aberto\";";

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
            /// <summary>
            /// Verifica se o progresso ->Memórias<- já ocorreu 
            /// </summary>
            /// <returns>Retorna true ou false.</returns>
            public static bool Memórias()
            {
                string connectionString = $"Data Source=Database\\umdianegro.db;Version=3;";
                bool temp = false;

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT elemento_historia_ocorreu FROM elemento_historia WHERE elemento_historia_nome = \"Memórias\";";

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
            /// <summary>
            /// Verifica se o progresso ->Atender um desconhecido<- já ocorreu 
            /// </summary>
            /// <returns>Retorna true ou false.</returns>
            public static bool Atender_Desconhecido()
            {
                string connectionString = $"Data Source=Database\\umdianegro.db;Version=3;";
                bool temp = false;

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT elemento_historia_ocorreu FROM elemento_historia WHERE elemento_historia_nome = \"Atender Desconhecido\";";

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
            /// <summary>
            /// Verifica se o progresso ->Parte 1 da História<- já ocorreu 
            /// </summary>
            /// <returns>Retorna true ou false.</returns>
            public static bool Parte1_História()
            {
                string connectionString = $"Data Source=Database\\umdianegro.db;Version=3;";
                bool temp = false;

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT elemento_historia_ocorreu FROM elemento_historia WHERE elemento_historia_nome = \"Parte 1 História\";";

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
        public static class Alterar_num_Mensagens
        {
            /// <summary>
            /// Altera o número de mensagens não respondidas.
            /// </summary>
            /// <param name="n_adicionar">Adiciona n à contagem de mensagens não respondidas</param>
            /// <param name="n_subtrair">Subtrai n à contagem de mensagens não respondidas</param>
            public static void Todas_Não_Respondidas(int n_adicionar = 0, int n_subtrair = 0)
            {
                string connectionString = $"Data Source=Database\\umdianegro.db;Version=3;";

                int n_msg = 0;

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT mensagem_quantidade FROM mensagem WHERE mensagem_nome = \"Todas\";";

                    using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                n_msg = reader.GetInt16(0);
                            }
                        }
                    }

                    n_msg += n_adicionar;
                    n_msg -= n_subtrair;

                    string updateQuery = "UPDATE mensagem SET mensagem_quantidade = @int WHERE mensagem_nome = @nome;";

                    using (SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@nome", "Todas");
                        updateCommand.Parameters.AddWithValue("@int", n_msg);
                        updateCommand.ExecuteNonQuery();
                    }

                    connection.Close();
                }
            }
            public static void Rafael_Brother(int n_adicionar = 0, int n_subtrair = 0)
            {
                string connectionString = $"Data Source=Database\\umdianegro.db;Version=3;";

                int n_msg = 0;

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT mensagem_quantidade FROM mensagem WHERE mensagem_nome = \"Rafael Brother\";";

                    using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                n_msg = reader.GetInt16(0);
                            }
                        }
                    }

                    n_msg += n_adicionar;
                    n_msg -= n_subtrair;

                    string updateQuery = "UPDATE mensagem SET mensagem_quantidade = @int WHERE mensagem_nome = @nome;";

                    using (SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@nome", "Rafael Brother");
                        updateCommand.Parameters.AddWithValue("@int", n_msg);
                        updateCommand.ExecuteNonQuery();
                    }

                    connection.Close();
                }
            }
            public static void CSP(int n_adicionar = 0, int n_subtrair = 0)
            {
                string connectionString = $"Data Source=Database\\umdianegro.db;Version=3;";

                int n_msg = 0;

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT mensagem_quantidade FROM mensagem WHERE mensagem_nome = \"CSP\";";

                    using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                n_msg = reader.GetInt16(0);
                            }
                        }
                    }

                    n_msg += n_adicionar;
                    n_msg -= n_subtrair;

                    string updateQuery = "UPDATE mensagem SET mensagem_quantidade = @int WHERE mensagem_nome = @nome;";

                    using (SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@nome", "CSP");
                        updateCommand.Parameters.AddWithValue("@int", n_msg);
                        updateCommand.ExecuteNonQuery();
                    }

                    connection.Close();
                }
            }
            public static void Sofia_Filha(int n_adicionar = 0, int n_subtrair = 0)
            {
                string connectionString = $"Data Source=Database\\umdianegro.db;Version=3;";

                int n_msg = 0;

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT mensagem_quantidade FROM mensagem WHERE mensagem_nome = \"Sofia Filha\";";

                    using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                n_msg = reader.GetInt16(0);
                            }
                        }
                    }

                    n_msg += n_adicionar;
                    n_msg -= n_subtrair;

                    string updateQuery = "UPDATE mensagem SET mensagem_quantidade = @int WHERE mensagem_nome = @nome;";

                    using (SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@nome", "Sofia Filha");
                        updateCommand.Parameters.AddWithValue("@int", n_msg);
                        updateCommand.ExecuteNonQuery();
                    }

                    connection.Close();
                }
            }
            public static void Chefe_Bruno(int n_adicionar = 0, int n_subtrair = 0)
            {
                string connectionString = $"Data Source=Database\\umdianegro.db;Version=3;";

                int n_msg = 0;

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT mensagem_quantidade FROM mensagem WHERE mensagem_nome = \"Chefe Bruno\";";

                    using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                n_msg = reader.GetInt16(0);
                            }
                        }
                    }

                    n_msg += n_adicionar;
                    n_msg -= n_subtrair;

                    string updateQuery = "UPDATE mensagem SET mensagem_quantidade = @int WHERE mensagem_nome = @nome;";

                    using (SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@nome", "Chefe Bruno");
                        updateCommand.Parameters.AddWithValue("@int", n_msg);
                        updateCommand.ExecuteNonQuery();
                    }

                    connection.Close();
                }
            }
        }
        public static class Ler_num_Mensagens
        {
            public static int Todas_Não_Respondidas()
            {
                string connectionString = $"Data Source=Database\\umdianegro.db;Version=3;";

                int n_msg = 0;

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT mensagem_quantidade FROM mensagem WHERE mensagem_nome = \"Todas\";";

                    using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                n_msg = reader.GetInt16(0);
                            }
                        }
                    }

                    connection.Close();
                }

                return n_msg;
            }
            public static int Rafael_Brother()
            {
                string connectionString = $"Data Source=Database\\umdianegro.db;Version=3;";

                int n_msg = 0;

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT mensagem_quantidade FROM mensagem WHERE mensagem_nome = \"Rafael Brother\";";

                    using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                n_msg = reader.GetInt16(0);
                            }
                        }
                    }

                    connection.Close();
                }

                return n_msg;
            }
            public static int CSP()
            {
                string connectionString = $"Data Source=Database\\umdianegro.db;Version=3;";

                int n_msg = 0;

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT mensagem_quantidade FROM mensagem WHERE mensagem_nome = \"CSP\";";

                    using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                n_msg = reader.GetInt16(0);
                            }
                        }
                    }

                    connection.Close();
                }

                return n_msg;
            }
            public static int Sofia_Filha()
            {
                string connectionString = $"Data Source=Database\\umdianegro.db;Version=3;";

                int n_msg = 0;

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT mensagem_quantidade FROM mensagem WHERE mensagem_nome = \"Sofia Filha\";";

                    using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                n_msg = reader.GetInt16(0);
                            }
                        }
                    }

                    connection.Close();
                }

                return n_msg;
            }
            public static int Chefe_Bruno()
            {
                string connectionString = $"Data Source=Database\\umdianegro.db;Version=3;";

                int n_msg = 0;

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT mensagem_quantidade FROM mensagem WHERE mensagem_nome = \"Chefe Bruno\";";

                    using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                n_msg = reader.GetInt16(0);
                            }
                        }
                    }

                    connection.Close();
                }

                return n_msg;
            }
        }
    }
}
