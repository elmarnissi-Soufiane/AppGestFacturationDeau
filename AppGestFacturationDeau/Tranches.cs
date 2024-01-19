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
    public partial class Tranches : Form
    {
        db_facture_eauEntities d = new db_facture_eauEntities();

        Utilisateur Util = null;
        public Utilisateur U { set { this.U = value; } }

        public Tranches()
        {
            InitializeComponent();
        }

        public Tranches(Utilisateur u)
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

        private void Tranches_Load(object sender, EventArgs e)
        {
            try
            {
                tool_retour.SetToolTip(pic_retour, "رجوع");
                tool_valider_taxe.SetToolTip(pic_confirmer, "تأكيد الضريبة");
                tool_valider_tr.SetToolTip(pic_tranche, "تأكيد الشطر");
                tool_cancel.SetToolTip(pic_anuller, "إلغاء");
                cb_tranches.DataSource = d.Tranches.ToList();
                cb_tranches.DisplayMember = "Libelle";
                cb_tranches.ValueMember = "Id";
                cb_tranches.Text = "";
                
                txt_taxe.Text = d.Taxes.FirstOrDefault().Prix.ToString(".00");
            }
            catch
            {
                return;
            }
        }

        private void cb_tranches_SelectedIndexChanged(object sender, EventArgs e)
        {
           try
            {
                int tr = -1;

                bool trp = Int32.TryParse(cb_tranches.SelectedValue.ToString(), out tr);
                if (trp)
                {
                    if (Int32.Parse(cb_tranches.SelectedValue.ToString()) >= 1)
                    {
                        int id = Int32.Parse(cb_tranches.SelectedValue.ToString());
                        var res = d.Tranches.Where(t => t.Id == id).FirstOrDefault();
                        txt_prix_tranche.Text = res.Prix.Value.ToString(".00");
                        return;
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void pic_anuller_Click(object sender, EventArgs e)
        {
            txt_prix_tranche.Text = "";
            cb_tranches.Text = "";
            txt_taxe.Text = "";
        }

        private void pic_confirmer_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل أنت متأكد", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    decimal test_2 = -1;

                    bool res_2 = decimal.TryParse(txt_taxe.Text.Replace(".", ","), out test_2);

                    if (res_2)
                    {
                        var taxe = d.Taxes.Where(x => x.IdT == 1).FirstOrDefault();
                        taxe.Prix = decimal.Parse(txt_taxe.Text.Replace(".", ","));
                        d.SaveChanges();
                        MessageBox.Show("لقد تم تجديد الضريبة بنجاح");
                        return;
                    }
                    else
                    {
                        txt_taxe.Text = "";
                    }
                }
            }
            catch
            {
                return;
            } 
        }

        private void cb_tranches_DropDownStyleChanged(object sender, EventArgs e)
        {

        }

        private void cb_tranches_TextChanged(object sender, EventArgs e)
        {
        }

        private void pic_tranche_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل أنت متأكد", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    decimal test = -1;
                    bool res = decimal.TryParse(txt_prix_tranche.Text.Replace(".", ","), out test);
                    if (cb_tranches.Text.Trim() == "")
                    {
                        MessageBox.Show("اختر الشطر المناسب من اجل التجديد");
                    }
                    else
                    {
                        if (res)
                        {
                            int id = Int32.Parse(cb_tranches.SelectedValue.ToString());
                            var tranche = d.Tranches.Where(nis => nis.Id == id).FirstOrDefault();
                            tranche.Prix = decimal.Parse(txt_prix_tranche.Text.Replace(".", ","));
                            d.SaveChanges();
                            MessageBox.Show("لقد تم تجديد الشطر بنجاح");
                            return;
                        }
                        else
                        {
                            txt_prix_tranche.Text = "";

                        }
                    }
                }
            }
            catch
            {
                return;
            }
        }
    }
}
