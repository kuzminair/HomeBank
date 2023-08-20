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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            UpdateEnum.UpdateAccount(cBChoiceAccount2);
            UpdateEnum.UpdateExpense(cBoxEspenseType2);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        
        private void btnAddExpense_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxSummaExp.Text != "" && cBoxEspenseType2.Text != "" && cBChoiceAccount2.Text != "" && dateTimePickerExpense.Text != "")
            {
                string queryScalar = $"SELECT AccountSumma FROM AccountTable WHERE AccountName = '{cBChoiceAccount2.Text}'";
                int rest = OutputDataGrid.ScalarToInt(queryScalar);
                if (rest >= Int32.Parse(textBoxSummaExp.Text))
                {
                    string queryUpdate = $"UPDATE AccountTable SET AccountSumma = AccountSumma-'{Int32.Parse(textBoxSummaExp.Text)}' WHERE AccountName = '{cBChoiceAccount2.Text}'";
                    OutputDataGrid.CommandKlass(queryUpdate);
                    string query = $"INSERT INTO ExpenseTable (ExpenseDate, ExpenseSumma, ExpenseComment, ExpenseType, ExpenseAccountID) VALUES ('{dateTimePickerExpense.Text}', '{Int32.Parse(textBoxSummaExp.Text)}', '{textBoxCommentExp.Text}', '{cBoxEspenseType2.Text}', '{cBChoiceAccount2.Text}')";
                    OutputDataGrid.CommandKlass(query);
                    MessageBox.Show("Данные добавлены");
                }
                else
                    MessageBox.Show($"Расход превышает остаток на счете. Остаток на данном счете = {rest}");
            }
            else
            {
                MessageBox.Show("Заполните все обязательные поля");
            }
        }

        private void btnAddExpenseType_MouseClick(object sender, MouseEventArgs e)
        {
            Form8 newForm = new Form8();
            newForm.Show();
        }

        private void btnUpdate_MouseClick(object sender, MouseEventArgs e)
        {
            UpdateEnum.UpdateExpense(cBoxEspenseType2);
        }
    }
}
