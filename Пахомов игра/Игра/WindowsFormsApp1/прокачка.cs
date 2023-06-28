using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class прокачка : Form
    {
        private Form1 form1;


        public прокачка(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Upgrade_Load(object sender, EventArgs e)
        {
            lblCash.Text = form1.lblMoney.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(form1.money >= 100 && form1.pc == 1)
            
            { 
                form1.lblLvl.Text = "2 лвл" ;
                form1.pc += 1;
                form1.money -= 100;
                form1.lblMoney.Text = form1.money.ToString();
                lblCash.Text = form1.lblMoney.Text;
            }
            else if(form1.money >= 100 && form1.pc == 1)
            {
                MessageBox.Show( "Подкопи немного","не хватает денег");
            }
            if (form1.money >= 200 && form1.pc == 2)

            {
                form1.lblLvl.Text = "3 лвл";
                form1.pc +=1;
                form1.money -= 200;
                form1.lblMoney.Text = form1.money.ToString();
                lblCash.Text = form1.lblMoney.Text;
            }
            else if (form1.money >= 200 && form1.lblLvl.Text != "2 лвл")
            {
                MessageBox.Show("Подкопи немного", "не хватает денег");
            }
             if (form1.money >= 300 && form1.pc == 3)

            {
                form1.lblLvl.Text = "4 лвл";
                form1.pc +=1;
                form1.money -= 400;
                form1.lblMoney.Text = form1.money.ToString();
                lblCash.Text = form1.lblMoney.Text;
            }
             if (form1.money >= 400 && form1.lblLvl.Text != "4 лвл")
            {
                MessageBox.Show("Подкопи немного", "не хватает денег");
            }
        }
    }
}
