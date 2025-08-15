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

namespace Veri_Tabani_Parti_Secim_Grafik_İstatistik
{
    public partial class FrmOyGiris: Form
    {
        public FrmOyGiris()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=ABDULLAH;Initial Catalog=DbSecim;Integrated Security=True;Encrypt=False");

        private void btnVoteSave_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into TBL_ILCE(ILCEAD,A_PARTİ,B_PARTİ,C_PARTİ,D_PARTİ,E_PARTİ) values" +
                "(@P1,@P2,@P3,@P4,@P5,@P6)", conn);
            cmd.Parameters.AddWithValue("@P1", txtIlceAd.Text);
            cmd.Parameters.AddWithValue("@P2", txtPartiA.Text);
            cmd.Parameters.AddWithValue("@P3", txtPartiB.Text);
            cmd.Parameters.AddWithValue("@P4", txtPartiC.Text);
            cmd.Parameters.AddWithValue("@P5", txtPartiD.Text);
            cmd.Parameters.AddWithValue("@P6", txtPartiE.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Oylarınız Girişi Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void FrmOyGiris_Load(object sender, EventArgs e)
        {

        }

        private void btnGraphics_Click(object sender, EventArgs e)
        {
            FrmGrafikler frmGrafikler = new FrmGrafikler();
            frmGrafikler.Show();
        }
    }
}
