using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tutorial_6
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

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Hi, Raghuwinder");
            listBox1.Items.Add("Hi, Neel");
            listBox1.Items.Add("hi, Ap");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Sorted = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
           label1.Text = "Total Items: " + listBox1.Items.Count;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            listBox1.SelectionMode = SelectionMode.MultiSimple;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = "You selected: " + listBox1.SelectedItem;
        }
    }
}
