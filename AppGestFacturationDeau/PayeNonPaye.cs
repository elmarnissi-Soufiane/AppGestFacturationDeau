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
    public partial class PayeNonPaye : Form
    {
        db_facture_eauEntities d = new db_facture_eauEntities();

        Utilisateur Util = null;
        public Utilisateur U { set { this.U = value; } }

        public PayeNonPaye()
        {
            InitializeComponent();
        }

        public PayeNonPaye(Utilisateur u)
        {
            InitializeComponent();
            this.Util = u;
        }

        private void pic_retour_fact_Click(object sender, EventArgs e)
        {
            if (Util != null)
            {
                Form f = new Accueil(Util);
                f.Show();
                this.Hide();
            }
        }

        private void PayeNonPaye_Load(object sender, EventArgs e)
        {
            try
            {
                tool_rechercher.SetToolTip(pic_recherche_fact, "بحث");
                tool_valider.SetToolTip(pic_valider_paye, "تأكيد");
                tool_imprimer.SetToolTip(pic_paye_imprimer, "طباعة");
                tool_retour.SetToolTip(pic_retour_fact, "رجوع");
                cb_paye_nonpaye.Visible = false;
                pic_valider_paye.Visible = false;
                pic_paye_imprimer.Visible = false;

                cb_paye_nonpaye.Items.Add(new { Text = "", Value = "" });
                cb_paye_nonpaye.Items.Add(new { Text = "لا", Value = "لا" });
                cb_paye_nonpaye.Items.Add(new { Text = "نعم", Value = "نعم" });
                cb_paye_nonpaye.ValueMember = "Value";
                cb_paye_nonpaye.DisplayMember = "Text";
                chk_penete.Visible = false;
                txt_penete.Visible = false;
                pic_penette.Visible = false;
            }
            catch
            {
                return;
            }
        }

        private void pic_retour_fact_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void rd_paye_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                chk_penete.Visible = false;
                chk_penete.Checked = false;
                txt_penete.Visible = false;
                pic_penette.Visible = false;
                txt_penete.Text = "";

                pic_paye_imprimer.Visible = true;
                pic_paye_imprimer.Enabled = false;
                var list_pay = (from f in d.Factures
                                join c in d.Compteurs
                                on f.IdC equals c.Id
                                join a in d.Adherents
                                on c.IdAdherent equals a.Id
                                where f.Paye.Equals("نعم")
                                select new { f.Paye, f.DateFin, f.DateFac, f.Prix, a.Prenom, a.Nom, a.CIN, c.Id }
                                ).ToList();

                dgv_facture.DataSource = list_pay;

                dgv_facture.Columns[7].HeaderText = "رقم العقدة";
                dgv_facture.Columns[6].HeaderText = "ر.ب.ت.و";
                dgv_facture.Columns[5].HeaderText = "النسب";
                dgv_facture.Columns[4].HeaderText = "الاسم";
                dgv_facture.Columns[3].HeaderText = "الواجب أداؤه";
                dgv_facture.Columns[2].HeaderText = "تاريخ الفاتورة";
                dgv_facture.Columns[1].HeaderText = "اخر اجل للأداء";
                dgv_facture.Columns[0].HeaderText = "مؤدى / غير مؤدى";

                
                cb_paye_nonpaye.Visible = false;
                pic_valider_paye.Visible = false;
                txt_recherche_fact.Text = "";
                dgv_facture.ClearSelection();
            }
            catch
            {
                return;
            }
        }

        private void rd_non_paye_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                chk_penete.Visible = true;

                var list_pay = (from f in d.Factures
                                join c in d.Compteurs
                                on f.IdC equals c.Id
                                join a in d.Adherents
                                on c.IdAdherent equals a.Id
                                where f.Paye.Equals("لا")
                                select new { f.Paye, f.DateFin, f.DateFac, f.Prix, a.Prenom, a.Nom, a.CIN, c.Id }
                            ).ToList();

                dgv_facture.DataSource = list_pay;
                dgv_facture.Columns[7].HeaderText = "رقم العقدة";
                dgv_facture.Columns[6].HeaderText = "ر.ب.ت.و";
                dgv_facture.Columns[5].HeaderText = "النسب";
                dgv_facture.Columns[4].HeaderText = "الاسم";
                dgv_facture.Columns[3].HeaderText = "الواجب أداؤه";
                dgv_facture.Columns[2].HeaderText = "تاريخ الفاتورة";
                dgv_facture.Columns[1].HeaderText = "اخر اجل للأداء";
                dgv_facture.Columns[0].HeaderText = "مؤدى / غير مؤدى";

                pic_paye_imprimer.Visible = false;
                txt_recherche_fact.Text = "";
            }
            catch
            {
                return;
            }
        }

        private void pic_recherche_fact_Click(object sender, EventArgs e)
        {
            try
            {
                var rech = txt_recherche_fact.Text;
                int n = -1;
                bool res = Int32.TryParse(rech, out n);

                if (!res)
                {
                    dgv_facture.DataSource = (from f in d.Factures
                                              join c in d.Compteurs
                                              on f.IdC equals c.Id
                                              join a in d.Adherents
                                              on c.IdAdherent equals a.Id
                                              where a.Nom.Contains(rech) || a.Prenom.Contains(rech) || a.CIN.Contains(rech)
                                              select new { f.Paye, f.DateFin, f.DateFac, f.Prix, a.Prenom, a.Nom, a.CIN, c.Id }
                               ).ToList();
                }
                else
                {
                    int IdCpt = Int32.Parse(rech);
                    dgv_facture.DataSource = (from f in d.Factures
                                              join c in d.Compteurs
                                              on f.IdC equals c.Id
                                              join a in d.Adherents
                                              on c.IdAdherent equals a.Id
                                              where c.Id == IdCpt
                                              select new { f.Paye, f.DateFin, f.DateFac, f.Prix, a.Prenom, a.Nom, a.CIN, c.Id }
                               ).ToList();
                }
                dgv_facture.Columns[7].HeaderText = "رقم العقدة";
                dgv_facture.Columns[6].HeaderText = "ر.ب.ت.و";
                dgv_facture.Columns[5].HeaderText = "النسب";
                dgv_facture.Columns[4].HeaderText = "الاسم";
                dgv_facture.Columns[3].HeaderText = "الواجب أداؤه";
                dgv_facture.Columns[2].HeaderText = "تاريخ الفاتورة";
                dgv_facture.Columns[1].HeaderText = "اخر اجل للأداء";
                dgv_facture.Columns[0].HeaderText = "مؤدى / غير مؤدى";
            }
            catch
            {
                return;
            }
        }

        private void txt_recherche_fact_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_recherche_fact_Enter(object sender, EventArgs e)
        {
            rd_non_paye.Checked = false;
            rd_paye.Checked = false;
            cb_paye_nonpaye.Visible = false;
            pic_valider_paye.Visible = false;
            pic_paye_imprimer.Visible = false;
            chk_penete.Visible = false;
            chk_penete.Checked = false;
            txt_penete.Visible = false;
            pic_penette.Visible = false;
            txt_penete.Text = "";
        }

        private void dgv_facture_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_facture_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgv_facture.CurrentRow.Cells != null)
                {
                    if (dgv_facture.CurrentRow.Cells[0].Value.ToString().Equals("لا"))
                    {
                        cb_paye_nonpaye.Visible = true;
                        pic_valider_paye.Visible = true;
                        cb_paye_nonpaye.Text = dgv_facture.CurrentRow.Cells[0].Value.ToString();
                    }
                    if (dgv_facture.SelectedCells.Count != 0)
                    {
                        pic_paye_imprimer.Enabled = true;
                    }
                    else
                    {
                        pic_paye_imprimer.Enabled = false;
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void pic_valider_paye_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل انت متأكد من هذه العملية", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Int32.Parse(dgv_facture.CurrentRow.Cells[7].Value.ToString());



                    var adh = d.Compteurs.Where(d => d.Id == id).Select(s => s.Adherent).FirstOrDefault();

                    var count_fact = d.Factures.Where(w => w.IdC == id && w.Paye.Equals("لا")).Count();
                    if (count_fact > 0)
                    {
                        var fact = d.Factures.Where(w => w.IdC == id && w.Paye.Equals("لا")).OrderBy(w => w.DateFac).FirstOrDefault();
                        fact.Paye = cb_paye_nonpaye.Text;

                        if (fact.Paye.Trim().Equals("نعم"))
                        {
                            d.SaveChanges();
                            MessageBox.Show(fact.DateFac.Month + "تمة تسديد فاتورة شهر ");

                            var list_pay = (from f in d.Factures
                                            join c in d.Compteurs
                                            on f.IdC equals c.Id
                                            join a in d.Adherents
                                            on c.IdAdherent equals a.Id
                                            where f.Paye.Equals("لا")
                                            select new { f.Paye, f.DateFin, f.DateFac, f.Prix, a.Prenom, a.Nom, a.CIN, c.Id }
                                        ).ToList();

                            dgv_facture.DataSource = list_pay;
                            dgv_facture.Columns[7].HeaderText = "رقم العقدة";
                            dgv_facture.Columns[6].HeaderText = "ر.ب.ت.و";
                            dgv_facture.Columns[5].HeaderText = "النسب";
                            dgv_facture.Columns[4].HeaderText = "الاسم";
                            dgv_facture.Columns[3].HeaderText = "الواجب أداؤه";
                            dgv_facture.Columns[2].HeaderText = "تاريخ الفاتورة";
                            dgv_facture.Columns[1].HeaderText = "اخر اجل للأداء";
                            dgv_facture.Columns[0].HeaderText = "مؤدى / غير مؤدى";

                            return;
                        }
                        else
                        {
                            MessageBox.Show("لم يتم تسديد فاتورة");
                            return;
                        }
                    }
                    else
                    {
                        var fact = d.Factures.Where(w => w.IdC == id && w.Paye.Equals("لا")).FirstOrDefault();
                        fact.Paye = cb_paye_nonpaye.Text;

                        if (fact.Paye.Trim().Equals("نعم"))
                        {
                            d.SaveChanges();
                            MessageBox.Show(fact.DateFac.Month + " تمة تسديد فاتورة شهر");

                            var list_pay = (from f in d.Factures
                                            join c in d.Compteurs
                                            on f.IdC equals c.Id
                                            join a in d.Adherents
                                            on c.IdAdherent equals a.Id
                                            where f.Paye.Equals("لا")
                                            select new { f.Paye, f.DateFin, f.DateFac, f.Prix, a.Prenom, a.Nom, a.CIN, c.Id }
                                        ).ToList();

                            dgv_facture.DataSource = list_pay;
                            dgv_facture.Columns[7].HeaderText = "رقم العقدة";
                            dgv_facture.Columns[6].HeaderText = "ر.ب.ت.و";
                            dgv_facture.Columns[5].HeaderText = "النسب";
                            dgv_facture.Columns[4].HeaderText = "الاسم";
                            dgv_facture.Columns[3].HeaderText = "الواجب أداؤه";
                            dgv_facture.Columns[2].HeaderText = "تاريخ الفاتورة";
                            dgv_facture.Columns[1].HeaderText = "اخر اجل للأداء";
                            dgv_facture.Columns[0].HeaderText = "مؤدى / غير مؤدى";

                            return;
                        }
                        else
                        {
                            MessageBox.Show("لم يتم تسديد فاتورة");
                            return;
                        }
                    }
                    if (dgv_facture.CurrentRow == null)
                    {
                        cb_paye_nonpaye.Visible = false;
                        pic_valider_paye.Visible = false;
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void cb_paye_nonpaye_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pic_paye_imprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل انت متأكد من هذه العملية", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    object obj = dgv_facture.CurrentRow;

                    ImprimerRecu imp_re = new ImprimerRecu();
                    imp_re.Adher_row = obj;
                    imp_re.Show();
                }
            }
            catch
            {
                return;
            }
        }

        private void chk_penalite_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void chk_penete_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_non_paye.Checked)
            {
                if (chk_penete.Checked)
                {
                    txt_penete.Visible = true;
                    pic_penette.Visible = true;
                    pic_paye_imprimer.Visible = false;
                    pic_valider_paye.Visible = false;
                    cb_paye_nonpaye.Visible = true;
                }
                else
                {
                    pic_penette.Visible = false;
                    txt_penete.Visible = false;
                    pic_valider_paye.Visible = true;
                    txt_penete.Text = "";
                }
            }
        }

        private void pic_penette_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل انت متأكد من هذه العملية", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    decimal res = -1;
                    bool penete = decimal.TryParse(txt_penete.Text, out res);
                    int id = Int32.Parse(dgv_facture.CurrentRow.Cells[7].Value.ToString());
                    var date = DateTime.Parse(dgv_facture.CurrentRow.Cells[2].Value.ToString());

                    var cons = d.Consomations.Where(c => c.IdCompteur == id && c.Date_debut.Month == date.Month && c.Date_debut.Year == date.Year).FirstOrDefault();
                    var fact = d.Factures.Where(m => m.IdC == id && m.Paye.Equals("لا")).FirstOrDefault();

                    if (penete)
                    {
                        cons.Perenete = decimal.Parse(txt_penete.Text);
                        fact.Prix += cons.Perenete;
                        d.SaveChanges();
                        MessageBox.Show("تمت العملية بنجاح");

                        var list_pay = (from f in d.Factures
                                        join c in d.Compteurs
                                        on f.IdC equals c.Id
                                        join a in d.Adherents
                                        on c.IdAdherent equals a.Id
                                        where f.Paye.Equals("لا")
                                        select new { f.Paye, f.DateFin, f.DateFac, f.Prix, a.Prenom, a.Nom, a.CIN, c.Id }
                                        ).ToList();

                        dgv_facture.DataSource = list_pay;
                        dgv_facture.Columns[7].HeaderText = "رقم العقدة";
                        dgv_facture.Columns[6].HeaderText = "ر.ب.ت.و";
                        dgv_facture.Columns[5].HeaderText = "النسب";
                        dgv_facture.Columns[4].HeaderText = "الاسم";
                        dgv_facture.Columns[3].HeaderText = "الواجب أداؤه";
                        dgv_facture.Columns[2].HeaderText = "تاريخ الفاتورة";
                        dgv_facture.Columns[1].HeaderText = "اخر اجل للأداء";
                        dgv_facture.Columns[0].HeaderText = "مؤدى / غير مؤدى";

                        txt_penete.Text = "";
                        return;
                    }
                    else
                    {
                        MessageBox.Show("أدخل المعلومات صحيحة");
                        return;
                    }
                }
            }
            catch
            {
                MessageBox.Show("هناك عطب");
                return;
            }
        }

        private void txt_penete_TextChanged(object sender, EventArgs e)
        {

        }

        private void tool_retour_Popup(object sender, PopupEventArgs e)
        {

        }

        private void tool_valider_Popup(object sender, PopupEventArgs e)
        {

        }

        private void tool_imprimer_Popup(object sender, PopupEventArgs e)
        {

        }

        private void tool_rechercher_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
