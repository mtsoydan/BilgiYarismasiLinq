using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Media;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace Lınq_Kim500
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataClasses1DataContext mydt = new DataClasses1DataContext();
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_SoruEkle_Click(object sender, EventArgs e)
        {
            frmSoruEkle soruEkle = new frmSoruEkle();
            this.Hide();
            soruEkle.ShowDialog();
        }

        private void btn_Cıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Basla_Click(object sender, EventArgs e)
        {
            frmYarismaBasla frmBasla = new frmYarismaBasla(); this.Hide();
            frmBasla.Show(); 
            ArrayList array = new ArrayList();
            //for (int i = 0; i <= 10; i++)
            //{
            //    array[i] = mydt.RasgeleSoru();
            //}
            //foreach (var item in array)
            //{
            //    MessageBox.Show(item.ToString());
            //}
            
            //var sorgu = from a in mydt.RasgeleSoru() select a;
            //foreach (var item in sorgu)
            //{
            //    array.Add(item);
            //}
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SoundPlayer Sd = new SoundPlayer();
            Sd.SoundLocation = Application.StartupPath + @"\sesler\acilis.wav";
            Sd.Play();

        }
        private void Form1_Activated(object sender, EventArgs e)
        {
        }
    }
}
