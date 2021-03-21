using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoreControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*void radioButton_CheckedChanged(object sender,EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                MessageBox.Show(rb.Text);
            }
        }*/
        void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb.Checked)
            {
                MessageBox.Show(rb.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "Plamen can code in";
            if (checkBox1.Checked) s = s + " " + checkBox1.Text;
            if (checkBox2.Checked) s = s + " " + checkBox2.Text;
            if (checkBox3.Checked) s = s + " " + checkBox3.Text;
            if (checkBox4.Checked) s = s + " " + checkBox4.Text;
            if (checkBox5.Checked) s = s + " " + checkBox5.Text;
            MessageBox.Show(s);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("George's next birthday is on " + dateTimePicker1.Text);
        }

        private void addNodes_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Add("Dogs");
            treeView1.Nodes.Add("Bear");
            treeView1.Nodes.Add("Deer");

            treeView1.Nodes[0].Nodes.Add("Beagle");
            treeView1.Nodes[0].Nodes.Add("Collie");
            treeView1.Nodes[0].Nodes.Add("Labrador");

        }

        private void removeNodes_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Remove();
        }
    }
}
