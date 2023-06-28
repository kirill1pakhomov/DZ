using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         int time = 0;
        public int day = 1;
        int pay = 0;
        public int money = 100;
        public int point = 0;
        public string status;
        public int HidenPoint =10;
        public int pc = 1;
        public int softlvl = 1;
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            
            time++;
            lbltime.Text = time.ToString();
            label2.Text = day.ToString();
            lblPoint.Text = point.ToString();

            // статус

            if (point == 10 && point <= 20)
            {
                lblStatus.Text = "Никто"
                    ;
                status = "Никто";
            }
            else if (point >= 21 && point <=30)
            {
                lblStatus.Text = "Мамкин программист";
                status = "Мамкин программист";
            }
            else if (point >= 31 && point <= 39)
            {
                lblStatus.Text = "Почти программист";
                status = "Почти программист";
            }
            else if (point >= 40 && point <= 31000)
            {
                lblStatus.Text = "Программист";
                status = "Программист";
            }


            while (time==23)
            {
                time = 0;
                day++;
                money += pay;
                lblMoney.Text = money.ToString();
                lblPoint.Text = point.ToString();

                // налоги 
               
                    if (day == 30)
                    {
                        money -= 100;
                    lblMoney.Text = money.ToString();
                    MessageBox.Show("Налог никто не отменял,100$ на базу","налог");
                }
                    else if (day == 60)
                    {
                        money -= 100;
                    lblMoney.Text = money.ToString();
                    MessageBox.Show("Налог никто не отменял,100$ на базу", "налог");
                }
                    else if (day == 90)
                    {
                        money -= 100;
                    lblMoney.Text = money.ToString();
                    MessageBox.Show("Налог никто не отменял,100$ на базу", "налог");
                }
                    else if (day == 120)
                    {
                        money -= 100;
                    lblMoney.Text = money.ToString();
                    MessageBox.Show("Налог никто не отменял,100$ на базу", "налог");
                }
                    else if (day == 150)
                    {
                        money -= 100;
                    lblMoney.Text = money.ToString();
                    MessageBox.Show("Налог никто не отменял,100$ на базу", "налог");
                }

                //вирус
                вирус vs = new вирус(this);
                if (day == 5)
                {
                    vs.Show();
                }
                else if (day == 10)
                {
                    vs.Show();
                }
                else if (day == 15)
                {
                    vs.Show();
                }
                else if (day == 20)
                {
                    vs.Show();
                }
                else if (day == 25)
                {
                    vs.Show();
                }






                //настроение
                HidenPoint--;
                if (HidenPoint == 0)
                {
                    MessageBox.Show("Ты умер,стресс ни кого не щадит", "Проигрыш");
                    Application.Exit();
                }

                if (HidenPoint <= 5)
                    {
                        lblNastr.Text = "Плохое";
                    
                    }
             
            }
           


            if (HidenPoint >= 10)
            {
                lblNastr.Text = "Нормальное";

            }
            if (HidenPoint >= 15)
            {
                lblNastr.Text = "Хорошее";

            }
            if (HidenPoint >= 20)
            {
                lblNastr.Text = "Отличное";

            }


            if (lblJob.Text == "Дворник /10$ день")
            {
                pay = 10;
                
                
            }
            if (lblJob.Text == "Строитель/30$ день")
            {
                pay = 30;
            }
            
            if (lblJob.Text == "Фриланс/50$ день")
            {
                pay = 50;
            }
            if (lblJob.Text == "Программист/100$ день")
            {
                pay = 100;
            }

            

        }
        public void ChangeLabelText(string text)
        {
            lblJob.Text = text;
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMoney.Text = money.ToString();
            lblPoint.Text = point.ToString();
            timer1.Start();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            работа job = new работа(this);
            job.Show();
           
        }
        public void ChangeLabel(string text)
        {
            lblJob.Text = text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            прокачка up = new прокачка(this);
            up.Show();
        }

        private void lblLvl_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Развлечения vp = new Развлечения(this);
            vp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            софт sf = new софт(this);
            sf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            хакер hc = new хакер(this);
            hc.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            кликер mm = new кликер(this);
            mm.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
