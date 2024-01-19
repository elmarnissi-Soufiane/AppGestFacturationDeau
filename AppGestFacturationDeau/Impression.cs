using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppGestFacturationDeau.FactureDsTableAdapters;

namespace AppGestFacturationDeau
{
    public partial class Impression : Form
    {
        db_facture_eauEntities d = new db_facture_eauEntities();

        Utilisateur Util = null;
        public Utilisateur U { set { this.U = value; } }

        public Impression()
        {
            InitializeComponent();
        }

        public Impression(Utilisateur u)
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

        private void Impression_Load(object sender, EventArgs e)
        {
            try
            {
                tool_valider.SetToolTip(pic_valider_Cry, "تأكيد");
                tool_retour.SetToolTip(pic_retour, "رجوع");
                cb_cry_compteur.Items.Add(new { Text = "", Value = "" });
                cb_cry_compteur.Items.Add(new { Text = "يناير", Value = 1 });
                cb_cry_compteur.Items.Add(new { Text = "فبراير", Value = 2 });
                cb_cry_compteur.Items.Add(new { Text = "مارس", Value = 3 });
                cb_cry_compteur.Items.Add(new { Text = "أبريل", Value = 4 });
                cb_cry_compteur.Items.Add(new { Text = "ماي", Value = 5 });
                cb_cry_compteur.Items.Add(new { Text = "يونيو", Value = 6 });
                cb_cry_compteur.Items.Add(new { Text = "يوليوز", Value = 7 });
                cb_cry_compteur.Items.Add(new { Text = "غشت", Value = 8 });
                cb_cry_compteur.Items.Add(new { Text = "شتنبر", Value = 9 });
                cb_cry_compteur.Items.Add(new { Text = "أكتوبر", Value = 10 });
                cb_cry_compteur.Items.Add(new { Text = "نونبر", Value = 11 });
                cb_cry_compteur.Items.Add(new { Text = "دجنبر", Value = 12 });
                cb_cry_compteur.ValueMember = "Value";
                cb_cry_compteur.DisplayMember = "Text";
            }
            catch
            {
                return;
            }
        }

        private void cb_cry_compteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void pic_valider_Cry_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل أنت متأكد", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (cb_cry_compteur.SelectedIndex <= 0)
                    {
                        MessageBox.Show(" اختر الشهر المناسب");
                        return;
                    }
                    else
                    {
                        CryFacture cr;
                        int mois = Int32.Parse(cb_cry_compteur.SelectedIndex.ToString());
                        int count = d.Factures.Where(h => h.DateFac.Month == mois).Count();
                        if (count > 0)
                        {
                            FactureDs ds = new FactureDs();
                            ds = new FactureDs();
                            Ps_Taxe_CryTableAdapter taxe = new Ps_Taxe_CryTableAdapter();
                            PRIX_TRANCHETableAdapter tr = new PRIX_TRANCHETableAdapter();
                            Ps_Qte_CryTableAdapter qte = new Ps_Qte_CryTableAdapter();

                            qte.Fill(ds.Ps_Qte_Cry, mois);
                            tr.Fill(ds.PRIX_TRANCHE);
                            taxe.Fill(ds.Ps_Taxe_Cry);


                            cr = new CryFacture();
                            cr.SetDataSource(ds);
                            Cry_Factures.ReportSource = cr;
                            Cry_Factures.Refresh();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("الشهر الذي ثم إختياره ليس به أي فاتورة");
                            cr = null;
                            Cry_Factures.ReportSource = cr;
                            Cry_Factures.Refresh();
                            return;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("المرجوا مراجعة معطياتكم");
                return;
            }

        }
    }
}
