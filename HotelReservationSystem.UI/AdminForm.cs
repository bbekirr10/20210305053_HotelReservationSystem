using HotelReservationSystem.BusinessLayer.Operations;
using HotelReservationSystem.Class;
using HotelReservationSystem.DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HotelReservationSystem.UI
{
    public partial class AdminForm : Form
    {
        private readonly HotelDbContext context;
        private readonly RoomManager _roomManager;
        private readonly CustomerManager _customerManager;
        private readonly ReservationManager _reservationManager;

        public AdminForm()
        {
            InitializeComponent();
            context = new HotelDbContext();
            _roomManager = new RoomManager(new HotelDbContext());
            _customerManager = new CustomerManager(new HotelDbContext());
            _reservationManager = new ReservationManager(new HotelDbContext());
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addRoom = new Room();
            addRoom.RoomType = txtRoomType.Text;
            addRoom.RoomPrice = Convert.ToDecimal(txtRoomPrice.Text);
            addRoom.RoomAvailability = Convert.ToString(chkAvailable.Checked);
            _roomManager.AddRoom(addRoom);
            MessageBox.Show("Room added successfully.");
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtRoomId.Text);
            var updatedValue = _roomManager.GetRoomById(id);
            updatedValue.RoomId = Convert.ToInt32(txtRoomId.Text);
            updatedValue.RoomType = txtRoomType.Text;
            updatedValue.RoomPrice = Convert.ToDecimal(txtRoomPrice.Text);
            updatedValue.RoomAvailability = Convert.ToString(chkAvailable.Checked);
            _roomManager.UpdateRoom(updatedValue);
            MessageBox.Show("Room updated successfully.");
        }
        private void btnList_Click(object sender, EventArgs e)
        {
            var rooms = _roomManager.GetAllRooms();
            dgvRooms.DataSource = rooms;
            dgvRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = (int)dgvRooms.CurrentRow.Cells["RoomId"].Value;
            _roomManager.DeleteRoom(id);
            MessageBox.Show("The room has been deleted.");
            _roomManager.GetAllRooms();
            dgvRooms.DataSource = _roomManager.GetAllRooms();
        }



        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            var addCustomer = new Customer();
            addCustomer.CustomerName = txtCustomerName.Text;
            addCustomer.CustomerPassword = txtCustomerPassword.Text;
            addCustomer.CustomerContactInfo = txtCustomerContact.Text;
            _customerManager.AddCustomer(addCustomer);
            MessageBox.Show("Customer added successfully.");
        }
        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtCustomerId.Text);
            var updatedValue = _customerManager.GetCustomerById(id);
            updatedValue.CustomerID = Convert.ToInt32(txtCustomerId.Text);
            updatedValue.CustomerName = txtCustomerName.Text;
            updatedValue.CustomerPassword = txtCustomerPassword.Text;
            updatedValue.CustomerContactInfo = txtCustomerContact.Text;
            _customerManager.UpdateCustomer(updatedValue);
            MessageBox.Show("Customer updated successfully.");
        }
        private void btnListCustomer_Click(object sender, EventArgs e)
        {
            var customer = _customerManager.GetAllCustomers();
            dgvCustomerInformation.DataSource = customer;
            dgvCustomerInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }
        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            int id = (int)dgvCustomerInformation.CurrentRow.Cells["CustomerID"].Value;
            _customerManager.DeleteCustomer(id);
            MessageBox.Show("The customer has been deleted.");
            _customerManager.GetAllCustomers();
            dgvCustomerInformation.DataSource = _customerManager.GetAllCustomers();

        }



        private void btnReservation_Click(object sender, EventArgs e)
        {
            var addReservation = new Reservation();
            addReservation.ReservationId = Convert.ToInt32(txtReservationId.Text);
            addReservation.RoomId = Convert.ToInt32(txtReservationRoomId.Text);
            addReservation.CustomerId = Convert.ToInt32(txtCustomerId.Text);
            addReservation.CheckInDate = Convert.ToDateTime(dtpInDate.Text);
            addReservation.CheckInDate = Convert.ToDateTime(dtpCheckOut.Text);
            addReservation.Status = txtStatus.Text;
            _reservationManager.AddReservation(addReservation);
            MessageBox.Show("Reservation added successfully.");

        }
        private void btnReservationUpdate_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(txtReservationId.Text);
            var updatedValue = _reservationManager.GetReservationById(id);
            updatedValue.ReservationId = Convert.ToInt32(txtReservationId.Text);
            updatedValue.RoomId = Convert.ToInt32(txtReservationRoomId.Text);
            updatedValue.CustomerId = Convert.ToInt32(txtReservationCustomerId.Text);
            updatedValue.CheckInDate = Convert.ToDateTime(dtpInDate.Text);
            updatedValue.CheckOutDate = Convert.ToDateTime(dtpCheckOut.Text);
            updatedValue.Status = txtStatus.Text;
            _reservationManager.UpdateReservation(updatedValue);
            MessageBox.Show("Reservation updated successfully.");
        }
        private void btnListReservation_Click(object sender, EventArgs e)
        {
            var reservations = _reservationManager.GetAllReservations();
            dgvReservations.DataSource = reservations;
            dgvReservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }
        private void btnDeleteReservation_Click(object sender, EventArgs e)
        {
            int id = (int)dgvReservations.CurrentRow.Cells["ReservationId"].Value;
            _reservationManager.DeleteReservation(id);
            MessageBox.Show("The reservation has been deleted.");
            _reservationManager.GetAllReservations();
            dgvReservations.DataSource = _reservationManager.GetAllReservations();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerId.Text = string.Empty;
            txtCustomerName.Text = string.Empty;
            txtCustomerPassword.Text = string.Empty;
            txtCustomerContact.Text = string.Empty;
            txtRoomId.Text = string.Empty;
            txtRoomPrice.Text = string.Empty;
            txtRoomType.Text = string.Empty;
            txtReservationId.Text = string.Empty;
            txtReservationRoomId.Text = string.Empty;
            txtReservationCustomerId.Text = string.Empty;
            dtpInDate.Text = string.Empty;
            dtpCheckOut.Text = string.Empty;
            txtStatus.Text = string.Empty;

        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvCustomerInformation.DataSource = _customerManager.GetAllCustomers();
            dgvRooms.DataSource = _roomManager.GetAllRooms();
            dgvReservations.DataSource = _reservationManager.GetAllReservations();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }


    }
}
