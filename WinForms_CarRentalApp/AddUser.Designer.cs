namespace WinForms_CarRentalApp
{
    partial class AddUser
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblAddUserUserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.cboxRoles = new System.Windows.Forms.ComboBox();
            this.btnSubmitUser = new System.Windows.Forms.Button();
            this.btnCancelUser = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(306, 59);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(113, 29);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Add User";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblAddUserUserName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbUserName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboxRoles, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(175, 105);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(381, 225);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lblAddUserUserName
            // 
            this.lblAddUserUserName.AutoSize = true;
            this.lblAddUserUserName.Location = new System.Drawing.Point(3, 0);
            this.lblAddUserUserName.Name = "lblAddUserUserName";
            this.lblAddUserUserName.Size = new System.Drawing.Size(76, 16);
            this.lblAddUserUserName.TabIndex = 0;
            this.lblAddUserUserName.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Role";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(193, 3);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(143, 22);
            this.tbUserName.TabIndex = 2;
            // 
            // cboxRoles
            // 
            this.cboxRoles.FormattingEnabled = true;
            this.cboxRoles.Location = new System.Drawing.Point(193, 115);
            this.cboxRoles.Name = "cboxRoles";
            this.cboxRoles.Size = new System.Drawing.Size(143, 24);
            this.cboxRoles.TabIndex = 3;
            // 
            // btnSubmitUser
            // 
            this.btnSubmitUser.BackColor = System.Drawing.Color.Green;
            this.btnSubmitUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitUser.Location = new System.Drawing.Point(181, 373);
            this.btnSubmitUser.Name = "btnSubmitUser";
            this.btnSubmitUser.Size = new System.Drawing.Size(105, 48);
            this.btnSubmitUser.TabIndex = 4;
            this.btnSubmitUser.Text = "Submit";
            this.btnSubmitUser.UseVisualStyleBackColor = false;
            this.btnSubmitUser.Click += new System.EventHandler(this.btnSubmitUser_Click);
            // 
            // btnCancelUser
            // 
            this.btnCancelUser.BackColor = System.Drawing.Color.Crimson;
            this.btnCancelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelUser.Location = new System.Drawing.Point(444, 373);
            this.btnCancelUser.Name = "btnCancelUser";
            this.btnCancelUser.Size = new System.Drawing.Size(97, 48);
            this.btnCancelUser.TabIndex = 5;
            this.btnCancelUser.Text = "Cancel";
            this.btnCancelUser.UseVisualStyleBackColor = false;
            this.btnCancelUser.Click += new System.EventHandler(this.btnCancelUser_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnSubmitUser);
            this.Controls.Add(this.btnCancelUser);
            this.Name = "AddUser";
            this.Text = "Add User";
            this.Load += new System.EventHandler(this.AddUser_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblAddUserUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.ComboBox cboxRoles;
        private System.Windows.Forms.Button btnSubmitUser;
        private System.Windows.Forms.Button btnCancelUser;
    }
}