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


namespace BusReserve.Pages
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void logInExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backImageButton_Click(object sender, EventArgs e)
        {
            Home openForm = new Home();
            openForm.Show();
            Visible = false;
        }
    }
}
