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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            processCalc.StartInfo = new System.Diagnostics.ProcessStartInfo("calc.exe");
            UpdateEnum.UpdateSource(comboBoxSourcePr);
            UpdateEnum.UpdateAccount(comboBoxAccount);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnAddProfitSource_MouseClick(object sender, MouseEventArgs e)
        {
            Form9 newForm = new Form9();
            newForm.Show();
        }

        private void btnAddProfit_MouseClick(object sender, MouseEventArgs e)
        {
            Form5 newForm = new Form5();
            newForm.Show();
        }

        private void btnUpdate_MouseClick(object sender, MouseEventArgs e)
        {
            UpdateEnum.UpdateSource(comboBoxSourcePr);
        }

        private void btnPeriodAll_MouseClick(object sender, MouseEventArgs e)
        {
            if (comboBoxSourcePr.Text == "" && comboBoxAccount.Text == "")
            {
                string query = @"SELECT ProfitDate AS 'Дата', ProfitSumma AS 'Сумма', ProfitSource AS 'Источник', ProfitComment AS 'Комментарий', ProfitAccountID AS 'Счет' FROM ProfitTable;";
                OutputDataGrid.OutputData(query, dataGridViewProfit);
            }
            if (comboBoxSourcePr.Text != "" && comboBoxAccount.Text == "")
            {
                string query = $"SELECT ProfitDate AS 'Дата', ProfitSumma AS 'Сумма', ProfitSource AS 'Источник', ProfitComment AS 'Комментарий', ProfitAccountID AS 'Счет' FROM ProfitTable WHERE ProfitSource = '{comboBoxSourcePr.Text}';";
                OutputDataGrid.OutputData(query, dataGridViewProfit);
            }
            if (comboBoxSourcePr.Text == "" && comboBoxAccount.Text != "")
            {
                string query = $"SELECT ProfitDate AS 'Дата', ProfitSumma AS 'Сумма', ProfitSource AS 'Источник', ProfitComment AS 'Комментарий', ProfitAccountID AS 'Счет' FROM ProfitTable WHERE ProfitAccountID = '{comboBoxAccount.Text}';";
                OutputDataGrid.OutputData(query, dataGridViewProfit);
            }
            if (comboBoxSourcePr.Text != "" && comboBoxAccount.Text != "")
            {
                string query = $"SELECT ProfitDate AS 'Дата', ProfitSumma AS 'Сумма', ProfitSource AS 'Источник', ProfitComment AS 'Комментарий', ProfitAccountID AS 'Счет' FROM ProfitTable WHERE ProfitSource = '{comboBoxSourcePr.Text}' AND ProfitAccountID = '{comboBoxAccount.Text}';";
                OutputDataGrid.OutputData(query, dataGridViewProfit);
            }
            label6.Text = $"Обновлено {DateTime.Now}";
        }

        private void btnPeriodChoice_MouseClick(object sender, MouseEventArgs e)
        {
            if (comboBoxSourcePr.Text == "" && comboBoxAccount.Text == "")
            {
                string query = $"SELECT ProfitDate AS 'Дата', ProfitSumma AS 'Сумма', ProfitSource AS 'Источник', ProfitComment AS 'Комментарий', ProfitAccountID AS 'Счет' FROM ProfitTable WHERE ProfitDate BETWEEN '{dateTimePicker1.Text}' AND '{dateTimePicker2.Text}';";
                OutputDataGrid.OutputData(query, dataGridViewProfit);
            }
            if (comboBoxSourcePr.Text != "" && comboBoxAccount.Text == "")
            {
                string query = $"SELECT ProfitDate AS 'Дата', ProfitSumma AS 'Сумма', ProfitSource AS 'Источник', ProfitComment AS 'Комментарий', ProfitAccountID AS 'Счет' FROM ProfitTable WHERE ProfitSource = '{comboBoxSourcePr.Text}' AND ProfitDate BETWEEN '{dateTimePicker1.Text}' AND '{dateTimePicker2.Text}';";
                OutputDataGrid.OutputData(query, dataGridViewProfit);
            }
            if (comboBoxSourcePr.Text == "" && comboBoxAccount.Text != "")
            {
                string query = $"SELECT ProfitDate AS 'Дата', ProfitSumma AS 'Сумма', ProfitSource AS 'Источник', ProfitComment AS 'Комментарий', ProfitAccountID AS 'Счет' FROM ProfitTable WHERE ProfitAccountID = '{comboBoxAccount.Text}' AND ProfitDate BETWEEN '{dateTimePicker1.Text}' AND '{dateTimePicker2.Text}';";
                OutputDataGrid.OutputData(query, dataGridViewProfit);
            }
            if (comboBoxSourcePr.Text != "" && comboBoxAccount.Text != "")
            {
                string query = $"SELECT ProfitDate AS 'Дата', ProfitSumma AS 'Сумма', ProfitSource AS 'Источник', ProfitComment AS 'Комментарий', ProfitAccountID AS 'Счет' FROM ProfitTable WHERE ProfitSource = '{comboBoxSourcePr.Text}' AND ProfitAccountID = '{comboBoxAccount.Text}' AND ProfitDate BETWEEN '{dateTimePicker1.Text}' AND '{dateTimePicker2.Text}';";
                OutputDataGrid.OutputData(query, dataGridViewProfit);
            }
            label6.Text = $"Обновлено {DateTime.Now}";

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
    }
}
