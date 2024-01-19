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
    public partial class ImprimerRecu : Form
    {
        public ImprimerRecu()
        {
            InitializeComponent();
        }

        public object Adher_row { get; set; }
        db_facture_eauEntities d = new db_facture_eauEntities();
        private void ImprimerRecu_Load(object sender, EventArgs e)
        {
            try
            {
                int Id = Int32.Parse(((DataGridViewRow)Adher_row).Cells[7].Value.ToString());

                var Date = DateTime.Parse(((DataGridViewRow)Adher_row).Cells[2].Value.ToString());
                int Mois = Int32.Parse(Date.Month.ToString());
                var fact = d.Consomations.FirstOrDefault();
                //MessageBox.Show("Test"+fact.Perenete);

                FactureDs ds = new FactureDs();

                PS_Paye_CryTableAdapter pt = new PS_Paye_CryTableAdapter();
                pt.Fill(ds.PS_Paye_Cry, Mois, Id);

                CryRecu cr = new CryRecu();
                cr.SetDataSource(ds);
                Cry_Recu.ReportSource = cr;
                Cry_Recu.Refresh();
            }
            catch
            {
                //throw;
                MessageBox.Show("هناك عطب");
                return;
            }
        }
    }
}
