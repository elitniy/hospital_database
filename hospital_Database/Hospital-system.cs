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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var connString = @"Data Source=P101\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            //SOBELERIN SIYAHINI 
            var selectSql = "select * from Department";
            var selectCmd = new SqlCommand(selectSql, conn);
            var adapter = new SqlDataAdapter(selectCmd);
            var ds = new DataSet();
            adapter.Fill(ds);
            esas_ekran.Text = "";
            for (var i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                esas_ekran.Text += ds.Tables[0].Rows[i]["id"].ToString() + " " + ds.Tables[0].Rows[i]["Name"].ToString() + " " + ds.Tables[0].Rows[i]["Phone"].ToString()+"\r\n";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var connString = @"Data Source=P101\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            //SOBELERIN SIYAHINI 
            var selectSql = "select * from Doctor";
            var selectCmd = new SqlCommand(selectSql, conn);
            var adapter = new SqlDataAdapter(selectCmd);
            var ds = new DataSet();
            adapter.Fill(ds);
            esas_ekran.Text = "";
            for (var i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                esas_ekran.Text += ds.Tables[0].Rows[i]["id"].ToString() + " " + ds.Tables[0].Rows[i]["Name"].ToString() + " " + ds.Tables[0].Rows[i]["Phone"].ToString() + "\r\n";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            redakt_penceresi frm = new redakt_penceresi();
            frm.Show();
        }
    }
}
