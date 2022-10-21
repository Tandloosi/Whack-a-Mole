



using System.Xml.Linq;

namespace Whack_a_Mole
    
{
    public partial class Form1 : Form
    {
        int TimeBetweenMoles = 1000000000;

        int grnbtn = 0;
        int var = 1;
        int score;
        









        public Form1()
        {
            InitializeComponent();
        }

 

        public void Form1_Load(object sender, EventArgs e)
        {
            



        }

        public void btn1_Click(object sender, EventArgs e)
        {
            var = 1;
            
            if (grnbtn == 1)
            {
                score++;
            }
            if (grnbtn != 1)
            {
                score--;
            }
            lbl2.Text = score.ToString();

            
        }

        public void btn2_Click(object sender, EventArgs e)
        {
            var = 1;

            if (grnbtn == 2)
            {
                score++;
            }
            if (grnbtn != 2)
            {
                score--;
            }
            lbl2.Text = score.ToString();

            
        }

        public void btn3_Click(object sender, EventArgs e)
        {
            var = 1;

            if (grnbtn == 3)
            {
                score++;
            }
            if (grnbtn != 3)
            {
                score--;
            }
            lbl2.Text = score.ToString();

            
        }

        public void btn4_Click(object sender, EventArgs e)
        {
            var = 1;

            if (grnbtn == 4)
            {
                score++;
            }
            if (grnbtn != 4)
            {
                score--;
            }
            lbl2.Text = score.ToString();

            
        }

        public void btn5_Click(object sender, EventArgs e)
        {
            var = 1;

            if (grnbtn == 5)
            {
                score++;
            }
            if (grnbtn != 5)
            {
                score--;
            }
            lbl2.Text = score.ToString();

            
        }

        public void btn6_Click(object sender, EventArgs e)
        {
            var = 1;

            if (grnbtn == 6)
            {
                score++;
            }
            if (grnbtn != 6)
            {
                score--;
            }
            lbl2.Text = score.ToString();

           

            
        }

        public void btn7_Click(object sender, EventArgs e)
        {
            var = 1;

            if (grnbtn == 7)
            {
                score++;
            }
            if (grnbtn != 7)
            {
                score--;
            }
            lbl2.Text = score.ToString();

            

            
        }

        public void btn8_Click(object sender, EventArgs e)
        {
            var = 1;

            if (grnbtn == 8)
            {
                score++;
            }
            if (grnbtn != 8)
            {
                score--;
            }
            lbl2.Text = score.ToString();

           

            
        }

        public void btn9_Click(object sender, EventArgs e)
        {
            var = 1;

            if (grnbtn == 9)
            {
                score++;
            }
            if (grnbtn != 9)
            {
                score--;
            }
            lbl2.Text = score.ToString();
            
            
            

        }

        public void btnEasy_Click(object sender, EventArgs e)
        {
            TimeBetweenMoles = 2000;
            tmr1.Interval = TimeBetweenMoles;
        }

        public void btnMedium_Click(object sender, EventArgs e)
        {
            TimeBetweenMoles = 1000;
            tmr1.Interval = TimeBetweenMoles;
        }

        public void tmr1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            grnbtn = rnd.Next(1,9);

            

            if (grnbtn == 1)
            {
                this.btn1.BackgroundImage = Properties.Resources.whackamoleup;
            }
            if (grnbtn != 1)
            {
                this.btn1.BackgroundImage = Properties.Resources.whackamoledown;
            }

            if (grnbtn == 2)
            {
                this.btn2.BackgroundImage = Properties.Resources.whackamoleup;
            }
            if (grnbtn != 2)
            {
                this.btn2.BackgroundImage = Properties.Resources.whackamoledown;
            }

            if (grnbtn == 3)
            {
                this.btn3.BackgroundImage = Properties.Resources.whackamoleup;
            }
            if (grnbtn != 3)
            {
                this.btn3.BackgroundImage = Properties.Resources.whackamoledown;
            }

            if (grnbtn == 4)
            {
                this.btn4.BackgroundImage = Properties.Resources.whackamoleup;
            }
            if (grnbtn != 4)
            {
                this.btn4.BackgroundImage = Properties.Resources.whackamoledown;
            }

            if (grnbtn == 5)
            {
                this.btn5.BackgroundImage = Properties.Resources.whackamoleup;
            }
            if (grnbtn != 5)
            {
                this.btn5.BackgroundImage = Properties.Resources.whackamoledown;
            }

            if (grnbtn == 6)
            {
                this.btn6.BackgroundImage = Properties.Resources.whackamoleup;
            }
            if (grnbtn != 6)
            {
                this.btn6.BackgroundImage = Properties.Resources.whackamoledown;
            }

