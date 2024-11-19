namespace GestionVolYassmineKharrat
{
    partial class GestionDesAvions
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtref = new System.Windows.Forms.TextBox();
            this.cmbmarques = new System.Windows.Forms.ComboBox();
            this.txtnb = new System.Windows.Forms.TextBox();
            this.ckDispo = new System.Windows.Forms.CheckBox();
            this.btnajouter = new System.Windows.Forms.Button();
            this.btnsupp = new System.Windows.Forms.Button();
            this.dgvAvions = new System.Windows.Forms.DataGridView();
            this.Reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NbPassagers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvions)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marque";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "reference";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "nombre de passageers";
            // 
            // txtref
            // 
            this.txtref.Location = new System.Drawing.Point(184, 22);
            this.txtref.Name = "txtref";
            this.txtref.Size = new System.Drawing.Size(100, 20);
            this.txtref.TabIndex = 4;
            // 
            // cmbmarques
            // 
            this.cmbmarques.FormattingEnabled = true;
            this.cmbmarques.Location = new System.Drawing.Point(184, 73);
            this.cmbmarques.Name = "cmbmarques";
            this.cmbmarques.Size = new System.Drawing.Size(121, 21);
            this.cmbmarques.TabIndex = 5;
            // 
            // txtnb
            // 
            this.txtnb.Location = new System.Drawing.Point(184, 111);
            this.txtnb.Name = "txtnb";
            this.txtnb.Size = new System.Drawing.Size(100, 20);
            this.txtnb.TabIndex = 6;
            // 
            // ckDispo
            // 
            this.ckDispo.AutoSize = true;
            this.ckDispo.Location = new System.Drawing.Point(184, 171);
            this.ckDispo.Name = "ckDispo";
            this.ckDispo.Size = new System.Drawing.Size(73, 17);
            this.ckDispo.TabIndex = 7;
            this.ckDispo.Text = "disponible";
            this.ckDispo.UseVisualStyleBackColor = true;
            // 
            // btnajouter
            // 
            this.btnajouter.Location = new System.Drawing.Point(471, 35);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(75, 23);
            this.btnajouter.TabIndex = 8;
            this.btnajouter.Text = "Ajouter";
            this.btnajouter.UseVisualStyleBackColor = true;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // btnsupp
            // 
            this.btnsupp.Location = new System.Drawing.Point(471, 111);
            this.btnsupp.Name = "btnsupp";
            this.btnsupp.Size = new System.Drawing.Size(75, 23);
            this.btnsupp.TabIndex = 9;
            this.btnsupp.Text = "Supprimer";
            this.btnsupp.UseVisualStyleBackColor = true;
            this.btnsupp.Click += new System.EventHandler(this.btnsupp_Click);
            // 
            // dgvAvions
            // 
            this.dgvAvions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Reference,
            this.Marque,
            this.NbPassagers});
            this.dgvAvions.Location = new System.Drawing.Point(44, 215);
            this.dgvAvions.Name = "dgvAvions";
            this.dgvAvions.Size = new System.Drawing.Size(337, 150);
            this.dgvAvions.TabIndex = 10;
            this.dgvAvions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAvions_CellClick);
            // 
            // Reference
            // 
            this.Reference.HeaderText = "Reference";
            this.Reference.Name = "Reference";
            // 
            // Marque
            // 
            this.Marque.HeaderText = "Marque";
            this.Marque.Name = "Marque";
            // 
            // NbPassagers
            // 
            this.NbPassagers.HeaderText = "NbPassagers";
            this.NbPassagers.Name = "NbPassagers";
            // 
            // GestionDesAvions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvAvions);
            this.Controls.Add(this.btnsupp);
            this.Controls.Add(this.btnajouter);
            this.Controls.Add(this.ckDispo);
            this.Controls.Add(this.txtnb);
            this.Controls.Add(this.cmbmarques);
            this.Controls.Add(this.txtref);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "GestionDesAvions";
            this.Text = "GestionDesAvions";
            this.Load += new System.EventHandler(this.GestionDesAvions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtref;
        private System.Windows.Forms.ComboBox cmbmarques;
        private System.Windows.Forms.TextBox txtnb;
        private System.Windows.Forms.CheckBox ckDispo;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.Button btnsupp;
        private System.Windows.Forms.DataGridView dgvAvions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marque;
        private System.Windows.Forms.DataGridViewTextBoxColumn NbPassagers;
    }
}

