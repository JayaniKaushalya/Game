using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bgame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int speed = 3;
        int vdir = +1;
        int slide_speed = 10;
        private void vert_Tick(object sender, EventArgs e)
        {
            if (ball.Top < 0)
            {

                vdir = +1;

            }
            else if (ball.Top > (this.Height - ball.Height - slider.Height))
            {
                vdir = -1;

            }
            

            
                ball.Top += (vdir*speed);

            



        }

        int hdir = +1;
        bool _left = false, _right = false;
        private void horz_Tick(object sender, EventArgs e)
        {

            if (ball.Left < 0)
            {

                hdir = +1;

            }
            else if (ball.Left > (this.Width - ball.Width))
            {
                hdir = -1;

            }
           

            
                ball.Left += (hdir*speed); 

            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //active

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_right && slider.Left<(this.Width=slider.Width))
            {
                slider.Left =slider.Left - 10;
             

            }
            else if (_right && slider.Left > 0)
            {
                slider.Left += 10;


            }
        }
    }
}
