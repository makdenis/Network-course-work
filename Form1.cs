﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PCComm
{
    public partial class Form1 : Form
    {
 
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PCComm.Form1.ActiveForm.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
