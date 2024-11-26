using BuyCar_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buycar
{
    public partial class BuyCar_SignLog : Form
    {
        public BuyCar_SignLog()
        {
            InitializeComponent();
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            string nick = txtNick.Text;
            string password = mskPassword.Text;
            LogIn logIn = new LogIn();
            SqlDataReader reader = logIn.Log(nick, password);
            if (reader.Read())
            {
                BuyCarMain main = new BuyCarMain();
                main.nick = txtNick.Text;
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You have entered wrong password or nick\n Please try again.");
            }
        }

        private void btnAdminEnter_Click(object sender, EventArgs e)
        {
            int mersisno =Convert.ToInt32(mskMersisNo.Text);
            string adminPassword = mskAdminPassword.Text;
            Admin_LogIn admin_LogIn = new Admin_LogIn();
            SqlDataReader reader = admin_LogIn.Log(mersisno, adminPassword);
            if (reader.Read())
            {
                BuyCar_Admin buyCar_Admin = new BuyCar_Admin();
                buyCar_Admin.mersisno = Convert.ToInt32(mskMersisNo.Text);
                buyCar_Admin.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You have entered wrong password or nick\n Please try again.");
            }
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            try
            {
                // TC kimlik numarası uzunluğunun kontrolü
                if (mskTC.Text.Length < 11)
                {
                    throw new ArgumentException("TC kimlik numarası 11 karakterden küçük olamaz.");
                }

                // Email'in uygunluğunun kontrolü
                if (!IsValidEmail(txtEmail.Text))
                {
                    throw new ArgumentException("Geçersiz email adresi. Lütfen geçerli bir email girin.");
                }


                if (!IsValidPhoneNumber(mskPhone.Text))
                {
                    throw new ArgumentException("Geçersiz telefon numarası. Lütfen geçerli bir telefon numarası girin.");
                }
                // Yukarıdaki koşulları geçtikten sonra ekleme işlemi yapılır.
                CSignUp signUp = new CSignUp();
                signUp.Add(new BuyCar_DataAccess.Customer
                {
                    TC = mskTC.Text,
                    Name = txtName.Text,
                    Surname = txtSurname.Text,
                    City = cmbCity.Text,
                    Email = txtEmail.Text,
                    Phone = mskPhone.Text,
                    Nick = txtSNick.Text,
                    Password = mskSPassword.Text
                });

                MessageBox.Show("Welcome to BuyCar.\nYou can login now.");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Geçersiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bool IsValidEmail(string email)
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(email);
                    return addr.Address == email && email.Contains(".");
                }
                catch
                {
                    return false;
                }
            }
            bool IsValidPhoneNumber(string phoneNumber)
            {

                if (!phoneNumber.StartsWith("(5"))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BuyCar buyCar = new BuyCar();
            buyCar.Show();
            this.Hide();
        }
        private List<string> city = new List<string>
        {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Aksaray",
            "Amasya",
            "Ankara",
            "Antalya",
            "Ardahan",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bartın",
            "Batman",
            "Bayburt",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Düzce",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkâri",
            "Hatay",
            "Iğdır",
            "Isparta",
            "İstanbul",
            "İzmir",
            "Kahramanmaraş",
            "Karabük",
            "Karaman",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kilis",
            "Kırıkkale",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Mardin",
            "Mersin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Osmaniye",
            "Rize",
            "Sakarya",
            "Samsun",
            "Şanlıurfa",
            "Siirt",
            "Sinop",
            "Sivas",
            "Şırnak",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Uşak",
            "Van",
            "Yalova",
            "Yozgat",
            "Zonguldak"
        };

        private void cmbCity_TextUpdate(object sender, EventArgs e)
        {
            string wanted = cmbCity.Text.ToLower();
            var filtered = city.Where(city => city.ToLower().StartsWith(wanted)).ToList();
            cmbCity.DataSource = filtered;
            cmbCity.DroppedDown = true;
            cmbCity.SelectionStart = wanted.Length;
            cmbCity.SelectionLength = cmbCity.Text.Length - wanted.Length;
        }
    }
}
