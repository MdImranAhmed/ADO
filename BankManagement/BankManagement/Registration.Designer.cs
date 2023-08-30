namespace BankManagement
{
    partial class Registration
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNotActive = new System.Windows.Forms.RadioButton();
            this.rbActive = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.pbEmployee = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmployeeFullName = new System.Windows.Forms.Label();
            this.txtEmployeeAddress = new System.Windows.Forms.TextBox();
            this.lblEmpStatus = new System.Windows.Forms.Label();
            this.dtpJoinDate = new System.Windows.Forms.DateTimePicker();
            this.txtEmpFullName = new System.Windows.Forms.TextBox();
            this.lblEmployeeAddress = new System.Windows.Forms.Label();
            this.lblEmpUsername = new System.Windows.Forms.Label();
            this.txtEmpNID = new System.Windows.Forms.TextBox();
            this.txtEmpUserName = new System.Windows.Forms.TextBox();
            this.txtEmployeeEmail = new System.Windows.Forms.TextBox();
            this.lblEmpJoinDate = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblconfirmPassword = new System.Windows.Forms.Label();
            this.txtEmpConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtEmpPassword = new System.Windows.Forms.TextBox();
            this.lblEmpEmail = new System.Windows.Forms.Label();
            this.lblEmpNID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::BankManagement.Properties.Resources.out__removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(12, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(523, 366);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rbNotActive);
            this.groupBox1.Controls.Add(this.rbActive);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.btnRegister);
            this.groupBox1.Controls.Add(this.pbEmployee);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblEmployeeFullName);
            this.groupBox1.Controls.Add(this.txtEmployeeAddress);
            this.groupBox1.Controls.Add(this.lblEmpStatus);
            this.groupBox1.Controls.Add(this.dtpJoinDate);
            this.groupBox1.Controls.Add(this.txtEmpFullName);
            this.groupBox1.Controls.Add(this.lblEmployeeAddress);
            this.groupBox1.Controls.Add(this.lblEmpUsername);
            this.groupBox1.Controls.Add(this.txtEmpNID);
            this.groupBox1.Controls.Add(this.txtEmpUserName);
            this.groupBox1.Controls.Add(this.txtEmployeeEmail);
            this.groupBox1.Controls.Add(this.lblEmpJoinDate);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.lblconfirmPassword);
            this.groupBox1.Controls.Add(this.txtEmpConfirmPassword);
            this.groupBox1.Controls.Add(this.txtEmpPassword);
            this.groupBox1.Controls.Add(this.lblEmpEmail);
            this.groupBox1.Controls.Add(this.lblEmpNID);
            this.groupBox1.Location = new System.Drawing.Point(541, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 473);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // rbNotActive
            // 
            this.rbNotActive.AutoSize = true;
            this.rbNotActive.Location = new System.Drawing.Point(327, 346);
            this.rbNotActive.Name = "rbNotActive";
            this.rbNotActive.Size = new System.Drawing.Size(89, 20);
            this.rbNotActive.TabIndex = 39;
            this.rbNotActive.TabStop = true;
            this.rbNotActive.Text = "Not Active";
            this.rbNotActive.UseVisualStyleBackColor = true;
            this.rbNotActive.CheckedChanged += new System.EventHandler(this.rbNotActive_CheckedChanged);
            // 
            // rbActive
            // 
            this.rbActive.AutoSize = true;
            this.rbActive.Location = new System.Drawing.Point(218, 346);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(65, 20);
            this.rbActive.TabIndex = 38;
            this.rbActive.TabStop = true;
            this.rbActive.Text = "Active";
            this.rbActive.UseVisualStyleBackColor = true;
            this.rbActive.CheckedChanged += new System.EventHandler(this.rbActive_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(463, 259);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(133, 29);
            this.btnClear.TabIndex = 36;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(463, 221);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(133, 29);
            this.btnBrowse.TabIndex = 35;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click_1);
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(187, 424);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(166, 43);
            this.btnRegister.TabIndex = 37;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click_1);
            // 
            // pbEmployee
            // 
            this.pbEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbEmployee.Location = new System.Drawing.Point(463, 86);
            this.pbEmployee.Name = "pbEmployee";
            this.pbEmployee.Size = new System.Drawing.Size(133, 111);
            this.pbEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEmployee.TabIndex = 34;
            this.pbEmployee.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 37);
            this.label1.TabIndex = 32;
            this.label1.Text = "Ready to Register";
            // 
            // lblEmployeeFullName
            // 
            this.lblEmployeeFullName.AutoSize = true;
            this.lblEmployeeFullName.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeFullName.Location = new System.Drawing.Point(44, 86);
            this.lblEmployeeFullName.Name = "lblEmployeeFullName";
            this.lblEmployeeFullName.Size = new System.Drawing.Size(137, 16);
            this.lblEmployeeFullName.TabIndex = 20;
            this.lblEmployeeFullName.Text = "Employee Full Name";
            // 
            // txtEmployeeAddress
            // 
            this.txtEmployeeAddress.Location = new System.Drawing.Point(216, 311);
            this.txtEmployeeAddress.Name = "txtEmployeeAddress";
            this.txtEmployeeAddress.Size = new System.Drawing.Size(206, 22);
            this.txtEmployeeAddress.TabIndex = 31;
            // 
            // lblEmpStatus
            // 
            this.lblEmpStatus.AutoSize = true;
            this.lblEmpStatus.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpStatus.Location = new System.Drawing.Point(44, 346);
            this.lblEmpStatus.Name = "lblEmpStatus";
            this.lblEmpStatus.Size = new System.Drawing.Size(107, 16);
            this.lblEmpStatus.TabIndex = 21;
            this.lblEmpStatus.Text = "Status          :";
            // 
            // dtpJoinDate
            // 
            this.dtpJoinDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpJoinDate.Location = new System.Drawing.Point(219, 279);
            this.dtpJoinDate.Name = "dtpJoinDate";
            this.dtpJoinDate.Size = new System.Drawing.Size(203, 22);
            this.dtpJoinDate.TabIndex = 33;
            // 
            // txtEmpFullName
            // 
            this.txtEmpFullName.Location = new System.Drawing.Point(218, 81);
            this.txtEmpFullName.Name = "txtEmpFullName";
            this.txtEmpFullName.Size = new System.Drawing.Size(205, 22);
            this.txtEmpFullName.TabIndex = 30;
            // 
            // lblEmployeeAddress
            // 
            this.lblEmployeeAddress.AutoSize = true;
            this.lblEmployeeAddress.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeAddress.Location = new System.Drawing.Point(44, 317);
            this.lblEmployeeAddress.Name = "lblEmployeeAddress";
            this.lblEmployeeAddress.Size = new System.Drawing.Size(59, 16);
            this.lblEmployeeAddress.TabIndex = 23;
            this.lblEmployeeAddress.Text = "Address";
            // 
            // lblEmpUsername
            // 
            this.lblEmpUsername.AutoSize = true;
            this.lblEmpUsername.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpUsername.Location = new System.Drawing.Point(44, 117);
            this.lblEmpUsername.Name = "lblEmpUsername";
            this.lblEmpUsername.Size = new System.Drawing.Size(133, 16);
            this.lblEmpUsername.TabIndex = 24;
            this.lblEmpUsername.Text = "UserName           :";
            // 
            // txtEmpNID
            // 
            this.txtEmpNID.Location = new System.Drawing.Point(219, 248);
            this.txtEmpNID.Name = "txtEmpNID";
            this.txtEmpNID.Size = new System.Drawing.Size(204, 22);
            this.txtEmpNID.TabIndex = 29;
            // 
            // txtEmpUserName
            // 
            this.txtEmpUserName.Location = new System.Drawing.Point(218, 117);
            this.txtEmpUserName.Name = "txtEmpUserName";
            this.txtEmpUserName.Size = new System.Drawing.Size(204, 22);
            this.txtEmpUserName.TabIndex = 28;
            // 
            // txtEmployeeEmail
            // 
            this.txtEmployeeEmail.Location = new System.Drawing.Point(218, 220);
            this.txtEmployeeEmail.Name = "txtEmployeeEmail";
            this.txtEmployeeEmail.Size = new System.Drawing.Size(204, 22);
            this.txtEmployeeEmail.TabIndex = 27;
            // 
            // lblEmpJoinDate
            // 
            this.lblEmpJoinDate.AutoSize = true;
            this.lblEmpJoinDate.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpJoinDate.Location = new System.Drawing.Point(44, 285);
            this.lblEmpJoinDate.Name = "lblEmpJoinDate";
            this.lblEmpJoinDate.Size = new System.Drawing.Size(129, 16);
            this.lblEmpJoinDate.TabIndex = 19;
            this.lblEmpJoinDate.Text = "Join Date           :";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(44, 155);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(155, 16);
            this.lblPassword.TabIndex = 18;
            this.lblPassword.Text = "Password                :";
            // 
            // lblconfirmPassword
            // 
            this.lblconfirmPassword.AutoSize = true;
            this.lblconfirmPassword.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconfirmPassword.Location = new System.Drawing.Point(44, 187);
            this.lblconfirmPassword.Name = "lblconfirmPassword";
            this.lblconfirmPassword.Size = new System.Drawing.Size(139, 16);
            this.lblconfirmPassword.TabIndex = 17;
            this.lblconfirmPassword.Text = "Confirm Password  :";
            // 
            // txtEmpConfirmPassword
            // 
            this.txtEmpConfirmPassword.Location = new System.Drawing.Point(217, 184);
            this.txtEmpConfirmPassword.Name = "txtEmpConfirmPassword";
            this.txtEmpConfirmPassword.Size = new System.Drawing.Size(204, 22);
            this.txtEmpConfirmPassword.TabIndex = 26;
            // 
            // txtEmpPassword
            // 
            this.txtEmpPassword.Location = new System.Drawing.Point(218, 152);
            this.txtEmpPassword.Name = "txtEmpPassword";
            this.txtEmpPassword.Size = new System.Drawing.Size(204, 22);
            this.txtEmpPassword.TabIndex = 25;
            // 
            // lblEmpEmail
            // 
            this.lblEmpEmail.AutoSize = true;
            this.lblEmpEmail.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpEmail.Location = new System.Drawing.Point(44, 223);
            this.lblEmpEmail.Name = "lblEmpEmail";
            this.lblEmpEmail.Size = new System.Drawing.Size(153, 16);
            this.lblEmpEmail.TabIndex = 22;
            this.lblEmpEmail.Text = "Employee Email       : ";
            // 
            // lblEmpNID
            // 
            this.lblEmpNID.AutoSize = true;
            this.lblEmpNID.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpNID.Location = new System.Drawing.Point(44, 254);
            this.lblEmpNID.Name = "lblEmpNID";
            this.lblEmpNID.Size = new System.Drawing.Size(97, 16);
            this.lblEmpNID.TabIndex = 16;
            this.lblEmpNID.Text = "Employee NID";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1183, 647);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.MinimumSize = new System.Drawing.Size(1201, 694);
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNotActive;
        private System.Windows.Forms.RadioButton rbActive;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.PictureBox pbEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmployeeFullName;
        private System.Windows.Forms.TextBox txtEmployeeAddress;
        private System.Windows.Forms.Label lblEmpStatus;
        private System.Windows.Forms.DateTimePicker dtpJoinDate;
        private System.Windows.Forms.TextBox txtEmpFullName;
        private System.Windows.Forms.Label lblEmployeeAddress;
        private System.Windows.Forms.Label lblEmpUsername;
        private System.Windows.Forms.TextBox txtEmpNID;
        private System.Windows.Forms.TextBox txtEmpUserName;
        private System.Windows.Forms.TextBox txtEmployeeEmail;
        private System.Windows.Forms.Label lblEmpJoinDate;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblconfirmPassword;
        private System.Windows.Forms.TextBox txtEmpConfirmPassword;
        private System.Windows.Forms.TextBox txtEmpPassword;
        private System.Windows.Forms.Label lblEmpEmail;
        private System.Windows.Forms.Label lblEmpNID;
    }
}