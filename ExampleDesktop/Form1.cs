﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Label helloWorldLabel = new Label();
            helloWorldLabel.Text = "Hello World";
            this.Controls.Add(helloWorldLabel);
        }
    }
}
