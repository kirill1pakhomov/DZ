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
    public partial class вирус : Form
    {
        private Form1 form1;


        public вирус(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (form1.softlvl == 1)
            {
                Random random = new Random();
                double chance = 0.40;
                double randomValue = random.NextDouble();

                if (randomValue < chance)
                {

                    MessageBox.Show("Ты уничтожил вирус!");
                    form1.point += 5;
                    form1.lblPoint.Text = form1.point.ToString();

                }
                else
                {

                    MessageBox.Show("Вирус оказался сильнее,но ты ничего не потерял");
                    
                }
            }



           else if (form1.status == "Мамин программист")
            {
                Random random = new Random();
                double chance = 0.60;
                double randomValue = random.NextDouble();

                if (randomValue < chance)
                {

                    MessageBox.Show("Мамин программист,ты уничтожил вирус!");
                    form1.point += 3;
                    form1.lblPoint.Text = form1.point.ToString();

                }
                else
                {

                    MessageBox.Show("Мамин программист.Вирус оказался сильнее,твои очки уменьшены на 3");
                    form1.point -= 3;
                    form1.lblPoint.Text = form1.point.ToString();

                }
            }
            else if (form1.status == "Почти программист")
            {
                Random random = new Random();
                double chance = 0.80;
                double randomValue = random.NextDouble();

                if (randomValue < chance)
                {

                    MessageBox.Show("Почти программист.Ты уничтожил вирус!");
                    form1.point += 2;
                    form1.lblPoint.Text = form1.point.ToString();

                }
                else
                {

                    MessageBox.Show("Почти программист.Ты не справился с вирусом,твои очки уменьшены на 7 и уровень софта снижен на 1");
                    form1.point -= 7;
                    form1.softlvl -= 1;
                    form1.lblPoint.Text = form1.point.ToString();
                    form1.lblSoft.Text = form1.softlvl.ToString();

                }
            }
            else if (form1.status == "Программист")
            {
                Random random = new Random();
                double chance = 0.90;
                double randomValue = random.NextDouble();

                if (randomValue < chance)
                {

                    MessageBox.Show("Программист.Ты уничтожил вирус!");
                    form1.point += 1;
                    form1.lblPoint.Text = form1.point.ToString();

                }
                else
                {

                    MessageBox.Show("Программист.ты не справились с вирусом,твои очки уменьшены на 9 и уровень софта снижен на 1");
                    form1.point -= 9;
                    form1.softlvl -= 1;
                    form1.lblPoint.Text = form1.point.ToString();
                    form1.lblSoft.Text = form1.softlvl.ToString();

                }
            }
           this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (form1.softlvl == 1)
            {
                Random random = new Random();
                double chance = 0.90;
                double randomValue = random.NextDouble();

                if (randomValue < chance)
                {

                    MessageBox.Show("Тебе повезло,вирус пожалел тебя!");
                    form1.point += 5;
                    form1.lblPoint.Text = form1.point.ToString();

                }
                else
                {

                    MessageBox.Show("Ты не справился с вирусом,но ты ничего не потерял");

                }

            }



            else if (form1.softlvl==2)
            {
                Random random = new Random();
                double chance = 0.60;
                double randomValue = random.NextDouble();

                if (randomValue < chance)
                {

                    MessageBox.Show("Тебе повезло,вирус пожалел тебя!");
                    

                }
                else
                {

                    MessageBox.Show("Ты не справился с вирусом,твои очки уменьшены на 3");
                    form1.point -= 3;
                    form1.lblPoint.Text = form1.point.ToString();
                    form1.lblPoint.Text = form1.point.ToString();
                    form1.lblSoft.Text = form1.softlvl.ToString();

                }
            }
            else if (form1.softlvl ==3)
            {
                Random random = new Random();
                double chance = 0.40;
                double randomValue = random.NextDouble();

                if (randomValue < chance)
                {

                    MessageBox.Show("Тебе повезло,вирус пожалел тебя!");
                    

                }
                else
                {

                    MessageBox.Show("Ты не справился с вирусом,твои очки уменьшены на 7 и уровень софта снижен на 1");
                    form1.point -= 7;
                    form1.softlvl -= 1;
                    form1.lblPoint.Text = form1.point.ToString();
                    form1.lblSoft.Text = form1.softlvl.ToString();


                }
            }
            else if (form1.softlvl ==4)
            {
                Random random = new Random();
                double chance = 0.20;
                double randomValue = random.NextDouble();

                if (randomValue < chance)
                {

                    MessageBox.Show("Тебе повезло,вирус пожалел тебя!");
                   

                }
                else
                {

                    MessageBox.Show("Ты не справился с вирусом,твои очки уменьшены на 9 и уровень софта снижен на 1");
                    form1.point -= 9;
                    form1.softlvl -= 1;
                    form1.lblPoint.Text = form1.point.ToString();
                    form1.lblSoft.Text = form1.softlvl.ToString();

                }
            }
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
