using System;
using System.Drawing;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            User foundUser = VirtualDatabase.users.Find(i => i.Username == username && i.Password == password);
            if (foundUser != null)
            {
                MainForm mainForm = new MainForm(foundUser);
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("User is not found!","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            TextBox T1 = (TextBox)sender;
            T1.BackColor = Color.Yellow;
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            TextBox T2 = (TextBox)sender;
            T2.BackColor = Color.White;
        }
    }
}
