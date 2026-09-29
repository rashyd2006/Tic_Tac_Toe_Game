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
    }
}
