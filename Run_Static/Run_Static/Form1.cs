using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Run_Static
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
            int min = 1;//задаем время старта на таймере
            int sec = 0;
            private void timer1_Tick(object sender, EventArgs e)
            {
                if (timer1.Enabled)
                {
                    label2.Visible = true;

                    if (sec > 0)
                    {

                        sec--;

                        if (sec < 10)
                            labelSec.Text = "0" + sec.ToString();
                        else
                            labelSec.Text = sec.ToString();

                    }
                    else
                    {
                        if (min > 0)
                        {
                            min--;
                            if (min < 10)
                                labelMin.Text = "0" + min.ToString();
                            else
                                labelMin.Text = min.ToString();
                            sec = 59;
                            labelSec.Text = "59";
                        }
                        else
                        {
                            min = 0;
                            labelMin.Text = "00";

                        }

                    }

                }

                if (min == 0 && sec == 0)
                {
                    timer1.Enabled = false;
                    if (MessageBox.Show("Відведений час вичерпано.\n Спробуйте наступного разу.") == DialogResult.OK)
                        Application.Exit();
                }
            
            }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                
                btnStop.Text = "Start";
                timer1.Enabled = false;
                
            }
            else
            {
                
                btnStop.Text = "Stop";
                timer1.Enabled = true;

            }
        }

        private void btnStop_MouseMove(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            btnStop.Left = r.Next(0, this.ClientSize.Width - btnStop.Width);
            btnStop.Top = r.Next(0, this.ClientSize.Height - btnStop.Height);

            //проверка на границы формы
            if ((btnStop.Location.X < 0 || btnStop.Location.X > ClientSize.Width - btnStop.Width) || 
                (btnStop.Location.Y < 0 || btnStop.Location.Y > ClientSize.Height - btnStop.Height))
            {
                //выводим батон в центр если вышли за приделы формы
                btnStop.Left = (ClientSize.Width - btnStop.Size.Width) / 2;
                btnStop.Top = (ClientSize.Height - btnStop.Size.Height) / 2;
            }
        }
    }
}
