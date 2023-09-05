using System.Data.SQLite;

namespace Projeto_rpg
{
    public class Banco_de_Dados
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
                        updateCommand.Parameters.AddWithValue("@nome", "atender_desconhecido");
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
                        updateCommand.Parameters.AddWithValue("@nome", "cofre_aberto");
                        updateCommand.Parameters.AddWithValue("@bool", valor);
                        updateCommand.ExecuteNonQuery();
                    }

                    connection.Close();
                }
            }
            /// <summary>
            /// Altera o número de mensagens não respondidas.
            /// </summary>
            /// <param name="n_adicionar">Adiciona n à contagem de mensagens não respondidas</param>
            /// <param name="n_subtrair">Subtrai n à contagem de mensagens não respondidas</param>
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
            /// <summary>
            /// Verifica a quantidade de mensagens não respondidas 
            /// </summary>
            /// <returns>Retorna true ou false.</returns>
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
