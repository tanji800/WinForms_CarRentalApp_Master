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
    public partial class AddUser : Form
    {
        private readonly CarRentalEntities _db;
        private ManageUsers _manageUsers;
        public AddUser()
        {
            
            InitializeComponent();
            _db = new CarRentalEntities();
            _manageUsers=new ManageUsers();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            try
            {
                var roles = _db.Roles.ToList();
                cboxRoles.DataSource = roles;
                cboxRoles.ValueMember = "id";
                cboxRoles.DisplayMember = "name";
                _manageUsers.PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex);

            }
            
        }

        private void btnSubmitUser_Click(object sender, EventArgs e)
        {
            try
            {
                var UserName = tbUserName.Text;
                var Roleid = (int)cboxRoles.SelectedValue;
                var password = Utils.HashDefaultPassword();
                var user = new User
                {
                    Password = password,
                    UserName = UserName,
                    isActive = true
                };
                _db.Users.Add(user);
                _db.SaveChanges();
                var userid=user.Id;
                var userRole = new UserRole
                {
                    roleid = Roleid,
                    userid = userid
                };
                _db.UserRoles.Add(userRole);
                _db.SaveChanges();
                MessageBox.Show("new User Added Successfully");
                Close();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : " + ex);
            }
            var manageuser = new ManageUsers();
            manageuser.PopulateGrid();
        }
        private void btnCancelUser_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
