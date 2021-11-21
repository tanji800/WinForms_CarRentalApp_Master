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
    public partial class AddEditRentalRecord : Form
    {
        private readonly CarRentalEntities _db;
        private Boolean isEditMode;

        public AddEditRentalRecord()
        {
            InitializeComponent();
            //lblId.Text = "Add New Vehical";
            lblTextRental.Text = "Add New Record";
            isEditMode = false;
           // _manageVehicleListing = manageVehicleListing;
            _db = new CarRentalEntities();
            
        }
        public AddEditRentalRecord( CarRentalRecord RecordToEdit)
        {

            InitializeComponent();

            lblTextRental.Text = "Edit Record";
            //lblId.Text = "Edit Vehical";
           
            if(RecordToEdit == null)
            {
                MessageBox.Show("Please Select valid Record to edit");
            }
            else
            {
                isEditMode = true;
                _db = new CarRentalEntities();
                PopulateFields(RecordToEdit);

            }
            
            
        }

        private void PopulateFields(CarRentalRecord RecordToEdit)
        {
            tbCustomerName.Text = RecordToEdit.CustomerName;
            datiDateRented.Value = (DateTime)RecordToEdit.DateRented;
            datiDateReturned.Value = (DateTime)RecordToEdit.DateReturned;
            lblRecordid.Text = (RecordToEdit.id).ToString();
            tbCost.Text = RecordToEdit.Cost.ToString();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                String customerName = tbCustomerName.Text;
                var dateOut = datiDateRented.Value;
                var dateIn = datiDateReturned.Value;
                var carTyp = comboxCarType.Text;
                decimal cost=decimal.Parse(tbCost.Text);
                var isValidate = true;

                if (string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(carTyp))
                {
                    MessageBox.Show("Please enter Customer Name or Car Type");
                    isValidate = false;
                }
                if (dateOut > dateIn)
                {
                    MessageBox.Show("Please enter Valid Date");
                    isValidate = false;
                }

                if (isValidate)
                {
                    var submitRecord = new CarRentalRecord();
                    if (isEditMode)
                    {
                        var id = int.Parse(lblRecordid.Text);
                        submitRecord = _db.CarRentalRecords.FirstOrDefault(q => q.id == id);
                    }
                    submitRecord.CustomerName = customerName;
                    submitRecord.DateRented = dateOut;
                    submitRecord.DateReturned = dateIn;
                    submitRecord.Cost = cost;
                    submitRecord.TypeOfCarId = (int)comboxCarType.SelectedValue;
                    if (!isEditMode)

                        _db.CarRentalRecords.Add(submitRecord);

                    _db.SaveChanges();
                    MessageBox.Show($"Customer Nmae : {customerName}\n\r" +
                        $"Date Rented : {dateIn} \n\r" +
                        $"Date Rentured : {dateOut}\n\r" +
                        $"Car Type : {carTyp}\n\r" +
                        $"Cost : {cost}\n\r" +
                        $"Thank you for Renting car");
                    Close();
                    
                }
                else
                {
                    var submitRecord = new CarRentalRecord();
                    submitRecord.CustomerName = customerName;
                    submitRecord.DateRented = dateOut;
                    submitRecord.DateReturned = dateIn;
                    submitRecord.Cost = cost;
                    submitRecord.TypeOfCarId = (int)comboxCarType.SelectedValue;

                    _db.CarRentalRecords.Add(submitRecord);
                    _db.SaveChanges();

                    MessageBox.Show($"Customer Nmae : {customerName}\n\r" +
                        $"Date Rented : {dateIn} \n\r" +
                        $"Date Rentured : {dateOut}\n\r" +
                        $"Car Type : {carTyp}\n\r" +
                        $"Cost : {cost}\n\r" +
                        $"Thank you for Renting car");

                }
                    Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            Close();
        }

        private void tbCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainWindow mainWindow =new MainWindow();
            mainWindow.Show();
        }

        private void AddEditRentalRecord_Load_1(object sender, EventArgs e)
        {
            var car = _db.TypesOfCars
               .Select(q => new { Id = q.Id , BrandModel = q.Make  +" "+q.Model })
               .ToList();
            comboxCarType.DisplayMember = "BrandModel";
            comboxCarType.ValueMember = "Id";
            comboxCarType.DataSource = car;
        }
    }
}
