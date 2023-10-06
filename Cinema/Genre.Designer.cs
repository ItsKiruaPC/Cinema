namespace Cinema
{
    partial class Genre
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdgenre = new System.Windows.Forms.DataGridView();
            this.btnajouter = new System.Windows.Forms.Button();
            this.btnsuppr = new System.Windows.Forms.Button();
            this.txtrecherche = new System.Windows.Forms.TextBox();
            this.btnmodif = new System.Windows.Forms.Button();
            this.btnrecherche = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblmessage = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fichier = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catégorie = new System.Windows.Forms.ToolStripMenuItem();
            this.sallesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Petit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Fermer = new System.Windows.Forms.Button();
            this.btn_Moyen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdgenre)).BeginInit();
            this.menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdgenre
            // 
            this.grdgenre.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Exo 2 Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdgenre.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdgenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdgenre.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdgenre.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.grdgenre.Location = new System.Drawing.Point(9, 85);
            this.grdgenre.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grdgenre.Name = "grdgenre";
            this.grdgenre.RowHeadersWidth = 51;
            this.grdgenre.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Exo 2 Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdgenre.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.grdgenre.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdgenre.RowTemplate.Height = 24;
            this.grdgenre.Size = new System.Drawing.Size(472, 269);
            this.grdgenre.TabIndex = 28;
            this.grdgenre.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdgenre_CellCenter);
            // 
            // btnajouter
            // 
            this.btnajouter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.btnajouter.FlatAppearance.BorderSize = 2;
            this.btnajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajouter.ForeColor = System.Drawing.SystemColors.Control;
            this.btnajouter.Location = new System.Drawing.Point(9, 384);
            this.btnajouter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(115, 54);
            this.btnajouter.TabIndex = 8;
            this.btnajouter.Text = "Ajouter";
            this.btnajouter.UseVisualStyleBackColor = true;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // btnsuppr
            // 
            this.btnsuppr.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.btnsuppr.FlatAppearance.BorderSize = 2;
            this.btnsuppr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsuppr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuppr.ForeColor = System.Drawing.SystemColors.Control;
            this.btnsuppr.Location = new System.Drawing.Point(375, 384);
            this.btnsuppr.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnsuppr.Name = "btnsuppr";
            this.btnsuppr.Size = new System.Drawing.Size(115, 54);
            this.btnsuppr.TabIndex = 6;
            this.btnsuppr.Text = "Supprimer";
            this.btnsuppr.UseVisualStyleBackColor = true;
            this.btnsuppr.Click += new System.EventHandler(this.btnsuppr_Click);
            // 
            // txtrecherche
            // 
            this.txtrecherche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.txtrecherche.ForeColor = System.Drawing.SystemColors.Control;
            this.txtrecherche.Location = new System.Drawing.Point(136, 45);
            this.txtrecherche.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtrecherche.Name = "txtrecherche";
            this.txtrecherche.Size = new System.Drawing.Size(162, 20);
            this.txtrecherche.TabIndex = 1;
            // 
            // btnmodif
            // 
            this.btnmodif.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.btnmodif.FlatAppearance.BorderSize = 2;
            this.btnmodif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodif.ForeColor = System.Drawing.SystemColors.Control;
            this.btnmodif.Location = new System.Drawing.Point(574, 241);
            this.btnmodif.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnmodif.Name = "btnmodif";
            this.btnmodif.Size = new System.Drawing.Size(115, 54);
            this.btnmodif.TabIndex = 5;
            this.btnmodif.Text = "Modifier";
            this.btnmodif.UseVisualStyleBackColor = true;
            this.btnmodif.Click += new System.EventHandler(this.btnmodif_Click);
            // 
            // btnrecherche
            // 
            this.btnrecherche.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.btnrecherche.FlatAppearance.BorderSize = 2;
            this.btnrecherche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrecherche.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrecherche.ForeColor = System.Drawing.SystemColors.Control;
            this.btnrecherche.Location = new System.Drawing.Point(315, 40);
            this.btnrecherche.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnrecherche.Name = "btnrecherche";
            this.btnrecherche.Size = new System.Drawing.Size(87, 28);
            this.btnrecherche.TabIndex = 2;
            this.btnrecherche.Text = "Rechercher";
            this.btnrecherche.UseVisualStyleBackColor = true;
            this.btnrecherche.Click += new System.EventHandler(this.btnrecherche_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Merriweather Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(570, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Modifier les tables";
            // 
            // txtnum
            // 
            this.txtnum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.txtnum.ForeColor = System.Drawing.SystemColors.Control;
            this.txtnum.Location = new System.Drawing.Point(574, 133);
            this.txtnum.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(44, 20);
            this.txtnum.TabIndex = 3;
            // 
            // txtnom
            // 
            this.txtnom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.txtnom.ForeColor = System.Drawing.SystemColors.Control;
            this.txtnom.Location = new System.Drawing.Point(574, 174);
            this.txtnom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(123, 20);
            this.txtnom.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(524, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "N°";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(524, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nom";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblmessage
            // 
            this.lblmessage.AutoSize = true;
            this.lblmessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmessage.ForeColor = System.Drawing.SystemColors.Control;
            this.lblmessage.Location = new System.Drawing.Point(504, 357);
            this.lblmessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.Size = new System.Drawing.Size(0, 20);
            this.lblmessage.TabIndex = 16;
            // 
            // btn_refresh
            // 
            this.btn_refresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.btn_refresh.FlatAppearance.BorderSize = 2;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_refresh.Location = new System.Drawing.Point(193, 384);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(115, 54);
            this.btn_refresh.TabIndex = 7;
            this.btn_refresh.Text = "Rafraichir";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichier,
            this.catégorie});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.menu.Size = new System.Drawing.Size(762, 24);
            this.menu.TabIndex = 69;
            this.menu.Text = "menuStrip1";
            this.menu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menu_MouseDown);
            // 
            // fichier
            // 
            this.fichier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.fichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichier.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fichier.ForeColor = System.Drawing.SystemColors.Control;
            this.fichier.Margin = new System.Windows.Forms.Padding(0, 0, 0, -1);
            this.fichier.Name = "fichier";
            this.fichier.Size = new System.Drawing.Size(54, 24);
            this.fichier.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.quitterToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // catégorie
            // 
            this.catégorie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.catégorie.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sallesToolStripMenuItem,
            this.filmsToolStripMenuItem,
            this.projectionsToolStripMenuItem,
            this.pdfToolStripMenuItem});
            this.catégorie.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.catégorie.ForeColor = System.Drawing.SystemColors.Control;
            this.catégorie.Margin = new System.Windows.Forms.Padding(0, 0, 0, -1);
            this.catégorie.Name = "catégorie";
            this.catégorie.Size = new System.Drawing.Size(75, 24);
            this.catégorie.Text = "Catégories";
            // 
            // sallesToolStripMenuItem
            // 
            this.sallesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.sallesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.sallesToolStripMenuItem.Name = "sallesToolStripMenuItem";
            this.sallesToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.sallesToolStripMenuItem.Text = "Salles";
            this.sallesToolStripMenuItem.Click += new System.EventHandler(this.sallesToolStripMenuItem_Click);
            // 
            // filmsToolStripMenuItem
            // 
            this.filmsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.filmsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.filmsToolStripMenuItem.Name = "filmsToolStripMenuItem";
            this.filmsToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.filmsToolStripMenuItem.Text = "Films";
            this.filmsToolStripMenuItem.Click += new System.EventHandler(this.filmsToolStripMenuItem_Click);
            // 
            // projectionsToolStripMenuItem
            // 
            this.projectionsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.projectionsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.projectionsToolStripMenuItem.Name = "projectionsToolStripMenuItem";
            this.projectionsToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.projectionsToolStripMenuItem.Text = "Projections";
            this.projectionsToolStripMenuItem.Click += new System.EventHandler(this.projectionsToolStripMenuItem_Click);
            // 
            // pdfToolStripMenuItem
            // 
            this.pdfToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.pdfToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.pdfToolStripMenuItem.Name = "pdfToolStripMenuItem";
            this.pdfToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.pdfToolStripMenuItem.Text = "Pdf";
            this.pdfToolStripMenuItem.Click += new System.EventHandler(this.pdfToolStripMenuItem_Click);
            // 
            // btn_Petit
            // 
            this.btn_Petit.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_Petit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Petit.FlatAppearance.BorderSize = 0;
            this.btn_Petit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Petit.Location = new System.Drawing.Point(10, 4);
            this.btn_Petit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Petit.Name = "btn_Petit";
            this.btn_Petit.Size = new System.Drawing.Size(15, 15);
            this.btn_Petit.TabIndex = 73;
            this.btn_Petit.UseVisualStyleBackColor = false;
            this.btn_Petit.Click += new System.EventHandler(this.btn_Petit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Fermer);
            this.panel1.Controls.Add(this.btn_Moyen);
            this.panel1.Controls.Add(this.btn_Petit);
            this.panel1.Location = new System.Drawing.Point(672, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(90, 24);
            this.panel1.TabIndex = 74;
            // 
            // btn_Fermer
            // 
            this.btn_Fermer.BackColor = System.Drawing.Color.Red;
            this.btn_Fermer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Fermer.FlatAppearance.BorderSize = 0;
            this.btn_Fermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Fermer.Location = new System.Drawing.Point(70, 4);
            this.btn_Fermer.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Fermer.Name = "btn_Fermer";
            this.btn_Fermer.Size = new System.Drawing.Size(15, 15);
            this.btn_Fermer.TabIndex = 75;
            this.btn_Fermer.UseVisualStyleBackColor = false;
            this.btn_Fermer.Click += new System.EventHandler(this.btn_Fermer_Click);
            // 
            // btn_Moyen
            // 
            this.btn_Moyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Moyen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Moyen.FlatAppearance.BorderSize = 0;
            this.btn_Moyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Moyen.Location = new System.Drawing.Point(40, 4);
            this.btn_Moyen.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Moyen.Name = "btn_Moyen";
            this.btn_Moyen.Size = new System.Drawing.Size(15, 15);
            this.btn_Moyen.TabIndex = 74;
            this.btn_Moyen.UseVisualStyleBackColor = false;
            this.btn_Moyen.Click += new System.EventHandler(this.btn_Moyen_Click);
            // 
            // Genre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(762, 471);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.lblmessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnrecherche);
            this.Controls.Add(this.btnmodif);
            this.Controls.Add(this.txtrecherche);
            this.Controls.Add(this.btnsuppr);
            this.Controls.Add(this.btnajouter);
            this.Controls.Add(this.grdgenre);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Genre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genres";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdgenre)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.Button btnsuppr;
        private System.Windows.Forms.TextBox txtrecherche;
        private System.Windows.Forms.Button btnmodif;
        private System.Windows.Forms.Button btnrecherche;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblmessage;
        internal System.Windows.Forms.DataGridView grdgenre;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fichier;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catégorie;
        private System.Windows.Forms.ToolStripMenuItem sallesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pdfToolStripMenuItem;
        private System.Windows.Forms.Button btn_Petit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Fermer;
        private System.Windows.Forms.Button btn_Moyen;
    }
}

