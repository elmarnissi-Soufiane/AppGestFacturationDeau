namespace AppGestFacturationDeau
{
    partial class ImprimerRecu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImprimerRecu));
            this.Cry_Recu = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // Cry_Recu
            // 
            this.Cry_Recu.ActiveViewIndex = -1;
            this.Cry_Recu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Cry_Recu.Cursor = System.Windows.Forms.Cursors.Default;
            this.Cry_Recu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cry_Recu.Location = new System.Drawing.Point(0, 0);
            this.Cry_Recu.Name = "Cry_Recu";
            this.Cry_Recu.Size = new System.Drawing.Size(644, 362);
            this.Cry_Recu.TabIndex = 0;
            this.Cry_Recu.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // ImprimerRecu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 362);
            this.Controls.Add(this.Cry_Recu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImprimerRecu";
            this.Text = "Imprimer";
            this.Load += new System.EventHandler(this.ImprimerRecu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer Cry_Recu;
    }
}