using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XandO
{
    public partial class Form1 : Form
    {
        bool restart;
        bool xTurn = true;
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button_Click(object sender, EventArgs e)
        {
            Button sender1 = (Button)sender;
            if(xTurn)
            {
               sender1.Text = "X";
            }
            else
            {
                sender1.Text = "O";
            }
            count++;
            xTurn = !xTurn;
            sender1.Enabled = false;
            restart = true;
            winer(sender1);
        }

        void winer(Button pressBtn)
        {
            if ((button1.Text==button2.Text&& button2.Text== button3.Text&& button2.Enabled == false)|| 
                    (button4.Text == button5.Text && button5.Text == button6.Text && button5.Enabled == false)||
                    (button7.Text == button8.Text && button8.Text == button9.Text && button8.Enabled == false)||
                    (button1.Text == button5.Text && button5.Text == button9.Text && button5.Enabled == false)||
                    (button3.Text == button5.Text && button5.Text == button7.Text && button5.Enabled == false)||
                    (button1.Text == button4.Text && button4.Text == button7.Text && button4.Enabled == false)||
                    (button2.Text == button5.Text && button5.Text == button8.Text && button5.Enabled == false)||
                    (button3.Text == button6.Text && button6.Text == button9.Text && button6.Enabled == false))
            {
                MessageBox.Show($"Победитель {pressBtn.Text}");
                 this.Close();

            }
            else
            {
                if (count == 9)
                {
                  MessageBox.Show($"Ничья");
                this.Close();
                }
                
            }
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (!restart)
            {
              xTurn = true;
            }
            

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!restart)
            {
                xTurn = false;
            }
        }
    }
}
