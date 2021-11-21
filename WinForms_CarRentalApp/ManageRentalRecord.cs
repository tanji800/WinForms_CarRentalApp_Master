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
    public partial class ManageRentalRecord : Form
    {
        private readonly CarRentalEntities _db;

        public ManageRentalRecord()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }

        private void btnAddNewRecord_Click(object sender, EventArgs e)
        {
            try
            {
                var addRentalRecord = new AddEditRentalRecord();
                
                addRentalRecord.ShowDialog();
                addRentalRecord.MdiParent = this.MdiParent;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in: " + ex.Message);

            }

        }

        private void btnManageRentalRecordRefresh_Click(object sender, EventArgs e)
        {
            _db.SaveChanges();
            PopulateGrid();
            gvRecordList.Refresh();
        }

        private void btnEditRecord_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)gvRecordList.SelectedRows[0].Cells["Id"].Value;

                var Record = _db.CarRentalRecords.FirstOrDefault(q => q.id == id);

                var addEditRentalRecord = new AddEditRentalRecord(Record);
                addEditRentalRecord.ShowDialog();
                addEditRentalRecord.MdiParent = this.MdiParent;
                gvRecordList.Refresh();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error in: " + ex.Message);
            }
            

            
        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)gvRecordList.SelectedRows[0].Cells["Id"].Value;

                var Record = _db.CarRentalRecords.FirstOrDefault(q => q.id == id);
                _db.CarRentalRecords.Remove(Record);
                _db.SaveChanges();
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);

            }
        }

        private void ManageRentalRecord_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateGrid();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
               
            }
        }

        private void PopulateGrid()
        {
            var Records = _db.CarRentalRecords
                .Select(q => new
                {
                    Customer=q.CustomerName,
                    DateOut=q.DateRented,
                    DateIn=q.DateReturned,
                    cost=q.Cost,
                    id=q.id,
                    car = q.TypesOfCar.Make + " "+q.TypesOfCar.Model
                }).ToList();
            gvRecordList.DataSource = Records;
            gvRecordList.Columns[1].HeaderText = "Date Rented";
            gvRecordList.Columns[2].HeaderText = "Date Returned";
            gvRecordList.Columns["id"].Visible = false;


        }
    }
}
