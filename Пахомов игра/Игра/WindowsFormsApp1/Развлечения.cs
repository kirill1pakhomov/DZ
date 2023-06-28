using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Развлечения : Form
    {
        private Form1 form1;
        public Развлечения(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(form1.money >= 5)
            {
                form1.money -= 5;
                form1.HidenPoint += 2;
                form1.lblMoney.Text = form1.money.ToString();
                lblCash.Text = form1.lblMoney.Text;
            }
            else
            {
                MessageBox.Show("Ты бомж,работай!!!");
            }
        }

        private void Развлечения_Load(object sender, EventArgs e)
        {
            lblCash.Text = form1.lblMoney.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (form1.money >= 20)
            {
                form1.money -= 20;
                form1.HidenPoint += 7;
                form1.lblMoney.Text = form1.money.ToString();
                lblCash.Text = form1.lblMoney.Text;
            }
            else
            {
                MessageBox.Show("Ты бомж,работай!!!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (form1.money >= 30)
            {
                form1.money -= 30;
                form1.HidenPoint += 10;
                form1.lblMoney.Text = form1.money.ToString();
                lblCash.Text = form1.lblMoney.Text;
            }
            else
            {
                MessageBox.Show("Ты бомж,работай!!!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
