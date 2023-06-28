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
    public partial class кликер : Form
    {
        private Form1 form1;


        public кликер(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1.money += 1;
            form1.lblMoney.Text = form1.money.ToString();
            lblcash.Text = form1.lblMoney.Text.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            lblcash.Text = form1.lblMoney.Text.ToString();
            
        }
    }
}
