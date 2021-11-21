using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_CarRentalApp
{
    public partial class ResetPassword : Form
    {
        private readonly CarRentalEntities _db;
        private User _user;
        public ResetPassword( User user)
        {
            _db = new CarRentalEntities();
            _user = user;

            InitializeComponent();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                var password = tbNewPassword.Text;
                var conformPassword = tbConformPassword.Text;
                var user = _db.Users.FirstOrDefault(q => q.Id == _user.Id);
                if (password != conformPassword)
                {
                    MessageBox.Show("New Password and Conform Password are not Same");
                }
                else
                {
                    user.Password = Utils.HashPassword(password);
                    _db.SaveChanges();
                    MessageBox.Show("Password was reseted Successfully");
                    Close();
                }
               
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex);
            }
           
        }
    }
}
