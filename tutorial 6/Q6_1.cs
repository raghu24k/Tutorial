using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using tutorial_6.Properties;

namespace WindowsFormsApp1
{
    public partial class Q6_1 : Form
    {
        public Q6_1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            string prefix = "";

            if (radioButton1.Checked)
                prefix = "Mr.";
            else if (radioButton2.Checked)
                prefix = "Miss";

            StringBuilder sources = new StringBuilder();
            
            if (checkBox1.Checked) sources.Append("News Paper, ");
            if (checkBox2.Checked) sources.Append("Friends, ");
            if (checkBox3.Checked) sources.Append("Website, ");
            if (checkBox4.Checked && !string.IsNullOrWhiteSpace(textBox2.Text))
                sources.Append(textBox2.Text + ", ");
            if (sources.Length > 2)
                sources.Length -= 2;

            lblResult.Text = $"Hello {prefix} {name}. You know about us from {sources}.";
        }
    }
}
