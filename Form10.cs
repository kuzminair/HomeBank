using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeBank
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            UpdateEnum.UpdateAccount(cBChoiceAccount1);
            UpdateEnum.UpdateAccount(cBChoiceAccount2);
        }

        private void btnTransfer_MouseClick(object sender, MouseEventArgs e)
        {
            if (cBChoiceAccount1.Text != "" && cBChoiceAccount2.Text != "" && textBoxSum.Text != "")
            {
                string queryScalar = $"SELECT AccountSumma FROM AccountTable WHERE AccountName = '{cBChoiceAccount1.Text}'";
                int rest = OutputDataGrid.ScalarToInt(queryScalar);
                if (rest >= Int32.Parse(textBoxSum.Text))
                {
                    string query = $"UPDATE AccountTable SET AccountSumma = AccountSumma + '{Int32.Parse(textBoxSum.Text)}' WHERE AccountName = '{cBChoiceAccount2.Text}';" +
                           $"UPDATE AccountTable SET AccountSumma = AccountSumma - '{Int32.Parse(textBoxSum.Text)}' WHERE AccountName = '{cBChoiceAccount1.Text}';";
                    OutputDataGrid.CommandKlassTransaction(query);
                    MessageBox.Show("Перевод осуществлен");
                }
                else MessageBox.Show($"Недостаточно средств. Остаток на счете {cBChoiceAccount1.Text} = {rest}");
            }
            else
            {
                MessageBox.Show("Заполните все обязательные поля");
            }
        }
        
    }
}
