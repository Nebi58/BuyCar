using BuyCar_Business;
using BuyCar_DataAccess;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buycar
{
    public partial class BuyCar_Admin : Form
    {
        public BuyCar_Admin()
        {
            InitializeComponent();
        }
        public int mersisno;
        private void BuyCar_Admin_Load(object sender, EventArgs e)
        {
            Admin_Info admin_Info = new Admin_Info();
            SqlDataReader reader = admin_Info.admininfo(mersisno);
            while (reader.Read())
            {
                lblName.Text = reader[0] + " ";
                lblSurname.Text = reader[1] + " ";
            }
            Car_List car_List = new Car_List();
            dgwCarList.DataSource = car_List.selectCar();
            dgwCarList.Columns["Car_SerialNo"].HeaderText = "SerialNo";
            dgwCarList.Columns["Car_Brand"].HeaderText = "Brand";
            dgwCarList.Columns["Car_Model"].HeaderText = "Model";
            dgwCarList.Columns["Property_Year"].HeaderText = "Year";
            dgwCarList.Columns["Property_Price"].HeaderText = "Price";
            dgwCarList.Columns["Property_Color"].HeaderText = "Color";
            dgwCarList.Columns["Property_FuelType"].HeaderText = "FuelType";
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            Admin_AddCars admin_AddCars = new Admin_AddCars();
            admin_AddCars.Show();
        }

        private void btnSaled_Click(object sender, EventArgs e)
        {
            Admin_SaledCars admin_SaledCars = new Admin_SaledCars();
            admin_SaledCars.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Çıkmak istediğine emin misin?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.Yes)
            {
                this.Hide();
                BuyCar_SignLog buyCar_SignLog = new BuyCar_SignLog();
                buyCar_SignLog.Show();
            }
            else
            {

            }
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
                GetData2();
            
        }
        public void GetData2()
        {
            Connection connection = new Connection();
            SqlCommand command = new SqlCommand("SELECT t1.Car_SerialNo,t1.Car_Brand,t1.Car_Model" +
                ", t2.Property_Year,t2.Property_Price,t2.Property_Color,t2.Property_FuelType FROM Tbl_Car t1 " +
                "INNER JOIN Tbl_Property t2 ON t1.Car_SerialNo = t2.Car_SerialNo", connection.connection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgwCarList.DataSource = dataTable;
        }

        private void btnMyCars_Click(object sender, EventArgs e)
        {
            MyCars myCars = new MyCars();
            myCars.Show();
            this.Hide();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            Backup backup = new Backup();
            backup.Show();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            if (dgwCarList.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF(.pdf|.pdf";
                save.FileName = "Car List.pdf";
                bool ErrorMessage = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Veriyi diske yazamıyor" + ex.Message);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable pdftable = new PdfPTable(dgwCarList.Columns.Count);
                            pdftable.DefaultCell.Padding = 2;
                            pdftable.WidthPercentage = 100;
                            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn col in dgwCarList.Columns)
                            {
                                PdfPCell pdfcell = new PdfPCell(new Phrase(col.HeaderText));
                                pdftable.AddCell(pdfcell);
                            }
                            foreach (DataGridViewRow viewRow in dgwCarList.Rows)
                            {
                                foreach (DataGridViewCell dgwCell in viewRow.Cells)
                                {
                                    pdftable.AddCell(dgwCell.Value.ToString());
                                }
                            }
                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                using (Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f))
                                {
                                    PdfWriter.GetInstance(document, fileStream);

                                    document.Open();
                                    document.Add(pdftable);
                                    document.Close();
                                }

                                fileStream.Close();
                            }
                            MessageBox.Show("Arabalarım pdf formatında kaydedilmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Pdf formatına çevrilirken bir hata oluştu", "Hata" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Kayıt bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            Car_Import car_Import = new Car_Import();
            car_Import.Show();
        }

        private void btnProperty_Click(object sender, EventArgs e)
        {
            Car_Property car_Property = new Car_Property();
            car_Property.Show();
            this.Hide();
        }

        private void btnMyMember_Click(object sender, EventArgs e)
        {
            ZedGraph_MyMember _MyMember = new ZedGraph_MyMember();
            _MyMember.Show();
            this.Hide();
        }

        private void btnDeletedMember_Click(object sender, EventArgs e)
        {
            ZedGraph_DeletedMember _DeletedMember = new ZedGraph_DeletedMember();
            _DeletedMember.Show();
            this.Hide();
        }
    }
}
