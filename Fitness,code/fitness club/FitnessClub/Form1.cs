using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FitnessClub.Model;
using static FitnessClub.Utilities.Hash;

namespace FitnessClub
{
    public partial class Form1 : Form
    {
        private readonly db3Entities _context;
        public Form1()
        {
            InitializeComponent();
            _context = new db3Entities();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == string.Empty || password == string.Empty)
            {
                ShowError("Error", "Username and password fields should be filled");
                return;
            }

            //Authentication
            User user = _context.Users.FirstOrDefault(u => u.Username.ToLower() == username.ToLower());

            if (user == null)
            {
                ShowError("Error", "Username or password is invalid");
                return;
            }

            if (!CheckHash(user.Password, password))
            {
                ShowError("Error", "Username or password is invalid");
                return;
            }

            //Authorization
            switch (user.RoleId)
            {
                case 1:
                    new AdminForm().ShowDialog();
                    break;
                case 2:
                    if (user.HasVerifiedPassword == false)
                        new VerifyPasswordForm(user).ShowDialog();
                    else
                        new CashierForm(user).ShowDialog();
                    break;
                default:
                    ShowError("Unknown login error", "Unknown error occurred. Please, contact Emin!");
                    break;
            }
            this.Show();
        }

        private void ShowError(string title, string content)
        {
            MessageBox.Show(content, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        
    }
}
