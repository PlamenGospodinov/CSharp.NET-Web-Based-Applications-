using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchingGame
{
    public partial class UserProfile : Form
    {
        public UserProfile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DataOK())
            {
                this.Hide();
                MatchingGame mg = new MatchingGame(FirstName.Text);
                mg.ShowDialog();
            }
            
        }

        public bool DataOK()
        {
            bool rv = true;

            if(FirstName.Text.Length == 0 || FirstName.Text is null)
            {
                firstName_message.Text = "First name is required!";
                firstName_message.ForeColor = Color.Red;
                rv = false;
            }

            if (LastName.Text.Length == 0 || LastName.Text is null)
            {
                lastName_message.Text = "First name is required!";
                lastName_message.ForeColor = Color.Red;
                rv = false;
            }
            if (Email.Text.Length == 0 || Email.Text is null)
            {
                email_message.Text = "First name is required!";
                email_message.ForeColor = Color.Red;
                rv = false;
            }
            return rv;

        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            salutation.SelectedIndex = 0;
            FirstName.Text = null;
            firstName_message.Text = null;
            LastName.Text = null;
            lastName_message.Text = null;
            Email.Text = null;
            email_message.Text = null;
            firstName_message.ForeColor = Color.Black;
            lastName_message.ForeColor = Color.Black;
            email_message.ForeColor = Color.Black;
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            salutation.SelectedIndex = 0;
            FirstName.Text = null;
            firstName_message.Text = null;
            LastName.Text = null;
            lastName_message.Text = null;
            Email.Text = null;
            email_message.Text = null;
            firstName_message.ForeColor = Color.Black;
            lastName_message.ForeColor = Color.Black;
            email_message.ForeColor = Color.Black;
        }
    }
}
