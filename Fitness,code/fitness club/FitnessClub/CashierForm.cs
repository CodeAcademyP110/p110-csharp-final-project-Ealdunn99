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

namespace FitnessClub
{
    public partial class CashierForm : Form
    {
        private readonly db3Entities _context;
        private readonly User _loggedUser;
        private readonly List<OrderDetail> _orderDetails;

        public CashierForm(User user)
        {
            InitializeComponent();
            _context = new db3Entities();
            _loggedUser = user;
            _orderDetails = new List<OrderDetail>();
        }

        private void CashierForm_Load_1(object sender, EventArgs e)
        {
            
            //Show cashier name for welcoming
            txtWelcome.Text = $"Dear {_loggedUser.Firstname} {_loggedUser.Lastname}, Welcome.";
            UpdateCategoriesCombo();


        }

        private void UpdateCategoriesCombo()
        {
            
            cmbCategories.Items.AddRange(_context.Categories.ToArray());
            cmbCategories.SelectedIndex = 0;
        }

        private void CmbCategories_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cmbItems.Items.Clear();
            Category selectedCategory = cmbCategories.SelectedItem as Category;
            cmbItems.Items.AddRange(selectedCategory.Products.ToArray());
            cmbItems.SelectedIndex = 0;
        }

        private void CmbItems_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Product selectedProduct = cmbItems.SelectedItem as Product;
            txtItemPrice.Text = selectedProduct.Price + " AZN";
        }

        private void BtnAddItem_Click_1(object sender, EventArgs e)
        {
            Product selectedProduct = cmbItems.SelectedItem as Product;


            if (_orderDetails.Any(d => d.Product.CategoryId == selectedProduct.CategoryId))
            {
                _orderDetails.First(d => d.Product.CategoryId == selectedProduct.CategoryId);
            }
            else
            {
                _orderDetails.Add(new OrderDetail { Product = selectedProduct });
            }
            UpdateItemButtons();
        }

        private void UpdateItemButtons()
        {
            pnlOrderItems.Controls.Clear();
            decimal? totalPrice = 0;

            foreach (var item in _orderDetails)
            {
                //update buttons
                Button btn = new Button();
                btn.Text = $"{item.Product.Name} ";
                btn.BackColor = Color.DodgerBlue;
                btn.FlatStyle = FlatStyle.Flat;
                btn.Font = new Font("Century Gothic", 10.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                btn.ForeColor = SystemColors.ControlLightLight;
                btn.Name = "btnLogin";
                btn.Size = new Size(150, 50);
                btn.UseVisualStyleBackColor = false;


                btn.Click += (sender, e) =>
                {
                    _orderDetails.Remove(item);
                    pnlOrderItems.Controls.Remove(btn);

                    totalPrice -= item.Product.Price;
                    txtTotalPrice.Text = $"{totalPrice} AZN";
                };

                pnlOrderItems.Controls.Add(btn);

                //update total price
                totalPrice += item.Product.Price;
            }

            pnlOrderItems.Visible = true;
            lblPanelLabel.Visible = true;
            txtTotalPrice.Text = $"{totalPrice} AZN";
        }

        private async void BtnFinishOrder_Click_1(object sender, EventArgs e)
        {
            string customerName = txtCustomerName.Text.Trim();
            string cusLastName = txtCusLastName.Text.Trim();

            textBox1.Text = _loggedUser.Id.ToString();


            PendingsOrder order = _context.PendingsOrders.Add(new PendingsOrder
            {
                UserId = _loggedUser.Id,
                Date = DateTime.Now,
                CustomerName = customerName,
                CusLastName = cusLastName

            });

            await _context.SaveChangesAsync();

            foreach (var item in _orderDetails)
            {
                _context.OrderDetails.Add(new Model.OrderDetail
                {
                    ProductId = item.Product.Id,

                    PendingOrderId = order.Id
                });
            }

            await _context.SaveChangesAsync();
            
            ShowMessage("Success", "New order is added to the list Pending Orders", false);
            ShowMessage("Success", $"Customer Id {_loggedUser.Id.ToString()}", false);

        }

        private class OrderDetail
        {
            public Product Product { get; set; }

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
