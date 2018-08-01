using System;
using System.Windows.Forms;

namespace Car_Cutting_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();

            var cutting = new ExusCuttingStringHelper(richTextBox5.Text);
            textBox1.Text = cutting.Vechicle.ToString();
            textBox2.Text = cutting.Province.ToString();
            textBox3.Text = cutting.MiscellaneousCusipNumber.ToString();
            textBox4.Text = cutting.EnginType.ToString();
            textBox5.Text = cutting.EnginType2.ToString();
            textBox6.Text = cutting.CollateralType.ToString();
            textBox7.Text = cutting.DeedNo.ToString();
            textBox8.Text = cutting.AccountNo.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox5.Clear();
        }
    }
}