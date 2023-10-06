namespace Cinema
{
    partial class Form3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblmessage = new System.Windows.Forms.Label();
            this.Titre = new System.Windows.Forms.Label();
            this.Num = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnrecherche = new System.Windows.Forms.Button();
            this.txtrecherche = new System.Windows.Forms.TextBox();
            this.btnsuppr = new System.Windows.Forms.Button();
            this.btnajouter = new System.Windows.Forms.Button();
            this.grdgenre = new System.Windows.Forms.DataGridView();
            this.Public = new System.Windows.Forms.Label();
            this.cb_public = new System.Windows.Forms.ComboBox();
            this.Genre = new System.Windows.Forms.Label();
            this.lst_genre = new System.Windows.Forms.ListBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fichier = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catégorie = new System.Windows.Forms.ToolStripMenuItem();
            this.genreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sallesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Petit = new System.Windows.Forms.TextBox();
            this.Moyen = new System.Windows.Forms.TextBox();
            this.ferme = new System.Windows.Forms.TextBox();
            this.pdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdgenre)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblmessage
            // 
            this.lblmessage.AutoSize = true;
            this.lblmessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmessage.Location = new System.Drawing.Point(191, 374);
            this.lblmessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.Size = new System.Drawing.Size(0, 15);
            this.lblmessage.TabIndex = 44;
            this.lblmessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Titre
            // 
            this.Titre.AutoSize = true;
            this.Titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titre.ForeColor = System.Drawing.SystemColors.Control;
            this.Titre.Location = new System.Drawing.Point(524, 194);
            this.Titre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Titre.Name = "Titre";
            this.Titre.Size = new System.Drawing.Size(33, 13);
            this.Titre.TabIndex = 43;
            this.Titre.Text = "Titre";
            this.Titre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Num
            // 
            this.Num.AutoSize = true;
            this.Num.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num.ForeColor = System.Drawing.SystemColors.Control;
            this.Num.Location = new System.Drawing.Point(524, 153);
            this.Num.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Num.Name = "Num";
            this.Num.Size = new System.Drawing.Size(21, 13);
            this.Num.TabIndex = 42;
            this.Num.Text = "N°";
            this.Num.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtnom
            // 
            this.txtnom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.txtnom.ForeColor = System.Drawing.SystemColors.Control;
            this.txtnom.Location = new System.Drawing.Point(574, 192);
            this.txtnom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(149, 20);
            this.txtnom.TabIndex = 41;
            // 
            // txtnum
            // 
            this.txtnum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.txtnum.ForeColor = System.Drawing.SystemColors.Control;
            this.txtnum.Location = new System.Drawing.Point(574, 150);
            this.txtnum.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(44, 20);
            this.txtnum.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(570, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Modifier les tables";
            // 
            // btnrecherche
            // 
            this.btnrecherche.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.btnrecherche.FlatAppearance.BorderSize = 2;
            this.btnrecherche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrecherche.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrecherche.Location = new System.Drawing.Point(307, 52);
            this.btnrecherche.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnrecherche.Name = "btnrecherche";
            this.btnrecherche.Size = new System.Drawing.Size(86, 30);
            this.btnrecherche.TabIndex = 38;
            this.btnrecherche.Text = "Rechercher";
            this.btnrecherche.UseVisualStyleBackColor = true;
            this.btnrecherche.Click += new System.EventHandler(this.btnrecherche_Click);
            // 
            // txtrecherche
            // 
            this.txtrecherche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.txtrecherche.Location = new System.Drawing.Point(138, 58);
            this.txtrecherche.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtrecherche.Name = "txtrecherche";
            this.txtrecherche.Size = new System.Drawing.Size(162, 20);
            this.txtrecherche.TabIndex = 36;
            // 
            // btnsuppr
            // 
            this.btnsuppr.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.btnsuppr.FlatAppearance.BorderSize = 2;
            this.btnsuppr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsuppr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuppr.Location = new System.Drawing.Point(287, 402);
            this.btnsuppr.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnsuppr.Name = "btnsuppr";
            this.btnsuppr.Size = new System.Drawing.Size(106, 49);
            this.btnsuppr.TabIndex = 35;
            this.btnsuppr.Text = "Supprimer";
            this.btnsuppr.UseVisualStyleBackColor = true;
            this.btnsuppr.Click += new System.EventHandler(this.btnsuppr_Click);
            // 
            // btnajouter
            // 
            this.btnajouter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.btnajouter.FlatAppearance.BorderSize = 2;
            this.btnajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajouter.Location = new System.Drawing.Point(85, 402);
            this.btnajouter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(106, 49);
            this.btnajouter.TabIndex = 34;
            this.btnajouter.Text = "Ajouter";
            this.btnajouter.UseVisualStyleBackColor = true;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // grdgenre
            // 
            this.grdgenre.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdgenre.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdgenre.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdgenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdgenre.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdgenre.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.grdgenre.Location = new System.Drawing.Point(9, 103);
            this.grdgenre.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grdgenre.Name = "grdgenre";
            this.grdgenre.RowHeadersWidth = 51;
            this.grdgenre.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdgenre.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.grdgenre.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdgenre.RowTemplate.Height = 24;
            this.grdgenre.Size = new System.Drawing.Size(472, 269);
            this.grdgenre.TabIndex = 45;
            this.grdgenre.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdgenre_CellCenter);
            // 
            // Public
            // 
            this.Public.AutoSize = true;
            this.Public.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Public.ForeColor = System.Drawing.SystemColors.Control;
            this.Public.Location = new System.Drawing.Point(524, 239);
            this.Public.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Public.Name = "Public";
            this.Public.Size = new System.Drawing.Size(42, 13);
            this.Public.TabIndex = 48;
            this.Public.Text = "Public";
            this.Public.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cb_public
            // 
            this.cb_public.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.cb_public.ForeColor = System.Drawing.SystemColors.Control;
            this.cb_public.FormattingEnabled = true;
            this.cb_public.Location = new System.Drawing.Point(574, 239);
            this.cb_public.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cb_public.Name = "cb_public";
            this.cb_public.Size = new System.Drawing.Size(149, 21);
            this.cb_public.TabIndex = 49;
            // 
            // Genre
            // 
            this.Genre.AutoSize = true;
            this.Genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genre.ForeColor = System.Drawing.SystemColors.Control;
            this.Genre.Location = new System.Drawing.Point(524, 287);
            this.Genre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(41, 13);
            this.Genre.TabIndex = 50;
            this.Genre.Text = "Genre";
            this.Genre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lst_genre
            // 
            this.lst_genre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.lst_genre.ForeColor = System.Drawing.SystemColors.Control;
            this.lst_genre.FormattingEnabled = true;
            this.lst_genre.Location = new System.Drawing.Point(574, 278);
            this.lst_genre.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lst_genre.Name = "lst_genre";
            this.lst_genre.ScrollAlwaysVisible = true;
            this.lst_genre.Size = new System.Drawing.Size(123, 95);
            this.lst_genre.TabIndex = 51;
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
            this.menu.TabIndex = 65;
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
            this.genreToolStripMenuItem,
            this.sallesToolStripMenuItem,
            this.projectionsToolStripMenuItem,
            this.pdfToolStripMenuItem});
            this.catégorie.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.catégorie.ForeColor = System.Drawing.SystemColors.Control;
            this.catégorie.Margin = new System.Windows.Forms.Padding(0, 0, 0, -1);
            this.catégorie.Name = "catégorie";
            this.catégorie.Size = new System.Drawing.Size(75, 24);
            this.catégorie.Text = "Catégories";
            // 
            // genreToolStripMenuItem
            // 
            this.genreToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.genreToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.genreToolStripMenuItem.Name = "genreToolStripMenuItem";
            this.genreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.genreToolStripMenuItem.Text = "Genres";
            this.genreToolStripMenuItem.Click += new System.EventHandler(this.genreToolStripMenuItem_Click);
            // 
            // sallesToolStripMenuItem
            // 
            this.sallesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.sallesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.sallesToolStripMenuItem.Name = "sallesToolStripMenuItem";
            this.sallesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sallesToolStripMenuItem.Text = "Salles";
            this.sallesToolStripMenuItem.Click += new System.EventHandler(this.sallesToolStripMenuItem_Click);
            // 
            // projectionsToolStripMenuItem
            // 
            this.projectionsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.projectionsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.projectionsToolStripMenuItem.Name = "projectionsToolStripMenuItem";
            this.projectionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.projectionsToolStripMenuItem.Text = "Projections";
            this.projectionsToolStripMenuItem.Click += new System.EventHandler(this.projectionsToolStripMenuItem_Click);
            // 
            // Petit
            // 
            this.Petit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.Petit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Petit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Petit.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.Petit.ForeColor = System.Drawing.Color.Green;
            this.Petit.Location = new System.Drawing.Point(688, 0);
            this.Petit.Name = "Petit";
            this.Petit.Size = new System.Drawing.Size(25, 24);
            this.Petit.TabIndex = 68;
            this.Petit.Text = "⬛";
            this.Petit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Petit.Click += new System.EventHandler(this.Petit_TextChanged);
            // 
            // Moyen
            // 
            this.Moyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.Moyen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Moyen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Moyen.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.Moyen.ForeColor = System.Drawing.Color.DarkOrange;
            this.Moyen.Location = new System.Drawing.Point(713, 0);
            this.Moyen.Name = "Moyen";
            this.Moyen.Size = new System.Drawing.Size(25, 24);
            this.Moyen.TabIndex = 67;
            this.Moyen.Text = "⬛";
            this.Moyen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Moyen.Click += new System.EventHandler(this.Moyen_TextChanged);
            // 
            // ferme
            // 
            this.ferme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.ferme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ferme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ferme.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.ferme.ForeColor = System.Drawing.Color.Red;
            this.ferme.Location = new System.Drawing.Point(738, 0);
            this.ferme.Name = "ferme";
            this.ferme.Size = new System.Drawing.Size(25, 24);
            this.ferme.TabIndex = 66;
            this.ferme.Text = "⬛";
            this.ferme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ferme.Click += new System.EventHandler(this.ferme_TextChanged);
            // 
            // pdfToolStripMenuItem
            // 
            this.pdfToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.pdfToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.pdfToolStripMenuItem.Name = "pdfToolStripMenuItem";
            this.pdfToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pdfToolStripMenuItem.Text = "Pdf";
            this.pdfToolStripMenuItem.Click += new System.EventHandler(this.pdfToolStripMenuItem_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(762, 471);
            this.Controls.Add(this.Petit);
            this.Controls.Add(this.Moyen);
            this.Controls.Add(this.ferme);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.lst_genre);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.cb_public);
            this.Controls.Add(this.Public);
            this.Controls.Add(this.lblmessage);
            this.Controls.Add(this.Titre);
            this.Controls.Add(this.Num);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnrecherche);
            this.Controls.Add(this.txtrecherche);
            this.Controls.Add(this.btnsuppr);
            this.Controls.Add(this.btnajouter);
            this.Controls.Add(this.grdgenre);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form3";
            this.Text = "Films";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdgenre)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblmessage;
        private System.Windows.Forms.Label Titre;
        private System.Windows.Forms.Label Num;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnrecherche;
        private System.Windows.Forms.TextBox txtrecherche;
        private System.Windows.Forms.Button btnsuppr;
        private System.Windows.Forms.Button btnajouter;
        internal System.Windows.Forms.DataGridView grdgenre;
        private System.Windows.Forms.Label Public;
        private System.Windows.Forms.ComboBox cb_public;
        private System.Windows.Forms.Label Genre;
        private System.Windows.Forms.ListBox lst_genre;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fichier;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catégorie;
        private System.Windows.Forms.ToolStripMenuItem genreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sallesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectionsToolStripMenuItem;
        private System.Windows.Forms.TextBox Petit;
        private System.Windows.Forms.TextBox Moyen;
        private System.Windows.Forms.TextBox ferme;
        private System.Windows.Forms.ToolStripMenuItem pdfToolStripMenuItem;
    }
}