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
    public partial class hekimlerin_redakt_penceresi : Form
    {
        public hekimlerin_redakt_penceresi()
        {
            InitializeComponent();
        }

        private void elave_et_Click(object sender, EventArgs e)
        {
            var connString = @"Data Source=P101\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            var adText = adi.Text;
            var soyadText = soyadi.Text;
            var telefonText = telefon.Text;
            var emailText = e_mail.Text;
            var sobeText = shobe.Text;
            var scheduleldText = scheduleld.Text;
            var startdateText = start_date.Text;
            var endDateText = endDate.Text;
            var shiftText = shift.Text;
            var dateText = date_id.Text;
            var sql = "insert into Doctor (Name,Surname,Phone,Email,DepartmentId,ScheduleId,StartDate,EndDate,ShiftId,DateID) values('" + adText + "','" + soyadText + "','" + telefonText + "','" + emailText + "','" + sobeText + "','" + scheduleldText + "','" + startdateText + "','" + endDateText + "','" + shiftText + "','" + dateText + "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        private void cixis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hekimlerin_redakt_penceresi_Load(object sender, EventArgs e)
        {

        }
    }
}
