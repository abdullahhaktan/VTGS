using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Veri_Tabani_Parti_Secim_Grafik_İstatistik
{
    public partial class FrmGrafikler: Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=ABDULLAH;Initial Catalog=DbSecim;Integrated Security=True;Encrypt=False");

        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            // İlçe Adlarını ComoboBox'a Yükleme
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT ILCEAD FROM TBL_ILCE", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbIlce.Items.Add(dr[0].ToString());
            }
            conn.Close();

            // Grafiğe Toplam Sonuçları Getirme
            conn.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT SUM(A_PARTİ), SUM(B_PARTİ), SUM(C_PARTİ), SUM(D_PARTİ), SUM(E_PARTİ) " +
                "FROM TBL_ILCE", conn);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                chart1.Series["Partiler"].Points.AddXY("A Parti", dr2[0]);
                chart1.Series["Partiler"].Points.AddXY("B Parti", dr2[1]);
                chart1.Series["Partiler"].Points.AddXY("C Parti", dr2[2]);
                chart1.Series["Partiler"].Points.AddXY("D Parti", dr2[3]);
                chart1.Series["Partiler"].Points.AddXY("E Parti", dr2[4]);
            }
            conn.Close();
        }

        private void cmbIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM TBL_ILCE WHERE" +
                " ILCEAD=@P1", conn);

            cmd.Parameters.AddWithValue("@P1", cmbIlce.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                prgrssBarPartiA.Value = Convert.ToInt32(dr[2]);
                prgrssBarPartiB.Value = Convert.ToInt32(dr[3]);
                prgrssBarPartiC.Value = Convert.ToInt32(dr[4]);
                prgrssBarPartiD.Value = Convert.ToInt32(dr[5]);
                prgressBarPartiE.Value = Convert.ToInt32(dr[6]);

                lblPartiA.Text = dr[2].ToString();
                lblPartiB.Text = dr[3].ToString();
                lblPartiC.Text = dr[4].ToString();
                lblPartiD.Text = dr[5].ToString();
                lblPartiE.Text = dr[6].ToString();
            }
            conn.Close();
            dr.Close();
        }
    }
}
