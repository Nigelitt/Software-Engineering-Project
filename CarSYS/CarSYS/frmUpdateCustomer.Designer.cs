﻿namespace CarSYS
{
    partial class frmUpdateCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateCustomer));
            this.btnBack = new System.Windows.Forms.Button();
            this.grpUpdateCustomer = new System.Windows.Forms.GroupBox();
            this.dtpCustomer = new System.Windows.Forms.DateTimePicker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblCustID = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.txtLicence = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblLicence = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.btnUpdCustomer = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.cboUpdateCustomer = new System.Windows.Forms.ComboBox();
            this.lblCust = new System.Windows.Forms.Label();
            this.grpUpdateCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(305, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grpUpdateCustomer
            // 
            this.grpUpdateCustomer.Controls.Add(this.dtpCustomer);
            this.grpUpdateCustomer.Controls.Add(this.lblStatus);
            this.grpUpdateCustomer.Controls.Add(this.txtStatus);
            this.grpUpdateCustomer.Controls.Add(this.lblCustID);
            this.grpUpdateCustomer.Controls.Add(this.txtCustomerID);
            this.grpUpdateCustomer.Controls.Add(this.lblDOB);
            this.grpUpdateCustomer.Controls.Add(this.txtLicence);
            this.grpUpdateCustomer.Controls.Add(this.lblEmail);
            this.grpUpdateCustomer.Controls.Add(this.txtEmail);
            this.grpUpdateCustomer.Controls.Add(this.txtZipCode);
            this.grpUpdateCustomer.Controls.Add(this.lblZipCode);
            this.grpUpdateCustomer.Controls.Add(this.lblCountry);
            this.grpUpdateCustomer.Controls.Add(this.txtCountry);
            this.grpUpdateCustomer.Controls.Add(this.lblAddress);
            this.grpUpdateCustomer.Controls.Add(this.txtAddress);
            this.grpUpdateCustomer.Controls.Add(this.lblPhone);
            this.grpUpdateCustomer.Controls.Add(this.txtPhone);
            this.grpUpdateCustomer.Controls.Add(this.lblLicence);
            this.grpUpdateCustomer.Controls.Add(this.lblSurname);
            this.grpUpdateCustomer.Controls.Add(this.txtSurname);
            this.grpUpdateCustomer.Controls.Add(this.btnUpdCustomer);
            this.grpUpdateCustomer.Controls.Add(this.txtFirstName);
            this.grpUpdateCustomer.Controls.Add(this.lblFirstName);
            this.grpUpdateCustomer.Location = new System.Drawing.Point(12, 97);
            this.grpUpdateCustomer.Name = "grpUpdateCustomer";
            this.grpUpdateCustomer.Size = new System.Drawing.Size(365, 281);
            this.grpUpdateCustomer.TabIndex = 11;
            this.grpUpdateCustomer.TabStop = false;
            this.grpUpdateCustomer.Text = "Update customer  details";
            // 
            // dtpCustomer
            // 
            this.dtpCustomer.Location = new System.Drawing.Point(79, 215);
            this.dtpCustomer.Name = "dtpCustomer";
            this.dtpCustomer.Size = new System.Drawing.Size(257, 20);
            this.dtpCustomer.TabIndex = 11;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(68, 24);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 54;
            this.lblStatus.Text = "Status";
            // 
            // txtStatus
            // 
            this.txtStatus.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtStatus.Location = new System.Drawing.Point(131, 17);
            this.txtStatus.MaxLength = 1;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(40, 20);
            this.txtStatus.TabIndex = 2;
            this.txtStatus.Text = "A";
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Location = new System.Drawing.Point(199, 20);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(65, 13);
            this.lblCustID.TabIndex = 52;
            this.lblCustID.Text = "Customer ID";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(270, 17);
            this.txtCustomerID.MaxLength = 12;
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(66, 20);
            this.txtCustomerID.TabIndex = 0;
            this.txtCustomerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(30, 221);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(30, 13);
            this.lblDOB.TabIndex = 50;
            this.lblDOB.Text = "DOB";
            // 
            // txtLicence
            // 
            this.txtLicence.Location = new System.Drawing.Point(81, 79);
            this.txtLicence.MaxLength = 18;
            this.txtLicence.Name = "txtLicence";
            this.txtLicence.Size = new System.Drawing.Size(92, 20);
            this.txtLicence.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(30, 119);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 47;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(81, 112);
            this.txtEmail.MaxLength = 40;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(255, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(244, 172);
            this.txtZipCode.MaxLength = 18;
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(92, 20);
            this.txtZipCode.TabIndex = 10;
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Location = new System.Drawing.Point(188, 179);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(50, 13);
            this.lblZipCode.TabIndex = 43;
            this.lblZipCode.Text = "Zip Code";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(30, 179);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(43, 13);
            this.lblCountry.TabIndex = 42;
            this.lblCountry.Text = "Country";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(79, 172);
            this.txtCountry.MaxLength = 56;
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(92, 20);
            this.txtCountry.TabIndex = 9;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(30, 153);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 40;
            this.lblAddress.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(81, 146);
            this.txtAddress.MaxLength = 100;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(255, 20);
            this.txtAddress.TabIndex = 8;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(180, 85);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(58, 13);
            this.lblPhone.TabIndex = 38;
            this.lblPhone.Text = "Phone No.";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(244, 82);
            this.txtPhone.MaxLength = 18;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(92, 20);
            this.txtPhone.TabIndex = 6;
            // 
            // lblLicence
            // 
            this.lblLicence.AutoSize = true;
            this.lblLicence.Location = new System.Drawing.Point(10, 82);
            this.lblLicence.Name = "lblLicence";
            this.lblLicence.Size = new System.Drawing.Size(65, 13);
            this.lblLicence.TabIndex = 25;
            this.lblLicence.Text = "Licence No.";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(189, 46);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 13;
            this.lblSurname.Text = "Surname";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(244, 43);
            this.txtSurname.MaxLength = 20;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(92, 20);
            this.txtSurname.TabIndex = 4;
            // 
            // btnUpdCustomer
            // 
            this.btnUpdCustomer.Location = new System.Drawing.Point(81, 241);
            this.btnUpdCustomer.Name = "btnUpdCustomer";
            this.btnUpdCustomer.Size = new System.Drawing.Size(255, 34);
            this.btnUpdCustomer.TabIndex = 12;
            this.btnUpdCustomer.Text = "Update Customer";
            this.btnUpdCustomer.UseVisualStyleBackColor = true;
            this.btnUpdCustomer.Click += new System.EventHandler(this.btnUpdCustomer_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(81, 43);
            this.txtFirstName.MaxLength = 20;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(92, 20);
            this.txtFirstName.TabIndex = 3;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(18, 46);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 6;
            this.lblFirstName.Text = "First Name";
            // 
            // cboUpdateCustomer
            // 
            this.cboUpdateCustomer.FormattingEnabled = true;
            this.cboUpdateCustomer.Location = new System.Drawing.Point(122, 56);
            this.cboUpdateCustomer.Name = "cboUpdateCustomer";
            this.cboUpdateCustomer.Size = new System.Drawing.Size(226, 21);
            this.cboUpdateCustomer.TabIndex = 1;
            this.cboUpdateCustomer.Text = "Update Customer";
            this.cboUpdateCustomer.SelectedIndexChanged += new System.EventHandler(this.cboUpdateCustomer_SelectedIndexChanged);
            // 
            // lblCust
            // 
            this.lblCust.AutoSize = true;
            this.lblCust.Location = new System.Drawing.Point(22, 59);
            this.lblCust.Name = "lblCust";
            this.lblCust.Size = new System.Drawing.Size(84, 13);
            this.lblCust.TabIndex = 55;
            this.lblCust.Text = "Chose Customer";
            // 
            // frmUpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 396);
            this.Controls.Add(this.lblCust);
            this.Controls.Add(this.cboUpdateCustomer);
            this.Controls.Add(this.grpUpdateCustomer);
            this.Controls.Add(this.btnBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUpdateCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Customer";
            this.Load += new System.EventHandler(this.frmUpdateCustomer_Load);
            this.grpUpdateCustomer.ResumeLayout(false);
            this.grpUpdateCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox grpUpdateCustomer;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.TextBox txtLicence;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblLicence;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Button btnUpdCustomer;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.ComboBox cboUpdateCustomer;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.DateTimePicker dtpCustomer;
        private System.Windows.Forms.Label lblCust;
    }
}