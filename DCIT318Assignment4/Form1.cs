using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCIT318Assignment4
{
    public partial class Form1 : Form
    {
        string username;
        string password;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            username = TboxUser.Text;
            password = TboxPassword.Text;

            string message = $"Username: {username}\nPassword: {password}";

            MessageBox.Show(message, "User Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
