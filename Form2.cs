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
    public partial class Form2 : Form
    {
        public static Form2 instance;
        string name = Form1.instance.name;
        int questionNum = 1;
        double correctAnswer;
        double score;
        double percentage;
        double totalQue = 8;
        public Form2()
        {
            InitializeComponent();
            instance = this;
            AskQuestions(questionNum);
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;
            }
                questionNum++;
                AskQuestions(questionNum);
            

            if (questionNum == 9)
            {
                percentage = Math.Round(((score * 100) / totalQue), 2);
                MessageBox.Show("Hello " +name+ "! \nYour number of correct answers: " +score+ "\nPercentage: " +percentage+ "%");
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
        }

        private void AskQuestions(int qNum)
        {
            switch(qNum)
            {
                case 1:
                    pb1.Image = Properties.Resources.dany;
                    lbQue.Text = "What is Daenerys Targaryen also known as?";
                    bn1.Text = "The King's Hand";
                    bn2.Text = "The Imp";
                    bn3.Text = "The Mother of Dragons";
                    bn4.Text = "The Realm's Delight";
                    correctAnswer = 3;
                    break;

                case 2:
                    pb1.Image = Properties.Resources.tyrion;
                    lbQue.Text = "What was the name of the woman Tyrion Lannister loved?";
                    bn1.Text = "Shae";
                    bn2.Text = "Daenerys";
                    bn3.Text = "Margaery";
                    bn4.Text = "Talisa";
                    correctAnswer = 1;
                    break;

                case 3:
                    pb1.Image = Properties.Resources.iron;
                    lbQue.Text = "Who created the iron throne?";
                    bn1.Text = "Ned Stark";
                    bn2.Text = "Robert Baratheon";
                    bn3.Text = "Aegon the Conqueror";
                    bn4.Text = "Tywin Lannister";
                    correctAnswer = 3;
                    break;

                case 4:
                    pb1.Image = Properties.Resources.arya;
                    lbQue.Text = "What was the name of Arya Stark's first sword?";
                    bn1.Text = "Dark Sister";
                    bn2.Text = "Needle";
                    bn3.Text = "Longclaw";
                    bn4.Text = "Oathkeeper";
                    correctAnswer = 2;
                    break;

                case 5:
                    pb1.Image = Properties.Resources.tyrell;
                    lbQue.Text = "Which house sigil and saying does this belonng to?";
                    bn1.Text = "House Targaryen";
                    bn2.Text = "House Tyrell";
                    bn3.Text = "House Greyjoy";
                    bn4.Text = "House Martell";
                    correctAnswer = 2;
                    break;

                case 6:
                    pb1.Image = Properties.Resources.cersei;
                    lbQue.Text = "How many children did Cersei Lannister and Robert Baratheon have?";
                    bn1.Text = "0";
                    bn2.Text = "1";
                    bn3.Text = "2";
                    bn4.Text = "3";
                    correctAnswer = 1;
                    break;

                case 7:
                    pb1.Image = Properties.Resources.jon;
                    lbQue.Text = "Why did Jon Snow have a scar near his eye?";
                    bn1.Text = "Ygritte shot him with an arrow";
                    bn2.Text = "Nightwalker bit him";
                    bn3.Text = "Due to a duel";
                    bn4.Text = "Orell's hawk scratched him";
                    correctAnswer = 4;
                    break;

                case 8:
                    pb1.Image = Properties.Resources.hodor;
                    lbQue.Text = "What does the word \"hodor\" actually mean?";
                    bn1.Text = "Hold Four";
                    bn2.Text = "Hold More";
                    bn3.Text = "Hold Door";
                    bn4.Text = "Hold Boar";
                    correctAnswer = 3;
                    break;
            }
        }
    }
}
