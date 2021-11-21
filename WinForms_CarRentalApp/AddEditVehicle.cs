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
    public partial class AddEditVehicle : Form
    {
        private readonly CarRentalEntities _db;
        private ManageVehicleListing _manageVehicleListing;
        private Boolean isEditMode;
        public AddEditVehicle(ManageVehicleListing manageVehicleListing = null)
        {
            InitializeComponent();
            lblId.Text = "Add New Vehical";
            isEditMode = false;
            _manageVehicleListing = manageVehicleListing;
            _db = new CarRentalEntities();
        }
        public AddEditVehicle( TypesOfCar carToEdit, ManageVehicleListing manageVehicleListing = null)
        {
            InitializeComponent();
            //lblTitle.Text = "Add New Vehical";
            lblId.Text = "Edit Vehical";
            isEditMode = true;
            _db = new CarRentalEntities();
            PopulateFields(carToEdit);
        }

        private void PopulateFields(TypesOfCar car)
        {
           // tbYear.Text = car.Id.ToString();
            tbMake.Text = car.Make;
            tbModel.Text = car.Model;
            tbVIN.Text = car.VIN;
            tbYear.Text =car.Year.ToString();
            tbLicencePlateNumber.Text = car.LicencePlateNumber;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if(isEditMode)
            {
                var id=int.Parse(lblId.Text);
                var car=_db.TypesOfCars.FirstOrDefault(q=> q.Id==id);
                car.Make= tbMake.Text;
                car.Model= tbModel.Text;
                car.Year = int.Parse(tbYear.Text);
                car.VIN= tbVIN.Text;
                car.LicencePlateNumber = tbLicencePlateNumber.Text;

                _db.SaveChanges();
                Close();
            }
            else
            {
                var newCar = new TypesOfCar
                {
                    Make = tbMake.Text,
                    Model = tbModel.Text,
                    VIN = tbVIN.Text,
                    Year = int.Parse(tbYear.Text),
                    LicencePlateNumber = tbLicencePlateNumber.Text

                };
                _db.TypesOfCars.Add(newCar);
                _db.SaveChanges();
                PopulateFields(newCar);
                MessageBox.Show("Operation Completed. Refresh Grid to see Changes");
                Close();
            }
            _manageVehicleListing.PopulateGrid();
            

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void AddEditVehicle_Load(object sender, EventArgs e)
        {
            //var Vehicle = _db.TypesOfCars
            //   .Select(q => new { Id = q.Id, BrandModel = q.Make + " " + q.Model })
            //   .ToList();
            //comboxCarType.DisplayMember = "BrandModel";
            //comboxCarType.ValueMember = "Id";
            //comboxCarType.DataSource = car;
        }

        
    }
}
