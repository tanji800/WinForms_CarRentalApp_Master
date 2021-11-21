namespace WinForms_CarRentalApp
{
    partial class AddEditRentalRecord
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
            this.lblTextRental = new System.Windows.Forms.Label();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.datiDateRented = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.datiDateReturned = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.comboxCarType = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.lblRecordid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTextRental
            // 
            this.lblTextRental.AutoSize = true;
            this.lblTextRental.BackColor = System.Drawing.Color.Red;
            this.lblTextRental.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTextRental.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextRental.ForeColor = System.Drawing.Color.Yellow;
            this.lblTextRental.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTextRental.Location = new System.Drawing.Point(144, 36);
            this.lblTextRental.Name = "lblTextRental";
            this.lblTextRental.Size = new System.Drawing.Size(498, 61);
            this.lblTextRental.TabIndex = 0;
            this.lblTextRental.Text = "Car  Rental  System";
            this.lblTextRental.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTextRental.UseWaitCursor = true;
           
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.BackColor = System.Drawing.SystemColors.Menu;
            this.tbCustomerName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbCustomerName.Location = new System.Drawing.Point(54, 150);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(244, 22);
            this.tbCustomerName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Name";
            
            // 
            // datiDateRented
            // 
            this.datiDateRented.Location = new System.Drawing.Point(54, 251);
            this.datiDateRented.Name = "datiDateRented";
            this.datiDateRented.Size = new System.Drawing.Size(244, 22);
            this.datiDateRented.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date Rented";
            
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(486, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date Returned";
            // 
            // datiDateReturned
            // 
            this.datiDateReturned.Location = new System.Drawing.Point(491, 251);
            this.datiDateReturned.Name = "datiDateReturned";
            this.datiDateReturned.Size = new System.Drawing.Size(232, 22);
            this.datiDateReturned.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Car Type";
            // 
            // comboxCarType
            // 
            this.comboxCarType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxCarType.FormattingEnabled = true;
            this.comboxCarType.Location = new System.Drawing.Point(54, 335);
            this.comboxCarType.Name = "comboxCarType";
            this.comboxCarType.Size = new System.Drawing.Size(244, 24);
            this.comboxCarType.TabIndex = 9;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Red;
            this.btnSubmit.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.Yellow;
            this.btnSubmit.Location = new System.Drawing.Point(491, 335);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(145, 50);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(486, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cost";
            // 
            // tbCost
            // 
            this.tbCost.BackColor = System.Drawing.SystemColors.Menu;
            this.tbCost.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbCost.Location = new System.Drawing.Point(491, 150);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(232, 22);
            this.tbCost.TabIndex = 12;
            this.tbCost.TextChanged += new System.EventHandler(this.tbCost_TextChanged);
            // 
            // lblRecordid
            // 
            this.lblRecordid.AutoSize = true;
            this.lblRecordid.Location = new System.Drawing.Point(198, 394);
            this.lblRecordid.Name = "lblRecordid";
            this.lblRecordid.Size = new System.Drawing.Size(63, 16);
            this.lblRecordid.TabIndex = 13;
            this.lblRecordid.Text = "RecordId";
            this.lblRecordid.Visible = false;
            // 
            // AddEditRentalRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRecordid);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.comboxCarType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.datiDateReturned);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datiDateRented);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCustomerName);
            this.Controls.Add(this.lblTextRental);
            this.Name = "AddEditRentalRecord";
            this.Text = "Add Rental Record";
            this.Load += new System.EventHandler(this.AddEditRentalRecord_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTextRental;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datiDateRented;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datiDateReturned;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboxCarType;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.Label lblRecordid;
    }
}

