namespace BankManagement.Forms
{
    partial class Customer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCustAccountNo = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pbCustomer = new System.Windows.Forms.PictureBox();
            this.dtpDateofBirth = new System.Windows.Forms.DateTimePicker();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.cmbAccountType = new System.Windows.Forms.ComboBox();
            this.txtDepositAmount = new System.Windows.Forms.TextBox();
            this.txtCustPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtCustNID = new System.Windows.Forms.TextBox();
            this.txtCustOccupation = new System.Windows.Forms.TextBox();
            this.txtFathersLName = new System.Windows.Forms.TextBox();
            this.txtFathersFName = new System.Windows.Forms.TextBox();
            this.txtCustAccountNo = new System.Windows.Forms.TextBox();
            this.txtCustLName = new System.Windows.Forms.TextBox();
            this.txtCustomerFName = new System.Windows.Forms.TextBox();
            this.lblDepositAmount = new System.Windows.Forms.Label();
            this.lblCustNID = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblOccupation = new System.Windows.Forms.Label();
            this.lblDateofBirth = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.lblFathersLName = new System.Windows.Forms.Label();
            this.lblCustomerLName = new System.Windows.Forms.Label();
            this.lblFathersFName = new System.Windows.Forms.Label();
            this.lblCustomerFName = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox1.Controls.Add(this.lblCustAccountNo);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.pbCustomer);
            this.groupBox1.Controls.Add(this.dtpDateofBirth);
            this.groupBox1.Controls.Add(this.cmbGender);
            this.groupBox1.Controls.Add(this.cmbAccountType);
            this.groupBox1.Controls.Add(this.txtDepositAmount);
            this.groupBox1.Controls.Add(this.txtCustPhoneNumber);
            this.groupBox1.Controls.Add(this.txtCustNID);
            this.groupBox1.Controls.Add(this.txtCustOccupation);
            this.groupBox1.Controls.Add(this.txtFathersLName);
            this.groupBox1.Controls.Add(this.txtFathersFName);
            this.groupBox1.Controls.Add(this.txtCustAccountNo);
            this.groupBox1.Controls.Add(this.txtCustLName);
            this.groupBox1.Controls.Add(this.txtCustomerFName);
            this.groupBox1.Controls.Add(this.lblDepositAmount);
            this.groupBox1.Controls.Add(this.lblCustNID);
            this.groupBox1.Controls.Add(this.lblPhoneNumber);
            this.groupBox1.Controls.Add(this.lblOccupation);
            this.groupBox1.Controls.Add(this.lblDateofBirth);
            this.groupBox1.Controls.Add(this.lblGender);
            this.groupBox1.Controls.Add(this.lblAccountType);
            this.groupBox1.Controls.Add(this.lblAccountNumber);
            this.groupBox1.Controls.Add(this.lblFathersLName);
            this.groupBox1.Controls.Add(this.lblCustomerLName);
            this.groupBox1.Controls.Add(this.lblFathersFName);
            this.groupBox1.Controls.Add(this.lblCustomerFName);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(661, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 535);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Information";
            // 
            // lblCustAccountNo
            // 
            this.lblCustAccountNo.AutoSize = true;
            this.lblCustAccountNo.Location = new System.Drawing.Point(197, 7);
            this.lblCustAccountNo.Name = "lblCustAccountNo";
            this.lblCustAccountNo.Size = new System.Drawing.Size(57, 18);
            this.lblCustAccountNo.TabIndex = 6;
            this.lblCustAccountNo.Text = "label1";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(171, 486);
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
            this.btnBrowse.Location = new System.Drawing.Point(171, 438);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(202, 29);
            this.btnBrowse.TabIndex = 5;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pbCustomer
            // 
            this.pbCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCustomer.Location = new System.Drawing.Point(10, 418);
            this.pbCustomer.Name = "pbCustomer";
            this.pbCustomer.Size = new System.Drawing.Size(133, 111);
            this.pbCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCustomer.TabIndex = 4;
            this.pbCustomer.TabStop = false;
            // 
            // dtpDateofBirth
            // 
            this.dtpDateofBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateofBirth.Location = new System.Drawing.Point(170, 248);
            this.dtpDateofBirth.Name = "dtpDateofBirth";
            this.dtpDateofBirth.Size = new System.Drawing.Size(203, 26);
            this.dtpDateofBirth.TabIndex = 3;
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(170, 221);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(203, 26);
            this.cmbGender.TabIndex = 2;
            // 
            // cmbAccountType
            // 
            this.cmbAccountType.FormattingEnabled = true;
            this.cmbAccountType.Location = new System.Drawing.Point(170, 60);
            this.cmbAccountType.Name = "cmbAccountType";
            this.cmbAccountType.Size = new System.Drawing.Size(205, 26);
            this.cmbAccountType.TabIndex = 2;
            // 
            // txtDepositAmount
            // 
            this.txtDepositAmount.Location = new System.Drawing.Point(169, 377);
            this.txtDepositAmount.Name = "txtDepositAmount";
            this.txtDepositAmount.Size = new System.Drawing.Size(206, 26);
            this.txtDepositAmount.TabIndex = 1;
            // 
            // txtCustPhoneNumber
            // 
            this.txtCustPhoneNumber.Location = new System.Drawing.Point(171, 345);
            this.txtCustPhoneNumber.Name = "txtCustPhoneNumber";
            this.txtCustPhoneNumber.Size = new System.Drawing.Size(204, 26);
            this.txtCustPhoneNumber.TabIndex = 1;
            // 
            // txtCustNID
            // 
            this.txtCustNID.Location = new System.Drawing.Point(170, 280);
            this.txtCustNID.Name = "txtCustNID";
            this.txtCustNID.Size = new System.Drawing.Size(203, 26);
            this.txtCustNID.TabIndex = 1;
            // 
            // txtCustOccupation
            // 
            this.txtCustOccupation.Location = new System.Drawing.Point(169, 312);
            this.txtCustOccupation.Name = "txtCustOccupation";
            this.txtCustOccupation.Size = new System.Drawing.Size(204, 26);
            this.txtCustOccupation.TabIndex = 1;
            // 
            // txtFathersLName
            // 
            this.txtFathersLName.Location = new System.Drawing.Point(169, 189);
            this.txtFathersLName.Name = "txtFathersLName";
            this.txtFathersLName.Size = new System.Drawing.Size(204, 26);
            this.txtFathersLName.TabIndex = 1;
            // 
            // txtFathersFName
            // 
            this.txtFathersFName.Location = new System.Drawing.Point(170, 157);
            this.txtFathersFName.Name = "txtFathersFName";
            this.txtFathersFName.Size = new System.Drawing.Size(204, 26);
            this.txtFathersFName.TabIndex = 1;
            // 
            // txtCustAccountNo
            // 
            this.txtCustAccountNo.Location = new System.Drawing.Point(171, 25);
            this.txtCustAccountNo.Name = "txtCustAccountNo";
            this.txtCustAccountNo.Size = new System.Drawing.Size(204, 26);
            this.txtCustAccountNo.TabIndex = 1;
            // 
            // txtCustLName
            // 
            this.txtCustLName.Location = new System.Drawing.Point(169, 126);
            this.txtCustLName.Name = "txtCustLName";
            this.txtCustLName.Size = new System.Drawing.Size(204, 26);
            this.txtCustLName.TabIndex = 1;
            // 
            // txtCustomerFName
            // 
            this.txtCustomerFName.Location = new System.Drawing.Point(171, 93);
            this.txtCustomerFName.Name = "txtCustomerFName";
            this.txtCustomerFName.Size = new System.Drawing.Size(204, 26);
            this.txtCustomerFName.TabIndex = 1;
            // 
            // lblDepositAmount
            // 
            this.lblDepositAmount.AutoSize = true;
            this.lblDepositAmount.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepositAmount.Location = new System.Drawing.Point(8, 382);
            this.lblDepositAmount.Name = "lblDepositAmount";
            this.lblDepositAmount.Size = new System.Drawing.Size(157, 16);
            this.lblDepositAmount.TabIndex = 0;
            this.lblDepositAmount.Text = "Deposit Amount        :";
            // 
            // lblCustNID
            // 
            this.lblCustNID.AutoSize = true;
            this.lblCustNID.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustNID.Location = new System.Drawing.Point(8, 285);
            this.lblCustNID.Name = "lblCustNID";
            this.lblCustNID.Size = new System.Drawing.Size(150, 16);
            this.lblCustNID.TabIndex = 0;
            this.lblCustNID.Text = "NID Number            :";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(7, 350);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(162, 16);
            this.lblPhoneNumber.TabIndex = 0;
            this.lblPhoneNumber.Text = "Phone Number          : ";
            // 
            // lblOccupation
            // 
            this.lblOccupation.AutoSize = true;
            this.lblOccupation.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOccupation.Location = new System.Drawing.Point(8, 317);
            this.lblOccupation.Name = "lblOccupation";
            this.lblOccupation.Size = new System.Drawing.Size(158, 16);
            this.lblOccupation.TabIndex = 0;
            this.lblOccupation.Text = "Occupation              :";
            // 
            // lblDateofBirth
            // 
            this.lblDateofBirth.AutoSize = true;
            this.lblDateofBirth.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateofBirth.Location = new System.Drawing.Point(8, 256);
            this.lblDateofBirth.Name = "lblDateofBirth";
            this.lblDateofBirth.Size = new System.Drawing.Size(157, 16);
            this.lblDateofBirth.TabIndex = 0;
            this.lblDateofBirth.Text = "Date of Birth            :";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(8, 226);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(164, 16);
            this.lblGender.TabIndex = 0;
            this.lblGender.Text = "Gender                    : ";
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountType.Location = new System.Drawing.Point(8, 65);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(158, 16);
            this.lblAccountType.TabIndex = 0;
            this.lblAccountType.Text = "Type of Account       :";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNumber.Location = new System.Drawing.Point(7, 30);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(127, 16);
            this.lblAccountNumber.TabIndex = 0;
            this.lblAccountNumber.Text = "Account Number :";
            // 
            // lblFathersLName
            // 
            this.lblFathersLName.AutoSize = true;
            this.lblFathersLName.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFathersLName.Location = new System.Drawing.Point(7, 194);
            this.lblFathersLName.Name = "lblFathersLName";
            this.lblFathersLName.Size = new System.Drawing.Size(159, 16);
            this.lblFathersLName.TabIndex = 0;
            this.lblFathersLName.Text = "Father\'s Last Name    :";
            // 
            // lblCustomerLName
            // 
            this.lblCustomerLName.AutoSize = true;
            this.lblCustomerLName.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerLName.Location = new System.Drawing.Point(8, 131);
            this.lblCustomerLName.Name = "lblCustomerLName";
            this.lblCustomerLName.Size = new System.Drawing.Size(154, 16);
            this.lblCustomerLName.TabIndex = 0;
            this.lblCustomerLName.Text = "Customer Last Name :";
            // 
            // lblFathersFName
            // 
            this.lblFathersFName.AutoSize = true;
            this.lblFathersFName.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFathersFName.Location = new System.Drawing.Point(7, 162);
            this.lblFathersFName.Name = "lblFathersFName";
            this.lblFathersFName.Size = new System.Drawing.Size(160, 16);
            this.lblFathersFName.TabIndex = 0;
            this.lblFathersFName.Text = "Father\'s  First Name   :";
            // 
            // lblCustomerFName
            // 
            this.lblCustomerFName.AutoSize = true;
            this.lblCustomerFName.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerFName.Location = new System.Drawing.Point(7, 98);
            this.lblCustomerFName.Name = "lblCustomerFName";
            this.lblCustomerFName.Size = new System.Drawing.Size(155, 16);
            this.lblCustomerFName.TabIndex = 0;
            this.lblCustomerFName.Text = "Customer First Name :";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(960, 566);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 31);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(810, 566);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 31);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(661, 566);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(93, 31);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Location = new System.Drawing.Point(27, 25);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.RowHeadersWidth = 51;
            this.dgvCustomer.RowTemplate.Height = 24;
            this.dgvCustomer.Size = new System.Drawing.Size(617, 509);
            this.dgvCustomer.TabIndex = 1;
            this.dgvCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.Location = new System.Drawing.Point(281, 581);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(120, 29);
            this.lblEmployeeName.TabIndex = 7;
            this.lblEmployeeName.Text = "Unknown";
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeId.Location = new System.Drawing.Point(448, 581);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(120, 29);
            this.lblEmployeeId.TabIndex = 7;
            this.lblEmployeeId.Text = "Unknown";
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1075, 632);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblEmployeeId);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(1093, 679);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox pbCustomer;
        private System.Windows.Forms.DateTimePicker dtpDateofBirth;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.ComboBox cmbAccountType;
        private System.Windows.Forms.TextBox txtDepositAmount;
        private System.Windows.Forms.TextBox txtCustPhoneNumber;
        private System.Windows.Forms.TextBox txtCustOccupation;
        private System.Windows.Forms.TextBox txtFathersFName;
        private System.Windows.Forms.TextBox txtCustomerFName;
        private System.Windows.Forms.Label lblDepositAmount;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblOccupation;
        private System.Windows.Forms.Label lblDateofBirth;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.Label lblFathersFName;
        private System.Windows.Forms.Label lblCustomerFName;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.TextBox txtFathersLName;
        private System.Windows.Forms.TextBox txtCustAccountNo;
        private System.Windows.Forms.TextBox txtCustLName;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label lblFathersLName;
        private System.Windows.Forms.Label lblCustomerLName;
        private System.Windows.Forms.TextBox txtCustNID;
        private System.Windows.Forms.Label lblCustNID;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblCustAccountNo;
        private System.Windows.Forms.Label lblEmployeeId;
    }
}