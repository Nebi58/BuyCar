using BuyCar_Business;
using BuyCar_DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buycar
{
    public partial class Admin_AddCars : Form
    {
        public Admin_AddCars()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Car_Add car_Add = new Car_Add();
                car_Add.Add_Property(new Property
                {
                    Year = Convert.ToInt32(mskYear.Text),
                    Price = Convert.ToInt32(txtPrice.Text),
                    Color = txtColor.Text,
                    FuelType = txtFuelType.Text
                });
                int Id = car_Add.Car_Id();
                car_Add.Add_Car(Id, new Car
                {
                    Brand = txtBrand.Text,
                    Model = txtModel.Text,
                });
                MessageBox.Show("Inserted...");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
