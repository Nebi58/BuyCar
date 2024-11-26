using BuyCar_Business;
using BuyCar_DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buycar
{
    public partial class Car_Import : Form
    {
        public Car_Import()
        {
            InitializeComponent();
        }
        Connection connection = new Connection();
        Import ımport = new Import();
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (.txt)|.txt|All Files (.)|.";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtImport.Text = openFileDialog.FileName;
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            string fileppath = txtImport.Text;

            if (!string.IsNullOrEmpty(fileppath) && File.Exists(fileppath))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(fileppath))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            string[] values = line.Split(',');

                            if (values.Length == 6)
                            {
                                string Car_Brand = values[0].ToString();
                                string Car_Model = values[1].ToString();
                                int Property_Year = Convert.ToInt32(values[2]);
                                int Property_Price = Convert.ToInt32(values[3]);
                                string Property_Color = values[4].ToString();
                                string Property_FuelType = values[5].ToString();

                                ımport.Import_Car(Car_Brand, Car_Model);
                                int id = ımport.Car_Id();
                                ımport.Import_Property(id, Property_Year, Property_Price, Property_Color, Property_FuelType);
                            }
                            else
                            {
                                MessageBox.Show("Dosya formatı geçersiz. Her satırda Ders_ID, Ders_Adi, Ders_Aciklama ve Ders_Kredi sütunları olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            }
                        }

                        MessageBox.Show("Seçilen text dosyasındaki ders veya dersler başarıyla sisteme yüklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Text dosyasındaki dersleri yüklerken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir dosya seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
