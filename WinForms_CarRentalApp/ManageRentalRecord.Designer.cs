namespace WinForms_CarRentalApp
{
    partial class ManageRentalRecord
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
            this.gvRecordList = new System.Windows.Forms.DataGridView();
            this.lblManageRentalRecord = new System.Windows.Forms.Label();
            this.btnAddNewRecord = new System.Windows.Forms.Button();
            this.btnEditRecord = new System.Windows.Forms.Button();
            this.btnDeleteRecord = new System.Windows.Forms.Button();
            this.btnManageRentalRecordRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvRecordList)).BeginInit();
            this.SuspendLayout();
            // 
            // gvRecordList
            // 
            this.gvRecordList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRecordList.Location = new System.Drawing.Point(31, 69);
            this.gvRecordList.Name = "gvRecordList";
            this.gvRecordList.RowHeadersWidth = 51;
            this.gvRecordList.RowTemplate.Height = 24;
            this.gvRecordList.Size = new System.Drawing.Size(736, 286);
            this.gvRecordList.TabIndex = 0;
            // 
            // lblManageRentalRecord
            // 
            this.lblManageRentalRecord.AutoSize = true;
            this.lblManageRentalRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageRentalRecord.Location = new System.Drawing.Point(285, 24);
            this.lblManageRentalRecord.Name = "lblManageRentalRecord";
            this.lblManageRentalRecord.Size = new System.Drawing.Size(211, 25);
            this.lblManageRentalRecord.TabIndex = 1;
            this.lblManageRentalRecord.Text = "Manage Renatl Record";
            // 
            // btnAddNewRecord
            // 
            this.btnAddNewRecord.Location = new System.Drawing.Point(58, 392);
            this.btnAddNewRecord.Name = "btnAddNewRecord";
            this.btnAddNewRecord.Size = new System.Drawing.Size(153, 23);
            this.btnAddNewRecord.TabIndex = 2;
            this.btnAddNewRecord.Text = "Add New Record";
            this.btnAddNewRecord.UseVisualStyleBackColor = true;
            this.btnAddNewRecord.Click += new System.EventHandler(this.btnAddNewRecord_Click);
            // 
            // btnEditRecord
            // 
            this.btnEditRecord.Location = new System.Drawing.Point(323, 392);
            this.btnEditRecord.Name = "btnEditRecord";
            this.btnEditRecord.Size = new System.Drawing.Size(137, 23);
            this.btnEditRecord.TabIndex = 3;
            this.btnEditRecord.Text = "Edit Record";
            this.btnEditRecord.UseVisualStyleBackColor = true;
            this.btnEditRecord.Click += new System.EventHandler(this.btnEditRecord_Click);
            // 
            // btnDeleteRecord
            // 
            this.btnDeleteRecord.Location = new System.Drawing.Point(592, 392);
            this.btnDeleteRecord.Name = "btnDeleteRecord";
            this.btnDeleteRecord.Size = new System.Drawing.Size(144, 23);
            this.btnDeleteRecord.TabIndex = 4;
            this.btnDeleteRecord.Text = "Delete Record";
            this.btnDeleteRecord.UseVisualStyleBackColor = true;
            this.btnDeleteRecord.Click += new System.EventHandler(this.btnDeleteRecord_Click);
            // 
            // btnManageRentalRecordRefresh
            // 
            this.btnManageRentalRecordRefresh.Location = new System.Drawing.Point(31, 24);
            this.btnManageRentalRecordRefresh.Name = "btnManageRentalRecordRefresh";
            this.btnManageRentalRecordRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnManageRentalRecordRefresh.TabIndex = 5;
            this.btnManageRentalRecordRefresh.Text = "Refresh";
            this.btnManageRentalRecordRefresh.UseVisualStyleBackColor = true;
            this.btnManageRentalRecordRefresh.Click += new System.EventHandler(this.btnManageRentalRecordRefresh_Click);
            // 
            // ManageRentalRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnManageRentalRecordRefresh);
            this.Controls.Add(this.btnDeleteRecord);
            this.Controls.Add(this.btnEditRecord);
            this.Controls.Add(this.btnAddNewRecord);
            this.Controls.Add(this.lblManageRentalRecord);
            this.Controls.Add(this.gvRecordList);
            this.Name = "ManageRentalRecord";
            this.Text = "Manage Rental Record";
            this.Load += new System.EventHandler(this.ManageRentalRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvRecordList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvRecordList;
        private System.Windows.Forms.Label lblManageRentalRecord;
        private System.Windows.Forms.Button btnAddNewRecord;
        private System.Windows.Forms.Button btnEditRecord;
        private System.Windows.Forms.Button btnDeleteRecord;
        private System.Windows.Forms.Button btnManageRentalRecordRefresh;
    }
}