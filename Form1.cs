using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOTQuiz
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public string name;
        public Form1()
        {
            InitializeComponent();
            instance = this;
            pl1.BackColor = Color.FromArgb(150, Color.Black);
            lbInstruc.Text = "This is a multiple-choice quiz wherein the questions are related to the TV series titled \"Game of Thrones\". This has 8 questions and each question has 4 choices. At the end of the game, your score and percentage will be shown through a message box. Goodluck! Valar morghulis!";
        }

        private void bnStart_Click(object sender, EventArgs e)
        {
           Form2 form2 = new Form2();
            form2.ShowDialog();
            this.Hide();
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            name = tbName.Text;
        }
    }
}
