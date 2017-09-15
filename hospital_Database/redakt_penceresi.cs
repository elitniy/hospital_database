using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospital_Database
{
    public partial class redakt_penceresi : Form
    {
        public redakt_penceresi()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sobenin_redakt_penceresi frm = new sobenin_redakt_penceresi();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hekimlerin_redakt_penceresi  frm = new hekimlerin_redakt_penceresi();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tibb_bacilarin_redakt_penceresi frm = new tibb_bacilarin_redakt_penceresi();
            frm.Show();
        }
    }
}
