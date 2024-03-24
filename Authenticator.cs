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
    public partial class Authenticator : Form
    {
        public Authenticator()
        {
            InitializeComponent();
        }

        private void help_Click(object sender, EventArgs e)
        {
            Help_Page help_page = new Help_Page(this);
            if (this.username.Text.Length > 0)
            {
                help_page.PreSet_Username(this.username.Text);
            }
            help_page.Show();
            this.Hide();
        }

        private string LoadCSV(string name, string password)
        {
            string[] data = File.ReadAllLines("..\\..\\user_data.csv");
            foreach (string line in data)
            {
                string[] split = line.Split(',');
                if (split[0] == name)
                {
                    if (split[1] == password)
                    {
                        return split[3];
                    }
                }
            }
            return null;
        }

        private void logon_Click(object sender, EventArgs e)
        {
            string user = LoadCSV(this.username.Text, this.password.Text);
            if(user != null)
            {
                if(user == "0")
                {
                    Admin admin = new Admin();
                    admin.Show();
                    this.Hide();
                    return;
                }
                Dashboard dashboard = new Dashboard(this, user);
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void register_Click(object sender, EventArgs e)
        {
            Register register = new Register(this, this.username.Text);
            register.Show();
            this.Hide();
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                logon_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void password_label_Click(object sender, EventArgs e)
        {
            this.password.UseSystemPasswordChar = !this.password.UseSystemPasswordChar;
        }
    }
}
