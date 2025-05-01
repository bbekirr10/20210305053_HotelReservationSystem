namespace HotelReservationSystem.UI
{
    partial class LoginForm
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
            btnLogin = new Button();
            cmbRole = new ComboBox();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            lblRole = new Label();
            lblPassword = new Label();
            lblUserName = new Label();
            panel1 = new Panel();
            label1 = new Label();
            btnExit = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Arial", 12F);
            btnLogin.Location = new Point(252, 211);
            btnLogin.Margin = new Padding(5);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(95, 36);
            btnLogin.TabIndex = 13;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(137, 180);
            cmbRole.Margin = new Padding(5);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(210, 26);
            cmbRole.TabIndex = 12;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(137, 127);
            txtPassword.Margin = new Padding(5);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(210, 26);
            txtPassword.TabIndex = 11;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(137, 73);
            txtUserName.Margin = new Padding(5);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(210, 26);
            txtUserName.TabIndex = 10;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Arial", 12F);
            lblRole.Location = new Point(83, 188);
            lblRole.Margin = new Padding(5, 0, 5, 0);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(44, 18);
            lblRole.TabIndex = 9;
            lblRole.Text = "Role:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Arial", 12F);
            lblPassword.Location = new Point(50, 135);
            lblPassword.Margin = new Padding(5, 0, 5, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(82, 18);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Password:";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Arial", 12F);
            lblUserName.Location = new Point(45, 81);
            lblUserName.Margin = new Padding(5, 0, 5, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(87, 18);
            lblUserName.TabIndex = 7;
            lblUserName.Text = "UserName:";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(532, 59);
            panel1.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(150, 2);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(241, 51);
            label1.TabIndex = 15;
            label1.Text = "Login Page";
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Arial", 12F);
            btnExit.Location = new Point(437, 244);
            btnExit.Margin = new Padding(5);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(95, 36);
            btnExit.TabIndex = 15;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(535, 284);
            Controls.Add(btnExit);
            Controls.Add(panel1);
            Controls.Add(btnLogin);
            Controls.Add(cmbRole);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(lblRole);
            Controls.Add(lblPassword);
            Controls.Add(lblUserName);
            Font = new Font("Arial", 12F);
            Margin = new Padding(4);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private ComboBox cmbRole;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Label lblRole;
        private Label lblPassword;
        private Label lblUserName;
        private Panel panel1;
        private Label label1;
        private Button btnExit;
    }
}