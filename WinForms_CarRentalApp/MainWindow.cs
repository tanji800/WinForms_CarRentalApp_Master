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
    public partial class MainWindow : Form
    {
        private Login _login;
        public string _RoleName;
        public User _user;
        
        public MainWindow()
        {
            InitializeComponent();
        }
        public MainWindow( Login login , User user)
        {
            InitializeComponent();
            _login = login;
            _user = user;
            _RoleName = user.UserRoles.FirstOrDefault().Role.shortname;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            if(_user.Password==Utils.HashDefaultPassword())
            {
                var resetpassword = new ResetPassword(_user);
                resetpassword.ShowDialog();
            }
            var username=_user.UserName;
            tsiLoginText.Text = $"Logged In As {username}";
            if(_RoleName != "admin")
            {
                manageToolStripMenuItem.Visible = false;
            }
            
        }

        private void addRentalRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addRentalRecord = new AddEditRentalRecord();
            
            addRentalRecord.ShowDialog();
            addRentalRecord.MdiParent = this;
        }

        private void manageVehicalListingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vehicleListing = new ManageVehicleListing();
            //vehicleListing.MdiParent = this;
            vehicleListing.ShowDialog();
            vehicleListing.MdiParent = this;

        }

        private void manageRentalRecoedsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ManageRentalRecord=new ManageRentalRecord();
            ManageRentalRecord.ShowDialog();
            //ManageRentalRecord.MdiParent=this;
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var manageUsers= new ManageUsers();
            manageUsers.ShowDialog();
        }

        private void tsiLoginText_Click(object sender, EventArgs e)
        {

        }
    }
}
