using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTS_UI
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void btnBiletAl_Click(object sender, EventArgs e)
        {
            frmBiletAl biletAl = new frmBiletAl();
            biletAl.Show();
        }

        private void btnBiletSorgula_Click(object sender, EventArgs e)
        {
            frmBiletSorgula frm = new frmBiletSorgula();
            frm.Show();
        }

        private void btnTurlar_Click(object sender, EventArgs e)
        {
            frmTur tur = new frmTur();
            tur.Show();
        }

        private void btnRehberler_Click(object sender, EventArgs e)
        {
            frmRehber rehber = new frmRehber();
            rehber.Show();
        }

        private void btnYerler_Click(object sender, EventArgs e)
        {
            frmYer form = new frmYer();
            form.Show();
        }

        private void btnBolgeler_Click(object sender, EventArgs e)
        {
            frmBolge form = new frmBolge();
            form.Show();
        }

        private void btnDiller_Click(object sender, EventArgs e)
        {
            frmDil form = new frmDil();
            form.Show();
        }        

        private void timer1_Tick(object sender, EventArgs e)
        {
            kampanyaUC1.Visible = !kampanyaUC1.Visible;
            otsturuc1.Visible = !otsturuc1.Visible;
        }                 

        private void BtnTwitter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Üzgünüz, bu özellik şu anda kullanılamıyor");
        }

        private void BtnWhatsapp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Üzgünüz, bu özellik şu anda kullanılamıyor");

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
