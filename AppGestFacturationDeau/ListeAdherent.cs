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
    public partial class ListeAdherent : Form
    {
        db_facture_eauEntities d = new db_facture_eauEntities();

        Utilisateur Util = null;
        public Utilisateur U { set { this.U = value; } }

        public ListeAdherent()
        {
            InitializeComponent();
        }

        public ListeAdherent(Utilisateur u)
        {
            InitializeComponent();
            this.Util = u;
        }

        private void pic_retour_Click(object sender, EventArgs e)
        {
            if (Util != null)
            {
                Form f = new Accueil(Util);
                f.Show();
                this.Hide();
            }
        }

        public void ActualiserDGV()
        {
            var list = (from a in d.Adherents
                        join c in d.Compteurs
                        on a.Id equals c.IdAdherent
                        select new { a.Date_Inscription, a.CIN, a.Prenom, a.Nom, c.Id }).ToList();
            dgv_adherents.DataSource = list;

            dgv_adherents.ClearSelection();

            dgv_adherents.Columns[4].HeaderText = "رقم العقدة";
            dgv_adherents.Columns[3].HeaderText = "النسب";
            dgv_adherents.Columns[2].HeaderText = "الاسم";
            dgv_adherents.Columns[1].HeaderText = "ر.ب.ت.و";
            dgv_adherents.Columns[0].HeaderText = "تاريخ الانخراط";

            Vider(this);
        }
        private void ListeAdherent_Load(object sender, EventArgs e)
        {
            tool_vider.SetToolTip(pic_nouveau, "إفراغ");
            tool_ajouter.SetToolTip(pic_ajouter, "إضافة");
            tool_modifier.SetToolTip(pic_modifier, "تعديل");
            tool_supprimer.SetToolTip(pic_supprimer, "مسح");
            tool_rehcercher.SetToolTip(pic_recherche, "بحث");
            tool_actualiser.SetToolTip(pic_actualiser, "تجديد");
            tool_retour.SetToolTip(pic_retour, "رجوع");
            ActualiserDGV();
        }

        private void pic_actualiser_Click(object sender, EventArgs e)
        {
            ActualiserDGV();
        }

        private void pic_ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل أنت متأكد", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (txt_cin.Text.Trim() == "" || txt_nom.Text.Trim() == "" || txt_prenom.Text.Trim() == "" || dtp_inscription.Text.Trim() == "")
                    {
                        MessageBox.Show("المرجو ملأ جميع الخانات");
                        return;
                    }
                    Adherent adherent = new Adherent()
                    {
                        Nom = txt_nom.Text,
                        Prenom = txt_prenom.Text,
                        CIN = txt_cin.Text,
                        Date_Inscription = dtp_inscription.Value
                    };
                    d.Adherents.Add(adherent);
                    int IdAd = adherent.Id;
                    d.Compteurs.Add(new Compteur() { IdAdherent = IdAd });
                    d.SaveChanges();
                    MessageBox.Show("تمة العملية بنجاح");
                    ActualiserDGV();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("لم تثم العملية بنجاح");
                return;
            }
        }

        private void pic_supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل أنت متأكد", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (!txt_compteur.Text.Trim().Equals(""))
                    {
                        int idCpt = Int32.Parse(txt_compteur.Text);
                        var cpt = d.Compteurs.Where(c => c.Id == idCpt).FirstOrDefault();
                        int IdAdherent = cpt.IdAdherent;
                        var adherent = d.Adherents.Where(a => a.Id == IdAdherent).FirstOrDefault();

                        d.Compteurs.Remove(cpt);
                        d.Adherents.Remove(adherent);
                        d.SaveChanges();
                        MessageBox.Show("تمة العملية بنجاح");
                        ActualiserDGV();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("لم تثم العملية بنجاح");
                        return;
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void pic_modifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل أنت متأكد", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (txt_cin.Text.Trim() == "" || txt_nom.Text.Trim() == "" || txt_prenom.Text.Trim() == "" || dtp_inscription.Text.Trim() == "")
                    {
                        MessageBox.Show("المرجو ملأ جميع الخانات");
                        return;
                    }
                    if (dgv_adherents.CurrentRow != null)
                    {
                        int idCpt = Int32.Parse(txt_compteur.Text);
                        Compteur Cpt = d.Compteurs.Where(c => c.Id == idCpt).FirstOrDefault();
                        int IdAdherent = Cpt.IdAdherent;
                        Adherent ad = d.Adherents.Where(a => a.Id == IdAdherent).FirstOrDefault();
                        ad.Nom = txt_nom.Text;
                        ad.Prenom = txt_prenom.Text;
                        ad.Date_Inscription = dtp_inscription.Value;
                        ad.CIN = txt_cin.Text;

                        d.SaveChanges();
                        MessageBox.Show("تمة العملية بنجاح");
                        ActualiserDGV();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("لم تثم العملية بنجاح");
                        return;
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void dgv_adherents_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgv_adherents.CurrentRow.Cells != null)
                {
                    txt_compteur.Text = dgv_adherents.CurrentRow.Cells[4].Value.ToString();
                    txt_cin.Text = dgv_adherents.CurrentRow.Cells[1].Value.ToString();
                    txt_prenom.Text = dgv_adherents.CurrentRow.Cells[2].Value.ToString();
                    txt_nom.Text = dgv_adherents.CurrentRow.Cells[3].Value.ToString();

                    if (dgv_adherents.CurrentRow.Cells[0].Value == null)
                    {
                        dtp_inscription.Value = DateTime.Now;
                    }
                    else
                    {
                        dtp_inscription.Text = dgv_adherents.CurrentRow.Cells[0].Value.ToString();
                    }
                }
            }
            catch
            {
                return;
            }
        }

        public void Vider(Control c)
        {
            foreach (Control f in c.Controls)
            {
                if (f is TextBox)
                {
                    ((TextBox)f).Text = "";
                }
                if (f.Controls.Count != 0)
                {
                    Vider(f);
                }
            }
        }

        private void pic_nouveau_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد تجديد المعطيات؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Vider(this);
                ActualiserDGV();
            }
        }

        private void pic_recherche_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_recherche.Text.Trim().Equals(""))
                {
                    MessageBox.Show("غير موجود");
                    ActualiserDGV();
                    return;
                }
                else
                {
                    var rech = txt_recherche.Text;
                    dgv_adherents.DataSource = d.Compteurs.Where(c => c.Adherent.CIN.Contains(rech) || c.Adherent.Nom.Contains(rech) || c.Adherent.Prenom.Contains(rech)).Select(s => new { s.Adherent.Date_Inscription, s.Adherent.CIN, s.Adherent.Prenom, s.Adherent.Nom, s.Id }).ToList();
                    txt_nom.Text = "";
                    txt_prenom.Text = "";
                    txt_cin.Text = "";
                    txt_compteur.Text = "";
                }
            }
            catch
            {
                return;
            }
        }

        private void dgv_adherents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_recherche_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_prenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_cin_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtp_inscription_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_compteur_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
