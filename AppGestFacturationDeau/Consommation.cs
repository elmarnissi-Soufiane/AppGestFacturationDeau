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
    public partial class Consommation : Form
    {
        db_facture_eauEntities d = new db_facture_eauEntities();

        Utilisateur Util = null;
        public Utilisateur U { set { this.U = value; } }

        public Consommation()
        {
            InitializeComponent();
        }

        public Consommation(Utilisateur u)
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

        private void Consommation_Load(object sender, EventArgs e)
        {
            try
            {
                tool_valider.SetToolTip(pic_valider, "تأكيد");
                tool_retour.SetToolTip(pic_retour, "رجوع");
                dtp_fin.Enabled = false;
                cb_compteur.DataSource = d.Compteurs.ToList();
                cb_compteur.DisplayMember = "Id";
                cb_compteur.ValueMember = "Id";

                cb_compteur.Text = "";

                rtxt_ancienne.SelectionAlignment = HorizontalAlignment.Center;
                rtxt_nouvelle.SelectionAlignment = HorizontalAlignment.Center;
                rtxt_quantite.SelectionAlignment = HorizontalAlignment.Center;
                rtxt_prix_paye.SelectionAlignment = HorizontalAlignment.Center;

                cb_compteur.Focus();
            }
            catch
            {
                return;
            }
        }

        private void cb_compteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txt_nouvelle_consomation.Text = "";
                if (cb_compteur.Text.Trim() == "")
                {
                    txt_cin_ad_consom.Text = "";
                    txt_nom_ad_consom.Text = "";
                    txt_nouvelle_consomation.Text = "";
                    rtxt_ancienne.Text = "";
                }
                int test = -1;
                bool tr = Int32.TryParse(cb_compteur.SelectedValue.ToString(), out test);
                if (tr)
                {
                    if (Int32.Parse(cb_compteur.SelectedValue.ToString()) >= 1)
                    {
                        int idCpt = Int32.Parse(cb_compteur.Text);
                        var cpt = d.Compteurs.Where(n => n.Id == idCpt).FirstOrDefault();
                        var adh = d.Adherents.Where(nis => nis.Id == cpt.IdAdherent).FirstOrDefault();
                        txt_nom_ad_consom.Text = adh.Nom + " " + adh.Prenom;
                        txt_cin_ad_consom.Text = adh.CIN;
                        DateTime date = DateTime.Now;
                        var con = d.Consomations.Where(n => n.IdCompteur == idCpt && n.Date_fin < date).OrderByDescending(o => o.Date_fin).Select(o => o.Nouvelle).FirstOrDefault();
                        
                        rtxt_ancienne.Text = con.ToString();

                        txt_nouvelle_consomation.Focus();
                        return;
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void cb_compteur_Leave(object sender, EventArgs e)
        {
        }
        
        private void txt_nouvelle_consomation_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int res = -1;
                bool txt_conso = Int32.TryParse(txt_nouvelle_consomation.Text, out res);

                bool cb_txt = Int32.TryParse(cb_compteur.Text, out res);

                if (txt_nouvelle_consomation.Text.Trim().Equals(""))
                {
                    rtxt_nouvelle.Text = "";
                    rtxt_prix_paye.Text = "";
                    rtxt_quantite.Text = "";
                }
                else if (cb_txt && txt_conso)
                {
                    rtxt_nouvelle.Text = txt_nouvelle_consomation.Text;
                    int consommation = Int32.Parse(rtxt_nouvelle.Text) - Int32.Parse(rtxt_ancienne.Text);
                    rtxt_quantite.Text = consommation.ToString();


                    int qte = Int32.Parse(rtxt_quantite.Text);


                    var tr_1 = d.Tranches.Where(t => t.Id == 1).FirstOrDefault();
                    decimal p_tr_1 = decimal.Parse(tr_1.Prix.ToString());

                    var tr_2 = d.Tranches.Where(t => t.Id == 2).FirstOrDefault();
                    decimal p_tr_2 = decimal.Parse(tr_2.Prix.ToString());

                    var tr_3 = d.Tranches.Where(t => t.Id == 3).FirstOrDefault();
                    decimal p_tr_3 = decimal.Parse(tr_3.Prix.ToString());


                    var taxe = d.Taxes.Where(n => n.IdT == 1).FirstOrDefault().Prix;



                    if (qte > 25)
                    {
                        qte = qte - 25;
                        taxe += (15 * p_tr_1) + (10 * p_tr_2) + (qte * p_tr_3);
                    }
                    else
                    {
                        if (qte > 15)
                        {
                            qte = qte - 15;
                            taxe += 15 * p_tr_1 + (qte * p_tr_2);
                        }
                        else
                        {
                            taxe += qte * p_tr_1;
                        }
                    }
                    rtxt_prix_paye.Text = taxe.ToString(".00");

                }
                else
                {
                    MessageBox.Show("المرجو إدخال المعلومات صحيحة");
                    return;
                }
            }
            catch
            {
                return;
            }
        }

        private void cb_compteur_SelectedValueChanged(object sender, EventArgs e)
        {            
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

        private void pic_valider_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل تريد تأكيد العملية", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int res = -1;
                    bool txt_consom = Int32.TryParse(txt_nouvelle_consomation.Text.ToString(), out res);

                    bool cb_txt = Int32.TryParse(cb_compteur.Text, out res);

                    int combo = Int32.Parse(cb_compteur.Text.ToString());

                    var date1 = dtp_debut.Value;
                    var date2 = dtp_fin.Value;

                    

                    if (cb_compteur.Text.Trim() == "" || txt_nouvelle_consomation.Text.Trim() == "")
                    {
                        MessageBox.Show("اختر رقم العقذة وادخل العداد الحالي");
                        return;
                    }
                    else
                    {
                        if (cb_txt && txt_consom)
                        {
                            var count = d.Consomations.Where(c => c.IdCompteur == combo && (c.Date_fin.Month == date2.Month && c.Date_fin.Year == date2.Year)).Count();
                            if (count == 0)
                            {
                                Consomation cons = new Consomation();
                                cons.IdCompteur = Int32.Parse(cb_compteur.Text.ToString());
                                if (date1 < date2)
                                {
                                    cons.Date_debut = date1;
                                    cons.Date_fin = date2;
                                }
                                else
                                {
                                    MessageBox.Show("التاريخ الدي تم ادخاله غير صحيح");
                                    return;
                                }
                                cons.Ancienne = Int32.Parse(rtxt_ancienne.Text.ToString());
                                cons.Nouvelle = Int32.Parse(rtxt_nouvelle.Text.ToString());

                                var date = d.Factures.Where(f => f.IdC == combo).OrderByDescending(f => f.DateFac).Select(f => f.DateFac).FirstOrDefault();

                                Facture fac = new Facture();
                                fac.IdC = Int32.Parse(cb_compteur.Text);
                                fac.Prix = decimal.Parse(rtxt_prix_paye.Text);
                                fac.Paye = "لا";
                                fac.DateFac = DateTime.Now;
                                fac.DateFin = fac.DateFac.AddDays(14);
                                TimeSpan datediff = fac.DateFac.Date - date.Date;

                                if ((fac.DateFac.Date.CompareTo(date.Date) == -1) || (fac.DateFac.Date.CompareTo(date.Date) == 0) && datediff.Days < 28)
                                {
                                    MessageBox.Show("لقد تم تسجيل هذه الفاتورة سابقا");
                                    return;
                                }
                                else if (dtp_debut.Value.CompareTo(DateTime.Now) > 0)
                                {
                                    MessageBox.Show("المرجوا التأكد من التاريخ");
                                    return;
                                }
                                else
                                {
                                    d.Consomations.Add(cons);
                                    d.Factures.Add(fac);
                                    d.SaveChanges();
                                    MessageBox.Show("تمة العملية بنجاح");
                                    Vider(this);
                                    return;
                                }
                            }
                            else
                            {
                                MessageBox.Show("لم تتم العملية بنجاح");
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("!! المرجو إدخال المعلومات صحيحة");
                            return;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("المرجوا مراجعة المعطيات");
                return;
            }
        }

        private void cb_compteur_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txt_nouvelle_consomation.Text = "";
                if (cb_compteur.Text.Trim() == "")
                {
                    txt_cin_ad_consom.Text = "";
                    txt_nom_ad_consom.Text = "";
                    txt_nouvelle_consomation.Text = "";
                    rtxt_ancienne.Text = "";
                }
                int test = -1;
                bool tr = Int32.TryParse(cb_compteur.Text.ToString(), out test);
                if (tr)
                {
                    if (Int32.Parse(cb_compteur.Text.ToString()) >= 1)
                    {
                        int idCpt = Int32.Parse(cb_compteur.Text);
                        var cpt = d.Compteurs.Where(n => n.Id == idCpt).FirstOrDefault();
                        var adh = d.Adherents.Where(nis => nis.Id == cpt.IdAdherent).FirstOrDefault();
                        txt_nom_ad_consom.Text = adh.Nom + " " + adh.Prenom;
                        txt_cin_ad_consom.Text = adh.CIN;
                        DateTime date = DateTime.Now;
                        var con = d.Consomations.Where(n => n.IdCompteur == idCpt && n.Date_debut < date).OrderByDescending(o => o.Date_fin).FirstOrDefault();
                        rtxt_ancienne.Text = con.Nouvelle.ToString();


                        return;
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void dtp_debut_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            bool dt_parse = DateTime.TryParse(dtp_debut.Value.ToString(), out date);
            if (dt_parse)
            {
                dtp_fin.Value = dtp_debut.Value.AddMonths(1).AddDays(-1);
            }
        }

        private void rtxt_ancienne_TextChanged(object sender, EventArgs e)
        {

        }

        private void chk_mdf_conso_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_mdf_conso.Checked)
            {
                (new ModiferConsomation(Util)).Show();
                this.Hide();
            }
        }

        private void pic_valider_conso_mod_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
