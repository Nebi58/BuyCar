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
    public partial class BrokenCar : Form
    {
        public BrokenCar()
        {
            InitializeComponent();
        }
        // Markalar listesi
        private List<string> brand = new List<string> { "Mercedes", "Audi", "Ford", "BMW" };

        // Modeller listesi
        private List<string> Mmodel = new List<string> { "  G-Class", "C-Class" };
        private List<string> Amodel = new List<string> { "A3", "A5" };
        private List<string> Fmodel = new List<string> { "Fiesta", "Mustang" };
        private List<string> Bmodel = new List<string> { "X1", "X8" };

        private void cmbBrand_TextUpdate(object sender, EventArgs e)
        {
            string wanted = cmbBrand.Text.ToLower();
            var filtered = brand.Where(brand => brand.ToLower().StartsWith(wanted)).ToList();
            if(filtered.Count > 0)
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BuyCarMain buyCarMain = new BuyCarMain();
            buyCarMain.Show();
            this.Hide();
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            string selectedBrand = cmbBrand.SelectedItem as string;
            string message = "";

            if (selectedBrand == "BMW")
            {
                message = "BMW servisine yönlendiriliyorsunuz.";
            }
            else if (selectedBrand == "Mercedes")
            {
                message = "Mercedes bayisine yönlendiriliyorsunuz.";
            }
            else if (selectedBrand == "Audi")
            {
                message = "Audi bayisine yönlendiriliyorsunuz.";
            }
            else if (selectedBrand == "Ford")
            {
                message = "Ford bayisine yönlendiriliyorsunuz.";
            }
            else
            {
                message = "Lütfen bir marka seçin.";
            }

            MessageBox.Show(message, "Yönlendirme Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

