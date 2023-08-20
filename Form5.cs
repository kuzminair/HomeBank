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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            UpdateEnum.UpdateAccount(comboBoxAccount);
            UpdateEnum.UpdateSource(comboBoxProfitSource);
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

        private void btnAddProfitSource_MouseClick(object sender, MouseEventArgs e)
        {
            Form9 newForm = new Form9();
            newForm.Show();
        }

        private void btnSaveProfit_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxSummProfit.Text != "" && comboBoxProfitSource.Text != "" && comboBoxAccount.Text != "" && dateTimePickerProfit.Text != "")
            {
                string query = $"INSERT INTO ProfitTable (ProfitDate, ProfitSumma, ProfitComment, ProfitSource, ProfitAccountID) VALUES ('{dateTimePickerProfit.Text}', '{Int32.Parse(textBoxSummProfit.Text)}', '{textBoxComment.Text}', '{comboBoxProfitSource.Text}', '{comboBoxAccount.Text}')";
                OutputDataGrid.CommandKlass(query);
                string queryUpdate = $"UPDATE AccountTable SET AccountSumma = AccountSumma+'{Int32.Parse(textBoxSummProfit.Text)}' WHERE AccountName = '{comboBoxAccount.Text}'";
                OutputDataGrid.CommandKlass(queryUpdate);
                string queryScalar = $"SELECT AccountSumma FROM AccountTable WHERE AccountName = '{comboBoxAccount.Text}'";
                int rest = OutputDataGrid.ScalarToInt(queryScalar);
                MessageBox.Show($"Данные добавлены. Остаток на счете {comboBoxAccount.Text} = {rest}");
            }
            else
            {
                MessageBox.Show("Заполните все обязательные поля");
            }
        }

        private void Form5_MouseClick(object sender, MouseEventArgs e)
        {
            UpdateEnum.UpdateSource(comboBoxProfitSource);
        }

        private void btnUpdate_MouseClick(object sender, MouseEventArgs e)
        {
            UpdateEnum.UpdateAccount(comboBoxAccount);
        }
    }
}
