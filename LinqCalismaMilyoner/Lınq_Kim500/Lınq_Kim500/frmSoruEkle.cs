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
    public partial class frmSoruEkle : Form
    {
        public frmSoruEkle()
        {
            InitializeComponent();
        }
        DataClasses1DataContext myDT = new DataClasses1DataContext();
        private void txt_Ekle_Click(object sender, EventArgs e)
        {
            try
            {
                myDT.SoruEkle(txt_SoruMetni.Text, txt_SıkA.Text, txt_SıkB.Text, txt_SıkC.Text, txt_SıkD.Text, char.Parse(txt_DogruCevap.Text));

                
                //Sorular tbl_Soru = new Sorular();
                //SoruDogruSık tbl_SoruDogruSık = new SoruDogruSık();
                //SoruSıkları tbl_SoruSıkları = new SoruSıkları();
                //tbl_Soru.SoruMetni = txt_SoruMetni.Text;
                //tbl_SoruSıkları.A = txt_SıkA.Text;
                //tbl_SoruSıkları.B = txt_SıkB.Text;
                //tbl_SoruSıkları.C = txt_SıkC.Text;
                //tbl_SoruSıkları.D = txt_SıkD.Text;
                //tbl_SoruDogruSık.DogruSık = char.Parse(txt_DogruCevap.Text);
                //myDT.Sorulars.InsertOnSubmit(tbl_Soru);
                //myDT.SoruSıklarıs.InsertOnSubmit(tbl_SoruSıkları);
                //myDT.SoruDogruSıks.InsertOnSubmit(tbl_SoruDogruSık);
                myDT.SubmitChanges();
                MessageBox.Show("Soru Başarıyla Eklendi");
                
            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); Form1 frm1 = new Form1();
            frm1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmSoruListesi srlist = new frmSoruListesi();
            this.Hide();
            srlist.ShowDialog();
        }

        private void btn_Cikis_SoruEkle_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
