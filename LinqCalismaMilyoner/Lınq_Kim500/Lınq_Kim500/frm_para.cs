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
    public partial class frm_para : Form
    {
        public frm_para()
        {
            InitializeComponent();
        }
        
        public frm_para(string yol)
        {
            InitializeComponent();
            Resimyolu = yol;
        }
        string Resimyolu;
        private void frm_para_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(Resimyolu);
        }

        private void btn_Soru_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
