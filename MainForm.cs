using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class MainForm : Form
    {
        public MainForm(User user)
        {
            InitializeComponent();
            txtUsername.Enabled = false;

            txtUsername.Text = user.Username;
            txtPassword.Text = user.Password;
            txtName.Text = user.Name;
            txtSurname.Text = user.Surname;
            txtDescription.Text = user.Description;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string description = txtDescription.Text;
            string password = txtPassword.Text;

            User user = VirtualDatabase.users.Find(i => i.Username == txtUsername.Text);
            user.Name = name;
            user.Surname = surname;
            user.Description = description;
            user.Password = password;
        }
    }
}
