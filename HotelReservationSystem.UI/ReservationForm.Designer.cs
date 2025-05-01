namespace HotelReservationSystem.UI
{
    partial class ReservationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCancelReservation = new Button();
            btnReserve = new Button();
            dgvAvailableRooms = new DataGridView();
            btnSearchRoom = new Button();
            dtpCheckOutDate = new DateTimePicker();
            lblCheckOutDate = new Label();
            dtpCheckInDate = new DateTimePicker();
            lblCheckInDate = new Label();
            panel1 = new Panel();
            label1 = new Label();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAvailableRooms).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancelReservation
            // 
            btnCancelReservation.Location = new Point(553, 170);
            btnCancelReservation.Margin = new Padding(4);
            btnCancelReservation.Name = "btnCancelReservation";
            btnCancelReservation.Size = new Size(154, 32);
            btnCancelReservation.TabIndex = 17;
            btnCancelReservation.Text = "Exit";
            btnCancelReservation.UseVisualStyleBackColor = true;
            btnCancelReservation.Click += btnCancelReservation_Click;
            // 
            // btnReserve
            // 
            btnReserve.Location = new Point(305, 170);
            btnReserve.Margin = new Padding(4);
            btnReserve.Name = "btnReserve";
            btnReserve.Size = new Size(116, 32);
            btnReserve.TabIndex = 15;
            btnReserve.Text = "Reserve Room";
            btnReserve.UseVisualStyleBackColor = true;
            btnReserve.Click += btnReserve_Click;
            // 
            // dgvAvailableRooms
            // 
            dgvAvailableRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAvailableRooms.Location = new Point(15, 210);
            dgvAvailableRooms.Margin = new Padding(4);
            dgvAvailableRooms.Name = "dgvAvailableRooms";
            dgvAvailableRooms.Size = new Size(824, 232);
            dgvAvailableRooms.TabIndex = 14;
            // 
            // btnSearchRoom
            // 
            btnSearchRoom.Location = new Point(181, 170);
            btnSearchRoom.Margin = new Padding(4);
            btnSearchRoom.Name = "btnSearchRoom";
            btnSearchRoom.Size = new Size(116, 32);
            btnSearchRoom.TabIndex = 13;
            btnSearchRoom.Text = "Search Room";
            btnSearchRoom.UseVisualStyleBackColor = true;
            btnSearchRoom.Click += btnSearchRoom_Click;
            // 
            // dtpCheckOutDate
            // 
            dtpCheckOutDate.Location = new Point(536, 91);
            dtpCheckOutDate.Margin = new Padding(4);
            dtpCheckOutDate.Name = "dtpCheckOutDate";
            dtpCheckOutDate.Size = new Size(256, 26);
            dtpCheckOutDate.TabIndex = 12;
            // 
            // lblCheckOutDate
            // 
            lblCheckOutDate.AutoSize = true;
            lblCheckOutDate.Location = new Point(409, 98);
            lblCheckOutDate.Margin = new Padding(4, 0, 4, 0);
            lblCheckOutDate.Name = "lblCheckOutDate";
            lblCheckOutDate.Size = new Size(123, 18);
            lblCheckOutDate.TabIndex = 11;
            lblCheckOutDate.Text = "Check Out Date:";
            // 
            // dtpCheckInDate
            // 
            dtpCheckInDate.Location = new Point(127, 91);
            dtpCheckInDate.Margin = new Padding(4);
            dtpCheckInDate.Name = "dtpCheckInDate";
            dtpCheckInDate.Size = new Size(256, 26);
            dtpCheckInDate.TabIndex = 10;
            // 
            // lblCheckInDate
            // 
            lblCheckInDate.AutoSize = true;
            lblCheckInDate.Location = new Point(13, 98);
            lblCheckInDate.Margin = new Padding(4, 0, 4, 0);
            lblCheckInDate.Name = "lblCheckInDate";
            lblCheckInDate.Size = new Size(110, 18);
            lblCheckInDate.TabIndex = 9;
            lblCheckInDate.Text = "Check In Date:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(854, 84);
            panel1.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(219, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(372, 51);
            label1.TabIndex = 0;
            label1.Text = "RESERVATIONS";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(429, 170);
            btnBack.Margin = new Padding(4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(116, 32);
            btnBack.TabIndex = 19;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // ReservationForm
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(856, 443);
            Controls.Add(btnBack);
            Controls.Add(panel1);
            Controls.Add(btnCancelReservation);
            Controls.Add(btnReserve);
            Controls.Add(dgvAvailableRooms);
            Controls.Add(btnSearchRoom);
            Controls.Add(dtpCheckOutDate);
            Controls.Add(lblCheckOutDate);
            Controls.Add(dtpCheckInDate);
            Controls.Add(lblCheckInDate);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "ReservationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReservationForm";
            ((System.ComponentModel.ISupportInitialize)dgvAvailableRooms).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelReservation;
        private Button btnReserve;
        private DataGridView dgvAvailableRooms;
        private Button btnSearchRoom;
        private DateTimePicker dtpCheckOutDate;
        private Label lblCheckOutDate;
        private DateTimePicker dtpCheckInDate;
        private Label lblCheckInDate;
        private Panel panel1;
        private Label label1;
        private Button btnBack;
    }
}