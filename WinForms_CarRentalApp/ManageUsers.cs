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
    public partial class ManageUsers : Form
    {
        private readonly CarRentalEntities _db;
        public ManageUsers()
        {
            _db = new CarRentalEntities();
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var AddUser=new AddUser();
            //AddUser.MdiParent = this.MdiParent;
            AddUser.ShowDialog();
            AddUser.MdiParent = this.MdiParent;
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)gvUserList.SelectedRows[0].Cells["id"].Value;

                var user = _db.Users.FirstOrDefault(q => q.Id == id);

                var genericPassword = "password@123";
                var newPassword = Utils.HashPassword(genericPassword);
                user.Password = newPassword;
                _db.SaveChanges();

                MessageBox.Show($"Password reseted for {user.UserName} ");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error in: " + ex.Message);
            }
        }

        private void btnDeactivateUser_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)gvUserList.SelectedRows[0].Cells["id"].Value;

                var user = _db.Users.FirstOrDefault(q => q.Id == id);
                user.isActive=(bool)user.isActive==true ? false : true;
                _db.SaveChanges ();

                MessageBox.Show($"Active Ststus Changed for {user.UserName} ");
                PopulateGrid();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex);
            }

        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateGrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex);
            }
        }

        public void PopulateGrid()
        {
            var user = _db.Users
               .Select(q => new
               {
                   q.Id,
                   q.UserName,
                   q.UserRoles.FirstOrDefault().Role.name,
                   q.isActive
               }).ToList();
            gvUserList.DataSource = user;
            gvUserList.Columns[1].HeaderText = "User Name";
            gvUserList.Columns[2].HeaderText = "Role Name";
            gvUserList.Columns[3].HeaderText = "Is Active";
            gvUserList.Columns["Id"].Visible = false;
        }
    }
}
