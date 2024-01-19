namespace AppGestFacturationDeau
{
    partial class PayeNonPaye
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayeNonPaye));
            this.dgv_facture = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_penette = new System.Windows.Forms.PictureBox();
            this.chk_penete = new System.Windows.Forms.CheckBox();
            this.txt_penete = new System.Windows.Forms.TextBox();
            this.pic_paye_imprimer = new System.Windows.Forms.PictureBox();
            this.pic_valider_paye = new System.Windows.Forms.PictureBox();
            this.cb_paye_nonpaye = new System.Windows.Forms.ComboBox();
            this.pic_recherche_fact = new System.Windows.Forms.PictureBox();
            this.txt_recherche_fact = new System.Windows.Forms.TextBox();
            this.pic_retour_fact = new System.Windows.Forms.PictureBox();
            this.rd_non_paye = new System.Windows.Forms.RadioButton();
            this.rd_paye = new System.Windows.Forms.RadioButton();
            this.tool_retour = new System.Windows.Forms.ToolTip(this.components);
            this.tool_valider = new System.Windows.Forms.ToolTip(this.components);
            this.tool_imprimer = new System.Windows.Forms.ToolTip(this.components);
            this.tool_rechercher = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_facture)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_penette)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_paye_imprimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_valider_paye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_recherche_fact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_retour_fact)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_facture
            // 
            this.dgv_facture.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgv_facture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_facture.Location = new System.Drawing.Point(16, 6);
            this.dgv_facture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_facture.Name = "dgv_facture";
            this.dgv_facture.Size = new System.Drawing.Size(1381, 571);
            this.dgv_facture.TabIndex = 0;
            this.dgv_facture.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_facture_CellContentClick);
            this.dgv_facture.SelectionChanged += new System.EventHandler(this.dgv_facture_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.pic_penette);
            this.panel1.Controls.Add(this.chk_penete);
            this.panel1.Controls.Add(this.txt_penete);
            this.panel1.Controls.Add(this.pic_paye_imprimer);
            this.panel1.Controls.Add(this.pic_valider_paye);
            this.panel1.Controls.Add(this.cb_paye_nonpaye);
            this.panel1.Controls.Add(this.pic_recherche_fact);
            this.panel1.Controls.Add(this.txt_recherche_fact);
            this.panel1.Controls.Add(this.pic_retour_fact);
            this.panel1.Controls.Add(this.rd_non_paye);
            this.panel1.Controls.Add(this.rd_paye);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 585);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1413, 123);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pic_penette
            // 
            this.pic_penette.BackgroundImage = global::AppGestFacturationDeau.Properties.Resources.purepng_com_ok_iconyestickiconokcorrectokayconfirm_4115201939019kiil;
            this.pic_penette.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_penette.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_penette.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pic_penette.Location = new System.Drawing.Point(139, 42);
            this.pic_penette.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pic_penette.Name = "pic_penette";
            this.pic_penette.Size = new System.Drawing.Size(52, 47);
            this.pic_penette.TabIndex = 49;
            this.pic_penette.TabStop = false;
            this.pic_penette.Click += new System.EventHandler(this.pic_penette_Click);
            // 
            // chk_penete
            // 
            this.chk_penete.AutoSize = true;
            this.chk_penete.Location = new System.Drawing.Point(256, 36);
            this.chk_penete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chk_penete.Name = "chk_penete";
            this.chk_penete.Size = new System.Drawing.Size(61, 21);
            this.chk_penete.TabIndex = 48;
            this.chk_penete.Text = "الغرامة";
            this.chk_penete.UseVisualStyleBackColor = true;
            this.chk_penete.CheckedChanged += new System.EventHandler(this.chk_penete_CheckedChanged);
            // 
            // txt_penete
            // 
            this.txt_penete.Location = new System.Drawing.Point(220, 64);
            this.txt_penete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_penete.Name = "txt_penete";
            this.txt_penete.Size = new System.Drawing.Size(132, 22);
            this.txt_penete.TabIndex = 47;
            this.txt_penete.TextChanged += new System.EventHandler(this.txt_penete_TextChanged);
            // 
            // pic_paye_imprimer
            // 
            this.pic_paye_imprimer.BackColor = System.Drawing.Color.Transparent;
            this.pic_paye_imprimer.BackgroundImage = global::AppGestFacturationDeau.Properties.Resources.imprimante;
            this.pic_paye_imprimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_paye_imprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_paye_imprimer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pic_paye_imprimer.Location = new System.Drawing.Point(824, 42);
            this.pic_paye_imprimer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pic_paye_imprimer.Name = "pic_paye_imprimer";
            this.pic_paye_imprimer.Size = new System.Drawing.Size(57, 47);
            this.pic_paye_imprimer.TabIndex = 43;
            this.pic_paye_imprimer.TabStop = false;
            this.pic_paye_imprimer.Click += new System.EventHandler(this.pic_paye_imprimer_Click);
            // 
            // pic_valider_paye
            // 
            this.pic_valider_paye.BackgroundImage = global::AppGestFacturationDeau.Properties.Resources.purepng_com_ok_iconyestickiconokcorrectokayconfirm_4115201939019kiil;
            this.pic_valider_paye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_valider_paye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_valider_paye.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pic_valider_paye.Location = new System.Drawing.Point(377, 42);
            this.pic_valider_paye.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pic_valider_paye.Name = "pic_valider_paye";
            this.pic_valider_paye.Size = new System.Drawing.Size(57, 47);
            this.pic_valider_paye.TabIndex = 42;
            this.pic_valider_paye.TabStop = false;
            this.pic_valider_paye.Click += new System.EventHandler(this.pic_valider_paye_Click);
            // 
            // cb_paye_nonpaye
            // 
            this.cb_paye_nonpaye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_paye_nonpaye.FormattingEnabled = true;
            this.cb_paye_nonpaye.Location = new System.Drawing.Point(485, 54);
            this.cb_paye_nonpaye.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_paye_nonpaye.Name = "cb_paye_nonpaye";
            this.cb_paye_nonpaye.Size = new System.Drawing.Size(160, 24);
            this.cb_paye_nonpaye.TabIndex = 41;
            this.cb_paye_nonpaye.SelectedIndexChanged += new System.EventHandler(this.cb_paye_nonpaye_SelectedIndexChanged);
            // 
            // pic_recherche_fact
            // 
            this.pic_recherche_fact.BackColor = System.Drawing.Color.Transparent;
            this.pic_recherche_fact.BackgroundImage = global::AppGestFacturationDeau.Properties.Resources._1388;
            this.pic_recherche_fact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_recherche_fact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_recherche_fact.Location = new System.Drawing.Point(1293, 30);
            this.pic_recherche_fact.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pic_recherche_fact.Name = "pic_recherche_fact";
            this.pic_recherche_fact.Size = new System.Drawing.Size(96, 59);
            this.pic_recherche_fact.TabIndex = 40;
            this.pic_recherche_fact.TabStop = false;
            this.pic_recherche_fact.Click += new System.EventHandler(this.pic_recherche_fact_Click);
            // 
            // txt_recherche_fact
            // 
            this.txt_recherche_fact.Location = new System.Drawing.Point(1041, 50);
            this.txt_recherche_fact.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_recherche_fact.Name = "txt_recherche_fact";
            this.txt_recherche_fact.Size = new System.Drawing.Size(195, 22);
            this.txt_recherche_fact.TabIndex = 39;
            this.txt_recherche_fact.TextChanged += new System.EventHandler(this.txt_recherche_fact_TextChanged);
            this.txt_recherche_fact.Enter += new System.EventHandler(this.txt_recherche_fact_Enter);
            // 
            // pic_retour_fact
            // 
            this.pic_retour_fact.BackColor = System.Drawing.Color.Transparent;
            this.pic_retour_fact.BackgroundImage = global::AppGestFacturationDeau.Properties.Resources.return_back_blue_round_2_512;
            this.pic_retour_fact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_retour_fact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_retour_fact.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pic_retour_fact.Location = new System.Drawing.Point(19, 16);
            this.pic_retour_fact.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pic_retour_fact.Name = "pic_retour_fact";
            this.pic_retour_fact.Size = new System.Drawing.Size(112, 92);
            this.pic_retour_fact.TabIndex = 38;
            this.pic_retour_fact.TabStop = false;
            this.pic_retour_fact.Click += new System.EventHandler(this.pic_retour_fact_Click);
            this.pic_retour_fact.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.pic_retour_fact_PreviewKeyDown);
            // 
            // rd_non_paye
            // 
            this.rd_non_paye.AutoSize = true;
            this.rd_non_paye.BackColor = System.Drawing.Color.Transparent;
            this.rd_non_paye.Location = new System.Drawing.Point(673, 54);
            this.rd_non_paye.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rd_non_paye.Name = "rd_non_paye";
            this.rd_non_paye.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rd_non_paye.Size = new System.Drawing.Size(81, 21);
            this.rd_non_paye.TabIndex = 37;
            this.rd_non_paye.TabStop = true;
            this.rd_non_paye.Text = "لم يتم الأداء";
            this.rd_non_paye.UseVisualStyleBackColor = false;
            this.rd_non_paye.CheckedChanged += new System.EventHandler(this.rd_non_paye_CheckedChanged);
            // 
            // rd_paye
            // 
            this.rd_paye.AutoSize = true;
            this.rd_paye.BackColor = System.Drawing.Color.Transparent;
            this.rd_paye.Location = new System.Drawing.Point(912, 54);
            this.rd_paye.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rd_paye.Name = "rd_paye";
            this.rd_paye.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rd_paye.Size = new System.Drawing.Size(66, 21);
            this.rd_paye.TabIndex = 36;
            this.rd_paye.TabStop = true;
            this.rd_paye.Text = "تم الأداء";
            this.rd_paye.UseVisualStyleBackColor = false;
            this.rd_paye.CheckedChanged += new System.EventHandler(this.rd_paye_CheckedChanged);
            // 
            // tool_retour
            // 
            this.tool_retour.IsBalloon = true;
            this.tool_retour.ShowAlways = true;
            this.tool_retour.Popup += new System.Windows.Forms.PopupEventHandler(this.tool_retour_Popup);
            // 
            // tool_valider
            // 
            this.tool_valider.IsBalloon = true;
            this.tool_valider.ShowAlways = true;
            this.tool_valider.Popup += new System.Windows.Forms.PopupEventHandler(this.tool_valider_Popup);
            // 
            // tool_imprimer
            // 
            this.tool_imprimer.IsBalloon = true;
            this.tool_imprimer.ShowAlways = true;
            this.tool_imprimer.Popup += new System.Windows.Forms.PopupEventHandler(this.tool_imprimer_Popup);
            // 
            // tool_rechercher
            // 
            this.tool_rechercher.IsBalloon = true;
            this.tool_rechercher.ShowAlways = true;
            this.tool_rechercher.Popup += new System.Windows.Forms.PopupEventHandler(this.tool_rechercher_Popup);
            // 
            // PayeNonPaye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppGestFacturationDeau.Properties.Resources.beach_style_blue_background_1080p_qyvzckhb__F0000;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1413, 708);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_facture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PayeNonPaye";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PayeNonPaye";
            this.Load += new System.EventHandler(this.PayeNonPaye_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_facture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_penette)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_paye_imprimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_valider_paye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_recherche_fact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_retour_fact)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_facture;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic_recherche_fact;
        private System.Windows.Forms.TextBox txt_recherche_fact;
        private System.Windows.Forms.PictureBox pic_retour_fact;
        private System.Windows.Forms.RadioButton rd_non_paye;
        private System.Windows.Forms.RadioButton rd_paye;
        private System.Windows.Forms.ComboBox cb_paye_nonpaye;
        private System.Windows.Forms.PictureBox pic_valider_paye;
        private System.Windows.Forms.PictureBox pic_paye_imprimer;
        private System.Windows.Forms.ToolTip tool_retour;
        private System.Windows.Forms.ToolTip tool_valider;
        private System.Windows.Forms.ToolTip tool_imprimer;
        private System.Windows.Forms.ToolTip tool_rechercher;
        private System.Windows.Forms.PictureBox pic_penette;
        private System.Windows.Forms.CheckBox chk_penete;
        private System.Windows.Forms.TextBox txt_penete;
    }
}