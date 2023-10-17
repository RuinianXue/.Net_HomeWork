using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestionAndScore
{
    public partial class Form1 : Form
    {
        private Random random;
        private int operand1;
        private int operand2;
        private string selectedOperator;
        private int correctAnswer;
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            //GenerateQuestion();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            operand1 = random.Next(1, 11);
            operand2 = random.Next(1, 11);
            selectedOperator = random.Next(2) == 0 ? "+" : "-";
            correctAnswer = selectedOperator == "+" ? operand1 + operand2 : operand1 - operand2;

            questionLabel.Text = $"{operand1} {selectedOperator} {operand2} = ?";
            answerTextBox.Text = "";
            feedbackLabel.Text = "";
        }
        private void submitButton_Click(object sender, EventArgs e)
        {
            int userAnswer;
            
             if (int.TryParse(answerTextBox.Text, out userAnswer))
            {
                if (userAnswer == correctAnswer)
                {
                    feedbackLabel.Text = "Correct!";
                    feedbackLabel.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    feedbackLabel.Text = "Incorrect!";
                    feedbackLabel.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                feedbackLabel.Text = "Invalid answer!";
                feedbackLabel.ForeColor = System.Drawing.Color.Red;
            }
        }

    }
}
