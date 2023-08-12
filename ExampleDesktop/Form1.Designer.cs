namespace ExampleDesktop
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.problemLabel = new System.Windows.Forms.Label();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.highestScorelabel = new System.Windows.Forms.Label();
            this.currentScoreLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.countdownLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(85, 100);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(166, 100);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 6;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // problemLabel
            // 
            this.problemLabel.AutoSize = true;
            this.problemLabel.Location = new System.Drawing.Point(103, 52);
            this.problemLabel.Name = "problemLabel";
            this.problemLabel.Size = new System.Drawing.Size(40, 13);
            this.problemLabel.TabIndex = 7;
            this.problemLabel.Text = "? + ? =";
            // 
            // answerTextBox
            // 
            this.answerTextBox.Location = new System.Drawing.Point(166, 49);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(45, 20);
            this.answerTextBox.TabIndex = 8;
            // 
            // highestScorelabel
            // 
            this.highestScorelabel.AutoSize = true;
            this.highestScorelabel.Location = new System.Drawing.Point(66, 74);
            this.highestScorelabel.Name = "highestScorelabel";
            this.highestScorelabel.Size = new System.Drawing.Size(77, 13);
            this.highestScorelabel.TabIndex = 10;
            this.highestScorelabel.Text = "Highest Score:";
            // 
            // currentScoreLabel
            // 
            this.currentScoreLabel.AutoSize = true;
            this.currentScoreLabel.Location = new System.Drawing.Point(163, 74);
            this.currentScoreLabel.Name = "currentScoreLabel";
            this.currentScoreLabel.Size = new System.Drawing.Size(78, 13);
            this.currentScoreLabel.TabIndex = 11;
            this.currentScoreLabel.Text = "Current Score: ";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // countdownLabel
            // 
            this.countdownLabel.AutoSize = true;
            this.countdownLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.countdownLabel.Location = new System.Drawing.Point(85, 9);
            this.countdownLabel.Name = "countdownLabel";
            this.countdownLabel.Size = new System.Drawing.Size(126, 26);
            this.countdownLabel.TabIndex = 12;
            this.countdownLabel.Text = "Time Left: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 143);
            this.Controls.Add(this.countdownLabel);
            this.Controls.Add(this.currentScoreLabel);
            this.Controls.Add(this.highestScorelabel);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.problemLabel);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Quick Maths";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label problemLabel;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Label highestScorelabel;
        private System.Windows.Forms.Label currentScoreLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label countdownLabel;
    }
}

