using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Lınq_Kim500
{
    public partial class frmGuncelle : Form
    {
        public frmGuncelle()
        {
            InitializeComponent();
        }
        int ID;
        public frmGuncelle(int _ID)
        {
            InitializeComponent();
            this.ID = _ID;   
        }
        DataClasses1DataContext mydt = new DataClasses1DataContext();
        private void button1_Click(object sender, EventArgs e)
        {
            frmSoruListesi srlist = new frmSoruListesi();
            this.Hide();
            srlist.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            mydt.SoruGuncelle(this.ID, txt_Guncel_SoruMetni.Text, char.Parse(txt_Guncel_DogruCevap.Text), txt_Guncel_SıkA.Text, txt_Guncel_SıkB.Text, txt_Guncel_SıkC.Text, txt_Guncel_SıkD.Text);
            mydt.SubmitChanges();
            MessageBox.Show("Soru Başarıyla Güncellendi");
        }
        Data dt= new Data();
        private void frmGuncelle_Activated(object sender, EventArgs e)
        {            
            try
            {
                Veriler.listview_Sorular soru = dt.SoruGetir(ID);
                txt_Guncel_SoruMetni.Text = soru.soruMetni;
                txt_Guncel_SıkA.Text = soru.SıkA;
                txt_Guncel_SıkB.Text = soru.SıkB;
                txt_Guncel_SıkC.Text = soru.SıkC;
                txt_Guncel_SıkD.Text = soru.SıkD;
                txt_Guncel_DogruCevap.Text = soru.dogruSık.ToString();       
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_Guncelle_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(txt_Guncel_SoruMetni.TextLength.ToString());
        }
    }
}
