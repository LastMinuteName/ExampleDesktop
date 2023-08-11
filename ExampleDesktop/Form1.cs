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

namespace ExampleDesktop
{
    public partial class Form1 : Form
    {
        int currentScore;
        int highScore;
        Calculator calculator = new Calculator();


        public Form1()
        {
            InitializeComponent();
            this.answerTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(submitAnswer);
        }

        private void submitAnswer(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return){
                int result = calculator.sum(1, 2);
                Console.WriteLine(result);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            System.Console.WriteLine("test");
        }
    }
}
