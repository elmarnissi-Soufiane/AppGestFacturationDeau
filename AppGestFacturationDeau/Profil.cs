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
    public partial class Profil : Form
    {
        db_facture_eauEntities d = new db_facture_eauEntities();

        Utilisateur util = null;
        public Utilisateur U { set { this.U = value; } }

        public Profil()
        {
            InitializeComponent();
        }

        public Profil(Utilisateur U)
        {
            InitializeComponent();
            this.util = U;
        }

        private void pic_anuller_Click(object sender, EventArgs e)
        {
            if (util != null)
            {
                Form f = new Accueil(util);
                f.Show();
                this.Hide();

            }
        }

        private void Profil_Load(object sender, EventArgs e)
        {
            tool_valider.SetToolTip(pic_confirmer, "تأكيد");
            tool_quitter.SetToolTip(pic_anuller, "إلغاء");
            txt_login.Text = util.LoginUtil;
        }

        private void pic_confirmer_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل أنت متأكد", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string log = txt_login.Text;
                    if (txt_mdp.Text.Trim().Equals(txt_confirmation_mdp.Text) && txt_mdp.Text.Trim() != "")
                    {
                        Utilisateur utl = d.Utilisateurs.Where(u => u.LoginUtil.Equals(log)).FirstOrDefault();
                        utl.Mot_de_passe = txt_mdp.Text;
                        d.SaveChanges();
                        MessageBox.Show("تم تغيير كلمة المرور بنجاح");

                        Form f = new Accueil(util);
                        f.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("المرجو ملأ المعلومات بدقة");
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void chk_mdp_profil_CheckedChanged(object sender, EventArgs e)
        {
           try
            {
                if (chk_mdp_profil.Checked)
                {
                    txt_mdp.UseSystemPasswordChar = false;
                    txt_confirmation_mdp.UseSystemPasswordChar = false;
                    chk_mdp_profil.Text = "اخفاء كلمة المرور";
                }
                else
                {
                    txt_mdp.UseSystemPasswordChar = true;
                    txt_confirmation_mdp.UseSystemPasswordChar = true;
                    chk_mdp_profil.Text = "كشف كلمة المرور";
                }
            }
            catch
            {
                return;
            }
        }

        private void txt_login_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
