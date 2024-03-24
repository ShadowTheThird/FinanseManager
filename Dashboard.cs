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
    public partial class Dashboard : Form
    {
        Authenticator authenticator;
        string user_id;
        string[] user_data;
        public Dashboard(Authenticator caller, string _user_id)
        {
            InitializeComponent();
            authenticator = caller;
            this.user_id = _user_id;
            user_data = File.ReadAllLines("..\\..\\user_data\\"+user_id+".csv");
            this.welcome_label.Text = "Welcome "+user_data[0];
            this.budget.Text = Value_Format(user_data[2]);
        }

        private string Value_Format(string original_value)
        {
            string reversed = new string(original_value.Reverse().ToArray()), value_sum = "NLP ";
            for (int i = 0; i < reversed.Length; i += 3)
            {
                if(i + 3 < reversed.Length)
                {
                    value_sum += reversed.Substring(i, 3) + "\'";
                }
                else
                {
                    value_sum += reversed.Substring(i);
                }
            }
            return new string(value_sum.Reverse().ToArray());
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            authenticator.Close();
        }
    }
}
