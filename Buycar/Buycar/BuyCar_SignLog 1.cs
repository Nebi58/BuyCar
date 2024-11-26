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
            string MersisNo = mskMersisNo.Text;
            string adminPassword = mskAdminPassword.Text;
            Admin_LogIn admin_LogIn = new Admin_LogIn();
            SqlDataReader reader = admin_LogIn.Log(MersisNo, adminPassword);
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
    }
}
