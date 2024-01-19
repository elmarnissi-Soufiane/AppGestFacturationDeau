using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGestFacturationDeau
{
    public partial class ModiferConsomation : Form
    {
        db_facture_eauEntities d = new db_facture_eauEntities();

        Utilisateur Util = null;
        public Utilisateur U { set { this.U = value; } }

        public ModiferConsomation()
        {
            InitializeComponent();
        }
        public ModiferConsomation(Utilisateur u)
        {
            InitializeComponent();
            this.Util = u;
        }


        private void pic_retour_Click(object sender, EventArgs e)
        {
            if (Util != null)
            {
                Form f = new Consommation(Util);
                f.Show();
                this.Hide();
            }
        }

        private void ModiferConsomation_Load(object sender, EventArgs e)
        {
            try
            {
                tool_modifier.SetToolTip(pic_mod_consom, "تعديل");
                tool_retour.SetToolTip(pic_retour, "رجوع");
                pic_exporter.Visible = false;
                dgv_mod_conso.DataSource = d.Consomations.Select(s => new { رقم_العقدة = s.IdCompteur, الإسم = s.Compteur.Adherent.Nom, النسب = s.Compteur.Adherent.Prenom ,بداية = s.Date_debut, النهاية = s.Date_fin, العداد_القديم = s.Ancienne, العداد_الحالي = s.Nouvelle }).ToList();
                txt_mod_anci_cons.Text = "";
                txt_mod_cpt.Text = "";
                txt_mod_mois.Text = "";
                txt_mod_nouvelle_cons.Text = "";
            }
            catch
            {
                return;
            }
        }

        private void dgv_mod_conso_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgv_mod_conso.CurrentRow.Cells != null)
                {
                    txt_mod_nouvelle_cons.Text = dgv_mod_conso.CurrentRow.Cells[6].Value.ToString();
                    txt_mod_anci_cons.Text = dgv_mod_conso.CurrentRow.Cells[5].Value.ToString();
                    txt_mod_mois.Text = DateTime.Parse(dgv_mod_conso.CurrentRow.Cells[3].Value.ToString()).Month.ToString();
                    txt_mod_cpt.Text = dgv_mod_conso.CurrentRow.Cells[0].Value.ToString();
                }
            }
            catch
            {
                return;
            }
        }

        private void pic_mod_consom_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل أنت متأكد", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (txt_mod_nouvelle_cons.Text == "" || txt_mod_anci_cons.Text == "")
                    {
                        MessageBox.Show("المرجوا ملأ الخانات");
                        return;
                    }
                    else
                    {
                        int res = -1;
                        bool txt_nv = Int32.TryParse(txt_mod_nouvelle_cons.Text, out res);
                        bool txt_anc = Int32.TryParse(txt_mod_anci_cons.Text, out res);
                        if (txt_nv && txt_anc)
                        {
                            int id = Int32.Parse(txt_mod_cpt.Text);
                            DateTime date = DateTime.Parse(dgv_mod_conso.CurrentRow.Cells[3].Value.ToString());
                            int nv = Int32.Parse(txt_mod_nouvelle_cons.Text);
                            int anc = Int32.Parse(txt_mod_anci_cons.Text);

                            var con = d.Consomations.Where(w => w.IdCompteur == id && w.Date_debut == date).FirstOrDefault();
                            var fac = d.Factures.Where(n => n.IdC == id && n.DateFac.Month == date.Month).FirstOrDefault();

                            if (nv >= anc)
                            {
                                con.Nouvelle = nv;
                                con.Ancienne = anc;

                                int qte = con.Nouvelle - con.Ancienne;

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
                                    taxe += (15 * p_tr_1) + (10 * p_tr_2) + (p_tr_3 * qte);
                                }
                                else
                                {
                                    if (qte > 15)
                                    {
                                        qte = qte - 15;
                                        taxe += (15 * p_tr_1) + (qte * p_tr_2);
                                    }
                                    else
                                    {
                                        taxe += qte * p_tr_1;
                                    }
                                }

                                fac.Prix = taxe;
                                d.SaveChanges();
                                MessageBox.Show("تمة العملية بنجاح");

                                dgv_mod_conso.DataSource = d.Consomations.Select(s => new { رقم_العقدة = s.IdCompteur, الإسم = s.Compteur.Adherent.Nom, النسب = s.Compteur.Adherent.Prenom, بداية = s.Date_debut, النهاية = s.Date_fin, العداد_القديم = s.Ancienne, العداد_الحالي = s.Nouvelle }).ToList();
                                //dgv_mod_conso.DataSource = d.Consomations.Select(s => new { رقم_العقدة = s.IdCompteur, بداية = s.Date_debut, النهاية = s.Date_fin, العداد_القديم = s.Ancienne, العداد_الحالي = s.Nouvelle }).ToList();
                                dgv_mod_conso.ClearSelection();
                                txt_mod_anci_cons.Text = "";
                                txt_mod_nouvelle_cons.Text = "";
                                txt_mod_mois.Text = "";
                                txt_mod_cpt.Text = "";
                                return;
                            }
                            else
                            {
                                MessageBox.Show("العداد القديم أكبر من العدادالحالي"); return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("المرجوا مراجعة معطياتكم"); return;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("خطأ غير متوقع");
                return;
            }
        }

        private void pic_exporter_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل أنت متأكد من هده العملية", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int res = -1;
                    var txt_mois = Int32.TryParse(txt_mod_mois.Text, out res);
                    if (txt_mod_mois.Text == "")
                    {
                        MessageBox.Show("المرجوا إدخال الشهر");
                        return;
                    }
                    else
                    {
                        if (txt_mois && (Int32.Parse(txt_mod_mois.Text) >= 1 && Int32.Parse(txt_mod_mois.Text) <= 12))
                        {
                            var textbox = Int32.Parse(txt_mod_mois.Text);
                            var count = (from c in d.Consomations
                                         join cm in d.Compteurs
                                         on c.IdCompteur equals cm.Id
                                         join f in d.Factures
                                         on cm.Id equals f.IdC
                                         where c.Date_debut.Month == textbox && f.DateFac.Month == textbox
                                         select new { الكمية = (c.Nouvelle - c.Ancienne), الثمن = f.Prix, العداد_الحالي = c.Nouvelle, العداد_القديم = c.Ancienne, بداية = c.Date_debut, إسم_المنخرط = c.Compteur.Adherent.Prenom, نسب_المنخرط = c.Compteur.Adherent.Nom, رقم_البطاقة_الوطنية = c.Compteur.Adherent.CIN, رقم_العقدة = c.IdCompteur }
                                             ).ToList();
                            string chemin = "";
                            saveFileDialog1.Filter = "CSV|*.csv";
                            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                            {
                                chemin = saveFileDialog1.FileName;
                            }

                            StreamWriter st = new StreamWriter(chemin, true, System.Text.Encoding.UTF8);
                            st.WriteLine(";");
                            st.WriteLine(";" + ";" + ";" + "جمعية أيت سنان للتنمية");
                            st.WriteLine(";" + ";" + ";" + "   الشهر" + txt_mod_mois.Text.ToString());
                            st.WriteLine(";");
                            st.WriteLine(";");
                            st.WriteLine(" الثمن ; الكمية ; العداد الحالي ; العداد القديم ; إسم المنخرط ; رقم البطاقة الوطنية ; رقم العقدة ");

                            decimal total_prix = 0;
                            decimal total_qte = 0;



                            foreach (var E in count)
                            {
                                st.WriteLine(E.الثمن + "; " + E.الكمية + "; " + E.العداد_الحالي + "; " + E.العداد_القديم + "; " + E.نسب_المنخرط + " " + E.إسم_المنخرط + "; " + E.رقم_البطاقة_الوطنية + "; " + E.رقم_العقدة);
                                total_prix += decimal.Parse(E.الثمن.ToString());
                                total_qte += E.الكمية;
                            }

                            st.WriteLine(total_prix + "; " + total_qte + "; " + "المجموع " + " " + "" + "; " + "" + "; " + "" + ";" + "" + "; " + "");
                            st.Close();
                            chk_mdf_conso.Checked = false;
                            MessageBox.Show("تمت العملية بنجاح");

                            return;
                        }
                        else
                        {
                            MessageBox.Show("أدخل الشهر المناسب");
                            return;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("لم تتم العملية بنجاح");
                return;
            }
        }

        private void chk_mdf_conso_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk_mdf_conso.Checked)
                {
                    pic_exporter.Visible = true;
                    txt_mod_mois.Enabled = true;
                    pic_mod_consom.Visible = false;
                    txt_mod_mois.Focus();
                }
                else
                {
                    pic_exporter.Visible = false;
                    txt_mod_mois.Enabled = false;
                    pic_mod_consom.Visible = true;
                    txt_mod_mois.Text = "";
                }
            }
            catch
            {
                return;
            }
        }
    }
}
