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
    public partial class Register : Form
    {
        Authenticator authenticator;
        public Register(Authenticator _authenticator, string name)
        {
            InitializeComponent();
            this.authenticator = _authenticator;
            username.Text = name;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            authenticator.Show();
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            if(this.username.Text != null && this.password.Text != null && this.confirm_password.Text != null) 
            {
                if (this.password.Text == this.confirm_password.Text)
                {
                    string[] users = File.ReadAllLines("..\\..\\user_data.csv");
                    foreach (string user in users)
                    {
                        string[] fields = user.Split(',');
                        if (fields[0] == this.username.Text)
                        {
                            MessageBox.Show("username already taken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    File.AppendAllText("..\\..\\user_data.csv", this.username.Text + "," + this.password.Text + "," + this.help.Text + "," + this.username.Text + Environment.NewLine);
                    string name = this.username.Text.ToLower();
                    name = name[0].ToString().ToUpper()+name.Substring(1);
                    File.WriteAllText("..\\..\\user_data\\" + this.username.Text + ".csv", name + Environment.NewLine);
                    this.Close();
                }
            }
        }
    }
}
