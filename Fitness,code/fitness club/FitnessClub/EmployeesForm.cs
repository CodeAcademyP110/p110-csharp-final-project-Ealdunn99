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
    public partial class EmployeesForm : Form
    {
        private readonly db3Entities _context;

        public EmployeesForm()
        {
            InitializeComponent();
            _context = new db3Entities();
        }

        private void EmployeesForm_Load_1(object sender, EventArgs e)
        {
            UpdateDataGridEmployees();

            cmbPositions.Items.AddRange(_context.Roles.ToArray());
            cmbPositions.SelectedIndex = 0;
        }

        private async void BtnAddEmployee_Click_1(object sender, EventArgs e)
        {
            string fname = txtFirstname.Text.Trim();
            string lname = txtLastname.Text.Trim();
            string username = txtUsername.Text.Trim();
            string pass = txtPassword.Text.Trim();
            Role selectedRole = cmbPositions.SelectedItem as Role;

            if (fname == string.Empty || lname == string.Empty ||
               username == string.Empty || pass == string.Empty)
            {
                ShowMessage("Error", "Please, fill all the fields");
                return;
            }

            if (_context.Users.Any(u => u.Username.ToLower() == username.ToLower()))
            {
                ShowMessage("Error", "Duplicate username");
                return;
            }

            _context.Users.Add(new User
            {
                Firstname = fname,
                Lastname = lname,
                Username = username,
                Password = GetHash(pass),
                RoleId = selectedRole.Id,
                HasVerifiedPassword = false
            });
            await _context.SaveChangesAsync();

            ShowMessage("Success", "New employee successfully added", false);
            UpdateDataGridEmployees();
        }

        private void ShowMessage(string title, string content, bool isError = true)
        {
            MessageBox.Show(
                content,
                title,
                MessageBoxButtons.OK,
                isError ? MessageBoxIcon.Error : MessageBoxIcon.Information);
        }

        private void UpdateDataGridEmployees()
        {
            dgwEmployees.DataSource =
                _context.Users.Where(u => u.RoleId == 1 || u.RoleId == 2)
                                                    .Select(u => new
                                                    {
                                                        Fullname = string.Concat(u.Firstname, " ", u.Lastname),
                                                        //Username = u.Username,
                                                        Role = u.Role.Name
                                                    }).ToList();
        }

       
    }
}
