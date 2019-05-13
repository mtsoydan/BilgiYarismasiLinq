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
    public partial class frmSoruListesi : Form
    {
        public frmSoruListesi()
        {
            InitializeComponent();
        }
        Data dt = new Data();
        DataClasses1DataContext mydt = new DataClasses1DataContext();
        List<Veriler.listview_Sorular> sr = null;
        private void frmSoruListesi_Activated(object sender, EventArgs e)
        {
            //listele();
            //listView1.Items.Clear();
            //listele(0);
        }
        void listele(int index)
        {
            listView1.Items.Clear();            
            if (index == 0)
            {
                    sr = dt.SoruGetir();                    
            }
            else
            {                
                sr = dt.SoruGetir(textBox1.Text);
            }
            foreach (Veriler.listview_Sorular item in sr)
            {                
                ListViewItem eleman = listView1.Items.Add(item.soruID.ToString());
                eleman.SubItems.Add(item.soruMetni);
                eleman.SubItems.Add(item.SıkA);
                eleman.SubItems.Add(item.SıkB);
                eleman.SubItems.Add(item.SıkC);
                eleman.SubItems.Add(item.SıkD);
                eleman.SubItems.Add(item.dogruSık.ToUpper());
            }
            sr.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmSoruEkle frmEkle = new frmSoruEkle();
            this.Hide();
            frmEkle.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        { 
            if (listView1.CheckedItems.Count == 1)
            {
                frmGuncelle frmGuncel = new frmGuncelle(int.Parse(listView1.CheckedItems[0].Text));
                this.Hide();
                frmGuncel.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen Bir Adet Kayıt Seçiniz");
            }            
        }
        private void frmSoruListesi_Load(object sender, EventArgs e)
        {
            listele(0);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int[] dizi = new int[listView1.CheckedItems.Count];
                for (int i = 0; i < dizi.Length; i++)
                {
                    dizi[i] = int.Parse(listView1.CheckedItems[i].Text);
                    //MessageBox.Show(listView1.CheckedItems[i].Text);
                    dt.SoruSil(dizi[i]);
                }
                MessageBox.Show("Kayıtlar Silindi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            listele(0);
        }
        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                listele(0);
                
            }
            else
            {
                listele(1);
            }
        }
    }
}
