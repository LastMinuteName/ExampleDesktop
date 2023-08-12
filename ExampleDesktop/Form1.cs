using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculation;
using Evaluator;

namespace ExampleDesktop
{
    public partial class Form1 : Form
    {
        Random randNumGen = new Random();
        int currentScore, highScore, int1, int2, seconds;
        bool problemStart;
        Calculator calculator = new Calculator();
        Evaluator.Evaluator evaluator = new Evaluator.Evaluator();


        public Form1()
        {
            InitializeComponent();
            this.answerTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(submitAnswer);
            stopButton.Enabled = false;
            problemStart = false;
        }

        private void submitAnswer(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return && problemStart == true){
                try
                {
                    int userInput = int.Parse(answerTextBox.Text);
                    int correctResult = calculator.sum(int1, int2);

                    bool isCorrect = evaluator.equals(userInput, correctResult);

                    if (isCorrect)
                    {
                        currentScore++;
                    }

                    updateCurrentScore();
                    generateNewProblem();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid user input");
                }

                answerTextBox.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            highScore = 0;
            currentScore = 0;
            updateCurrentScore();
            updateHighestScore();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            generateNewProblem();
            startButton.Enabled = false;
            stopButton.Enabled = true;
            currentScore = 0;
            updateCurrentScore();
            seconds = 60;
            timer.Start();
            countdownLabel.Text = $"Time Left: {seconds}";
            problemStart = true;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if (currentScore > highScore)
            {
                highScore = currentScore;
                updateHighestScore();
            }
            startButton.Enabled = true;
            stopButton.Enabled = false;
            problemStart = false;
            timer.Stop();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (seconds >= 0)
            {
                countdownLabel.Text = $"Time Left: {seconds--}";
            }
            else
            {
                if (currentScore > highScore)
                {
                    highScore = currentScore;
                    updateHighestScore();
                }
                startButton.Enabled = true;
                stopButton.Enabled = false;
                problemStart = false;
                timer.Stop();
            }
        }

        private void generateNewProblem()
        {
            int1 = randNumGen.Next(0, 100);
            int2 = randNumGen.Next(0, 100);

            problemLabel.Text = $"{int1} + {int2} = ";
        }

        private void updateHighestScore()
        {
            highestScorelabel.Text = $"Highest Score: {highScore}";
        }

        private void updateCurrentScore()
        {
            currentScoreLabel.Text = $"Current Score: {currentScore}";
        }
    }
}
