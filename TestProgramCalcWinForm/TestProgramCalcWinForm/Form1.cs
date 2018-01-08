using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows;
using System.Windows.Forms;

namespace TestProgramCalcWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "2";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "-";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string Input = richTextBox1.Text;

            for (int i = 0; i < Input.Length; i++)
            {
                
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Image printImage = new Bitmap(
                @"D:\Repos\VisualStudioProjects\TestProgramCalcWinForm\TestProgramCalcWinForm\Resources\pictures\1\Tool.jpg");

            pictureBox1.Image = printImage;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Image printImage = new Bitmap(
                @"D:\Repos\VisualStudioProjects\TestProgramCalcWinForm\TestProgramCalcWinForm\Resources\pictures\4\Product.jpg");

            pictureBox1.Image = printImage;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Image printImage = new Bitmap(
                @"D:\Repos\VisualStudioProjects\TestProgramCalcWinForm\TestProgramCalcWinForm\Resources\pictures\6\Tool.jpg");

            pictureBox1.Image = printImage;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Image printImage = new Bitmap(
                @"D:\Repos\VisualStudioProjects\TestProgramCalcWinForm\TestProgramCalcWinForm\Resources\pictures\7\Tool.jpg");

            pictureBox1.Image = printImage;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
