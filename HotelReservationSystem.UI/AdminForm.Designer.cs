namespace HotelReservationSystem.UI
{
    partial class AdminForm
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
            components = new System.ComponentModel.Container();
            dgvCustomerInformation = new DataGridView();
            ctmsDelete = new ContextMenuStrip(components);
            lblCustomerInformation = new Label();
            dgvReservations = new DataGridView();
            lblAllReservations = new Label();
            btnUpdate = new Button();
            btnAdd = new Button();
            dgvRooms = new DataGridView();
            ctmsRoomDelete = new ContextMenuStrip(components);
            lblManageRoom = new Label();
            txtRoomPrice = new TextBox();
            txtRoomType = new TextBox();
            chkAvailable = new CheckBox();
            txtRoomId = new TextBox();
            btnList = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnListCustomer = new Button();
            btnUpdateCustomer = new Button();
            btnAddCustomer = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtCustomerId = new TextBox();
            txtCustomerName = new TextBox();
            txtCustomerContact = new TextBox();
            panel1 = new Panel();
            label7 = new Label();
            label8 = new Label();
            txtCustomerPassword = new TextBox();
            button1 = new Button();
            btnClear = new Button();
            btnRefresh = new Button();
            btnListReservation = new Button();
            btnReservationUpdate = new Button();
            btnReservation = new Button();
            ctmsReservationDelete = new ContextMenuStrip(components);
            label9 = new Label();
            txtReservationId = new TextBox();
            label10 = new Label();
            txtReservationRoomId = new TextBox();
            label11 = new Label();
            txtReservationCustomerId = new TextBox();
            dtpInDate = new DateTimePicker();
            label12 = new Label();
            txtStatus = new TextBox();
            label13 = new Label();
            dtpCheckOut = new DateTimePicker();
            label14 = new Label();
            btnBack = new Button();
            btnDelete = new Button();
            btnDeleteReservation = new Button();
            btnDeleteCustomer = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCustomerInformation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvReservations).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCustomerInformation
            // 
            dgvCustomerInformation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomerInformation.ContextMenuStrip = ctmsDelete;
            dgvCustomerInformation.Location = new Point(121, 639);
            dgvCustomerInformation.Margin = new Padding(3, 4, 3, 4);
            dgvCustomerInformation.Name = "dgvCustomerInformation";
            dgvCustomerInformation.Size = new Size(764, 142);
            dgvCustomerInformation.TabIndex = 17;
            // 
            // ctmsDelete
            // 
            ctmsDelete.Name = "contextMenuStrip1";
            ctmsDelete.Size = new Size(61, 4);
            ctmsDelete.Text = "Delete";
            // 
            // lblCustomerInformation
            // 
            lblCustomerInformation.AutoSize = true;
            lblCustomerInformation.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            lblCustomerInformation.Location = new Point(6, 689);
            lblCustomerInformation.Name = "lblCustomerInformation";
            lblCustomerInformation.Size = new Size(88, 36);
            lblCustomerInformation.TabIndex = 16;
            lblCustomerInformation.Text = "Customer\r\nInformation";
            // 
            // dgvReservations
            // 
            dgvReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservations.Location = new Point(111, 413);
            dgvReservations.Margin = new Padding(3, 4, 3, 4);
            dgvReservations.Name = "dgvReservations";
            dgvReservations.Size = new Size(764, 177);
            dgvReservations.TabIndex = 15;
            // 
            // lblAllReservations
            // 
            lblAllReservations.AutoSize = true;
            lblAllReservations.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            lblAllReservations.Location = new Point(6, 502);
            lblAllReservations.Name = "lblAllReservations";
            lblAllReservations.Size = new Size(103, 36);
            lblAllReservations.TabIndex = 14;
            lblAllReservations.Text = "All \r\nReservations";
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Arial", 11.25F);
            btnUpdate.Location = new Point(877, 247);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(130, 30);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update Room";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Arial", 11.25F);
            btnAdd.Location = new Point(877, 185);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 28);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add Room";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvRooms
            // 
            dgvRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRooms.ContextMenuStrip = ctmsRoomDelete;
            dgvRooms.Location = new Point(111, 107);
            dgvRooms.Margin = new Padding(3, 4, 3, 4);
            dgvRooms.Name = "dgvRooms";
            dgvRooms.Size = new Size(764, 201);
            dgvRooms.TabIndex = 10;
            // 
            // ctmsRoomDelete
            // 
            ctmsRoomDelete.Name = "ctmsRoomDelete";
            ctmsRoomDelete.Size = new Size(61, 4);
            ctmsRoomDelete.Text = "RoomDelete";
            // 
            // lblManageRoom
            // 
            lblManageRoom.AutoSize = true;
            lblManageRoom.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            lblManageRoom.Location = new Point(6, 175);
            lblManageRoom.Name = "lblManageRoom";
            lblManageRoom.Size = new Size(64, 36);
            lblManageRoom.TabIndex = 9;
            lblManageRoom.Text = "Manage\r\nRoom";
            // 
            // txtRoomPrice
            // 
            txtRoomPrice.Font = new Font("Arial", 11.25F);
            txtRoomPrice.Location = new Point(620, 76);
            txtRoomPrice.Margin = new Padding(3, 4, 3, 4);
            txtRoomPrice.Name = "txtRoomPrice";
            txtRoomPrice.Size = new Size(151, 25);
            txtRoomPrice.TabIndex = 18;
            // 
            // txtRoomType
            // 
            txtRoomType.Font = new Font("Arial", 11.25F);
            txtRoomType.Location = new Point(374, 76);
            txtRoomType.Margin = new Padding(3, 4, 3, 4);
            txtRoomType.Name = "txtRoomType";
            txtRoomType.Size = new Size(151, 25);
            txtRoomType.TabIndex = 19;
            // 
            // chkAvailable
            // 
            chkAvailable.AutoSize = true;
            chkAvailable.Font = new Font("Arial", 11.25F);
            chkAvailable.Location = new Point(782, 79);
            chkAvailable.Margin = new Padding(3, 4, 3, 4);
            chkAvailable.Name = "chkAvailable";
            chkAvailable.Size = new Size(133, 21);
            chkAvailable.TabIndex = 20;
            chkAvailable.Text = "RoomAvailability";
            chkAvailable.UseVisualStyleBackColor = true;
            // 
            // txtRoomId
            // 
            txtRoomId.Font = new Font("Arial", 11.25F);
            txtRoomId.Location = new Point(136, 76);
            txtRoomId.Margin = new Padding(3, 4, 3, 4);
            txtRoomId.Name = "txtRoomId";
            txtRoomId.Size = new Size(151, 25);
            txtRoomId.TabIndex = 21;
            // 
            // btnList
            // 
            btnList.Font = new Font("Arial", 11.25F);
            btnList.Location = new Point(877, 219);
            btnList.Margin = new Padding(3, 4, 3, 4);
            btnList.Name = "btnList";
            btnList.Size = new Size(130, 24);
            btnList.TabIndex = 22;
            btnList.Text = "List Room";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11.25F);
            label1.Location = new Point(74, 80);
            label1.Name = "label1";
            label1.Size = new Size(63, 17);
            label1.TabIndex = 23;
            label1.Text = "RoomId:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F);
            label2.Location = new Point(288, 80);
            label2.Name = "label2";
            label2.Size = new Size(87, 17);
            label2.TabIndex = 24;
            label2.Text = "Room Type:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F);
            label3.Location = new Point(531, 80);
            label3.Name = "label3";
            label3.Size = new Size(90, 17);
            label3.TabIndex = 25;
            label3.Text = "Room Price:";
            // 
            // btnListCustomer
            // 
            btnListCustomer.Location = new Point(900, 688);
            btnListCustomer.Margin = new Padding(3, 4, 3, 4);
            btnListCustomer.Name = "btnListCustomer";
            btnListCustomer.Size = new Size(132, 26);
            btnListCustomer.TabIndex = 28;
            btnListCustomer.Text = "List Customer";
            btnListCustomer.UseVisualStyleBackColor = true;
            btnListCustomer.Click += btnListCustomer_Click;
            // 
            // btnUpdateCustomer
            // 
            btnUpdateCustomer.Location = new Point(900, 721);
            btnUpdateCustomer.Margin = new Padding(3, 4, 3, 4);
            btnUpdateCustomer.Name = "btnUpdateCustomer";
            btnUpdateCustomer.Size = new Size(132, 26);
            btnUpdateCustomer.TabIndex = 27;
            btnUpdateCustomer.Text = "Update Customer";
            btnUpdateCustomer.UseVisualStyleBackColor = true;
            btnUpdateCustomer.Click += btnUpdateCustomer_Click;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(900, 654);
            btnAddCustomer.Margin = new Padding(3, 4, 3, 4);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(132, 26);
            btnAddCustomer.TabIndex = 26;
            btnAddCustomer.Text = "Add Customer";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(828, 603);
            label4.Name = "label4";
            label4.Size = new Size(132, 17);
            label4.TabIndex = 34;
            label4.Text = "Customer Contact:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(257, 607);
            label5.Name = "label5";
            label5.Size = new Size(120, 17);
            label5.TabIndex = 33;
            label5.Text = "Customer Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 11.25F);
            label6.Location = new Point(24, 608);
            label6.Name = "label6";
            label6.Size = new Size(88, 17);
            label6.TabIndex = 32;
            label6.Text = "CustomerId:";
            // 
            // txtCustomerId
            // 
            txtCustomerId.Location = new Point(111, 602);
            txtCustomerId.Margin = new Padding(3, 4, 3, 4);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.Size = new Size(145, 25);
            txtCustomerId.TabIndex = 31;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(376, 602);
            txtCustomerName.Margin = new Padding(3, 4, 3, 4);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(151, 25);
            txtCustomerName.TabIndex = 30;
            // 
            // txtCustomerContact
            // 
            txtCustomerContact.Location = new Point(959, 599);
            txtCustomerContact.Margin = new Padding(3, 4, 3, 4);
            txtCustomerContact.Name = "txtCustomerContact";
            txtCustomerContact.Size = new Size(151, 25);
            txtCustomerContact.TabIndex = 29;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label7);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1145, 58);
            panel1.TabIndex = 35;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Book Antiqua", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(420, 9);
            label7.Name = "label7";
            label7.Size = new Size(244, 44);
            label7.TabIndex = 0;
            label7.Text = "Admin Panel";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(529, 606);
            label8.Name = "label8";
            label8.Size = new Size(147, 17);
            label8.TabIndex = 37;
            label8.Text = "Customer Password:";
            // 
            // txtCustomerPassword
            // 
            txtCustomerPassword.Location = new Point(675, 600);
            txtCustomerPassword.Margin = new Padding(3, 4, 3, 4);
            txtCustomerPassword.Name = "txtCustomerPassword";
            txtCustomerPassword.Size = new Size(151, 25);
            txtCustomerPassword.TabIndex = 36;
            // 
            // button1
            // 
            button1.Location = new Point(620, 785);
            button1.Name = "button1";
            button1.Size = new Size(81, 26);
            button1.TabIndex = 38;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(448, 784);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(81, 26);
            btnClear.TabIndex = 39;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(361, 784);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(81, 26);
            btnRefresh.TabIndex = 40;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnListReservation
            // 
            btnListReservation.Font = new Font("Arial", 11.25F);
            btnListReservation.Location = new Point(880, 498);
            btnListReservation.Margin = new Padding(3, 4, 3, 4);
            btnListReservation.Name = "btnListReservation";
            btnListReservation.Size = new Size(152, 25);
            btnListReservation.TabIndex = 43;
            btnListReservation.Text = "List Reservation";
            btnListReservation.UseVisualStyleBackColor = true;
            btnListReservation.Click += btnListReservation_Click;
            // 
            // btnReservationUpdate
            // 
            btnReservationUpdate.Font = new Font("Arial", 11.25F);
            btnReservationUpdate.Location = new Point(880, 531);
            btnReservationUpdate.Margin = new Padding(3, 4, 3, 4);
            btnReservationUpdate.Name = "btnReservationUpdate";
            btnReservationUpdate.Size = new Size(152, 26);
            btnReservationUpdate.TabIndex = 42;
            btnReservationUpdate.Text = "Update Reservation";
            btnReservationUpdate.UseVisualStyleBackColor = true;
            btnReservationUpdate.Click += btnReservationUpdate_Click;
            // 
            // btnReservation
            // 
            btnReservation.Font = new Font("Arial", 11.25F);
            btnReservation.Location = new Point(880, 464);
            btnReservation.Margin = new Padding(3, 4, 3, 4);
            btnReservation.Name = "btnReservation";
            btnReservation.Size = new Size(152, 26);
            btnReservation.TabIndex = 41;
            btnReservation.Text = "Add Reservation";
            btnReservation.UseVisualStyleBackColor = true;
            btnReservation.Click += btnReservation_Click;
            // 
            // ctmsReservationDelete
            // 
            ctmsReservationDelete.Name = "ctmsReservationDelete";
            ctmsReservationDelete.Size = new Size(61, 4);
            ctmsReservationDelete.Text = "ReservationDelete";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 11.25F);
            label9.Location = new Point(88, 321);
            label9.Name = "label9";
            label9.Size = new Size(101, 17);
            label9.TabIndex = 45;
            label9.Text = "ReservationId:";
            // 
            // txtReservationId
            // 
            txtReservationId.Location = new Point(188, 316);
            txtReservationId.Margin = new Padding(3, 4, 3, 4);
            txtReservationId.Name = "txtReservationId";
            txtReservationId.Size = new Size(157, 25);
            txtReservationId.TabIndex = 44;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 11.25F);
            label10.Location = new Point(124, 351);
            label10.Name = "label10";
            label10.Size = new Size(63, 17);
            label10.TabIndex = 47;
            label10.Text = "RoomId:";
            // 
            // txtReservationRoomId
            // 
            txtReservationRoomId.Location = new Point(188, 348);
            txtReservationRoomId.Margin = new Padding(3, 4, 3, 4);
            txtReservationRoomId.Name = "txtReservationRoomId";
            txtReservationRoomId.Size = new Size(157, 25);
            txtReservationRoomId.TabIndex = 46;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 11.25F);
            label11.Location = new Point(100, 383);
            label11.Name = "label11";
            label11.Size = new Size(88, 17);
            label11.TabIndex = 49;
            label11.Text = "CustomerId:";
            // 
            // txtReservationCustomerId
            // 
            txtReservationCustomerId.Location = new Point(188, 380);
            txtReservationCustomerId.Margin = new Padding(3, 4, 3, 4);
            txtReservationCustomerId.Name = "txtReservationCustomerId";
            txtReservationCustomerId.Size = new Size(157, 25);
            txtReservationCustomerId.TabIndex = 48;
            // 
            // dtpInDate
            // 
            dtpInDate.Location = new Point(469, 315);
            dtpInDate.Name = "dtpInDate";
            dtpInDate.Size = new Size(204, 25);
            dtpInDate.TabIndex = 50;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 11.25F);
            label12.Location = new Point(374, 318);
            label12.Name = "label12";
            label12.Size = new Size(96, 17);
            label12.TabIndex = 52;
            label12.Text = "CheckInDate:";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(472, 382);
            txtStatus.Margin = new Padding(3, 4, 3, 4);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(201, 25);
            txtStatus.TabIndex = 51;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 11.25F);
            label13.Location = new Point(361, 354);
            label13.Name = "label13";
            label13.Size = new Size(109, 17);
            label13.TabIndex = 54;
            label13.Text = "CheckOutDate:";
            // 
            // dtpCheckOut
            // 
            dtpCheckOut.Location = new Point(472, 351);
            dtpCheckOut.Name = "dtpCheckOut";
            dtpCheckOut.Size = new Size(204, 25);
            dtpCheckOut.TabIndex = 53;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 11.25F);
            label14.Location = new Point(416, 385);
            label14.Name = "label14";
            label14.Size = new Size(54, 17);
            label14.TabIndex = 55;
            label14.Text = "Status:";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(535, 784);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(81, 26);
            btnBack.TabIndex = 56;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Arial", 11.25F);
            btnDelete.Location = new Point(877, 280);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(130, 28);
            btnDelete.TabIndex = 57;
            btnDelete.Text = "Delete Room";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnDeleteReservation
            // 
            btnDeleteReservation.Font = new Font("Arial", 11.25F);
            btnDeleteReservation.Location = new Point(880, 565);
            btnDeleteReservation.Margin = new Padding(3, 4, 3, 4);
            btnDeleteReservation.Name = "btnDeleteReservation";
            btnDeleteReservation.Size = new Size(152, 25);
            btnDeleteReservation.TabIndex = 58;
            btnDeleteReservation.Text = "Delete Reservation";
            btnDeleteReservation.UseVisualStyleBackColor = true;
            btnDeleteReservation.Click += btnDeleteReservation_Click;
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.Location = new Point(900, 755);
            btnDeleteCustomer.Margin = new Padding(3, 4, 3, 4);
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(132, 26);
            btnDeleteCustomer.TabIndex = 59;
            btnDeleteCustomer.Text = "Delete Customer";
            btnDeleteCustomer.UseVisualStyleBackColor = true;
            btnDeleteCustomer.Click += btnDeleteCustomer_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(1114, 811);
            Controls.Add(btnDeleteCustomer);
            Controls.Add(btnDeleteReservation);
            Controls.Add(btnDelete);
            Controls.Add(btnBack);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(dtpCheckOut);
            Controls.Add(label12);
            Controls.Add(txtStatus);
            Controls.Add(dtpInDate);
            Controls.Add(label11);
            Controls.Add(txtReservationCustomerId);
            Controls.Add(label10);
            Controls.Add(txtReservationRoomId);
            Controls.Add(label9);
            Controls.Add(txtReservationId);
            Controls.Add(btnListReservation);
            Controls.Add(btnReservationUpdate);
            Controls.Add(btnReservation);
            Controls.Add(btnRefresh);
            Controls.Add(btnClear);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(txtCustomerPassword);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(txtCustomerId);
            Controls.Add(txtCustomerName);
            Controls.Add(txtCustomerContact);
            Controls.Add(btnListCustomer);
            Controls.Add(btnUpdateCustomer);
            Controls.Add(btnAddCustomer);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnList);
            Controls.Add(txtRoomId);
            Controls.Add(chkAvailable);
            Controls.Add(txtRoomType);
            Controls.Add(txtRoomPrice);
            Controls.Add(dgvCustomerInformation);
            Controls.Add(lblCustomerInformation);
            Controls.Add(dgvReservations);
            Controls.Add(lblAllReservations);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgvRooms);
            Controls.Add(lblManageRoom);
            Font = new Font("Arial", 11.25F);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)dgvCustomerInformation).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvReservations).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCustomerInformation;
        private Label lblCustomerInformation;
        private DataGridView dgvReservations;
        private Label lblAllReservations;
        private Button btnUpdate;
        private Button btnAdd;
        private DataGridView dgvRooms;
        private Label lblManageRoom;
        private TextBox txtRoomPrice;
        private TextBox txtRoomType;
        private CheckBox chkAvailable;
        private TextBox txtRoomId;
        private Button btnList;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnListCustomer;
        private Button btnUpdateCustomer;
        private Button btnAddCustomer;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtCustomerId;
        private TextBox txtCustomerName;
        private TextBox txtCustomerContact;
        private ContextMenuStrip ctmsDelete;
        private ToolStripMenuItem toolStripMenuItem1;
        private ContextMenuStrip ctmsRoomDelete;
        private Panel panel1;
        private Label label7;
        private Label label8;
        private TextBox txtCustomerPassword;
        private Button button1;
        private Button btnClear;
        private Button btnRefresh;
        private Button btnListReservation;
        private Button btnReservationUpdate;
        private Button btnReservation;
        private ContextMenuStrip ctmsReservationDelete;
        private Label label9;
        private TextBox txtReservationId;
        private Label label10;
        private TextBox txtReservationRoomId;
        private Label label11;
        private TextBox txtReservationCustomerId;
        private DateTimePicker dtpInDate;
        private Label label12;
        private TextBox txtStatus;
        private Label label13;
        private DateTimePicker dtpCheckOut;
        private Label label14;
        private Button btnBack;
        private Button btnDelete;
        private Button btnDeleteReservation;
        private Button btnDeleteCustomer;
    }
}