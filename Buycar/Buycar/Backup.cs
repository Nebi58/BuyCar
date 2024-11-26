using BuyCar_DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buycar
{
    public partial class Backup : Form
    {
        Connection connection=new Connection();
        public Backup()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Backup_Load(object sender, EventArgs e)
        {
            connection.connection();
            checkedListBox1.Items.Clear();
            SqlCommand cmd = new SqlCommand("Select * from Sysdatabases order by name", connection.connection());
            SqlDataReader myreader = cmd.ExecuteReader();
            while (myreader.Read())
                checkedListBox1.Items.Add(myreader[0]);
            connection.connection().Close();
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDatabases.Checked)
            {
                for (int item = 0; item <= checkedListBox1.Items.Count - 1; item++)
                    checkedListBox1.SetItemChecked(item, true);
            }
            else
            {
                for (int item = 0; item <= checkedListBox1.Items.Count - 1; item++)
                    checkedListBox1.SetItemChecked(item, false);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtBackup.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count != 0)
            {
                if (txtBackup.Text != "")
                {
                    foreach (object databasecheck in checkedListBox1.CheckedItems)
                    {
                        string lfolder;
                        lfolder = txtBackup.Text + @"\" + databasecheck.ToString() + ".mdf";
                        string strsql = "Backup Database " + databasecheck.ToString() + " To Disk='" + lfolder + "'";
                        SqlCommand cmd2 = new SqlCommand(strsql, connection.connection());
                        connection.connection();
                        cmd2.ExecuteNonQuery();
                        connection.connection().Close();
                    }
                    MessageBox.Show("Veri Tabanı Başarıyla Yedeklendi.");
                }
                else
                {
                    MessageBox.Show("Lütfen Yedeklemek İstediğiniz Yeri Seçiniz.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Yedeklemek İstediğiniz Veri Tabanını Seçiniz.");
            }
        }
    }
}
