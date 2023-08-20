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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreationTable.CreationFirstTable();
        }

        private void btnExpense_MouseClick(object sender, MouseEventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void btnProfit_MouseClick(object sender, MouseEventArgs e)
        {
            Form4 newForm = new Form4();
            newForm.Show();
        }

        private void btnAccount_MouseClick(object sender, MouseEventArgs e)
        {
            Form6 newForm = new Form6();
            newForm.Show();
        }

        private void btnAddAccount_MouseClick(object sender, MouseEventArgs e)
        {
            Form7 newForm = new Form7();
            newForm.Show();
        }

        private void btnShowAccount_MouseClick(object sender, MouseEventArgs e)
        {
            Form6 newForm = new Form6();
            newForm.Show();
        }

        private void btnAddProfit_MouseClick(object sender, MouseEventArgs e)
        {
            Form5 newForm = new Form5();
            newForm.Show();
        }

        private void btnShowProfit_MouseClick(object sender, MouseEventArgs e)
        {
            Form4 newForm = new Form4();
            newForm.Show();
        }

        private void btnAddExpense_MouseClick(object sender, MouseEventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show();
        }

        private void btnShowExpense_MouseClick(object sender, MouseEventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }
    }
}
