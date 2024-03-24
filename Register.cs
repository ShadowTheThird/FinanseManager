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
            if(this.username.Text != "" && this.password.Text != "" && this.confirm_password.Text != "" && this.name.Text != "") 
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
                        if (fields[3] == this.name.Text)
                        {
                            MessageBox.Show("name already taken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    File.AppendAllText("..\\..\\user_data.csv", this.username.Text + "," + this.password.Text + "," + this.help.Text + "," + this.name.Text + Environment.NewLine);
                    string name = this.name.Text[0].ToString().ToUpper()+this.name.Text.Substring(1);
                    File.WriteAllText("..\\..\\user_data\\" + this.name.Text + ".csv", name + Environment.NewLine + DateTime.Today.ToString("dd-MM-yyyy") + Environment.NewLine + "0" + Environment.NewLine);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("all fields must be filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void password_label_Click(object sender, EventArgs e)
        {
            this.password.UseSystemPasswordChar = !this.password.UseSystemPasswordChar;
        }

        private void confirm_password_label_Click(object sender, EventArgs e)
        {
            this.confirm_password.UseSystemPasswordChar = !this.confirm_password.UseSystemPasswordChar;
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                register_button_Click(sender, e);
            }
            if(e.KeyCode == Keys.Escape) 
            {
                this.Close();
            }
        }
    }
}
