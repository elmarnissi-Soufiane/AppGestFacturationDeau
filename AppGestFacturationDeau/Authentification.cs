using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection;
using System.IO;

namespace AppGestFacturationDeau
{
    public partial class Authentification : Form
    {
        public string path = @"Data Source=.;Initial Catalog = master; Integrated Security = True; MultipleActiveResultSets=True;Application Name = EntityFramework";
        public SqlConnection cnx;
        public SqlCommand cmd;
        public SqlDataReader dr;
        public string script = null;

        public void DeleteDatabase(string name)
        {
            try
            {
                cnx = new SqlConnection(path);
                StringBuilder bc = new StringBuilder();
                bc.Append(String.Format("drop database {0}", name));
                cmd = new SqlCommand(bc.ToString(), cnx);
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
            }
            catch
            {
                MessageBox.Show("هناك مشكلة ؟؟؟؟");
            }
        }

        public void ExecuteDatabase()
        {
            try
            {
                var location = new Uri(Assembly.GetEntryAssembly().GetName().CodeBase);
                var chemin = new FileInfo(Application.ExecutablePath).Directory.FullName + "\\script.sql";
                script = File.ReadAllText(chemin);

                string[] table = script.Split(new string[] { "GO" }, StringSplitOptions.None);

                using (cnx = new SqlConnection(path))
                {
                    cnx.Open();
                    foreach (string str in table)
                    {
                        using (cmd = cnx.CreateCommand())
                        {
                            cmd.CommandText = str;
                            cmd.ExecuteNonQuery();
                        }
                    }
                    
                }
            }
            catch
            {
                MessageBox.Show("هناك عطب في تشغيل التطبيق");
            }
        }
        
        db_facture_eauEntities d = new db_facture_eauEntities();

        public Authentification()
        {
            InitializeComponent();
        }

        private void pic_connecter_Click(object sender, EventArgs e)
        {
            Utilisateur util = d.Utilisateurs.Where(u => u.LoginUtil.Equals(txt_login.Text) && u.Mot_de_passe.Equals(txt_mdp.Text)).FirstOrDefault();
                 
            if (util != null)
            {

                Form f = new Accueil(util);
                f.Show();
                this.Hide();
            }
            else
            {
                txt_mdp.Text = "";
                txt_login.Focus();
                MessageBox.Show("كلمة المرور او اسم المستخدم غير صحيحة");
                return;
            }
        }

        private void pic_quitter_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد المغادرة؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void chk_mdp_authentification_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_mdp_authentification.Checked)
            {
                txt_mdp.UseSystemPasswordChar = false;
                chk_mdp_authentification.Text = "اخفاء كلمة المرور";
            }
            else
            {
                txt_mdp.UseSystemPasswordChar = true;
                chk_mdp_authentification.Text = "كشف كلمة المرور";
            }
        }

        private void Authentification_Load(object sender, EventArgs e)
        {
            try
            {
                tool_cnx.SetToolTip(pic_connecter, "دخول");
                tool_dec.SetToolTip(pic_quitter ,"خروج");          
                if (!d.Database.Exists())
                {
                    ExecuteDatabase();
                }
            }
            catch
            {
                MessageBox.Show("هناك عطب");
                return;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pic_user_Click(object sender, EventArgs e)
        {

        }

        private void txt_mdp_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
