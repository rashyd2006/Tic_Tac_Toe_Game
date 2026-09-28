using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int Count = 0;
        private bool IsDraw(int count)
        {
            return count == 9;
        }
        private void ShowGameOverMessage()
        {
            MessageBox.Show("GameOver", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private string GetWinnerName(int count)
        {
            return (count % 2 != 0) ? "Player1" : "Player2";
        }
        private bool IsButtonAvailable(object sender)
        {
            Button Currentbutton = (Button)sender;

            if (Currentbutton.Tag.ToString() == "?")
            {
                return true;
            }

            return false;
        }
        private void MakeMove(object sender, ref int Count)
        {
            Button Currentbutton = (Button)sender;

            Count++;

            if (Count % 2 != 0)
            {
                Currentbutton.BackgroundImage = Image.FromFile(@"c:\X.png");
                Currentbutton.Tag = "X";
                label4.Text = "Player2";
            }

            else
            {
                Currentbutton.BackgroundImage = Image.FromFile(@"c:\O.png");
                Currentbutton.Tag = "O";
                label4.Text = "Player1";
            }
        }
        private void ShowInvaildMoveMessage()
        {
            MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void PreparingAndDisplayingTheEventOnTheScreen(object sender)
        {
            if (IsButtonAvailable(sender))
            {
                MakeMove(sender, ref Count);
            }

            else
            {
                ShowInvaildMoveMessage();
            }
        }
        private void RestartGame()
        {
            Count = 0;

            button2.BackgroundImage = Image.FromFile(@"c:\question-mark-96.png");
            button2.Tag = "?";

            button3.BackgroundImage = Image.FromFile(@"c:\question-mark-96.png");
            button3.Tag = "?";

            button4.BackgroundImage = Image.FromFile(@"c:\question-mark-96.png");
            button4.Tag = "?";

            button5.BackgroundImage = Image.FromFile(@"c:\question-mark-96.png");
            button5.Tag = "?";

            button6.BackgroundImage = Image.FromFile(@"c:\question-mark-96.png");
            button6.Tag = "?";

            button7.BackgroundImage = Image.FromFile(@"c:\question-mark-96.png");
            button7.Tag = "?";

            button8.BackgroundImage = Image.FromFile(@"c:\question-mark-96.png");
            button8.Tag = "?";

            button9.BackgroundImage = Image.FromFile(@"c:\question-mark-96.png");
            button9.Tag = "?";

            button10.BackgroundImage = Image.FromFile(@"c:\question-mark-96.png");
            button10.Tag = "?";



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
        private void AnnounceWinner(Button b1, Button b2, Button b3)
        {
            b1.BackColor = Color.LightGreen;
            b2.BackColor = Color.LightGreen;
            b3.BackColor = Color.LightGreen;

            label5.Text = label4.Text;
            ShowGameOverMessage();
        }
        private void CheckToSeeIfTheGameHasEndedForTheFirstButton()
        {
            if (!IsDraw(Count))
            {
                if (Convert.ToString(button2.Tag) == Convert.ToString(button3.Tag) && Convert.ToString(button2.Tag) == Convert.ToString(button4.Tag))
                {
                    AnnounceWinner(button2, button3, button4);
                }

                else if (Convert.ToString(button2.Tag) == Convert.ToString(button6.Tag) && Convert.ToString(button2.Tag) == Convert.ToString(button10.Tag))
                {
                    AnnounceWinner(button2, button6, button10);
                }

                else if (Convert.ToString(button2.Tag) == Convert.ToString(button5.Tag) && Convert.ToString(button2.Tag) == Convert.ToString(button8.Tag))
                {
                    AnnounceWinner(button2, button5, button8);
                }
            }

            else
            {
                ShowGameOverMessage();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            PreparingAndDisplayingTheEventOnTheScreen(sender);
            CheckToSeeIfTheGameHasEndedForTheFirstButton();
        }

        private void CheckToSeeIfTheGameHasEndedForTheSecondButton()
        {
            if (!IsDraw(Count))
            {
                if (Convert.ToString(button3.Tag) == Convert.ToString(button2.Tag) && Convert.ToString(button3.Tag) == Convert.ToString(button4.Tag))
                {
                    AnnounceWinner(button2, button3, button4);
                }

                else if (Convert.ToString(button3.Tag) == Convert.ToString(button6.Tag) && Convert.ToString(button2.Tag) == Convert.ToString(button9.Tag))
                {
                    AnnounceWinner(button2, button6, button9);
                }
            }

            else
            {
                ShowGameOverMessage();
            }
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            PreparingAndDisplayingTheEventOnTheScreen(sender);
            CheckToSeeIfTheGameHasEndedForTheSecondButton();
        }

        private void CheckToSeeIfTheGameHasEndedForTheThirdButton()
        {
            if (!IsDraw(Count))
            {
                if (Convert.ToString(button4.Tag) == Convert.ToString(button3.Tag) && Convert.ToString(button4.Tag) == Convert.ToString(button2.Tag))
                {
                    AnnounceWinner(button4, button3, button2);
                }

                else if (Convert.ToString(button4.Tag) == Convert.ToString(button7.Tag) && Convert.ToString(button4.Tag) == Convert.ToString(button10.Tag))
                {
                    AnnounceWinner(button4, button7, button10);
                }

                else if(Convert.ToString(button4.Tag) == Convert.ToString(button6.Tag) && Convert.ToString(button4.Tag) == Convert.ToString(button8.Tag))
                {
                    AnnounceWinner(button4, button6, button8);
                }
            }

            else
            {
                ShowGameOverMessage();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            PreparingAndDisplayingTheEventOnTheScreen(sender);
            CheckToSeeIfTheGameHasEndedForTheThirdButton();
        }

        private void CheckToSeeIfTheGameHasEndedForTheFourthButton()
        {
            if (!IsDraw(Count))
            {
                if (Convert.ToString(button5.Tag) == Convert.ToString(button6.Tag) && Convert.ToString(button5.Tag) == Convert.ToString(button7.Tag))
                {
                    AnnounceWinner(button5, button6, button7);
                }

                else if (Convert.ToString(button5.Tag) == Convert.ToString(button2.Tag) && Convert.ToString(button5.Tag) == Convert.ToString(button8.Tag))
                {
                    AnnounceWinner(button2, button5, button8);
                }
            }

            else
            {
                ShowGameOverMessage();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            PreparingAndDisplayingTheEventOnTheScreen(sender);
            CheckToSeeIfTheGameHasEndedForTheFourthButton();
        }

        private void CheckToSeeIfTheGameHasEndedForTheFifthButton()
        {
            if (!IsDraw(Count))
            {
                if (Convert.ToString(button6.Tag) == Convert.ToString(button5.Tag) && Convert.ToString(button6.Tag) == Convert.ToString(button7.Tag))
                {
                    AnnounceWinner(button5, button6, button7);
                }

                else if (Convert.ToString(button6.Tag) == Convert.ToString(button3.Tag) && Convert.ToString(button6.Tag) == Convert.ToString(button9.Tag))
                {
                    AnnounceWinner(button3, button6, button9);
                }

                else if(Convert.ToString(button6.Tag) == Convert.ToString(button2.Tag) && Convert.ToString(button6.Tag) == Convert.ToString(button10.Tag))
                {
                    AnnounceWinner(button2, button6, button10);
                }

                else if(Convert.ToString(button6.Tag) == Convert.ToString(button4.Tag) && Convert.ToString(button6.Tag) == Convert.ToString(button8.Tag))
                {
                    AnnounceWinner(button4, button6, button8);
                }
            }

            else
            {
                ShowGameOverMessage();
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            PreparingAndDisplayingTheEventOnTheScreen(sender);
            CheckToSeeIfTheGameHasEndedForTheFifthButton();
        }


        private void CheckToSeeIfTheGameHasEndedForTheSixthButton()
        {
            if (!IsDraw(Count))
            {
                if (Convert.ToString(button7.Tag) == Convert.ToString(button4.Tag) && Convert.ToString(button7.Tag) == Convert.ToString(button10.Tag))
                {
                    AnnounceWinner(button4, button7, button10);
                }

                else if (Convert.ToString(button7.Tag) == Convert.ToString(button6.Tag) && Convert.ToString(button7.Tag) == Convert.ToString(button5.Tag))
                {
                    AnnounceWinner(button5, button6, button7);
                }
            }

            else
            {
                ShowGameOverMessage();
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            PreparingAndDisplayingTheEventOnTheScreen(sender);
            CheckToSeeIfTheGameHasEndedForTheSixthButton();
        }
    }
}
