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

namespace hospital_Database
{
    public partial class sobenin_redakt_penceresi : Form
    {
        public sobenin_redakt_penceresi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var connString = @"Data Source=P101\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            var adText = sobenin_adi.Text;
            var telefonText = telefon.Text;
            var sql = "insert into Department (Name,Phone) values('" + adText + "','" + telefonText + "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
