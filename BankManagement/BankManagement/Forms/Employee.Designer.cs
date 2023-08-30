namespace BankManagement.Forms
{
    partial class Employee
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
            this.components = new System.ComponentModel.Container();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dtpJoinDate = new System.Windows.Forms.DateTimePicker();
            this.txtEmployeeAddress = new System.Windows.Forms.TextBox();
            this.txtEmpNID = new System.Windows.Forms.TextBox();
            this.txtEmployeeEmail = new System.Windows.Forms.TextBox();
            this.txtEmpPassword = new System.Windows.Forms.TextBox();
            this.txtEmpUserName = new System.Windows.Forms.TextBox();
            this.lblEmployeeAddress = new System.Windows.Forms.Label();
            this.lblEmpJoinDate = new System.Windows.Forms.Label();
            this.lblEmpNID = new System.Windows.Forms.Label();
            this.lblEmpPassword = new System.Windows.Forms.Label();
            this.lblEmpEmail = new System.Windows.Forms.Label();
            this.lblEmpUsername = new System.Windows.Forms.Label();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.rbNotActive = new System.Windows.Forms.RadioButton();
            this.rbActive = new System.Windows.Forms.RadioButton();
            this.pbEmployee = new System.Windows.Forms.PictureBox();
            this.txtEmpFullName = new System.Windows.Forms.TextBox();
            this.lblEmpStatus = new System.Windows.Forms.Label();
            this.lblEmployeeFullName = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(998, 493);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 31);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(170, 407);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(202, 29);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(169, 362);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(202, 29);
            this.btnBrowse.TabIndex = 5;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(858, 493);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 31);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(706, 493);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(93, 31);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dtpJoinDate
            // 
            this.dtpJoinDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpJoinDate.Location = new System.Drawing.Point(173, 221);
            this.dtpJoinDate.Name = "dtpJoinDate";
            this.dtpJoinDate.Size = new System.Drawing.Size(202, 26);
            this.dtpJoinDate.TabIndex = 3;
            // 
            // txtEmployeeAddress
            // 
            this.txtEmployeeAddress.Location = new System.Drawing.Point(171, 258);
            this.txtEmployeeAddress.Name = "txtEmployeeAddress";
            this.txtEmployeeAddress.Size = new System.Drawing.Size(206, 26);
            this.txtEmployeeAddress.TabIndex = 1;
            // 
            // txtEmpNID
            // 
            this.txtEmpNID.Location = new System.Drawing.Point(173, 184);
            this.txtEmpNID.Name = "txtEmpNID";
            this.txtEmpNID.Size = new System.Drawing.Size(204, 26);
            this.txtEmpNID.TabIndex = 1;
            // 
            // txtEmployeeEmail
            // 
            this.txtEmployeeEmail.Location = new System.Drawing.Point(173, 146);
            this.txtEmployeeEmail.Name = "txtEmployeeEmail";
            this.txtEmployeeEmail.Size = new System.Drawing.Size(204, 26);
            this.txtEmployeeEmail.TabIndex = 1;
            // 
            // txtEmpPassword
            // 
            this.txtEmpPassword.Location = new System.Drawing.Point(173, 105);
            this.txtEmpPassword.Name = "txtEmpPassword";
            this.txtEmpPassword.Size = new System.Drawing.Size(204, 26);
            this.txtEmpPassword.TabIndex = 1;
            // 
            // txtEmpUserName
            // 
            this.txtEmpUserName.Location = new System.Drawing.Point(171, 69);
            this.txtEmpUserName.Name = "txtEmpUserName";
            this.txtEmpUserName.Size = new System.Drawing.Size(204, 26);
            this.txtEmpUserName.TabIndex = 1;
            // 
            // lblEmployeeAddress
            // 
            this.lblEmployeeAddress.AutoSize = true;
            this.lblEmployeeAddress.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeAddress.Location = new System.Drawing.Point(9, 263);
            this.lblEmployeeAddress.Name = "lblEmployeeAddress";
            this.lblEmployeeAddress.Size = new System.Drawing.Size(59, 16);
            this.lblEmployeeAddress.TabIndex = 0;
            this.lblEmployeeAddress.Text = "Address";
            // 
            // lblEmpJoinDate
            // 
            this.lblEmpJoinDate.AutoSize = true;
            this.lblEmpJoinDate.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpJoinDate.Location = new System.Drawing.Point(9, 229);
            this.lblEmpJoinDate.Name = "lblEmpJoinDate";
            this.lblEmpJoinDate.Size = new System.Drawing.Size(129, 16);
            this.lblEmpJoinDate.TabIndex = 0;
            this.lblEmpJoinDate.Text = "Join Date           :";
            // 
            // lblEmpNID
            // 
            this.lblEmpNID.AutoSize = true;
            this.lblEmpNID.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpNID.Location = new System.Drawing.Point(9, 189);
            this.lblEmpNID.Name = "lblEmpNID";
            this.lblEmpNID.Size = new System.Drawing.Size(97, 16);
            this.lblEmpNID.TabIndex = 0;
            this.lblEmpNID.Text = "Employee NID";
            // 
            // lblEmpPassword
            // 
            this.lblEmpPassword.AutoSize = true;
            this.lblEmpPassword.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpPassword.Location = new System.Drawing.Point(9, 110);
            this.lblEmpPassword.Name = "lblEmpPassword";
            this.lblEmpPassword.Size = new System.Drawing.Size(155, 16);
            this.lblEmpPassword.TabIndex = 0;
            this.lblEmpPassword.Text = "Password                :";
            // 
            // lblEmpEmail
            // 
            this.lblEmpEmail.AutoSize = true;
            this.lblEmpEmail.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpEmail.Location = new System.Drawing.Point(9, 151);
            this.lblEmpEmail.Name = "lblEmpEmail";
            this.lblEmpEmail.Size = new System.Drawing.Size(153, 16);
            this.lblEmpEmail.TabIndex = 0;
            this.lblEmpEmail.Text = "Employee Email       : ";
            // 
            // lblEmpUsername
            // 
            this.lblEmpUsername.AutoSize = true;
            this.lblEmpUsername.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpUsername.Location = new System.Drawing.Point(9, 74);
            this.lblEmpUsername.Name = "lblEmpUsername";
            this.lblEmpUsername.Size = new System.Drawing.Size(133, 16);
            this.lblEmpUsername.TabIndex = 0;
            this.lblEmpUsername.Text = "UserName           :";
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(12, 12);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowHeadersWidth = 51;
            this.dgvEmployee.RowTemplate.Height = 24;
            this.dgvEmployee.Size = new System.Drawing.Size(662, 512);
            this.dgvEmployee.TabIndex = 8;
            this.dgvEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox1.Controls.Add(this.lblEmployeeId);
            this.groupBox1.Controls.Add(this.rbNotActive);
            this.groupBox1.Controls.Add(this.rbActive);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.pbEmployee);
            this.groupBox1.Controls.Add(this.dtpJoinDate);
            this.groupBox1.Controls.Add(this.txtEmployeeAddress);
            this.groupBox1.Controls.Add(this.txtEmpNID);
            this.groupBox1.Controls.Add(this.txtEmployeeEmail);
            this.groupBox1.Controls.Add(this.txtEmpPassword);
            this.groupBox1.Controls.Add(this.txtEmpFullName);
            this.groupBox1.Controls.Add(this.txtEmpUserName);
            this.groupBox1.Controls.Add(this.lblEmployeeAddress);
            this.groupBox1.Controls.Add(this.lblEmpStatus);
            this.groupBox1.Controls.Add(this.lblEmpJoinDate);
            this.groupBox1.Controls.Add(this.lblEmployeeFullName);
            this.groupBox1.Controls.Add(this.lblEmpNID);
            this.groupBox1.Controls.Add(this.lblEmpPassword);
            this.groupBox1.Controls.Add(this.lblEmpEmail);
            this.groupBox1.Controls.Add(this.lblEmpUsername);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(699, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 472);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee  Information";
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Location = new System.Drawing.Point(192, 451);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(102, 18);
            this.lblEmployeeId.TabIndex = 12;
            this.lblEmployeeId.Text = "Employeeid";
            // 
            // rbNotActive
            // 
            this.rbNotActive.AutoSize = true;
            this.rbNotActive.Location = new System.Drawing.Point(266, 301);
            this.rbNotActive.Name = "rbNotActive";
            this.rbNotActive.Size = new System.Drawing.Size(114, 22);
            this.rbNotActive.TabIndex = 8;
            this.rbNotActive.TabStop = true;
            this.rbNotActive.Text = "Not Active";
            this.rbNotActive.UseVisualStyleBackColor = true;
            this.rbNotActive.CheckedChanged += new System.EventHandler(this.rbNotActive_CheckedChanged);
            // 
            // rbActive
            // 
            this.rbActive.AutoSize = true;
            this.rbActive.Location = new System.Drawing.Point(169, 301);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(80, 22);
            this.rbActive.TabIndex = 8;
            this.rbActive.TabStop = true;
            this.rbActive.Text = "Active";
            this.rbActive.UseVisualStyleBackColor = true;
            this.rbActive.CheckedChanged += new System.EventHandler(this.rbActive_CheckedChanged);
            // 
            // pbEmployee
            // 
            this.pbEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbEmployee.Location = new System.Drawing.Point(7, 343);
            this.pbEmployee.Name = "pbEmployee";
            this.pbEmployee.Size = new System.Drawing.Size(133, 111);
            this.pbEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEmployee.TabIndex = 4;
            this.pbEmployee.TabStop = false;
            // 
            // txtEmpFullName
            // 
            this.txtEmpFullName.Location = new System.Drawing.Point(173, 34);
            this.txtEmpFullName.Name = "txtEmpFullName";
            this.txtEmpFullName.Size = new System.Drawing.Size(204, 26);
            this.txtEmpFullName.TabIndex = 1;
            // 
            // lblEmpStatus
            // 
            this.lblEmpStatus.AutoSize = true;
            this.lblEmpStatus.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpStatus.Location = new System.Drawing.Point(9, 305);
            this.lblEmpStatus.Name = "lblEmpStatus";
            this.lblEmpStatus.Size = new System.Drawing.Size(107, 16);
            this.lblEmpStatus.TabIndex = 0;
            this.lblEmpStatus.Text = "Status          :";
            // 
            // lblEmployeeFullName
            // 
            this.lblEmployeeFullName.AutoSize = true;
            this.lblEmployeeFullName.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeFullName.Location = new System.Drawing.Point(9, 39);
            this.lblEmployeeFullName.Name = "lblEmployeeFullName";
            this.lblEmployeeFullName.Size = new System.Drawing.Size(153, 16);
            this.lblEmployeeFullName.TabIndex = 0;
            this.lblEmployeeFullName.Text = "Employee Full Name  :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1119, 630);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.groupBox1);
            this.Name = "Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.PictureBox pbEmployee;
        private System.Windows.Forms.DateTimePicker dtpJoinDate;
        private System.Windows.Forms.TextBox txtEmployeeAddress;
        private System.Windows.Forms.TextBox txtEmpNID;
        private System.Windows.Forms.TextBox txtEmployeeEmail;
        private System.Windows.Forms.TextBox txtEmpPassword;
        private System.Windows.Forms.TextBox txtEmpUserName;
        private System.Windows.Forms.Label lblEmployeeAddress;
        private System.Windows.Forms.Label lblEmpJoinDate;
        private System.Windows.Forms.Label lblEmpNID;
        private System.Windows.Forms.Label lblEmpPassword;
        private System.Windows.Forms.Label lblEmpEmail;
        private System.Windows.Forms.Label lblEmpUsername;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmpFullName;
        private System.Windows.Forms.Label lblEmployeeFullName;
        private System.Windows.Forms.Label lblEmpStatus;
        private System.Windows.Forms.RadioButton rbNotActive;
        private System.Windows.Forms.RadioButton rbActive;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}