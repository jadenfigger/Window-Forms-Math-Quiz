using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Times_Math_Quiz
{
    public partial class form1 : Form
    {
        public string[] questions = new string[] { "An algebraic expression that contains three terms is called?",
                                                   "A die is rolled. What is the probability of getting an even number?",
                                                   "In a race , Ram covers 5 km in 20 min. How much distance will he cover in 100 min ?",
                                                   "21 goats eat as much as 15 cows. How many goats eat as much as 35 cows?",
                                                   "What is the 7th digit in Pi?",
                                                   "What is the next prime number after 29?",
                                                   "A billion comes before a trillion, but what comes after a trillion?",
                                                   "What is the name of a 9 sided polygon",
                                                   "What is 2 + 8 * 8 / 2"};
        public string[,] answers = new string[,] { { "Monomial", "Binomial", "Trinomial", "None of these"},
                                                   { "1/6", "1/2", "1/3", "1/4"},
                                                   { "25km", "30km", "26km", "40km"},
                                                   { "41", "37", "49", "38"},
                                                   { "3", "5", "8", "2"},
                                                   { "34", "31", "39", "33"},
                                                   { "Quintillion", "Decillion", "Quadrillion", "Septillion"},
                                                   { "Nonagon", "Decagon", "Heptagon", "Dodecagon"},
                                                   { "38", "42", "40", "34"}};
        public string[] correctAnswer = new string[] { "C", "B", "A", "C", "D", "B", "C", "A", "D"};
        public int questionTime = 10;
        public int questionNumber = 0;

        public System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        public bool timerRunning = false;

        public int totalWrong = 0;
        public int totalCorrect = 0;

        public form1()
        {
            InitializeComponent();

            DisplayQuestion();
        }

        public void DisplayQuestion()
        {
            QuestionTextBox.Text = questions[questionNumber];
            A.Text = answers[questionNumber, 0];
            B.Text = answers[questionNumber, 1];
            C.Text = answers[questionNumber, 2];
            D.Text = answers[questionNumber, 3];
            QuestionTrackerText.Text = $"Question:  {questionNumber+1}/9";
        }

        private void Answer_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;

            if (button.Name == correctAnswer[questionNumber])
            {
                totalCorrect += 1;

                if (questionNumber+1 == questions.Length)
                {
                    questionNumber = 0;
                    totalWrong = 0;
                    totalCorrect = 0;
                } 
                else
                {
                    questionNumber += 1;
                }
                DisplayQuestion();
            }
            else
            {
                totalWrong += 1;
            }

            textCorrect.Text = $"Correct:  {totalCorrect}";
            textWrong.Text = $"Wrong:  {totalWrong}";
        }
    }
}
