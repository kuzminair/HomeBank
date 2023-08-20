using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace HomeBank
{
    class CreationTable
    {
        static public void CreationFirstTable()
        {
            SQLiteConnection _connection;
            string path = @"Data source = HomeBank.db;Mode = ReadWriteCreate;";
            string query1 = @"CREATE TABLE IF NOT EXISTS AccountTable(
                                    AccountID INTEGER PRIMARY KEY AUTOINCREMENT,
                                    AccountName TEXT UNIQUE,
                                    AccountSumma INTEGER,
                                    AccountComment TEXT);";
            string query2 = @"CREATE TABLE IF NOT EXISTS SourceTable(
                                    SourceID INTEGER PRIMARY KEY AUTOINCREMENT,
                                    SourceName TEXT UNIQUE);";
            string query3 = @"CREATE TABLE IF NOT EXISTS ExpenseTypeTable(
                                    ExpenseTypeID INTEGER PRIMARY KEY AUTOINCREMENT,
                                    ExpenseTypeName TEXT UNIQUE);";
            string query4 = @"CREATE TABLE IF NOT EXISTS ProfitTable(
                                    ProfitID INTEGER PRIMARY KEY AUTOINCREMENT,
                                    ProfitDate TEXT,
                                    ProfitSumma INTEGER,
                                    ProfitComment TEXT,                                    
                                    ProfitSource TEXT,
                                    ProfitAccountID TEXT);";
            string query5 = @"CREATE TABLE IF NOT EXISTS ExpenseTable(
                                    ExpenseID INTEGER PRIMARY KEY AUTOINCREMENT,
                                    ExpenseDate TEXT,
                                    ExpenseSumma INTEGER,
                                    ExpenseComment TEXT,
                                    ExpenseType TEXT,
                                    ExpenseAccountID TEXT);";

            string querySource = @"INSERT or IGNORE INTO SourceTable (SourceName) VALUES ('Заработная плата'), ('Дивиденды'), ('Купоны'), ('Сдача собственности в аренду')";
            string queryExpense = @"INSERT or IGNORE INTO ExpenseTypeTable (ExpenseTypeName) VALUES ('Продукты'), ('Коммунальные платежи'), ('Одежда'), ('Обувь'), ('Ремонт')";
            string queryAccount = @"INSERT or IGNORE INTO AccountTable (AccountName, AccountSumma, AccountComment) VALUES ('Основной', 0, 'Текущие расходы')";

            _connection = new SQLiteConnection(path);
            var cmd1 = new SQLiteCommand(query1, _connection);
            var cmd2 = new SQLiteCommand(query2, _connection);
            var cmd3 = new SQLiteCommand(query3, _connection);
            var cmd4 = new SQLiteCommand(query4, _connection);
            var cmd5 = new SQLiteCommand(query5, _connection);
            var cmd6 = new SQLiteCommand(querySource, _connection);
            var cmd7 = new SQLiteCommand(queryExpense, _connection);
            var cmd8 = new SQLiteCommand(queryAccount, _connection);
            _connection.Open();
            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();
            cmd4.ExecuteNonQuery();
            cmd5.ExecuteNonQuery();
            cmd6.ExecuteNonQuery();
            cmd7.ExecuteNonQuery();
            cmd8.ExecuteNonQuery();
            _connection.Close();
        }




    }
}
