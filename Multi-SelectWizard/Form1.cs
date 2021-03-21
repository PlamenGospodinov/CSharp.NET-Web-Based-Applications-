using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_SelectWizard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            leftListBox.Items.Clear();
            rightListBox.Items.Clear();
            leftListBox.SelectionMode = SelectionMode.MultiExtended;
            rightListBox.SelectionMode = SelectionMode.MultiExtended;

            for(int i = 0; i < 9; i++)
            {
                leftListBox.Items.Insert(i, "Item " + i);
            }

            leftListBox.Sorted = true;
            rightListBox.Sorted = true;
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            leftListBox.Items.Clear();
            rightListBox.Items.Clear();
            leftListBox.SelectionMode = SelectionMode.MultiExtended;
            rightListBox.SelectionMode = SelectionMode.MultiExtended;

            for (int i = 0; i < 9; i++)
            {
                leftListBox.Items.Insert(i, "Item " + i);
            }

            leftListBox.Sorted = true;
            rightListBox.Sorted = true;
        }

        private void moveRightButton_Click(object sender, EventArgs e)
        {
            for(int i = 0; i <= leftListBox.Items.Count - 1; i++)
            {
                if(leftListBox.GetSelected(i) == true)
                {
                    rightListBox.Items.Add(leftListBox.Items[i]);
                }
            }

            //now invert the scan for the removes
            for(int i = leftListBox.Items.Count - 1; i >= 0; i--)
            {
                if(leftListBox.GetSelected(i) == true)
                {
                    leftListBox.Items.RemoveAt(i);
                }
            }
        }
    }
}
