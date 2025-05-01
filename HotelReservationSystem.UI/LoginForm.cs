using HotelReservationSystem.Class;
using HotelReservationSystem.DataAccessLayer.Context;
using HotelReservationSystem.EntityLayer.Class;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace HotelReservationSystem.UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            cmbRole.Items.Add("Customer");
            cmbRole.Items.Add("Admin");
            cmbRole.SelectedIndex = 0;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            string role = cmbRole.SelectedItem.ToString();
            using (var context = new HotelDbContext())
            {
                if (role == "Admin")
                {
                    var admin = context.Admins.FirstOrDefault(a => a.AdminName == username && a.AdminPassword == password);
                    if (admin != null)
                    {
                      
                        MessageBox.Show("Admin login successful.");
                        this.Hide();
                        AdminForm adminForm = new AdminForm();
                        adminForm.Show();

                    }
                    else
                    {
                        MessageBox.Show("Admin information is incorrect.");
                    }
                }
                else if (role == "Customer")
                {
                    var customer = context.Customers.FirstOrDefault(c => c.CustomerName == username && c.CustomerPassword == password);
                    if (customer != null)
                    {
                        Session.LoggedInCustomerId = customer.CustomerID;
                        MessageBox.Show("Customer login successful.");
                        this.Hide();
                        ReservationForm reservationForm = new ReservationForm();
                        reservationForm.Show();


                    }
                    else
                    {
                        MessageBox.Show("Customer information is incorrect.");
                    }
                }
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
