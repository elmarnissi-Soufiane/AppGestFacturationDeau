namespace AppGestFacturationDeau
{
    partial class ModiferConsomation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModiferConsomation));
            this.pic_retour = new System.Windows.Forms.PictureBox();
            this.dgv_mod_conso = new System.Windows.Forms.DataGridView();
            this.txt_mod_mois = new System.Windows.Forms.TextBox();
            this.txt_mod_cpt = new System.Windows.Forms.TextBox();
            this.txt_mod_anci_cons = new System.Windows.Forms.TextBox();
            this.txt_mod_nouvelle_cons = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pic_mod_consom = new System.Windows.Forms.PictureBox();
            this.tool_retour = new System.Windows.Forms.ToolTip(this.components);
            this.tool_modifier = new System.Windows.Forms.ToolTip(this.components);
            this.pic_exporter = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.chk_mdf_conso = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_retour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mod_conso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mod_consom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_exporter)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_retour
            // 
            this.pic_retour.BackColor = System.Drawing.Color.Transparent;
            this.pic_retour.BackgroundImage = global::AppGestFacturationDeau.Properties.Resources.return_back_blue_round_2_512;
            this.pic_retour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_retour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_retour.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pic_retour.Location = new System.Drawing.Point(954, 25);
            this.pic_retour.Name = "pic_retour";
            this.pic_retour.Size = new System.Drawing.Size(62, 61);
            this.pic_retour.TabIndex = 30;
            this.pic_retour.TabStop = false;
            this.pic_retour.Click += new System.EventHandler(this.pic_retour_Click);
            // 
            // dgv_mod_conso
            // 
            this.dgv_mod_conso.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_mod_conso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mod_conso.Location = new System.Drawing.Point(6, 12);
            this.dgv_mod_conso.MultiSelect = false;
            this.dgv_mod_conso.Name = "dgv_mod_conso";
            this.dgv_mod_conso.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_mod_conso.Size = new System.Drawing.Size(788, 551);
            this.dgv_mod_conso.TabIndex = 31;
            this.dgv_mod_conso.SelectionChanged += new System.EventHandler(this.dgv_mod_conso_SelectionChanged);
            // 
            // txt_mod_mois
            // 
            this.txt_mod_mois.Enabled = false;
            this.txt_mod_mois.Location = new System.Drawing.Point(812, 180);
            this.txt_mod_mois.Name = "txt_mod_mois";
            this.txt_mod_mois.Size = new System.Drawing.Size(131, 20);
            this.txt_mod_mois.TabIndex = 32;
            // 
            // txt_mod_cpt
            // 
            this.txt_mod_cpt.Enabled = false;
            this.txt_mod_cpt.Location = new System.Drawing.Point(812, 247);
            this.txt_mod_cpt.Name = "txt_mod_cpt";
            this.txt_mod_cpt.Size = new System.Drawing.Size(131, 20);
            this.txt_mod_cpt.TabIndex = 33;
            // 
            // txt_mod_anci_cons
            // 
            this.txt_mod_anci_cons.Location = new System.Drawing.Point(815, 318);
            this.txt_mod_anci_cons.Name = "txt_mod_anci_cons";
            this.txt_mod_anci_cons.Size = new System.Drawing.Size(128, 20);
            this.txt_mod_anci_cons.TabIndex = 34;
            // 
            // txt_mod_nouvelle_cons
            // 
            this.txt_mod_nouvelle_cons.Location = new System.Drawing.Point(815, 395);
            this.txt_mod_nouvelle_cons.Name = "txt_mod_nouvelle_cons";
            this.txt_mod_nouvelle_cons.Size = new System.Drawing.Size(128, 20);
            this.txt_mod_nouvelle_cons.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(51)))));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(994, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 24);
            this.label3.TabIndex = 36;
            this.label3.Text = "الشهر";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(51)))));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(966, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 37;
            this.label1.Text = "رقم العقدة";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(51)))));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(947, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 38;
            this.label2.Text = "العداد الحالي";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(51)))));
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(950, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 35);
            this.label7.TabIndex = 40;
            this.label7.Text = "العداد القديم";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_mod_consom
            // 
            this.pic_mod_consom.BackColor = System.Drawing.Color.Transparent;
            this.pic_mod_consom.BackgroundImage = global::AppGestFacturationDeau.Properties.Resources._698873_icon_136_document_edit_128;
            this.pic_mod_consom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_mod_consom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_mod_consom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pic_mod_consom.Location = new System.Drawing.Point(980, 502);
            this.pic_mod_consom.Name = "pic_mod_consom";
            this.pic_mod_consom.Size = new System.Drawing.Size(62, 61);
            this.pic_mod_consom.TabIndex = 41;
            this.pic_mod_consom.TabStop = false;
            this.pic_mod_consom.Click += new System.EventHandler(this.pic_mod_consom_Click);
            // 
            // tool_retour
            // 
            this.tool_retour.IsBalloon = true;
            this.tool_retour.ShowAlways = true;
            // 
            // tool_modifier
            // 
            this.tool_modifier.IsBalloon = true;
            this.tool_modifier.ShowAlways = true;
            // 
            // pic_exporter
            // 
            this.pic_exporter.BackColor = System.Drawing.Color.Transparent;
            this.pic_exporter.BackgroundImage = global::AppGestFacturationDeau.Properties.Resources.excel_1_129882;
            this.pic_exporter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_exporter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_exporter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pic_exporter.Location = new System.Drawing.Point(824, 502);
            this.pic_exporter.Name = "pic_exporter";
            this.pic_exporter.Size = new System.Drawing.Size(62, 61);
            this.pic_exporter.TabIndex = 42;
            this.pic_exporter.TabStop = false;
            this.pic_exporter.Click += new System.EventHandler(this.pic_exporter_Click);
            // 
            // chk_mdf_conso
            // 
            this.chk_mdf_conso.AutoSize = true;
            this.chk_mdf_conso.BackColor = System.Drawing.Color.Transparent;
            this.chk_mdf_conso.Location = new System.Drawing.Point(827, 470);
            this.chk_mdf_conso.Name = "chk_mdf_conso";
            this.chk_mdf_conso.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chk_mdf_conso.Size = new System.Drawing.Size(53, 17);
            this.chk_mdf_conso.TabIndex = 43;
            this.chk_mdf_conso.Text = "تحميل";
            this.chk_mdf_conso.UseVisualStyleBackColor = false;
            this.chk_mdf_conso.CheckedChanged += new System.EventHandler(this.chk_mdf_conso_CheckedChanged);
            // 
            // ModiferConsomation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppGestFacturationDeau.Properties.Resources.beach_style_blue_background_1080p_qyvzckhb__F0000;
            this.ClientSize = new System.Drawing.Size(1060, 575);
            this.Controls.Add(this.chk_mdf_conso);
            this.Controls.Add(this.pic_exporter);
            this.Controls.Add(this.pic_mod_consom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_mod_nouvelle_cons);
            this.Controls.Add(this.txt_mod_anci_cons);
            this.Controls.Add(this.txt_mod_cpt);
            this.Controls.Add(this.txt_mod_mois);
            this.Controls.Add(this.dgv_mod_conso);
            this.Controls.Add(this.pic_retour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModiferConsomation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModiferConsomation";
            this.Load += new System.EventHandler(this.ModiferConsomation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_retour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mod_conso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mod_consom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_exporter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_retour;
        private System.Windows.Forms.DataGridView dgv_mod_conso;
        private System.Windows.Forms.TextBox txt_mod_mois;
        private System.Windows.Forms.TextBox txt_mod_cpt;
        private System.Windows.Forms.TextBox txt_mod_anci_cons;
        private System.Windows.Forms.TextBox txt_mod_nouvelle_cons;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pic_mod_consom;
        private System.Windows.Forms.ToolTip tool_retour;
        private System.Windows.Forms.ToolTip tool_modifier;
        private System.Windows.Forms.PictureBox pic_exporter;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox chk_mdf_conso;
    }
}