namespace AppGestFacturationDeau
{
    partial class Authentification
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authentification));
            this.chk_mdp_authentification = new System.Windows.Forms.CheckBox();
            this.pic_connecter = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_mdp = new System.Windows.Forms.TextBox();
            this.pic_quitter = new System.Windows.Forms.PictureBox();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.pic_user = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tool_dec = new System.Windows.Forms.ToolTip(this.components);
            this.tool_cnx = new System.Windows.Forms.ToolTip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_connecter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_quitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chk_mdp_authentification
            // 
            this.chk_mdp_authentification.AutoSize = true;
            this.chk_mdp_authentification.BackColor = System.Drawing.Color.Transparent;
            this.chk_mdp_authentification.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.chk_mdp_authentification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(51)))));
            this.chk_mdp_authentification.Location = new System.Drawing.Point(204, 405);
            this.chk_mdp_authentification.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chk_mdp_authentification.Name = "chk_mdp_authentification";
            this.chk_mdp_authentification.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chk_mdp_authentification.Size = new System.Drawing.Size(188, 33);
            this.chk_mdp_authentification.TabIndex = 23;
            this.chk_mdp_authentification.Text = "كشف كلمة المرور";
            this.chk_mdp_authentification.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chk_mdp_authentification.UseVisualStyleBackColor = false;
            this.chk_mdp_authentification.CheckedChanged += new System.EventHandler(this.chk_mdp_authentification_CheckedChanged);
            // 
            // pic_connecter
            // 
            this.pic_connecter.BackColor = System.Drawing.Color.Transparent;
            this.pic_connecter.BackgroundImage = global::AppGestFacturationDeau.Properties.Resources.purepng_com_ok_iconyestickiconokcorrectokayconfirm_4115201939019kiil;
            this.pic_connecter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_connecter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_connecter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pic_connecter.Location = new System.Drawing.Point(161, 484);
            this.pic_connecter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pic_connecter.Name = "pic_connecter";
            this.pic_connecter.Size = new System.Drawing.Size(75, 78);
            this.pic_connecter.TabIndex = 6;
            this.pic_connecter.TabStop = false;
            this.pic_connecter.Click += new System.EventHandler(this.pic_connecter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(51)))));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(368, 330);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "كلمة المرور";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(51)))));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(363, 271);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "اسم المستخدم";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_mdp
            // 
            this.txt_mdp.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.txt_mdp.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.txt_mdp.Location = new System.Drawing.Point(88, 336);
            this.txt_mdp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_mdp.Name = "txt_mdp";
            this.txt_mdp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_mdp.Size = new System.Drawing.Size(259, 22);
            this.txt_mdp.TabIndex = 3;
            this.txt_mdp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_mdp.UseSystemPasswordChar = true;
            this.txt_mdp.TextChanged += new System.EventHandler(this.txt_mdp_TextChanged);
            // 
            // pic_quitter
            // 
            this.pic_quitter.BackColor = System.Drawing.Color.Transparent;
            this.pic_quitter.BackgroundImage = global::AppGestFacturationDeau.Properties.Resources.gnome_panel_force_quit;
            this.pic_quitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_quitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_quitter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pic_quitter.Location = new System.Drawing.Point(343, 484);
            this.pic_quitter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pic_quitter.Name = "pic_quitter";
            this.pic_quitter.Size = new System.Drawing.Size(75, 78);
            this.pic_quitter.TabIndex = 2;
            this.pic_quitter.TabStop = false;
            this.pic_quitter.Click += new System.EventHandler(this.pic_quitter_Click);
            // 
            // txt_login
            // 
            this.txt_login.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.txt_login.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.txt_login.Location = new System.Drawing.Point(88, 277);
            this.txt_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(259, 22);
            this.txt_login.TabIndex = 1;
            this.txt_login.TextChanged += new System.EventHandler(this.txt_login_TextChanged);
            // 
            // pic_user
            // 
            this.pic_user.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pic_user.BackColor = System.Drawing.Color.Transparent;
            this.pic_user.BackgroundImage = global::AppGestFacturationDeau.Properties.Resources._28598;
            this.pic_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_user.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pic_user.Location = new System.Drawing.Point(211, 119);
            this.pic_user.Margin = new System.Windows.Forms.Padding(0);
            this.pic_user.Name = "pic_user";
            this.pic_user.Size = new System.Drawing.Size(135, 112);
            this.pic_user.TabIndex = 0;
            this.pic_user.TabStop = false;
            this.pic_user.Click += new System.EventHandler(this.pic_user_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Arabic Typesetting", 36F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(51)))));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(969, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(425, 220);
            this.label3.TabIndex = 8;
            this.label3.Text = "جمعية ايت سنان للتنمية\r\nجماعة تودغى العليا\r\nاقليم تنغير\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tool_dec
            // 
            this.tool_dec.IsBalloon = true;
            this.tool_dec.ShowAlways = true;
            // 
            // tool_cnx
            // 
            this.tool_cnx.IsBalloon = true;
            this.tool_cnx.ShowAlways = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(51)))));
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(537, 661);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 29);
            this.label4.TabIndex = 27;
            this.label4.Text = "للتواصل معنا";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(51)))));
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(67, 661);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(427, 29);
            this.label5.TabIndex = 28;
            this.label5.Text = "soufiane.nisrine.halima@gmail.com";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::AppGestFacturationDeau.Properties.Resources.email_128;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(16, 654);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 39);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // Authentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppGestFacturationDeau.Properties.Resources.high_tech_weezyo_l_ordinateur_design_en_forme_de_goutte_d_eau_istock_com_blackjack3d_215_1527670966;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1413, 708);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chk_mdp_authentification);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pic_connecter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pic_user);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_login);
            this.Controls.Add(this.txt_mdp);
            this.Controls.Add(this.pic_quitter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Authentification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Authentification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_connecter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_quitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pic_connecter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_mdp;
        private System.Windows.Forms.PictureBox pic_quitter;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.PictureBox pic_user;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chk_mdp_authentification;
        private System.Windows.Forms.ToolTip tool_dec;
        private System.Windows.Forms.ToolTip tool_cnx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

