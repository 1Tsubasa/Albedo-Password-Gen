using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                PassGen(8);
            }
            else if (radioButton2.Checked)
            {
                PassGen(16);
            }
            else if (radioButton3.Checked)
            {
                PassGen(20);
            }
            else if (radioButton4.Checked)
            {
                PassGen(30);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          Form2 Form2 = new Form2();
            Form2.ShowDialog();
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AlbedoPasswordGen by 1tsubasa you can contact me by discord or in this server : ");
            MessageBox.Show("discord.gg/clarityfr");
            MessageBox.Show("My discord name : 1tsubasa");
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void PassGen(int len)
        {
            const string Char = "abcdefghijklnmopqrstuvxyzABCDEFGHIJKLNMOPQRSTUVXYZ0123456789!*$";
            StringBuilder result = new StringBuilder();
            Random rand = new Random();
            while (0 < len--)
            {
                result.Append(Char[rand.Next(Char.Length)]);
            }
            textBox1.Text = result.ToString();
        }
    }
}
