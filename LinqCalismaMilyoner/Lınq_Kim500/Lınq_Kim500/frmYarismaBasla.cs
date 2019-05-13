using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Media;
namespace Lınq_Kim500
{
    public partial class frmYarismaBasla : Form
    {
        public frmYarismaBasla()
        {
            InitializeComponent();
        }
        Random Rnd = new Random();
        DataClasses1DataContext mydt = new DataClasses1DataContext();
        Data dt = new Data();
        int sure = 15;
        int SureTelefon = 30;
        DataTable DataTableSorular;
        SoundPlayer Sd = new SoundPlayer();
        int Sira = 0;
        string DogruCevap;
        int Soru = 0;
        bool CiftCevapAktif = false;
        void ParaArttir(int Sira)
        {
            if (Sira == 1)
            {
                btn_Para1.BackColor = Color.Green; btn_Para1.ForeColor = Color.Green;
                btn_Para1.BackgroundImage = Properties.Resources.solbgbilindi;
            }
            else if (Sira == 2)
            {
                btn_Para2.BackColor = Color.Green; btn_Para2.ForeColor = Color.Green;
                btn_Para2.BackgroundImage = Properties.Resources.solbgbilindi;
            }
            else if (Sira == 3)
            {
                btn_Para3.BackColor = Color.Green; btn_Para3.ForeColor = Color.Green;
                btn_Para3.BackgroundImage = Properties.Resources.solbgbilindi;
            }
            else if (Sira == 4)
            {
                btn_Para4.BackColor = Color.Green; btn_Para4.ForeColor = Color.Green;
                btn_Para4.BackgroundImage = Properties.Resources.solbgbilindi;
            }
            else if (Sira == 5)
            {
                btn_Para5.BackColor = Color.Green; btn_Para5.ForeColor = Color.Green;
                btn_Para5.BackgroundImage = Properties.Resources.solbgbilindi;
            }
            else if (Sira == 6)
            {
                btn_Para6.BackColor = Color.Green; btn_Para6.ForeColor = Color.Green;
                btn_Para6.BackgroundImage = Properties.Resources.solbgbilindi;
            }
            else if (Sira == 7)
            {
                btn_Para7.BackColor = Color.Green; btn_Para7.ForeColor = Color.Green;
                btn_Para7.BackgroundImage = Properties.Resources.solbgbilindi;

            }
            else if (Sira == 8)
            {
                btn_Para8.BackColor = Color.Green; btn_Para8.ForeColor = Color.Green;
                btn_Para8.BackgroundImage = Properties.Resources.solbgbilindi;
            }
            else if (Sira == 9)
            {
                btn_Para9.BackColor = Color.Green; btn_Para9.ForeColor = Color.Green;
                btn_Para9.BackgroundImage = Properties.Resources.solbgbilindi;
            }
            else if (Sira == 10)
            {
                this.Close();
                btn_Para10.BackColor = Color.Green; btn_Para10.ForeColor = Color.Green;
                btn_Para10.BackgroundImage = Properties.Resources.solbgbilindi;
                string yol = Application.StartupPath + @"\Cekler\cek10.jpg";
                frm_para pr = new frm_para(yol);
                pr.Show();
                if (Soru == 10)
                {
                    Soru = 1;
                }
            }
        }
        void YariYariya(string DogruCevap)
        {
            btn_JokerYuzdeEllı.BackgroundImage = Properties.Resources.yari_iptal;
            btn_JokerYuzdeEllı.Enabled = false;
            if (DogruCevap == "a")
            {
                btn_B.Visible = false;
                btn_C.Visible = false;
            }
            else if (DogruCevap == "b")
            {
                btn_A.Visible = false;
                btn_D.Visible = false;
            }
            else if (DogruCevap == "c")
            {
                btn_B.Visible = false;
                btn_A.Visible = false;
            }
            else
            {
                btn_A.Visible = false;
                btn_C.Visible = false;
            }
        }
        void Telefon(string DogruCevap, int Sayi)
        {   
            if (Sayi == 1)
            {
                richTextBox1.Text = "Büyük İhtimalle  "+DogruCevap.ToUpper()+"  Ama Tam Emin Olamıyorum";
            }
            else if(Sayi ==2)
            {
                richTextBox1.Text = "Kesinlikle  " +  DogruCevap.ToUpper() + "  Eminim";
            }
            else
            {
                richTextBox1.Text = "Kusura Bakma Hiç Bir Fikrim Yok";
            }
        }
        void KontrolEt(string Cevap)
        {       
            DialogResult Eminmisiniz = new DialogResult();
            Eminmisiniz = MessageBox.Show("Son Kararınızmı", "Uyari", MessageBoxButtons.YesNo);
            if (Eminmisiniz == DialogResult.Yes)
            {
                timer1.Stop();
                if (DataTableSorular.Rows[Soru][6].ToString() == Cevap)
                {
                    CiftCevapAktif = false;
                    btn_B.Visible = true;
                    btn_C.Visible = true;
                    btn_A.Visible = true;
                    btn_D.Visible = true;
                    Sira++;
                    Soru++;
                    ParaArttir(Sira);
                    Sd.SoundLocation = Application.StartupPath + @"\sesler\dogru.wav";
                    Sd.Play();
                    MessageBox.Show("Tebrikler");
                    btn_Soru.Text = DataTableSorular.Rows[Soru][1].ToString();
                    btn_A.Text = DataTableSorular.Rows[Soru][2].ToString();
                    btn_B.Text = DataTableSorular.Rows[Soru][3].ToString();
                    btn_C.Text = DataTableSorular.Rows[Soru][4].ToString();
                    btn_D.Text = DataTableSorular.Rows[Soru][5].ToString(); 
                    sure = 15;
                    timer1.Start();
                    panel1.Visible = false;
                }
                else
                {
                    if (CiftCevapAktif == true)
                    {
                        if (Cevap == "b")
                        {
                            btn_B.Enabled = false;
                            CiftCevapAktif = false;
                        }
                        else if (Cevap == "a")
                        {
                            btn_A.Enabled = false;
                            CiftCevapAktif = false;
                        }
                        else if (Cevap == "c")
                        {
                            btn_C.Enabled = false;
                            CiftCevapAktif = false;
                        }
                        else
                        {
                            btn_D.Enabled = false;
                            CiftCevapAktif = false;
                        }
                        return;
                    }
                    Sd.SoundLocation = Application.StartupPath + @"\sesler\yanlis.wav";
                    Sd.Play();
                    timer1.Stop();
                    MessageBox.Show("Yanlış Cevap");
                    timer1.Stop();
                    string yol = Application.StartupPath + @"\Cekler\cek" + Sira + ".jpg";
                    this.Hide();
                    frm_para pr = new frm_para(yol);
                    pr.Show();                    
                }
            }
            panel2.Visible = false;
            timer2.Enabled = false;
            PC_TelefonJokerSure.Visible = false;
        }
        void Seyirci(string DogruCevap)
        {
            if (DogruCevap == "a")
            {
                lbl_B.Text = Rnd.Next(22, 26).ToString();
                lbl_C.Text = Rnd.Next(12, 30).ToString();
                lbl_D.Text = Rnd.Next(14, 22).ToString();
                lbl_A.Text = (100 - (int.Parse(lbl_B.Text) + int.Parse(lbl_C.Text) + int.Parse(lbl_D.Text))).ToString();
            }
            else if (DogruCevap == "b")
            {
                lbl_A.Text = Rnd.Next(11, 25).ToString();
                lbl_C.Text = Rnd.Next(10, 20).ToString();
                lbl_D.Text = Rnd.Next(5, 15).ToString();
                lbl_B.Text = (100 - (int.Parse(lbl_A.Text) + int.Parse(lbl_C.Text) + int.Parse(lbl_D.Text))).ToString();
            }
            else if (DogruCevap == "c")
            {
                lbl_B.Text = Rnd.Next(10, 25).ToString();
                lbl_A.Text = Rnd.Next(10, 12).ToString();
                lbl_D.Text = Rnd.Next(10, 25).ToString();
                lbl_C.Text = (100 - (int.Parse(lbl_B.Text) + int.Parse(lbl_A.Text) + int.Parse(lbl_D.Text))).ToString();
            }
            else
            {
                lbl_B.Text = Rnd.Next(10, 15).ToString();
                lbl_C.Text = Rnd.Next(10, 25).ToString();
                lbl_A.Text = Rnd.Next(15, 25).ToString();
                lbl_D.Text = (100 - (int.Parse(lbl_B.Text) + int.Parse(lbl_C.Text) + int.Parse(lbl_A.Text))).ToString();
            }


        }
        private void frmYarismaBasla_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btn_telefonJoker1, "Üniversite Öğrencisi");
            toolTip1.SetToolTip(btn_telefonJoker2, "Edebiyat Öğretmeni");
            toolTip1.SetToolTip(btn_telefonJoker3, "Emekli Bankacı");
            PC_TelefonJokerSure.Visible = false;
            timer2.Enabled = false;
            panel1.Visible = false;
            panel2.Visible = false;
            DataTableSorular = dt.YarismaSorulari();
            btn_Soru.Text = DataTableSorular.Rows[Soru][1].ToString();
            btn_A.Text = DataTableSorular.Rows[Soru][2].ToString();
            btn_B.Text = DataTableSorular.Rows[Soru][3].ToString();
            btn_C.Text = DataTableSorular.Rows[Soru][4].ToString();
            btn_D.Text = DataTableSorular.Rows[Soru][5].ToString();
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sure >= 0)
            {
                pictureBox2.Image = Image.FromFile(Application.StartupPath + @"\BalonSure\sure" + sure + ".png");
                sure -= 1;
            }
            else
            {
                timer1.Enabled = false;
                MessageBox.Show("Yarişma Bitti");
                frm_para pr = new frm_para(Application.StartupPath + @"\Cekler\cek" + Sira + ".jpg");
                pr.Show();
            }
        }
        private void btn_A_Click(object sender, EventArgs e)
        {
            KontrolEt("a");
        }
        private void btn_B_Click(object sender, EventArgs e)
        {
            KontrolEt("b");
        }
        private void btn_C_Click_1(object sender, EventArgs e)
        {
            KontrolEt("c");
        }
        private void btn_D_Click(object sender, EventArgs e)
        {
            KontrolEt("d");
        }
        private void btn_Joker_CiftCevap_Click(object sender, EventArgs e)
        {
            btn_Joker_CiftCevap.Enabled = false;
            btn_Joker_CiftCevap.BackgroundImage = Properties.Resources.cift_iptal;
            CiftCevapAktif = true;
            MessageBox.Show("Çift Cevap Jokeri Aktif Edildi");
        }
        private void btn_JokerYuzdeEllı_Click(object sender, EventArgs e)
        {
            Sd.SoundLocation = Application.StartupPath + @"\sesler\joker50.wav";
            Sd.Play();
            YariYariya(DataTableSorular.Rows[Soru][6].ToString());
        }
        private void frmYarismaBasla_Activated(object sender, EventArgs e)
        {
            btn_B.Enabled = true;
            btn_C.Enabled = true;
            btn_A.Enabled = true;
            btn_D.Enabled = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn_JokerSeyirci_Click(object sender, EventArgs e)
        {
            string DogruCevap = DataTableSorular.Rows[Soru][6].ToString();
            Seyirci(DogruCevap);
            panel1.Visible = true;
            btn_JokerSeyirci.Enabled = false;
            btn_JokerSeyirci.BackgroundImage = Properties.Resources.seyirci_iptal;
        }
        private void btn_Joker_Telefon_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            timer1.Stop();
            PC_TelefonJokerSure.Visible = true;
            btn_Joker_Telefon.Enabled = false;
            timer2.Start();
            btn_Joker_Telefon.BackgroundImage = Properties.Resources.telefon_iptal;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (SureTelefon > 0)
            {       
                PC_TelefonJokerSure.Image = Image.FromFile(Application.StartupPath + @"\Sure\time" + SureTelefon + ".png");   
            }
            else
            {
                timer2.Stop();
                timer1.Start();
                MessageBox.Show("Sure Bitti");
                panel2.Visible = false;
                PC_TelefonJokerSure.Visible = false;
            }
            SureTelefon--;
        }
        private void btn_telefonJoker2_Click(object sender, EventArgs e)
        {
            DogruCevap = DataTableSorular.Rows[Soru][6].ToString();
            int sayi = Rnd.Next(1, 5);
            Telefon(DogruCevap, sayi);
            btn_telefonJoker1.Enabled = false;
            btn_telefonJoker3.Enabled = false;
        }
        private void btn_telefonJoker3_Click(object sender, EventArgs e)
        {
            DogruCevap = DataTableSorular.Rows[Soru][6].ToString();
            int sayi = Rnd.Next(1, 5);
            Telefon(DogruCevap, sayi);
            btn_telefonJoker1.Enabled = false;
            btn_telefonJoker2.Enabled = false;
        }
        private void btn_telefonJoker1_Click(object sender, EventArgs e)
        {
            DogruCevap = DataTableSorular.Rows[Soru][6].ToString();
            int sayi = Rnd.Next(1, 5);
            Telefon(DogruCevap, sayi);
            btn_telefonJoker2.Enabled = false;
            btn_telefonJoker3.Enabled = false;
        }
    }
}
