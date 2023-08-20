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
using System.Data.SqlClient;
using System.Diagnostics;

namespace HomeBank
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            processCalc.StartInfo = new System.Diagnostics.ProcessStartInfo("calc.exe");
            UpdateEnum.UpdateAccount(cBChoiceAccount);
            UpdateEnum.UpdateExpense(cBoxEspenseType);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnAddExpense_MouseClick(object sender, MouseEventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show();
        }

        private void btnAddTypeExpens_MouseClick(object sender, MouseEventArgs e)
        {
            Form8 newForm = new Form8();
            newForm.Show();
        }
        public int OutputSumExpense(string queryScalar)
        {
            int rest = OutputDataGrid.ScalarToInt(queryScalar);
            return rest;
        }
        private void btnPeriodExpense_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                int rest = 0;
                if (cBoxEspenseType.Text == "" && cBChoiceAccount.Text == "")
                {
                    string query = @"SELECT ExpenseID AS ID, ExpenseDate AS 'Дата', ExpenseSumma AS 'Сумма',
                            ExpenseType AS 'Тип расходов', ExpenseComment AS 'Комментарий', ExpenseAccountID AS 'Счет' FROM ExpenseTable;";
                    OutputDataGrid.OutputData(query, dataGridViewExpense);
                    rest = OutputSumExpense($"SELECT SUM(ExpenseSumma) FROM ExpenseTable");
                }
                if (cBoxEspenseType.Text != "" && cBChoiceAccount.Text == "")
                {
                    string query = $"SELECT ExpenseID AS ID, ExpenseDate AS 'Дата', ExpenseSumma AS 'Сумма', ExpenseType AS 'Тип расходов', ExpenseComment AS 'Комментарий', ExpenseAccountID AS 'Счет' FROM ExpenseTable WHERE ExpenseType = '{cBoxEspenseType.Text}';";
                    OutputDataGrid.OutputData(query, dataGridViewExpense);
                    rest = OutputSumExpense($"SELECT SUM(ExpenseSumma) FROM ExpenseTable WHERE ExpenseType = '{cBoxEspenseType.Text}';");
                }
                if (cBoxEspenseType.Text == "" && cBChoiceAccount.Text != "")
                {
                    string query = $"SELECT ExpenseID AS ID, ExpenseDate AS 'Дата', ExpenseSumma AS 'Сумма', ExpenseType AS 'Тип расходов', ExpenseComment AS 'Комментарий', ExpenseAccountID AS 'Счет' FROM ExpenseTable WHERE ExpenseAccountID = '{cBChoiceAccount.Text}';";
                    OutputDataGrid.OutputData(query, dataGridViewExpense);
                    rest = OutputSumExpense($"SELECT SUM(ExpenseSumma) FROM ExpenseTable WHERE ExpenseAccountID = '{cBChoiceAccount.Text}';");
                }
                if (cBoxEspenseType.Text != "" && cBChoiceAccount.Text != "")
                {
                    string query = $"SELECT ExpenseID AS ID, ExpenseDate AS 'Дата', ExpenseSumma AS 'Сумма', ExpenseType AS 'Тип расходов', ExpenseComment AS 'Комментарий', ExpenseAccountID AS 'Счет' FROM ExpenseTable WHERE ExpenseType = '{cBoxEspenseType.Text}' AND ExpenseAccountID = '{cBChoiceAccount.Text}';";
                    OutputDataGrid.OutputData(query, dataGridViewExpense);
                    rest = OutputSumExpense($"SELECT SUM(ExpenseSumma) FROM ExpenseTable WHERE ExpenseType = '{cBoxEspenseType.Text}' AND ExpenseAccountID = '{cBChoiceAccount.Text}';");
                }

                label4.Text = $"Обновлено {DateTime.Now}";
                labelSum.Text = $"ИТОГО: {rest} рублей";
            }
            catch (Exception)
            {
                MessageBox.Show("Попробуйте изменить запрос"); ;
            }
        }

        private void btnUpdate_MouseClick(object sender, MouseEventArgs e)
        {
            UpdateEnum.UpdateExpense(cBoxEspenseType);
            UpdateEnum.UpdateAccount(cBChoiceAccount);
        }

        private void btnPeriodChoice_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
            int rest = 0;
            if (cBoxEspenseType.Text == "" && cBChoiceAccount.Text == "")
            {
                string query = $"SELECT ExpenseID AS ID, ExpenseDate AS 'Дата', ExpenseSumma AS 'Сумма', ExpenseType AS 'Тип расходов', ExpenseComment AS 'Комментарий', ExpenseAccountID AS 'Счет' FROM ExpenseTable WHERE ExpenseDate BETWEEN '{dateTimePicker1.Text}' AND '{dateTimePicker2.Text}';";
                OutputDataGrid.OutputData(query, dataGridViewExpense);
                rest = OutputSumExpense($"SELECT SUM(ExpenseSumma) FROM ExpenseTable WHERE ExpenseDate BETWEEN '{dateTimePicker1.Text}' AND '{dateTimePicker2.Text}';");
            }
            if (cBoxEspenseType.Text != "" && cBChoiceAccount.Text == "")
            {
                string query = $"SELECT ExpenseID AS ID, ExpenseDate AS 'Дата', ExpenseSumma AS 'Сумма', ExpenseType AS 'Тип расходов', ExpenseComment AS 'Комментарий', ExpenseAccountID AS 'Счет' FROM ExpenseTable WHERE ExpenseType = '{cBoxEspenseType.Text}' AND ExpenseDate BETWEEN '{dateTimePicker1.Text}' AND '{dateTimePicker2.Text}';";
                OutputDataGrid.OutputData(query, dataGridViewExpense);
                rest = OutputSumExpense($"SELECT SUM(ExpenseSumma) FROM ExpenseTable WHERE ExpenseType = '{cBoxEspenseType.Text}' AND ExpenseDate BETWEEN '{dateTimePicker1.Text}' AND '{dateTimePicker2.Text}';");
                OutputDataGrid.OutputData(query, dataGridViewExpense);
            }
            if (cBoxEspenseType.Text == "" && cBChoiceAccount.Text != "")
            {
                string query = $"SELECT ExpenseID AS ID, ExpenseDate AS 'Дата', ExpenseSumma AS 'Сумма', ExpenseType AS 'Тип расходов', ExpenseComment AS 'Комментарий', ExpenseAccountID AS 'Счет' FROM ExpenseTable WHERE ExpenseAccountID = '{cBChoiceAccount.Text}' AND ExpenseDate BETWEEN '{dateTimePicker1.Text}' AND '{dateTimePicker2.Text}';";
                OutputDataGrid.OutputData(query, dataGridViewExpense);
                rest = OutputSumExpense($"SELECT SUM(ExpenseSumma) FROM ExpenseTable WHERE ExpenseAccountID = '{cBChoiceAccount.Text}' AND ExpenseDate BETWEEN '{dateTimePicker1.Text}' AND '{dateTimePicker2.Text}';");
            }
            if (cBoxEspenseType.Text != "" && cBChoiceAccount.Text != "")
            {
                string query = $"SELECT ExpenseID AS ID, ExpenseDate AS 'Дата', ExpenseSumma AS 'Сумма', ExpenseType AS 'Тип расходов', ExpenseComment AS 'Комментарий', ExpenseAccountID AS 'Счет' FROM ExpenseTable WHERE ExpenseType = '{cBoxEspenseType.Text}' AND ExpenseAccountID = '{cBChoiceAccount.Text}' AND ExpenseDate BETWEEN '{dateTimePicker1.Text}' AND '{dateTimePicker2.Text}';";
                OutputDataGrid.OutputData(query, dataGridViewExpense);
                rest = OutputSumExpense($"SELECT SUM(ExpenseSumma) FROM ExpenseTable WHERE ExpenseType = '{cBoxEspenseType.Text}' AND ExpenseAccountID = '{cBChoiceAccount.Text}' AND ExpenseDate BETWEEN '{dateTimePicker1.Text}' AND '{dateTimePicker2.Text}';");
            }
            label4.Text = $"Обновлено {DateTime.Now}";
            labelSum.Text = $"ИТОГО: {rest} рублей";
            }
            catch (Exception)
            {
                MessageBox.Show("Попробуйте изменить запрос");                ;
            }
 
        }

        private void btnCalc_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                processCalc.Start();
            }
            catch
            {
                MessageBox.Show("Приложения нет в библиотеке данного компьютера");
            }
        }

        private void btnDelete_MouseClick(object sender, MouseEventArgs e)
        {
            string path = @"Data source = HomeBank.db;Mode = ReadWriteCreate;";
            SQLiteConnection _connection = new SQLiteConnection(path);
            foreach (DataGridViewRow row in dataGridViewExpense.SelectedRows)
            {
                var tempId = Convert.ToInt32(row.Cells[0].Value);
                var tempSum = Convert.ToInt32(row.Cells[2].Value);
                var tempAccount = Convert.ToString(row.Cells[5].Value);
                var query = $"DELETE FROM ExpenseTable WHERE ExpenseID = '{tempId}';" +
                    $"UPDATE AccountTable SET AccountSumma = AccountSumma + '{tempSum}' WHERE AccountName = '{tempAccount}'; ";
                var cmd = new SQLiteCommand(query, _connection);
                _connection.Open();
                cmd.ExecuteNonQuery();
                dataGridViewExpense.Rows.Remove(row);
            }
            _connection.Close();
        }
    }
}
