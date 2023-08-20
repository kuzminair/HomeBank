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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnAddExpens_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxTypeExpens.Text != "")
            {
                string query = $"INSERT INTO ExpenseTypeTable (ExpenseTypeName) VALUES ('{textBoxTypeExpens.Text}')";
                OutputDataGrid.CommandKlass(query);
                this.Close();
            }
            else
            {
                MessageBox.Show("Введите наименование вида расхода");
            }
        }
    }
}
