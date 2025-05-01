using HotelReservationSystem.BusinessLayer.Operations;
using HotelReservationSystem.Class;
using HotelReservationSystem.DataAccessLayer.Context;
using HotelReservationSystem.EntityLayer.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationSystem.UI
{
    public partial class ReservationForm : Form
    {
        private readonly ReservationManager _reservationManager;
        private readonly RoomManager _roomManager;
        private readonly CustomerManager customerManager;
        HotelDbContext context = new HotelDbContext();
        public ReservationForm()
        {
            InitializeComponent();
            _reservationManager = new ReservationManager(new HotelDbContext());
            _roomManager = new RoomManager(new HotelDbContext());
            customerManager = new CustomerManager(new HotelDbContext());
        }

        private void btnSearchRoom_Click(object sender, EventArgs e)
        {
            DateTime checkInDate = dtpCheckInDate.Value;
            DateTime checkOutDate = dtpCheckOutDate.Value;

            List<Room> availableRooms = _roomManager.GetAvailableRooms(checkInDate, checkOutDate);
           
            dgvAvailableRooms.DataSource = availableRooms;
            dgvAvailableRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            if (dgvAvailableRooms.SelectedRows.Count > 0)
            {
                var selectedRow = dgvAvailableRooms.SelectedRows[0];
                int roomId = Convert.ToInt32(selectedRow.Cells["RoomId"].Value);
 

                // Kullanıcı id'yi almak için bir işlem ekleyebilirsiniz, burada bir örnek olarak 1 kullanıyoruz
                int customerId = Session.LoggedInCustomerId;

                DateTime checkInDate = dtpCheckInDate.Value;
                DateTime checkOutDate = dtpCheckOutDate.Value;

                var reservation = _reservationManager.MakeReservation(roomId, customerId, checkInDate, checkOutDate);
                MessageBox.Show($"Reservation confirmed for Room {roomId}");

              
            }
            else
            {
                MessageBox.Show("Please select a room to reserve.");
            }
        }

        private void btnCancelReservation_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
