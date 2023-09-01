using System.Data.SQLite;

// Criação do banco

string databasePath = "umdianegro.db"; // Nome do arquivo do banco de dados
SQLiteConnection.CreateFile(databasePath); // Cria o arquivo do banco de dados

// Conexão e interação com banco

// string databasePath = "seuarquivo.db";
//string connectionString = $"Data Source={databasePath};Version=3;";
//using SQLiteConnection connection = new SQLiteConnection(connectionString);
//connection.Open();

//// Exemplo de consulta SELECT
//string selectQuery = "SELECT * FROM sua_tabela;";
//using SQLiteCommand command = new SQLiteCommand(selectQuery, connection);
//using SQLiteDataReader reader = command.ExecuteReader();
//while (reader.Read())
//{
//    // Processar os resultados da consulta
//}

//// Exemplo de inserção de dados
//string insertQuery = "INSERT INTO sua_tabela (coluna1, coluna2) VALUES (@valor1, @valor2);";
//using SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, connection);
//insertCommand.Parameters.AddWithValue("@valor1", valor1);
//insertCommand.Parameters.AddWithValue("@valor2", valor2);
//insertCommand.ExecuteNonQuery();

//connection.Close();