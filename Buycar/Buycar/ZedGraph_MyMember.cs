using BuyCar_Business;
using BuyCar_DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buycar
{
    public partial class ZedGraph_MyMember : Form
    {
        public ZedGraph_MyMember()
        {
            InitializeComponent();
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

        private void ZedGraph_MyMember_Load(object sender, EventArgs e)
        {
            Member_List member_List = new Member_List();
            dgwMyMember.DataSource = member_List.MyMember();
            dgwMyMember.Columns["Customer_TC"].HeaderText = "TC";
            dgwMyMember.Columns["Customer_Name"].HeaderText = "Name";
            dgwMyMember.Columns["Customer_Surname"].HeaderText = "Surname";
            dgwMyMember.Columns["Customer_City"].HeaderText = "City";
            dgwMyMember.Columns["Customer_Email"].HeaderText = "Email";
            dgwMyMember.Columns["Customer_Phone"].HeaderText = "Phone";
            dgwMyMember.Columns["Customer_Nick"].HeaderText = "Nick";
            dgwMyMember.Columns["Customer_Password"].HeaderText = "Password";
        }
    }
}
