using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_CarRentalApp
{
    public partial class Login : Form
    {
        private readonly CarRentalEntities _db;
        public Login()
        {
            _db = new CarRentalEntities();
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SHA256 sha = SHA256.Create();
                
                var userName=tbUserName.Text.Trim();
                var password=tbPassword.Text;

                var hashed_Password = Utils.HashPassword(password);

                var user=_db.Users.FirstOrDefault(q=> q.UserName == userName && q.Password== hashed_Password);

                if(user==null)
                {
                    MessageBox.Show("Please enter Valid Credentials");
                }
                if(user.isActive==false)
                {
                    MessageBox.Show($"User {user.UserName} is not Active");
                }
                else
                {
                    //var role = user.UserRoles.FirstOrDefault();
                    //var roleName = role.Role.shortname;
                    var Mainwindow=new MainWindow( this, user);
                    Mainwindow.Show();
                    Hide();
                }

            }
            catch (Exception ex )
            {
                MessageBox.Show("Something went Wrong Please Try Again");
                
            }
        }
    }
}
