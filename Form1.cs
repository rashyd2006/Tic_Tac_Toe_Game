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
                Currentbutton.Image = Image.FromFile(@"c:\X.png");
                Currentbutton.Tag = "X";
            }

            else
            {
                Currentbutton.Image = Image.FromFile(@"c:\O.png");
                Currentbutton.Tag = "O";
            }
        }
        private void ShowInvaildMoveMessage()
        {
            MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
