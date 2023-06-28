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
    public partial class софт : Form
    {
        private Form1 form1;


        public софт(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;

        }

        private void soft_Load(object sender, EventArgs e)
        {
            lblPoint.Text = form1.lblPoint.Text;
            lblStatus.Text = form1.lblStatus.Text;
            lblsoftt.Text = form1.lblSoft.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (form1.point >= 10 && form1.pc == 2)
            {
                form1.lblSoft.Text = "Средний";
                form1.softlvl += 1;
                lblsoftt.Text = form1.lblSoft.Text;
            }
           else if (form1.point >= 20 && form1.pc == 3)
            {
                form1.lblSoft.Text = "Хороший";
                form1.softlvl += 1;
                lblsoftt.Text = form1.lblSoft.Text;
            }
           else if (form1.point >= 30 && form1.pc == 4)
            {
                form1.lblSoft.Text = "Отличный";
                form1.softlvl += 1;
                lblsoftt.Text = form1.lblSoft.Text;

            }
            

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblp_Click(object sender, EventArgs e)
        {

        }

        private void lblsoftt_Click(object sender, EventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
