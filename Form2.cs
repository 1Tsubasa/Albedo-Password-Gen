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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = "8";

            }

        }
        private void TimerCreatePass_Tick(object sender, EventArgs e)
        {
            const string Char = "abcdefghijklnmopqrstuvxyzABCDEFGHIJKLNMOPQRSTUVXYZ0123456789!*$";
            Random r = new Random();
            StringBuilder sb = new StringBuilder();

            int passwordLength = int.Parse(textBox1.Text);

            for (int i = 0; i < passwordLength; i++)
            {
                int idx = r.Next(0, Char.Length);
                sb.Append(Char[idx]);
            }

            textBox2.Text = sb.ToString();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AlbedoPasswordGen by 1tsubasa you can contact me by discord or in this server : ");
            MessageBox.Show("discord.gg/clarityfr");
            MessageBox.Show("My discord name : 1tsubasa");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TimerCreatePass_Tick(sender, e);
        }
    }
}
