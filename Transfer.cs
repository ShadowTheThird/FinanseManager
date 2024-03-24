using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanseManager
{
    public partial class Transfer : Form
    {
        Dashboard dashboard;
        public Transfer(Dashboard _dashboard)
        {
            InitializeComponent();
            this.dashboard = _dashboard;
            this.type.SelectedIndex = 0;
            this.date_type.SelectedIndex = 0;
        }

        private void date_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.date_type.SelectedIndex == 1)
            {
                this.date.Enabled = true;
            }
        }

        private void date_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
