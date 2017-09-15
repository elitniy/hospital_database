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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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
            for (var i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                sobeler.Items.Add(ds.Tables[0].Rows[i]["Name"]);
            }
            //hEKIMLERIN SIYAHINI
            var selectSqlD = "select * from Doctor";
            var selectCmdD = new SqlCommand(selectSqlD, conn);
            var adapterD = new SqlDataAdapter(selectCmdD);
            var dsD = new DataSet();
            adapterD.Fill(dsD);
            for (var i = 0; i < dsD.Tables[0].Rows.Count; i++)
            {
                hekimler.Items.Add(dsD.Tables[0].Rows[i]["Name"] + " " + dsD.Tables[0].Rows[i]["Surname"]);
            }
            //TARIXLER
            var selectSqlT = "select * from Department";
            var selectCmdT = new SqlCommand(selectSqlT, conn);
            var adapterT = new SqlDataAdapter(selectCmdT);
            var dsT = new DataSet();
            adapter.Fill(dsT);
            for (int i = 0; i < 100; i++)
            {
                tarix.Items.Add(DateTime.Now.AddDays(+i).ToString());
            }
            //NOVBELER
            var selectSqlN = "select * from Shift";
            var selectCmdN = new SqlCommand(selectSqlN, conn);
            var adapterN = new SqlDataAdapter(selectCmdN);
            var dsN = new DataSet();
            adapterN.Fill(dsN);
            for (var i = 0; i < dsN.Tables[0].Rows.Count; i++)
            {
                novbe.Items.Add(dsN.Tables[0].Rows[i]["Name"]);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var connString = @"Data Source=P101\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            var sobeText = sobeler.SelectedItem;
            var doctorText = hekimler.SelectedItem;
           // var tarixText = tarix.SelectedItem;
            //var novbeText = novbe.SelectedItem;
            var adText = adi.Text;
            var soyadText = soyadi.Text;
            var yasText = yasi.Text;
            var telText = tel.Text;
            var sql = "insert into Qeydiyyat_sobesi (Department,Doctor,Shift,Ad,Soyad,Yas,Tel) values('" + sobeText + "','" + doctorText + "','" + adText + "','" + soyadText + "','" + yasText + "','" + telText + "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
