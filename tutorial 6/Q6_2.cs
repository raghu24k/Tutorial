using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Q6_2 : Form
    {
        public Q6_2()
        {
            InitializeComponent();
        }

        private void fill_btn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Education");
            listBox1.Items.Add("Food for all");
            listBox1.Items.Add("Good Books");
            listBox1.Items.Add("Freedom of Speech");
            listBox1.Items.Add("Good Movies");
        }

        private void Count_btn_Click(object sender, EventArgs e)
        {
            lblcount.Text = "Total Items: " + listBox1.Items.Count;
            //label1.Text = "Total Items: " + listBox1.Items.Count;
        }

        private void sort_btn_Click(object sender, EventArgs e)
        {
            listBox1.Sorted = true;
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            lblcount.Text = "Display total items";
            lblselection.Text = "Your Selection";
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please select an item to remove.");
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        { 

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                lblselection.Text = listBox1.SelectedItem.ToString();
            }
        }
    }
}
