namespace AppGestFacturationDeau
{
    partial class Profil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profil));
            this.txt_confirmation_mdp = new System.Windows.Forms.TextBox();
            this.txt_mdp = new System.Windows.Forms.TextBox();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Adherents = new System.Windows.Forms.Label();
            this.pic_anuller = new System.Windows.Forms.PictureBox();
            this.pic_confirmer = new System.Windows.Forms.PictureBox();
            this.chk_mdp_profil = new System.Windows.Forms.CheckBox();
            this.tool_valider = new System.Windows.Forms.ToolTip(this.components);
            this.tool_quitter = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_anuller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_confirmer)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_confirmation_mdp
            // 
            this.txt_confirmation_mdp.Location = new System.Drawing.Point(101, 223);
            this.txt_confirmation_mdp.Name = "txt_confirmation_mdp";
            this.txt_confirmation_mdp.Size = new System.Drawing.Size(227, 20);
            this.txt_confirmation_mdp.TabIndex = 19;
            this.txt_confirmation_mdp.UseSystemPasswordChar = true;
            // 
            // txt_mdp
            // 
            this.txt_mdp.Location = new System.Drawing.Point(101, 148);
            this.txt_mdp.Name = "txt_mdp";
            this.txt_mdp.Size = new System.Drawing.Size(227, 20);
            this.txt_mdp.TabIndex = 18;
            this.txt_mdp.UseSystemPasswordChar = true;
            // 
            // txt_login
            // 
            this.txt_login.Enabled = false;
            this.txt_login.Location = new System.Drawing.Point(101, 71);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(227, 20);
            this.txt_login.TabIndex = 17;
            this.txt_login.TextChanged += new System.EventHandler(this.txt_login_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(376, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "تأكيد كلمة المرور";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(390, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "كلمة المرور";
            // 
            // lbl_Adherents
            // 
            this.lbl_Adherents.AutoSize = true;
            this.lbl_Adherents.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Adherents.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Adherents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(51)))));
            this.lbl_Adherents.Location = new System.Drawing.Point(390, 66);
            this.lbl_Adherents.Name = "lbl_Adherents";
            this.lbl_Adherents.Size = new System.Drawing.Size(99, 24);
            this.lbl_Adherents.TabIndex = 14;
            this.lbl_Adherents.Text = "اسم المستخدم";
            // 
            // pic_anuller
            // 
            this.pic_anuller.BackColor = System.Drawing.Color.Transparent;
            this.pic_anuller.BackgroundImage = global::AppGestFacturationDeau.Properties.Resources.Line_office_business_cross_math_button_delete_512;
            this.pic_anuller.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_anuller.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_anuller.Location = new System.Drawing.Point(312, 366);
            this.pic_anuller.Name = "pic_anuller";
            this.pic_anuller.Size = new System.Drawing.Size(81, 80);
            this.pic_anuller.TabIndex = 21;
            this.pic_anuller.TabStop = false;
            this.pic_anuller.Click += new System.EventHandler(this.pic_anuller_Click);
            // 
            // pic_confirmer
            // 
            this.pic_confirmer.BackColor = System.Drawing.Color.Transparent;
            this.pic_confirmer.BackgroundImage = global::AppGestFacturationDeau.Properties.Resources.purepng_com_ok_iconyestickiconokcorrectokayconfirm_4115201939019kiil;
            this.pic_confirmer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_confirmer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_confirmer.Location = new System.Drawing.Point(198, 376);
            this.pic_confirmer.Name = "pic_confirmer";
            this.pic_confirmer.Size = new System.Drawing.Size(56, 63);
            this.pic_confirmer.TabIndex = 20;
            this.pic_confirmer.TabStop = false;
            this.pic_confirmer.Click += new System.EventHandler(this.pic_confirmer_Click);
            // 
            // chk_mdp_profil
            // 
            this.chk_mdp_profil.AutoSize = true;
            this.chk_mdp_profil.BackColor = System.Drawing.Color.Transparent;
            this.chk_mdp_profil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.chk_mdp_profil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(51)))));
            this.chk_mdp_profil.Location = new System.Drawing.Point(240, 292);
            this.chk_mdp_profil.Name = "chk_mdp_profil";
            this.chk_mdp_profil.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chk_mdp_profil.Size = new System.Drawing.Size(152, 28);
            this.chk_mdp_profil.TabIndex = 22;
            this.chk_mdp_profil.Text = "كشف كلمة المرور";
            this.chk_mdp_profil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chk_mdp_profil.UseVisualStyleBackColor = false;
            this.chk_mdp_profil.CheckedChanged += new System.EventHandler(this.chk_mdp_profil_CheckedChanged);
            // 
            // tool_valider
            // 
            this.tool_valider.IsBalloon = true;
            this.tool_valider.ShowAlways = true;
            // 
            // tool_quitter
            // 
            this.tool_quitter.IsBalloon = true;
            this.tool_quitter.ShowAlways = true;
            // 
            // Profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppGestFacturationDeau.Properties.Resources.beach_style_blue_background_1080p_qyvzckhb__F0000;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 491);
            this.Controls.Add(this.chk_mdp_profil);
            this.Controls.Add(this.pic_anuller);
            this.Controls.Add(this.pic_confirmer);
            this.Controls.Add(this.txt_confirmation_mdp);
            this.Controls.Add(this.txt_mdp);
            this.Controls.Add(this.txt_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Adherents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Profil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profil";
            this.Load += new System.EventHandler(this.Profil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_anuller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_confirmer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_anuller;
        private System.Windows.Forms.PictureBox pic_confirmer;
        private System.Windows.Forms.TextBox txt_confirmation_mdp;
        private System.Windows.Forms.TextBox txt_mdp;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Adherents;
        private System.Windows.Forms.CheckBox chk_mdp_profil;
        private System.Windows.Forms.ToolTip tool_valider;
        private System.Windows.Forms.ToolTip tool_quitter;
    }
}