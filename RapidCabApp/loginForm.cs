using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RapidCabApp
{
    public partial class loginForm: Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void backToHomePage_Click(object sender, EventArgs e)
        {
            Form1 homePage = new Form1();
            homePage.Show();
            this.Hide();
        }
    }
}
