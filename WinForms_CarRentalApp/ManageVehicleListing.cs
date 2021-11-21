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
    public partial class ManageVehicleListing : Form
    {
        private readonly CarRentalEntities _db;
        public ManageVehicleListing()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }

        private void ManageVehicleListing_Load(object sender, EventArgs e)
        {
            try
            {
               PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Found: "+ex.Message);
                
            }
            
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            try
            {
                var addEditVehicle = new AddEditVehicle(this);
                addEditVehicle.MdiParent = this.MdiParent;
                addEditVehicle.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in: " + ex.Message);

            }
           
        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)gvVehicalListing.SelectedRows[0].Cells["Id"].Value;

                var car = _db.TypesOfCars.FirstOrDefault(q => q.Id == id);

                var addEditVehicle = new AddEditVehicle(car);

                addEditVehicle.ShowDialog();
                addEditVehicle.MdiParent = this.MdiParent;
                gvVehicalListing.Refresh();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error in: " + ex.Message);
            }
            
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)gvVehicalListing.SelectedRows[0].Cells["Id"].Value;

                var car = _db.TypesOfCars.FirstOrDefault(q => q.Id == id);
                _db.TypesOfCars.Remove(car);
                _db.SaveChanges();
                gvVehicalListing.Refresh();
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : "+ex.Message);
                
            }
        }

        public void PopulateGrid()
        {

            var cars = _db.TypesOfCars
               .Select(q => new
               {
                   Brand = q.Make,
                   model = q.Model,
                   VIN = q.VIN,
                   Year = q.Year,
                   LicencePlateNumber = q.LicencePlateNumber,
                   q.Id
               })
               .ToList();

            gvVehicalListing.DataSource = cars;
            gvVehicalListing.Columns[0].HeaderText = "BRAND";
            gvVehicalListing.Columns[1].HeaderText = "MODEL";
            gvVehicalListing.Columns[2].HeaderText = "VIN";
            gvVehicalListing.Columns[3].HeaderText = "YEAR";
            gvVehicalListing.Columns[4].HeaderText = "LICENCE PLATE NUMBER";
            gvVehicalListing.Columns[5].Visible = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            _db.SaveChanges();
            gvVehicalListing.Refresh(); 
            PopulateGrid();
        }
    }
}
