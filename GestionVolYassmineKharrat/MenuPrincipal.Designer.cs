namespace GestionVolYassmineKharrat
{
    partial class MenuPrincipal
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
            this.avionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesAvionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesVolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avionToolStripMenuItem,
            this.volToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // avionToolStripMenuItem
            // 
            this.avionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesAvionsToolStripMenuItem});
            this.avionToolStripMenuItem.Name = "avionToolStripMenuItem";
            this.avionToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.avionToolStripMenuItem.Text = "Avion";
            this.avionToolStripMenuItem.Click += new System.EventHandler(this.avionsToolStripMenuItem_Click);
            // 
            // gestionDesAvionsToolStripMenuItem
            // 
            this.gestionDesAvionsToolStripMenuItem.Name = "gestionDesAvionsToolStripMenuItem";
            this.gestionDesAvionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestionDesAvionsToolStripMenuItem.Text = "Gestion Des Avions";
            // 
            // volToolStripMenuItem
            // 
            this.volToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesVolsToolStripMenuItem});
            this.volToolStripMenuItem.Name = "volToolStripMenuItem";
            this.volToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.volToolStripMenuItem.Text = "Vol";
            this.volToolStripMenuItem.Click += new System.EventHandler(this.volToolStripMenuItem_Click);
            // 
            // gestionDesVolsToolStripMenuItem
            // 
            this.gestionDesVolsToolStripMenuItem.Name = "gestionDesVolsToolStripMenuItem";
            this.gestionDesVolsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.gestionDesVolsToolStripMenuItem.Text = "Gestion Des Vols";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincopal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem avionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesAvionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesVolsToolStripMenuItem;
    }
}