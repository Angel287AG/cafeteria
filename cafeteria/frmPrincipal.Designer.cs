namespace cafeteria
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cafeteriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maquinaExpendedoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cafeteriaToolStripMenuItem,
            this.maquinaExpendedoraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cafeteriaToolStripMenuItem
            // 
            this.cafeteriaToolStripMenuItem.Name = "cafeteriaToolStripMenuItem";
            this.cafeteriaToolStripMenuItem.Size = new System.Drawing.Size(86, 25);
            this.cafeteriaToolStripMenuItem.Text = "Cafetería";
            this.cafeteriaToolStripMenuItem.Click += new System.EventHandler(this.cafeteriaToolStripMenuItem_Click_1);
            // 
            // maquinaExpendedoraToolStripMenuItem
            // 
            this.maquinaExpendedoraToolStripMenuItem.Name = "maquinaExpendedoraToolStripMenuItem";
            this.maquinaExpendedoraToolStripMenuItem.Size = new System.Drawing.Size(179, 25);
            this.maquinaExpendedoraToolStripMenuItem.Text = "maquina expendedora";
            this.maquinaExpendedoraToolStripMenuItem.Click += new System.EventHandler(this.maquinaExpendedoraToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cafeteriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maquinaExpendedoraToolStripMenuItem;
    }
}