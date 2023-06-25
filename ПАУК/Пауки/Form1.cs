using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Пауки
{
    public partial class Form1 : Form
    {
        private int score = 0;
        private int time = 0;
        private Timer timer;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();

            CreateSpider();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++; 

            if (AreSpidersPresent() && time >= 10)
            {
                timer.Stop(); 
                MessageBox.Show("GAME OVER! Количество очков: " + score.ToString());
            }
        }



        private bool AreSpidersPresent()
        {
            foreach (Control control in this.Controls)
            {
                if (control is PictureBox && control.Tag?.ToString() == "spider")
                {
                    return true;
                }
            }
            return false;
        }


        private void Spider_Click(object sender, EventArgs e)
        {
            PictureBox spider = (PictureBox)sender;
            this.Controls.Remove(spider); 
            score++; 
            time = 0;

            
            label1.Text = "Очки: " + score.ToString();

            CreateSpider(); 
        }



        private void CreateSpider()
        {
            
            PictureBox spider = new PictureBox();
            spider.SizeMode = PictureBoxSizeMode.StretchImage;
            spider.Width = 50;
            spider.Height = 50;
            spider.Left = GetRandomNumber(0, this.ClientSize.Width - spider.Width);
            spider.Top = GetRandomNumber(0, this.ClientSize.Height - spider.Height);
            List<Image> spiderImages = new List<Image>()
             {
               Properties.Resources.spider_image1,
               Properties.Resources.spider_image2,
               Properties.Resources.spider_image3,
             };
            Random random = new Random();
            int index = random.Next(spiderImages.Count);
            spider.Image = spiderImages[index];

            spider.Tag = "spider";
            spider.Click += new EventHandler(Spider_Click);
            this.Controls.Add(spider);
        }





        private int GetRandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            score = 0;
            time = 0;
            foreach (Control control in this.Controls)
            {
                if (control is PictureBox && control.Tag?.ToString() == "spider")
                {
                    this.Controls.Remove(control);
                    control.Dispose();
                }
            }

            CreateSpider();
            timer.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
