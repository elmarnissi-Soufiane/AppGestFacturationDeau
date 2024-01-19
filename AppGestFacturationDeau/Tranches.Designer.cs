namespace AppGestFacturationDeau
{
    partial class Tranches
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tranches));
            this.pic_retour = new System.Windows.Forms.PictureBox();
            this.pic_anuller = new System.Windows.Forms.PictureBox();
            this.pic_confirmer = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_taxe = new System.Windows.Forms.TextBox();
            this.grb_tranche = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_prix_tranche = new System.Windows.Forms.TextBox();
            this.cb_tranches = new System.Windows.Forms.ComboBox();
            this.pic_tranche = new System.Windows.Forms.PictureBox();
            this.tool_retour = new System.Windows.Forms.ToolTip(this.components);
            this.tool_valider_tr = new System.Windows.Forms.ToolTip(this.components);
            this.tool_valider_taxe = new System.Windows.Forms.ToolTip(this.components);
            this.tool_cancel = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_retour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_anuller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_confirmer)).BeginInit();
            this.grb_tranche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_tranche)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_retour
            // 
            this.pic_retour.BackColor = System.Drawing.Color.Transparent;
            this.pic_retour.BackgroundImage = global::AppGestFacturationDeau.Properties.Resources.return_back_blue_round_2_512;
            this.pic_retour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_retour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_retour.Location = new System.Drawing.Point(29, 399);
            this.pic_retour.Name = "pic_retour";
            this.pic_retour.Size = new System.Drawing.Size(100, 74);
            this.pic_retour.TabIndex = 20;
            this.pic_retour.TabStop = false;
            this.pic_retour.Click += new System.EventHandler(this.pic_retour_Click);
            // 
            // pic_anuller
            // 
            this.pic_anuller.BackColor = System.Drawing.Color.Transparent;
            this.pic_anuller.BackgroundImage = global::AppGestFacturationDeau.Properties.Resources.Line_office_business_cross_math_button_delete_512;
            this.pic_anuller.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_anuller.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_anuller.Location = new System.Drawing.Point(223, 305);
            this.pic_anuller.Name = "pic_anuller";
            this.pic_anuller.Size = new System.Drawing.Size(81, 80);
            this.pic_anuller.TabIndex = 26;
            this.pic_anuller.TabStop = false;
            this.pic_anuller.Click += new System.EventHandler(this.pic_anuller_Click);
            // 
            // pic_confirmer
            // 
            this.pic_confirmer.BackColor = System.Drawing.Color.Transparent;
            this.pic_confirmer.BackgroundImage = global::AppGestFacturationDeau.Properties.Resources.purepng_com_ok_iconyestickiconokcorrectokayconfirm_4115201939019kiil;
            this.pic_confirmer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_confirmer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_confirmer.Location = new System.Drawing.Point(90, 189);
            this.pic_confirmer.Name = "pic_confirmer";
            this.pic_confirmer.Size = new System.Drawing.Size(56, 63);
            this.pic_confirmer.TabIndex = 25;
            this.pic_confirmer.TabStop = false;
            this.pic_confirmer.Click += new System.EventHandler(this.pic_confirmer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(420, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 28;
            this.label3.Text = "الضريبة";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_taxe
            // 
            this.txt_taxe.Location = new System.Drawing.Point(177, 232);
            this.txt_taxe.Name = "txt_taxe";
            this.txt_taxe.Size = new System.Drawing.Size(212, 20);
            this.txt_taxe.TabIndex = 27;
            // 
            // grb_tranche
            // 
            this.grb_tranche.BackColor = System.Drawing.Color.Transparent;
            this.grb_tranche.Controls.Add(this.pic_tranche);
            this.grb_tranche.Controls.Add(this.label2);
            this.grb_tranche.Controls.Add(this.label1);
            this.grb_tranche.Controls.Add(this.txt_prix_tranche);
            this.grb_tranche.Controls.Add(this.cb_tranches);
            this.grb_tranche.Location = new System.Drawing.Point(72, 64);
            this.grb_tranche.Name = "grb_tranche";
            this.grb_tranche.Size = new System.Drawing.Size(438, 119);
            this.grb_tranche.TabIndex = 29;
            this.grb_tranche.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(370, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "الثمن";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(362, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "الشطر";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_prix_tranche
            // 
            this.txt_prix_tranche.Location = new System.Drawing.Point(105, 83);
            this.txt_prix_tranche.Name = "txt_prix_tranche";
            this.txt_prix_tranche.Size = new System.Drawing.Size(212, 20);
            this.txt_prix_tranche.TabIndex = 26;
            // 
            // cb_tranches
            // 
            this.cb_tranches.FormattingEnabled = true;
            this.cb_tranches.Location = new System.Drawing.Point(105, 30);
            this.cb_tranches.Name = "cb_tranches";
            this.cb_tranches.Size = new System.Drawing.Size(212, 21);
            this.cb_tranches.TabIndex = 25;
            this.cb_tranches.SelectedIndexChanged += new System.EventHandler(this.cb_tranches_SelectedIndexChanged);
            // 
            // pic_tranche
            // 
            this.pic_tranche.BackColor = System.Drawing.Color.Transparent;
            this.pic_tranche.BackgroundImage = global::AppGestFacturationDeau.Properties.Resources.purepng_com_ok_iconyestickiconokcorrectokayconfirm_4115201939019kiil;
            this.pic_tranche.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_tranche.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_tranche.Location = new System.Drawing.Point(18, 39);
            this.pic_tranche.Name = "pic_tranche";
            this.pic_tranche.Size = new System.Drawing.Size(56, 63);
            this.pic_tranche.TabIndex = 29;
            this.pic_tranche.TabStop = false;
            this.pic_tranche.Click += new System.EventHandler(this.pic_tranche_Click);
            // 
            // tool_retour
            // 
            this.tool_retour.IsBalloon = true;
            this.tool_retour.ShowAlways = true;
            // 
            // tool_valider_tr
            // 
            this.tool_valider_tr.IsBalloon = true;
            this.tool_valider_tr.ShowAlways = true;
            // 
            // tool_valider_taxe
            // 
            this.tool_valider_taxe.IsBalloon = true;
            this.tool_valider_taxe.ShowAlways = true;
            // 
            // tool_cancel
            // 
            this.tool_cancel.IsBalloon = true;
            this.tool_cancel.ShowAlways = true;
            // 
            // Tranches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppGestFacturationDeau.Properties.Resources.beach_style_blue_background_1080p_qyvzckhb__F0000;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 491);
            this.Controls.Add(this.grb_tranche);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_taxe);
            this.Controls.Add(this.pic_anuller);
            this.Controls.Add(this.pic_confirmer);
            this.Controls.Add(this.pic_retour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tranches";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tranche";
            this.Load += new System.EventHandler(this.Tranches_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_retour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_anuller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_confirmer)).EndInit();
            this.grb_tranche.ResumeLayout(false);
            this.grb_tranche.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_tranche)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pic_retour;
        private System.Windows.Forms.PictureBox pic_anuller;
        private System.Windows.Forms.PictureBox pic_confirmer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_taxe;
        private System.Windows.Forms.GroupBox grb_tranche;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_prix_tranche;
        private System.Windows.Forms.ComboBox cb_tranches;
        private System.Windows.Forms.PictureBox pic_tranche;
        private System.Windows.Forms.ToolTip tool_retour;
        private System.Windows.Forms.ToolTip tool_valider_tr;
        private System.Windows.Forms.ToolTip tool_valider_taxe;
        private System.Windows.Forms.ToolTip tool_cancel;
    }
}