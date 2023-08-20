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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnAddProfitSource_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxProfitSource.Text != "")
            {
                string query = $"INSERT INTO SourceTable (SourceName) VALUES ('{textBoxProfitSource.Text}')";
                OutputDataGrid.CommandKlass(query);
                this.Close();
            }
            else
            {
                MessageBox.Show("Введите источник дохода");
            }
        }
    }
}
