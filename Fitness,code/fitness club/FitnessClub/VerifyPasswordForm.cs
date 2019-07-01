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
    public partial class VerifyPasswordForm : Form
    {
        private readonly User _loggedUser;
        private readonly db3Entities _context;

        public VerifyPasswordForm(User user)
        {
            InitializeComponent();
            _loggedUser = user;
            _context = new db3Entities();
        }

        private async void BtnUpdatePassword_Click_1(object sender, EventArgs e)
        {
            //read all values
            string currentPassword = txtCurrentPassword.Text.Trim();
            string newPassword = txtNewPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            if (currentPassword == string.Empty || newPassword == string.Empty || confirmPassword == string.Empty)
            {
                ShowMessage("Error", "Fill all the password fields");
                return;
            }

            if (!CheckHash(_loggedUser.Password, currentPassword))
            {
                ShowMessage("Error", "Current password is invalid.");
                return;
            }

            if (newPassword != confirmPassword)
            {
                ShowMessage("Error", "New password and confirm password don't match.");
                return;
            }

            //find User from database to update his/her password
            User updateUser = await _context.Users.FindAsync(_loggedUser.Id);
            updateUser.Password = GetHash(newPassword);
            updateUser.HasVerifiedPassword = true;
            await _context.SaveChangesAsync();

            //open Cashier or Barista form
            if (updateUser.Role.Name == Utilities.Roles.Cashier.ToString())
            {
                this.Close();
                new CashierForm(updateUser).Show();
            }

           
        }

        private void ShowMessage(string title, string content, bool isError = true)
        {
            MessageBox.Show(
                content,
                title,
                MessageBoxButtons.OK,
                isError ? MessageBoxIcon.Error : MessageBoxIcon.Information);
        }

        
    }
}
