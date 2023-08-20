using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace HomeBank
{
    public partial class Form6 : Form
    {
        public void OutputAccountTable()
        {
            string query = @"SELECT AccountID AS ID, AccountName AS 'Наименование счета', AccountSumma AS 'Сумма остатка',
                            AccountComment AS 'Комментарий' FROM AccountTable;";
            OutputDataGrid.OutputData(query, dataGridViewAccount);
            string queryScalar = $"SELECT SUM (AccountSumma) FROM AccountTable";
            int rest = OutputDataGrid.ScalarToInt(queryScalar);
            labelSumma.Text = $"ИТОГО: {rest} рублей";
            label3.Text = $"Обновлено {DateTime.Now}";

        }
        public Form6()
        {
            InitializeComponent();
            OutputAccountTable();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnAddAccount_MouseClick(object sender, MouseEventArgs e)
        {
            Form7 newForm = new Form7();
            newForm.Show();
        }

        private void btnAccountUpdate_MouseClick(object sender, MouseEventArgs e)
        {
            OutputAccountTable();
        }

        private void btnChangeAccount_MouseClick(object sender, MouseEventArgs e)
        {
            Form10 newForm = new Form10();
            newForm.Show();
        }

        private void btnDelete_MouseClick(object sender, MouseEventArgs e)
        {
            string path = @"Data source = HomeBank.db;Mode = ReadWriteCreate;";
            SQLiteConnection _connection = new SQLiteConnection(path);
            _connection.Open();
            foreach (DataGridViewRow row in dataGridViewAccount.SelectedRows)
            {
                var tempId = Convert.ToInt32(row.Cells[0].Value);
                var tempAccount = Convert.ToString(row.Cells[1].Value);
                DialogResult result = MessageBox.Show($"Удаление счета повлечет удаление данных о доходах и расходах, связанных с этим счетом. Вы действительно хотите удалить счет {tempAccount}?", 
                    "Сообщение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                if (result == DialogResult.Yes)
                {
                    var query = $"DELETE FROM AccountTable WHERE AccountID = '{tempId}';" +
                    $"DELETE FROM ProfitTable WHERE ProfitAccountID = '{tempAccount}';" +
                    $"DELETE FROM ExpenseTable WHERE ExpenseAccountID = '{tempAccount}';";
                    var cmd = new SQLiteCommand(query, _connection);
                    cmd.ExecuteNonQuery();
                    dataGridViewAccount.Rows.Remove(row);
                }
            }
            _connection.Close();
        }
    }
}
