using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
          login();
        }

        private void login()
        {
            string id = textUserID.Text;
            string pw = textPassword.Text;

            if (id == "user123" && pw == "1234")
            {
                Form1 a = new Form1();
                a.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("User ID or Password is incorrect", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void reset()
        {
            textUserID.Clear();
            textPassword.Clear();
            textUserID.Focus();
        }
        private void textPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                login();
            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                reset();
            }
        }

        private void textUserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                login();
            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                reset();
            }
        }
    }
}
