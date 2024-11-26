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
    public partial class ZedGraph_DeletedMember : Form
    {
        public ZedGraph_DeletedMember()
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

        private void ZedGraph_DeletedMember_Load(object sender, EventArgs e)
        {
            Member_List member_List = new Member_List();
            dgwDeleteMember.DataSource = member_List.DeleteMember();
            dgwDeleteMember.Columns["Delete_TC"].HeaderText = "TC";
            dgwDeleteMember.Columns["Delete_Name"].HeaderText = "Name";
            dgwDeleteMember.Columns["Delete_Surname"].HeaderText = "Surname";
            dgwDeleteMember.Columns["Delete_City"].HeaderText = "City";
            dgwDeleteMember.Columns["Delete_Email"].HeaderText = "Email";
            dgwDeleteMember.Columns["Delete_Phone"].HeaderText = "Phone";
            dgwDeleteMember.Columns["Delete_Nick"].HeaderText = "Nick";
            dgwDeleteMember.Columns["Delete_Password"].HeaderText = "Password";
        }
    }
}
