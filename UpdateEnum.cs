using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Data;

namespace HomeBank
{
    class UpdateEnum
    {

        static public void UpdateAccount(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            string path = @"Data source = HomeBank.db;Mode = ReadWriteCreate;";
            SQLiteConnection _connection;
            _connection = new SQLiteConnection(path);
            _connection.Open();
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            string query = @"SELECT AccountName FROM AccountTable;";
            var cmd = new SQLiteCommand(query, _connection);
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                var cells = row.ItemArray;
                foreach (object cell in cells)
                    comboBox.Items.Add(cell.ToString());
            }
            _connection.Close();
        }


        static public void UpdateSource(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            string path = @"Data source = HomeBank.db;Mode = ReadWriteCreate;";
            SQLiteConnection _connection;
            _connection = new SQLiteConnection(path);
            _connection.Open();
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            string query = @"SELECT SourceName FROM SourceTable;";
            var cmd = new SQLiteCommand(query, _connection);
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                var cells = row.ItemArray;
                foreach (object cell in cells)
                    comboBox.Items.Add(cell.ToString());
            }
            _connection.Close();
        }
        static public void UpdateExpense(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            string path = @"Data source = HomeBank.db;Mode = ReadWriteCreate;";
            SQLiteConnection _connection;
            _connection = new SQLiteConnection(path);
            _connection.Open();
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            string query = @"SELECT ExpenseTypeName FROM ExpenseTypeTable;";
            var cmd = new SQLiteCommand(query, _connection);
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                var cells = row.ItemArray;
                foreach (object cell in cells)
                    comboBox.Items.Add(cell.ToString());
            }
            _connection.Close();
        }



    }
}
