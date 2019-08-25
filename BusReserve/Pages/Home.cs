using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusReserve.Pages;
using BusReserve.Properties;

namespace BusReserve
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            LoginForm openForm = new LoginForm();
            openForm.Show();
            Visible = false;
        }

        
    }
}
