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
    public partial class хакер : Form
    {
        private Form1 form1;


        public хакер(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;

        }
        
        
        private void Hack_Load(object sender, EventArgs e)
        {
            labelstatus.Text = form1.lblStatus.Text.ToString();
            labelpoint.Text = form1.lblPoint.Text.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Random random = new Random();
            double chance = 0.60; 
            double randomValue = random.NextDouble(); 

            if (randomValue < chance)
            {
                
                MessageBox.Show("Ты взломал мудл");
                form1.point += 1;
                form1.lblPoint.Text = form1.point.ToString();
                labelstatus.Text = form1.lblStatus.Text.ToString();
                labelpoint.Text = form1.lblPoint.Text.ToString();
            }
            else
            {
                
                MessageBox.Show("Что-то пошло не так!");
                form1.point -= 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (form1.status == "Мамин программист" )
            {
                Random random = new Random();
                double chance = 0.50;
                double randomValue = random.NextDouble();

                if (randomValue < chance)
                {

                    MessageBox.Show("Ты взломал сына маминой подруги!");
                    form1.point += 3;
                    form1.lblPoint.Text = form1.point.ToString();
                    labelstatus.Text = form1.lblStatus.Text.ToString();
                    labelpoint.Text = form1.lblPoint.Text.ToString();
                }
                else
                {

                    MessageBox.Show("Что-то пошло не так!!");
                    form1.point -= 3;
                }
            }
            else if (form1.status == "Почти программист")
            {
                Random random = new Random();
                double chance = 0.60;
                double randomValue = random.NextDouble();

                if (randomValue < chance)
                {

                    MessageBox.Show("Ты взломал сына маминой подруги!");
                    form1.point += 3;
                    form1.lblPoint.Text = form1.point.ToString();
                    labelstatus.Text = form1.lblStatus.Text.ToString();
                    labelpoint.Text = form1.lblPoint.Text.ToString();
                }
                else
                {

                    MessageBox.Show("Что-то пошло не так!!");
                    form1.point -= 3;
                }
            }
            else if (form1.status == "Настоящий программист")
            {
                Random random = new Random();
                double chance = 0.90;
                double randomValue = random.NextDouble();

                if (randomValue < chance)
                {

                    MessageBox.Show("Ты взломал сына маминой подруги!");
                    form1.point += 3;
                    form1.lblPoint.Text = form1.point.ToString();
                    labelstatus.Text = form1.lblStatus.Text.ToString();
                    labelpoint.Text = form1.lblPoint.Text.ToString();
                }
                else
                {

                    MessageBox.Show("Что-то пошло не так!!");
                    form1.point -= 3;
                }
            }
            else
            {
                MessageBox.Show("Ты не достоин этого,качайся!!!");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
             if (form1.status == "Почти программист")
            {
                Random random = new Random();
                double chance = 0.40;
                double randomValue = random.NextDouble();

                if (randomValue < chance)
                {

                    MessageBox.Show("Ты взломад банк!");
                    form1.point += 5;
                    form1.lblPoint.Text = form1.point.ToString();
                    labelstatus.Text = form1.lblStatus.Text.ToString();
                    labelpoint.Text = form1.lblPoint.Text.ToString();
                }
                else
                {

                    MessageBox.Show("Что-то пошло не так!!");
                    form1.point -= 5;
                }
            }
            else if (form1.status == "Настоящий программист")
            {
                Random random = new Random();
                double chance = 0.60;
                double randomValue = random.NextDouble();

                if (randomValue < chance)
                {

                    MessageBox.Show("Ты взломал банк!");
                    form1.point += 5;
                    form1.lblPoint.Text = form1.point.ToString();
                    labelstatus.Text = form1.lblStatus.Text.ToString();
                    labelpoint.Text = form1.lblPoint.Text.ToString();
                }
                else
                {

                    MessageBox.Show("Что-то пошло не так!!");
                    form1.point -= 5;
                }
            }
            else
            {
                MessageBox.Show("Ты не достоин этого,качайся!!!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
              if (form1.status == "Настоящий программист")
            {
                Random random = new Random();
                double chance = 0.30;
                double randomValue = random.NextDouble();

                if (randomValue < chance)
                {

                    MessageBox.Show("Ты взломал зону 51!");
                    form1.point += 10;
                    form1.lblPoint.Text = form1.point.ToString();
                    labelstatus.Text = form1.lblStatus.Text.ToString();
                    labelpoint.Text = form1.lblPoint.Text.ToString();
                }
                else
                {

                    MessageBox.Show("Что-то пошло не так!!");
                    form1.point -= 5;
                }
            }
            else
            {
                MessageBox.Show("Ты не достоин этого,качайся!!!");
            }
        }

        private void labelpoint_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
