using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGestFacturationDeau
{
    public partial class Accueil : Form
    {
        Utilisateur Util = null; 
        public Utilisateur U { set { this.U = value; } }
        public Accueil()
        {
            InitializeComponent();
        }

        public Accueil(Utilisateur U)
        {
            InitializeComponent();
            this.Util = U;
        }

        private void pic_modifier_profil_Click(object sender, EventArgs e)
        {
            if (Util != null)
            {
                Form f = new Profil(Util);
                f.Show();
                this.Hide();
            }
            
        }

        private void pic_deconnecter_Click(object sender, EventArgs e)
        {
            Form f = new Authentification();
            f.Show();
            this.Hide();
        }

        private void pic_adherents_Click(object sender, EventArgs e)
        {
            Form f = new ListeAdherent(Util);
            f.Show();
            this.Hide();
        }

        private void pic_tranches_Click(object sender, EventArgs e)
        {
            Form f = new Tranches(Util);
            f.Show();
            this.Hide();
        }

        private void pic_consomation_Click(object sender, EventArgs e)
        {
            Form f = new Consommation(Util);
            f.Show();
            this.Hide();
        }

        private void pic_impression_Click(object sender, EventArgs e)
        {
            Form f = new Impression(Util);
            f.Show();
            this.Hide();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {
            tool_cancel.SetToolTip(pic_deconnecter, "رجوع");
        }

        private void pic_paiment_Click(object sender, EventArgs e)
        {
            Form f = new PayeNonPaye(Util);
            f.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
