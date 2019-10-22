﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pictureviewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.boxcolor = colorDialog1.Color;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.Load(openFileDialog1.filename);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox.checked)
                picturebox1.sizemode = PictureBoxSizeMode.StretchImage;
                else 
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }
    }
}
