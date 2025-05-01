namespace HotelReservationSystem.UI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAdmin = new Button();
            btnReservation = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdmin
            // 
            btnAdmin.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnAdmin.Location = new Point(74, 213);
            btnAdmin.Margin = new Padding(7, 6, 7, 6);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(469, 68);
            btnAdmin.TabIndex = 3;
            btnAdmin.Text = "Admin Transactions";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // btnReservation
            // 
            btnReservation.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnReservation.Location = new Point(74, 132);
            btnReservation.Margin = new Padding(7, 6, 7, 6);
            btnReservation.Name = "btnReservation";
            btnReservation.Size = new Size(469, 68);
            btnReservation.TabIndex = 2;
            btnReservation.Text = "Reservation Transactions";
            btnReservation.UseVisualStyleBackColor = true;
            btnReservation.Click += btnReservation_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumAquamarine;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(7, 6, 7, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(644, 90);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(211, 25);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(241, 51);
            label1.TabIndex = 5;
            label1.Text = "Main Form";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(17F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(645, 316);
            Controls.Add(panel1);
            Controls.Add(btnAdmin);
            Controls.Add(btnReservation);
            Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(7, 6, 7, 6);
            Name = "MainForm";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdmin;
        private Button btnReservation;
        private Panel panel1;
        private Label label1;
    }
}
