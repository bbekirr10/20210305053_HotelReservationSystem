namespace HotelReservationSystem.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            ReservationForm reservation = new ReservationForm();
            reservation.Show();
            this.Hide();

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            this.Hide();
        }
    }
}
