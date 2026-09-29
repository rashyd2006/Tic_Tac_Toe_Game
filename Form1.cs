using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp7.Properties;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int Count = 0;
        private void RestartGame()
        {
            Count = 0;

            button2.BackgroundImage = Image.FromFile(@"c:\question-mark-96.png");
            button2.Tag = "?";
            button2.BackColor = Color.Black;

            button3.BackgroundImage = Image.FromFile(@"c:\question-mark-96.png");
            button3.Tag = "?";
            button3.BackColor = Color.Black;

            button4.BackgroundImage = Image.FromFile(@"c:\question-mark-96.png");
            button4.Tag = "?";
            button4.BackColor = Color.Black;

            button5.BackgroundImage = Image.FromFile(@"c:\question-mark-96.png");
            button5.Tag = "?";
            button5.BackColor = Color.Black;

            button6.BackgroundImage = Image.FromFile(@"c:\question-mark-96.png");
            button6.Tag = "?";
            button6.BackColor = Color.Black;

            button7.BackgroundImage = Image.FromFile(@"c:\question-mark-96.png");
            button7.Tag = "?";
            button7.BackColor = Color.Black;

            button8.BackgroundImage = Image.FromFile(@"c:\question-mark-96.png");
            button8.Tag = "?";
            button8.BackColor = Color.Black;

            button9.BackgroundImage = Image.FromFile(@"c:\question-mark-96.png");
            button9.Tag = "?";
            button9.BackColor = Color.Black;

            button10.BackgroundImage = Image.FromFile(@"c:\question-mark-96.png");
            button10.Tag = "?";
            button10.BackColor = Color.Black;



            label4.Text = "Player1";
            label5.Text = "In Progress";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color whiteColor = Color.White;
            Pen myPen = new Pen(whiteColor);
            myPen.Width = 10;
            // رسم الخطين الأفقيين (إزاحة كبيرة لليسار)
            e.Graphics.DrawLine(myPen, 190, 240, 670, 240);
            e.Graphics.DrawLine(myPen, 190, 400, 670, 400);

            // رسم الخطين العموديين (إزاحة كبيرة لليسار)
            e.Graphics.DrawLine(myPen, 360, 80, 360, 560);
            e.Graphics.DrawLine(myPen, 520, 80, 520, 560);
        }

        private void AnnounceWinneer(Button b1, Button b2, Button b3, string winningTag)
        {
            b1.BackColor = Color.Yellow;
            b2.BackColor = Color.Yellow;
            b3.BackColor = Color.Yellow;

            string winner = (winningTag == "X") ? "Player1" : "Player2";
            label5.Text = winner + "wins!";

            MessageBox.Show(winner + " Wins!", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void CheckGameState()
        {
            Button[,] winningLines = new Button[,]
            {
          { button2, button3, button4 }, // الصف الأول
          { button5, button6, button7 }, // الصف الثاني
          { button8, button9, button10 }, // الصف الثالث
          { button2, button5, button8 }, // العمود الأول
          { button3, button6, button9 }, // العمود الثاني
          { button4, button7, button10 }, // العمود الثالث
          { button2, button6, button10 }, // القطر الأول
          { button4, button6, button8 }  // القطر الثاني
            };

            bool WinnerFound = false;

            for (int i = 0; i < 8; i++)
            {
                Button b1 = winningLines[i, 0];
                Button b2 = winningLines[i, 1];
                Button b3 = winningLines[i, 2];

                if (b1.Tag.ToString() != "?" && b1.Tag.ToString() == b2.Tag.ToString() && b2.Tag.ToString() == b3.Tag.ToString())
                {
                    WinnerFound = true;
                    AnnounceWinneer(b1, b2, b3, b1.Tag.ToString());
                    return;
                }

                if(!WinnerFound && Count == 9)
                {
                    MessageBox.Show("Draw!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }


    }

}