            if (grnbtn == 7)
            {
                this.btn7.BackgroundImage = Properties.Resources.whackamoleup;
            }
            if (grnbtn != 7)
            {
                this.btn7.BackgroundImage = Properties.Resources.whackamoledown;
            }

            if (grnbtn == 8)
            {
                this.btn8.BackgroundImage = Properties.Resources.whackamoleup;
            }
            if (grnbtn != 8)
            {
                this.btn8.BackgroundImage = Properties.Resources.whackamoledown;
            }

            if (grnbtn == 9)
            {
                this.btn9.BackgroundImage = Properties.Resources.whackamoleup;
            }
            if (grnbtn != 9)
            {
                this.btn9.BackgroundImage = Properties.Resources.whackamoledown;
            }

        }

        public void btnHard_Click(object sender, EventArgs e)
        {
            TimeBetweenMoles = 500;
            tmr1.Interval = TimeBetweenMoles;
           
        }

        public void btnStart_Click(object sender, EventArgs e)
        {
            /*  do
              {
                  btn1.BackColor = Color.Green;

              } while (grnbtn == 1);
              do
              {
                  btn1.BackColor = Color.Red;

              } while (grnbtn != 1);

              do
              {
                  btn2.BackColor = Color.Green;

              } while (grnbtn == 2);
              do
              {
                  btn2.BackColor = Color.Red;

              } while (grnbtn != 2);

              do
              {
                  btn3.BackColor = Color.Green;

              } while (grnbtn == 3);
              do
              {
                  btn3.BackColor = Color.Red;

              } while (grnbtn != 3);

              do
              {
                  btn4.BackColor = Color.Green;

              } while (grnbtn == 4);
              do
              {
                  btn4.BackColor = Color.Red;

              } while (grnbtn != 4);

              do
              {
                  btn5.BackColor = Color.Green;

              } while (grnbtn == 5);
              do
              {
                  btn5.BackColor = Color.Red;

              } while (grnbtn != 5);

              do
              {
                  btn6.BackColor = Color.Green;

              } while (grnbtn == 6);
              do
              {
                  btn6.BackColor = Color.Red;

              } while (grnbtn != 6);

              do
              {
                  btn7.BackColor = Color.Green;

              } while (grnbtn == 7);
              do
              {
                  btn7.BackColor = Color.Red;

              } while (grnbtn != 7);

              do
              {
                  btn8.BackColor = Color.Green;

              } while (grnbtn == 8);
              do
              {
                  btn8.BackColor = Color.Red;

              } while (grnbtn != 8);

              do
              {
                  btn9.BackColor = Color.Green;

              } while (grnbtn == 9);
              do
              {
                  btn9.BackColor = Color.Red;

              } while (grnbtn != 9);
            

           
            do
            {
                if (grnbtn == 1)
                {
                    btn1.BackColor = Color.Green;
                }
                if (grnbtn != 1)
                {
                    btn1.BackColor = Color.Red;
                }

                if (grnbtn == 2)
                {
                    btn2.BackColor = Color.Green;
                }
                if (grnbtn != 2)
                {
                    btn2.BackColor = Color.Red;
                }

                if (grnbtn == 3)
                {
                    btn3.BackColor = Color.Green;
                }
                if (grnbtn != 3)
                {
                    btn3.BackColor = Color.Red;
                }

                if (grnbtn == 4)
                {
                    btn4.BackColor = Color.Green;
                }
                if (grnbtn != 4)
                {
                    btn4.BackColor = Color.Red;
                }

                if (grnbtn == 5)
                {
                    btn5.BackColor = Color.Green;
                }
                if (grnbtn != 5)
                {
                    btn5.BackColor = Color.Red;
                }

                if (grnbtn == 6)
                {
                    btn6.BackColor = Color.Green;
                }
                if (grnbtn != 6)
                {
                    btn6.BackColor = Color.Red;
                }

                if (grnbtn == 7)
                {
                    btn7.BackColor = Color.Green;
                }
                if (grnbtn != 7)
                {
                    btn7.BackColor = Color.Red;
                }

                if (grnbtn == 8)
                {
                    btn8.BackColor = Color.Green;
                }
                if (grnbtn != 8)
                {
                    btn8.BackColor = Color.Red;
                }

                if (grnbtn == 9)
                {
                    btn9.BackColor = Color.Green;
                }
                if (grnbtn != 9)
                {
                    btn9.BackColor = Color.Red;
                }
                var = 0;

            } while (var == 1);
            */



        }
    }
}