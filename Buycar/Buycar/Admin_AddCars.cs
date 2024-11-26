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
        // Markalar listesi
        private List<string> brand = new List<string> { "Mercedes", "Audi", "Ford", "BMW" };

        // Modeller listesi
        private List<string> Mmodel = new List<string> { "G-Class", "C-Class" };
        private List<string> Amodel = new List<string> { "A3", "A5" };
        private List<string> Fmodel = new List<string> { "Mustang", "Fiesta" };
        private List<string> Bmodel = new List<string> { "X1", "X8" };
        private void cmbBrand_TextUpdate_1(object sender, EventArgs e)
        {
            string wanted = cmbBrand.Text.ToLower();
            var filtered = brand.Where(brand => brand.ToLower().StartsWith(wanted)).ToList();
            if (filtered.Count > 0)
            {
                cmbBrand.DataSource = filtered;
                cmbBrand.DroppedDown = true;
                cmbBrand.SelectionStart = wanted.Length;
                cmbBrand.SelectionLength = cmbBrand.Text.Length - wanted.Length;
            }
            else
            {
                cmbBrand.DataSource = null;
                cmbBrand.DroppedDown = false;
            }
        }

        private void cmbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedBrand = cmbBrand.Text;

            List<string> selectedModels = new List<string>();

            if (selectedBrand == "Mercedes")
            {
                selectedModels = Mmodel;
            }
            else if (selectedBrand == "Audi")
            {
                selectedModels = Amodel;
            }
            else if (selectedBrand == "Ford")
            {
                selectedModels = Fmodel;
            }
            else if (selectedBrand == "BMW")
            {
                selectedModels = Bmodel;
            }
            else
            {
                MessageBox.Show("Araba seçilmedi...");
            }

            cmbModel.DataSource = selectedModels;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
                try
                {
                 Car_Add car_Add = new Car_Add();
                car_Add.Add_Car(new Car
                {
                    Brand = cmbBrand.Text,
                    Model = cmbModel.Text
                });
                    int Id = car_Add.Car_Id();
                car_Add.Add_Property(Id,new Property
                {
                    Year = Convert.ToInt32(mskYear.Text),
                    Price = Convert.ToInt32(txtPrice.Text),
                    Color = cmbColor.Text,
                    FuelType = cmbFuelType.Text
                });
                MessageBox.Show("Inserted...");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BuyCar_Admin buyCar_Admin = new BuyCar_Admin();
            buyCar_Admin.Show();
            this.Hide();
        }
    }
}
