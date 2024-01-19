namespace AppGestFacturationDeau
{
    partial class Impression
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Impression));
            this.pic_retour = new System.Windows.Forms.PictureBox();
            this.Cry_Factures = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cb_cry_compteur = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pic_valider_Cry = new System.Windows.Forms.PictureBox();
            this.tool_retour = new System.Windows.Forms.ToolTip(this.components);
            this.tool_valider = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_retour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_valider_Cry)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_retour
            // 
            this.pic_retour.BackColor = System.Drawing.Color.Transparent;
            this.pic_retour.BackgroundImage = global::AppGestFacturationDeau.Properties.Resources.return_back_blue_round_2_512;
            this.pic_retour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_retour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_retour.Location = new System.Drawing.Point(12, 12);
            this.pic_retour.Name = "pic_retour";
            this.pic_retour.Size = new System.Drawing.Size(100, 61);
            this.pic_retour.TabIndex = 21;
            this.pic_retour.TabStop = false;
            this.pic_retour.Click += new System.EventHandler(this.pic_retour_Click);
            // 
            // Cry_Factures
            // 
            this.Cry_Factures.ActiveViewIndex = -1;
            this.Cry_Factures.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Cry_Factures.Cursor = System.Windows.Forms.Cursors.Default;
            this.Cry_Factures.Location = new System.Drawing.Point(12, 79);
            this.Cry_Factures.Name = "Cry_Factures";
            this.Cry_Factures.Size = new System.Drawing.Size(1036, 484);
            this.Cry_Factures.TabIndex = 22;
            this.Cry_Factures.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // cb_cry_compteur
            // 
            this.cb_cry_compteur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_cry_compteur.FormattingEnabled = true;
            this.cb_cry_compteur.Location = new System.Drawing.Point(413, 36);
            this.cb_cry_compteur.Name = "cb_cry_compteur";
            this.cb_cry_compteur.Size = new System.Drawing.Size(260, 21);
            this.cb_cry_compteur.TabIndex = 23;
            this.cb_cry_compteur.SelectedIndexChanged += new System.EventHandler(this.cb_cry_compteur_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(51)))));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(725, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "الشهر";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pic_valider_Cry
            // 
            this.pic_valider_Cry.BackColor = System.Drawing.Color.Transparent;
            this.pic_valider_Cry.BackgroundImage = global::AppGestFacturationDeau.Properties.Resources.purepng_com_ok_iconyestickiconokcorrectokayconfirm_4115201939019kiil;
            this.pic_valider_Cry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_valider_Cry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_valider_Cry.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pic_valider_Cry.Location = new System.Drawing.Point(342, 24);
            this.pic_valider_Cry.Name = "pic_valider_Cry";
            this.pic_valider_Cry.Size = new System.Drawing.Size(43, 38);
            this.pic_valider_Cry.TabIndex = 43;
            this.pic_valider_Cry.TabStop = false;
            this.pic_valider_Cry.Click += new System.EventHandler(this.pic_valider_Cry_Click);
            // 
            // tool_retour
            // 
            this.tool_retour.IsBalloon = true;
            this.tool_retour.ShowAlways = true;
            // 
            // tool_valider
            // 
            this.tool_valider.IsBalloon = true;
            this.tool_valider.ShowAlways = true;
            // 
            // Impression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppGestFacturationDeau.Properties.Resources.beach_style_blue_background_1080p_qyvzckhb__F0000;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1060, 575);
            this.Controls.Add(this.pic_valider_Cry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_cry_compteur);
            this.Controls.Add(this.Cry_Factures);
            this.Controls.Add(this.pic_retour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Impression";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impression";
            this.Load += new System.EventHandler(this.Impression_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_retour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_valider_Cry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_retour;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer Cry_Factures;
        private System.Windows.Forms.ComboBox cb_cry_compteur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic_valider_Cry;
        private System.Windows.Forms.ToolTip tool_retour;
        private System.Windows.Forms.ToolTip tool_valider;
    }
}