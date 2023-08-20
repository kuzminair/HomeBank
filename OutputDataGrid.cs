using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;

namespace HomeBank
{
    class OutputDataGrid
    {
        static string path = @"Data source = HomeBank.db;Mode = ReadWriteCreate;";
        static public int ScalarToInt(string query)
        {
            int result;

            SQLiteConnection _connection;
            _connection = new SQLiteConnection(path);
            var cmd = new SQLiteCommand(query, _connection);
            _connection.Open();
            cmd.ExecuteScalar();
            result = Int32.Parse(cmd.ExecuteScalar().ToString());
            _connection.Close();
            return result;
        }


        static public void OutputData (string query, DataGridView dataGrid)       
        {
            SQLiteConnection _connection;
            _connection = new SQLiteConnection(path);
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            var cmd = new SQLiteCommand(query, _connection);
            _connection.Open();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            dataGrid.DataSource = dt;
            _connection.Close();
        }
        static public void CommandKlass (string query)
        {
            SQLiteConnection _connection;
            _connection = new SQLiteConnection(path);
            var cmd = new SQLiteCommand(query, _connection);
            _connection.Open();
            cmd.ExecuteNonQuery();
            _connection.Close();
        }

        static public void CommandKlassTransaction(string query)
        {
            SQLiteConnection _connection = new SQLiteConnection(path);
            _connection.Open();
            var transaction = _connection.BeginTransaction();
            try
            {
            var cmd = new SQLiteCommand(query, _connection);
            cmd.ExecuteNonQuery();
            transaction.Commit();
            }
            catch (Exception)
            {
                transaction.Rollback();
            }
            _connection.Close();
        }
        static public void CommandDelete(string query, DataGridView dataGrid)
        {
            SQLiteConnection _connection = new SQLiteConnection(path);
            foreach (DataGridViewRow row in dataGrid.SelectedRows)
            {
                var tempId = Convert.ToInt32(row.Cells[0].Value);
                var SqlExpression = $"USE [Storage] DELETE FROM [dbo].[Workers] WHERE [WorkerId] = '{tempId}'";
                var cmd = new SQLiteCommand(query, _connection);
                _connection.Open();
                cmd.ExecuteNonQuery();
            }
                _connection.Close();
        }     
    }
}
