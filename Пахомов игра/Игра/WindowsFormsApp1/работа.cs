using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    public partial class работа : Form
    {
       
        private Form1 form1;
        bool button1Clicked = false;
       
        bool button2Clicked = false;
        bool button3Clicked = false;
        bool button4Clicked = false;

        public работа(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            if(!button1Clicked)
            {
                button1.Enabled = true;
            }
            else //if (button1Clicked) 
            { 
            button1.Enabled=false;
            }
            if (form1.point >= 21 && !button2Clicked)
            {
                button2.Enabled = true;
            }
            else //if (form1.point < 20 || button2Clicked)
            {
                button2.Enabled = false;
            }
            if (form1.point >= 31)
            {
                button3.Enabled = true;
            }
            else //if (form1.point < 30)
            {
                button3.Enabled = false;
            }
            if (form1.point >= 40)
            {
                button4.Enabled = true;
            }
            else //if (form1.point < 39)
            {
                button4.Enabled = false;
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void jobcs_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button1.Click += delegate {

                if (!button1Clicked)
                {
                    form1.ChangeLabel("Дворник /10$ день");
            form1.point += 10;
            button1.Enabled= false;

                    button1Clicked = true;
                }
                if(button1Clicked == true)
                {

                    button1.Enabled = false;
                }
            //};

        }

        private void button2_Click(object sender, EventArgs e)
        {
           // button2.Click += delegate {
                
                if (!button2Clicked && form1.point >= 21)
                {
                    
                    form1.ChangeLabel("Строитель/30$ день");
                    form1.point += 5;
                    button2.Enabled = false;
                    
                    button2Clicked = true;
                }
                else
                {
                    
                    button2.Enabled = false;
                }
           // };
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // button3.Click += delegate {

                if (!button3Clicked && form1.point >= 31)
                {
                    form1.ChangeLabel("Фриланс/50$ день");
            form1.point += 10;
            button3.Enabled = false;
                    button3Clicked = true;
                }
                else
                {

                    button3.Enabled = false;
                }
           // };
        }

        private void button4_Click(object sender, EventArgs e)
        {
           // button4.Click += delegate {

                if (!button4Clicked && form1.point >= 40)
                {
                    form1.ChangeLabel("Программист/100$ день");
            form1.point += 5;
            button4.Enabled = false;
                    button4Clicked = true;
                }
                else
                {

                    button4.Enabled = false;
                }
           // };

        }
        

    }

}
