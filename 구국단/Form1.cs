﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 구국단
{
    public partial class Form1 : Form
    {

        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 1; i<10; i++)
            {
                listBox1.Items.Add(textBox1.Text+"x"+i+"="+i*Convert.ToInt32(textBox1.Text));
                

            }
        }
    }
}
