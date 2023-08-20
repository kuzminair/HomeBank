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


    public partial class Form7 : Form
    {
         public Form7()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void btnSaveAccount_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxAccountName.Text != "")
            {
                string query = $"INSERT INTO AccountTable (AccountName, AccountSumma, AccountComment) VALUES ('{textBoxAccountName.Text}', 0, '{textBoxAccountComment.Text}')";
                OutputDataGrid.CommandKlass(query);
                this.Close();
            }
            else {
                MessageBox.Show("Введите наименование счета");
            }
        }
    }
}
