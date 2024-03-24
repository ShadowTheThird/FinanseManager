using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanseManager
{
    public partial class Help_Page : Form
    {
        Authenticator authenticator;
        public Help_Page(Authenticator caller)
        {
            InitializeComponent();
            authenticator = caller;
        }

        public void PreSet_Username(string name)
        {
            this.username.Text = name;
        }

        private string LoadCSV(string name)
        {
            string[] data = File.ReadAllLines("..\\..\\user_data.csv");
            foreach (string line in data)
            {
                string[] split = line.Split(',');
                if (split[0] == name)
                {
                    return split[2];
                }
            }
            return null;
        }

        private void help_Click(object sender, EventArgs e)
        {
            if (this.username.Text.Length > 0)
            {
                string user = LoadCSV(this.username.Text);
                if(user != null)
                {
                    MessageBox.Show(user, "Help Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("invalid username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("please insert a valid username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Help_Page_FormClosed(object sender, FormClosedEventArgs e)
        {
            authenticator.Show();
        }

        private void username_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                help_Click(sender, e);
            }
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
