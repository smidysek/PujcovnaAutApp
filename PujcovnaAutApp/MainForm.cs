using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PujcovnaAutApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            DatabaseHelper.AktualizovatDostupnostPodleDnesnihoData();
        }

        private void btnAuta_Click(object sender, EventArgs e)
        {
            var form = new FormAuta();
            form.ShowDialog();
        }

        private void btnZakaznici_Click(object sender, EventArgs e)
        {
            var form = new FormZakaznici();
            form.ShowDialog();
        }

        private void btnPujcky_Click(object sender, EventArgs e)
        {
            var form = new FormPujcky();
            form.ShowDialog();
        }

        private void btnStatistika_Click(object sender, EventArgs e)
        {
            var form = new FormStatistika();
            form.ShowDialog();
        }

        private void btnNovaPujcka_Click(object sender, EventArgs e)
        {
            var form = new FormNovaPujcka();
            form.ShowDialog();
        }

        private void btnKonec_Click(object sender, EventArgs e)
        {
            Close();
        }

        //MENU
        private void autaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormAuta();
            form.ShowDialog();
        }

        private void zákaznícíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormZakaznici();
            form.ShowDialog();
        }

        private void novéZapůjčeníToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormNovaPujcka();
            form.ShowDialog();
        }

        private void záznamyPůjčeníToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormPujcky();
            form.ShowDialog();
        }

        private void četnostPůjčováníToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormStatistika();
            form.ShowDialog();
        }

        private void jednotlivéVozidlaPodleObdobíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormPujckyVCase();
            form.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var form = new FormAuta();
            form.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var form = new FormZakaznici();
            form.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var form = new FormNovaPujcka();
            form.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var form = new FormPujcky();
            form.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            var form = new FormStatistika();
            form.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
