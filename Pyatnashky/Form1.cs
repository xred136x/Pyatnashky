using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pyatnashky
{
    public partial class Form1 : Form
    {
        
        
        static Random rand = new Random();
        public Form1()
        {
            InitializeComponent();           
        }
        
        public void BtnSpace()
        {
            Button[] buttons = Controls.OfType<Button>().ToArray();
            for (int i = 0; i < 17; i++)
            {
               if(buttons[i].Text == "0")
                    buttons[i].Visible = false;
               if(buttons[i].Text != "0")
                    buttons[i].Visible = true;
            }         
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void GameOver()
        {
            string win = "You Win!";
            List<Button> buttons = new List<Button> { button0, button1, button2, button3,
                button4, button5, button6, button7, button8, button9, button10, button11,
                button12, button13, button14, button15 };
            if (button0.Text == "0")
            {
                int count = 0;
                for(int i = 0; i < buttons.Count; i++)
                {
                    if (i.ToString() == buttons[i].Text)
                        count++;
                }
                if (count == 16)
                    MessageBox.Show(win);
            }
            
        }
        private void button15_Click(object sender, EventArgs e)
        {
            string num = "";
            if (button15.Text != "0" && button0.Text == "0")
            {
                num = button15.Text;
                button15.Text = button0.Text;
                button0.Text = num;
                
            }
            if (button15.Text != "0" && button14.Text == "0")
            {
                num = button15.Text;
                button15.Text = button14.Text;
                button14.Text = num;
            }
            if (button15.Text != "0" && button11.Text == "0")
            {
                num = button15.Text;
                button15.Text = button11.Text;
                button11.Text = num;
            }
            BtnSpace();
            GameOver();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string num = "";
            if (button14.Text != "0" && button15.Text == "0")
            {
                num = button14.Text;
                button14.Text = button15.Text;
                button15.Text = num;
            }
            if (button14.Text != "0" && button13.Text == "0")
            {
                num = button14.Text;
                button14.Text = button13.Text;
                button13.Text = num;
            }
            if (button14.Text != "0" && button10.Text == "0")
            {
                num = button14.Text;
                button14.Text = button10.Text;
                button10.Text = num;
            }
            BtnSpace();
            GameOver();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string num = "";
            if (button13.Text != "0" && button9.Text == "0")
            {
                num = button13.Text;
                button13.Text = button9.Text;
                button9.Text = num;
            }
            if (button13.Text != "0" && button14.Text == "0")
            {
                num = button13.Text;
                button13.Text = button14.Text;
                button14.Text = num;
            }
            BtnSpace();
            GameOver();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string num = "";
            if (button9.Text != "0" && button5.Text == "0")
            {
                num = button9.Text;
                button9.Text = button5.Text;
                button5.Text = num;
            }
            if (button9.Text != "0" && button10.Text == "0")
            {
                num = button9.Text;
                button9.Text = button10.Text;
                button10.Text = num;
            }
            if (button9.Text != "0" && button13.Text == "0")
            {
                num = button9.Text;
                button9.Text = button13.Text;
                button13.Text = num;
            }
            BtnSpace();
            GameOver();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string num = "";
            if (button10.Text != "0" && button11.Text == "0")
            {
                num = button10.Text;
                button10.Text = button11.Text;
                button11.Text = num;
            }
            if (button10.Text != "0" && button9.Text == "0")
            {
                num = button10.Text;
                button10.Text = button9.Text;
                button9.Text = num;
            }
            if (button10.Text != "0" && button14.Text == "0")
            {
                num = button10.Text;
                button10.Text = button14.Text;
                button14.Text = num;
            }
            if (button10.Text != "0" && button6.Text == "0")
            {
                num = button10.Text;
                button10.Text = button6.Text;
                button6.Text = num;
            }
            BtnSpace();
            GameOver();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string num = "";
            if (button11.Text != "0" && button12.Text == "0")
            {
                num = button11.Text;
                button11.Text = button12.Text;
                button12.Text = num;
            }
            if (button11.Text != "0" && button10.Text == "0")
            {
                num = button11.Text;
                button11.Text = button10.Text;
                button10.Text = num;
            }
            if (button11.Text != "0" && button15.Text == "0")
            {
                num = button11.Text;
                button11.Text = button15.Text;
                button15.Text = num;
            }
            if (button11.Text != "0" && button7.Text == "0")
            {
                num = button11.Text;
                button11.Text = button7.Text;
                button7.Text = num;
            }
            BtnSpace();
            GameOver();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string num = "";
            if (button12.Text != "0" && button11.Text == "0")
            {
                num = button12.Text;
                button12.Text = button11.Text;
                button11.Text = num;
            }
            if (button12.Text != "0" && button0.Text == "0")
            {
                num = button12.Text;
                button12.Text = button0.Text;
                button0.Text = num;
            }
            if (button12.Text != "0" && button8.Text == "0")
            {
                num = button12.Text;
                button12.Text = button8.Text;
                button8.Text = num;
            }
            BtnSpace();
            GameOver();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string num = "";
            if (button8.Text != "0" && button12.Text == "0")
            {
                num = button8.Text;
                button8.Text = button12.Text;
                button12.Text = num;
            }
            if (button8.Text != "0" && button7.Text == "0")
            {
                num = button8.Text;
                button8.Text = button7.Text;
                button7.Text = num;
            }
            if (button8.Text != "0" && button4.Text == "0")
            {
                num = button8.Text;
                button8.Text = button4.Text;
                button4.Text = num;
            }
            BtnSpace();
            GameOver();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string num = "";
            if (button7.Text != "0" && button6.Text == "0")
            {
                num = button7.Text;
                button7.Text = button6.Text;
                button6.Text = num;
            }
            if (button7.Text != "0" && button8.Text == "0")
            {
                num = button7.Text;
                button7.Text = button8.Text;
                button8.Text = num;
            }
            if (button7.Text != "0" && button3.Text == "0")
            {
                num = button7.Text;
                button7.Text = button3.Text;
                button3.Text = num;
            }
            if (button7.Text != "0" && button11.Text == "0")
            {
                num = button7.Text;
                button7.Text = button11.Text;
                button11.Text = num;
            }
            BtnSpace();
            GameOver();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string num = "";
            if (button6.Text != "0" && button7.Text == "0")
            {
                num = button6.Text;
                button6.Text = button7.Text;
                button7.Text = num;
            }
            if (button6.Text != "0" && button5.Text == "0")
            {
                num = button6.Text;
                button6.Text = button5.Text;
                button5.Text = num;
            }
            if (button6.Text != "0" && button2.Text == "0")
            {
                num = button6.Text;
                button6.Text = button2.Text;
                button2.Text = num;
            }
            if (button6.Text != "0" && button10.Text == "0")
            {
                num = button6.Text;
                button6.Text = button10.Text;
                button10.Text = num;
            }
            BtnSpace();
            GameOver();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string num = "";
            if (button5.Text != "0" && button6.Text == "0")
            {
                num = button5.Text;
                button5.Text = button6.Text;
                button6.Text = num;
            }
            if (button5.Text != "0" && button1.Text == "0")
            {
                num = button5.Text;
                button5.Text = button1.Text;
                button1.Text = num;
            }
            if (button5.Text != "0" && button9.Text == "0")
            {
                num = button5.Text;
                button5.Text = button9.Text;
                button9.Text = num;
            }
            BtnSpace();
            GameOver();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string num = "";
            if (button1.Text != "0" && button5.Text == "0")
            {
                num = button1.Text;
                button1.Text = button5.Text;
                button5.Text = num;
            }
            if (button1.Text != "0" && button2.Text == "0")
            {
                num = button1.Text;
                button1.Text = button2.Text;
                button2.Text = num;
            }
            BtnSpace();
            GameOver();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string num = "";
            if (button2.Text != "0" && button1.Text == "0")
            {
                num = button2.Text;
                button2.Text = button1.Text;
                button1.Text = num;
            }
            if (button2.Text != "0" && button3.Text == "0")
            {
                num = button2.Text;
                button2.Text = button3.Text;
                button3.Text = num;
            }
            if (button2.Text != "0" && button6.Text == "0")
            {
                num = button2.Text;
                button2.Text = button6.Text;
                button6.Text = num;
            }
            BtnSpace();
            GameOver();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string num = "";
            if (button3.Text != "0" && button4.Text == "0")
            {
                num = button3.Text;
                button3.Text = button4.Text;
                button4.Text = num;
            }
            if (button3.Text != "0" && button2.Text == "0")
            {
                num = button3.Text;
                button3.Text = button2.Text;
                button2.Text = num;
            }
            if (button3.Text != "0" && button7.Text == "0")
            {
                num = button3.Text;
                button3.Text = button7.Text;
                button7.Text = num;
            }
            BtnSpace();
            GameOver();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string num = "";
            if (button4.Text != "0" && button3.Text == "0")
            {
                num = button4.Text;
                button4.Text = button3.Text;
                button3.Text = num;
            }
            if (button4.Text != "0" && button8.Text == "0")
            {
                num = button4.Text;
                button4.Text = button8.Text;
                button8.Text = num;
            }
            BtnSpace();
            GameOver();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            string num = "";
            if (button0.Text != "0" && button12.Text == "0")
            {
                num = button0.Text;
                button0.Text = button12.Text;
                button12.Text = num;
            }
            if (button0.Text != "0" && button15.Text == "0")
            {
                num = button0.Text;
                button0.Text = button15.Text;
                button15.Text = num;
            }
            BtnSpace();
            GameOver();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            string num = "";
            List<Button> buttons = new List<Button> { button1, button2, button3, 
                button4, button5, button6, button7, button8, button9, button10, button11,
                button12, button13, button14, button15, button0};
           for (int j = 0; j < 20; j++)
           for (int i = 0; i < buttons.Count; i++)
           {               
                int a = rand.Next(0, 4);
                switch (a)
                {
                    case 0:
                        if (buttons[i].Text == "0" && buttons[i] != button15)
                        {
                            num = buttons[i].Text;
                            buttons[i].Text = buttons[i + 1].Text;
                            buttons[i + 1].Text = num;
                        } break;
                        
                    case 1:
                        if (buttons[i].Text == "0" && buttons[i] != button1)
                        {
                            num = buttons[i].Text;
                            buttons[i].Text = buttons[i - 1].Text;
                            buttons[i - 1].Text = num;
                        }; break;
                    case 2:
                        if (buttons[i].Text == "0" && buttons[i] != button1 && buttons[i] != button2 && 
                            buttons[i] != button3 && buttons[i] != button4)
                        {
                            num = buttons[i].Text;
                            buttons[i].Text = buttons[i - 4].Text;
                            buttons[i - 4].Text = num;
                        }; break;
                    case 3:
                        if (buttons[i].Text == "0" && buttons[i] != button12 && buttons[i] != button13 &&
                            buttons[i] != button14 && buttons[i] != button15)
                        {
                            num = buttons[i].Text;
                            buttons[i].Text = buttons[i + 4].Text;
                            buttons[i + 4].Text = num;
                        }; break;
                   
                }
           }
            BtnSpace();
            GameOver();
        }
    }
}
