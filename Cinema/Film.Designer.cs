namespace Cinema
{
    partial class Film
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblmessage = new System.Windows.Forms.Label();
            this.lbl_titre = new System.Windows.Forms.Label();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.lbl_modiftable = new System.Windows.Forms.Label();
            this.btnrecherche = new System.Windows.Forms.Button();
            this.txtrecherche = new System.Windows.Forms.TextBox();
            this.btnsuppr = new System.Windows.Forms.Button();
            this.btnajouter = new System.Windows.Forms.Button();
            this.grdgenre = new System.Windows.Forms.DataGridView();
            this.lbl_public = new System.Windows.Forms.Label();
            this.cb_public = new System.Windows.Forms.ComboBox();
            this.lbl_genre = new System.Windows.Forms.Label();
            this.lst_genre = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Fermer = new System.Windows.Forms.Button();
            this.btn_Moyen = new System.Windows.Forms.Button();
            this.btn_Petit = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fichier = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catégorie = new System.Windows.Forms.ToolStripMenuItem();
            this.sallesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdgenre)).BeginInit();
            this.panel1.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblmessage
            // 
            this.lblmessage.AutoSize = true;
            this.lblmessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmessage.Location = new System.Drawing.Point(286, 575);
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.Size = new System.Drawing.Size(0, 22);
            this.lblmessage.TabIndex = 44;
            this.lblmessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_titre
            // 
            this.lbl_titre.AutoSize = true;
            this.lbl_titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_titre.Location = new System.Drawing.Point(786, 298);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(45, 20);
            this.lbl_titre.TabIndex = 43;
            this.lbl_titre.Text = "Titre";
            this.lbl_titre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numero.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_numero.Location = new System.Drawing.Point(786, 235);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(27, 20);
            this.lbl_numero.TabIndex = 42;
            this.lbl_numero.Text = "N°";
            this.lbl_numero.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtnom
            // 
            this.txtnom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.txtnom.ForeColor = System.Drawing.SystemColors.Control;
            this.txtnom.Location = new System.Drawing.Point(861, 295);
            this.txtnom.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(222, 26);
            this.txtnom.TabIndex = 4;
            // 
            // txtnum
            // 
            this.txtnum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.txtnum.ForeColor = System.Drawing.SystemColors.Control;
            this.txtnum.Location = new System.Drawing.Point(861, 231);
            this.txtnum.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(64, 26);
            this.txtnum.TabIndex = 3;
            // 
            // lbl_modiftable
            // 
            this.lbl_modiftable.AutoSize = true;
            this.lbl_modiftable.Font = new System.Drawing.Font("Merriweather", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_modiftable.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_modiftable.Location = new System.Drawing.Point(855, 158);
            this.lbl_modiftable.Name = "lbl_modiftable";
            this.lbl_modiftable.Size = new System.Drawing.Size(236, 33);
            this.lbl_modiftable.TabIndex = 39;
            this.lbl_modiftable.Text = "Modifier les tables";
            // 
            // btnrecherche
            // 
            this.btnrecherche.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.btnrecherche.FlatAppearance.BorderSize = 2;
            this.btnrecherche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrecherche.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrecherche.Location = new System.Drawing.Point(460, 80);
            this.btnrecherche.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnrecherche.Name = "btnrecherche";
            this.btnrecherche.Size = new System.Drawing.Size(129, 46);
            this.btnrecherche.TabIndex = 2;
            this.btnrecherche.Text = "Rechercher";
            this.btnrecherche.UseVisualStyleBackColor = true;
            this.btnrecherche.Click += new System.EventHandler(this.btnrecherche_Click);
            // 
            // txtrecherche
            // 
            this.txtrecherche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.txtrecherche.ForeColor = System.Drawing.SystemColors.Control;
            this.txtrecherche.Location = new System.Drawing.Point(207, 89);
            this.txtrecherche.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtrecherche.Name = "txtrecherche";
            this.txtrecherche.Size = new System.Drawing.Size(241, 26);
            this.txtrecherche.TabIndex = 1;
            // 
            // btnsuppr
            // 
            this.btnsuppr.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.btnsuppr.FlatAppearance.BorderSize = 2;
            this.btnsuppr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsuppr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuppr.Location = new System.Drawing.Point(430, 618);
            this.btnsuppr.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnsuppr.Name = "btnsuppr";
            this.btnsuppr.Size = new System.Drawing.Size(159, 75);
            this.btnsuppr.TabIndex = 7;
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
            this.btnajouter.Location = new System.Drawing.Point(128, 618);
            this.btnajouter.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(159, 75);
            this.btnajouter.TabIndex = 8;
            this.btnajouter.Text = "Ajouter";
            this.btnajouter.UseVisualStyleBackColor = true;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // grdgenre
            // 
            this.grdgenre.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdgenre.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdgenre.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.grdgenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdgenre.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdgenre.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.grdgenre.Location = new System.Drawing.Point(14, 158);
            this.grdgenre.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grdgenre.Name = "grdgenre";
            this.grdgenre.RowHeadersWidth = 51;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grdgenre.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.grdgenre.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdgenre.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.grdgenre.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdgenre.RowTemplate.Height = 24;
            this.grdgenre.Size = new System.Drawing.Size(708, 414);
            this.grdgenre.TabIndex = 45;
            this.grdgenre.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdgenre_CellCenter);
            // 
            // lbl_public
            // 
            this.lbl_public.AutoSize = true;
            this.lbl_public.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_public.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_public.Location = new System.Drawing.Point(786, 368);
            this.lbl_public.Name = "lbl_public";
            this.lbl_public.Size = new System.Drawing.Size(57, 20);
            this.lbl_public.TabIndex = 48;
            this.lbl_public.Text = "Public";
            this.lbl_public.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cb_public
            // 
            this.cb_public.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.cb_public.ForeColor = System.Drawing.SystemColors.Control;
            this.cb_public.FormattingEnabled = true;
            this.cb_public.Location = new System.Drawing.Point(861, 368);
            this.cb_public.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cb_public.Name = "cb_public";
            this.cb_public.Size = new System.Drawing.Size(222, 28);
            this.cb_public.TabIndex = 5;
            // 
            // lbl_genre
            // 
            this.lbl_genre.AutoSize = true;
            this.lbl_genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_genre.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_genre.Location = new System.Drawing.Point(786, 442);
            this.lbl_genre.Name = "lbl_genre";
            this.lbl_genre.Size = new System.Drawing.Size(59, 20);
            this.lbl_genre.TabIndex = 50;
            this.lbl_genre.Text = "Genre";
            this.lbl_genre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lst_genre
            // 
            this.lst_genre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.lst_genre.ForeColor = System.Drawing.SystemColors.Control;
            this.lst_genre.FormattingEnabled = true;
            this.lst_genre.ItemHeight = 20;
            this.lst_genre.Location = new System.Drawing.Point(861, 428);
            this.lst_genre.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lst_genre.Name = "lst_genre";
            this.lst_genre.ScrollAlwaysVisible = true;
            this.lst_genre.Size = new System.Drawing.Size(182, 144);
            this.lst_genre.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Fermer);
            this.panel1.Controls.Add(this.btn_Moyen);
            this.panel1.Controls.Add(this.btn_Petit);
            this.panel1.Location = new System.Drawing.Point(1012, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 37);
            this.panel1.TabIndex = 75;
            // 
            // btn_Fermer
            // 
            this.btn_Fermer.BackColor = System.Drawing.Color.Red;
            this.btn_Fermer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Fermer.FlatAppearance.BorderSize = 0;
            this.btn_Fermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Fermer.Location = new System.Drawing.Point(105, 6);
            this.btn_Fermer.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Fermer.Name = "btn_Fermer";
            this.btn_Fermer.Size = new System.Drawing.Size(22, 23);
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
            this.btn_Moyen.Location = new System.Drawing.Point(60, 6);
            this.btn_Moyen.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Moyen.Name = "btn_Moyen";
            this.btn_Moyen.Size = new System.Drawing.Size(22, 23);
            this.btn_Moyen.TabIndex = 74;
            this.btn_Moyen.UseVisualStyleBackColor = false;
            this.btn_Moyen.Click += new System.EventHandler(this.btn_Moyen_Click);
            // 
            // btn_Petit
            // 
            this.btn_Petit.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_Petit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Petit.FlatAppearance.BorderSize = 0;
            this.btn_Petit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Petit.Location = new System.Drawing.Point(15, 6);
            this.btn_Petit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Petit.Name = "btn_Petit";
            this.btn_Petit.Size = new System.Drawing.Size(22, 23);
            this.btn_Petit.TabIndex = 73;
            this.btn_Petit.UseVisualStyleBackColor = false;
            this.btn_Petit.Click += new System.EventHandler(this.btn_Petit_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
            this.menu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichier,
            this.catégorie});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.menu.Size = new System.Drawing.Size(1143, 30);
            this.menu.TabIndex = 76;
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
            this.fichier.Size = new System.Drawing.Size(78, 29);
            this.fichier.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.quitterToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // catégorie
            // 
            this.catégorie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.catégorie.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filmsToolStripMenuItem,
            this.sallesToolStripMenuItem,
            this.projectionsToolStripMenuItem,
            this.pdfToolStripMenuItem});
            this.catégorie.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.catégorie.ForeColor = System.Drawing.SystemColors.Control;
            this.catégorie.Margin = new System.Windows.Forms.Padding(0, 0, 0, -1);
            this.catégorie.Name = "catégorie";
            this.catégorie.Size = new System.Drawing.Size(112, 29);
            this.catégorie.Text = "Catégories";
            // 
            // sallesToolStripMenuItem
            // 
            this.sallesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.sallesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.sallesToolStripMenuItem.Name = "sallesToolStripMenuItem";
            this.sallesToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.sallesToolStripMenuItem.Text = "Salles";
            this.sallesToolStripMenuItem.Click += new System.EventHandler(this.sallesToolStripMenuItem_Click);
            // 
            // projectionsToolStripMenuItem
            // 
            this.projectionsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.projectionsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.projectionsToolStripMenuItem.Name = "projectionsToolStripMenuItem";
            this.projectionsToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.projectionsToolStripMenuItem.Text = "Projections";
            this.projectionsToolStripMenuItem.Click += new System.EventHandler(this.projectionsToolStripMenuItem_Click);
            // 
            // pdfToolStripMenuItem
            // 
            this.pdfToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.pdfToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.pdfToolStripMenuItem.Name = "pdfToolStripMenuItem";
            this.pdfToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.pdfToolStripMenuItem.Text = "Pdf";
            this.pdfToolStripMenuItem.Click += new System.EventHandler(this.pdfToolStripMenuItem_Click);
            // 
            // filmsToolStripMenuItem
            // 
            this.filmsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.filmsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.filmsToolStripMenuItem.Name = "filmsToolStripMenuItem";
            this.filmsToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.filmsToolStripMenuItem.Text = "Genres";
            this.filmsToolStripMenuItem.Click += new System.EventHandler(this.genreToolStripMenuItem_Click);
            // 
            // Film
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1143, 725);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lst_genre);
            this.Controls.Add(this.lbl_genre);
            this.Controls.Add(this.cb_public);
            this.Controls.Add(this.lbl_public);
            this.Controls.Add(this.lblmessage);
            this.Controls.Add(this.lbl_titre);
            this.Controls.Add(this.lbl_numero);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.lbl_modiftable);
            this.Controls.Add(this.btnrecherche);
            this.Controls.Add(this.txtrecherche);
            this.Controls.Add(this.btnsuppr);
            this.Controls.Add(this.btnajouter);
            this.Controls.Add(this.grdgenre);
            this.Controls.Add(this.menu);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Film";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Films";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdgenre)).EndInit();
            this.panel1.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblmessage;
        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Label lbl_modiftable;
        private System.Windows.Forms.Button btnrecherche;
        private System.Windows.Forms.TextBox txtrecherche;
        private System.Windows.Forms.Button btnsuppr;
        private System.Windows.Forms.Button btnajouter;
        internal System.Windows.Forms.DataGridView grdgenre;
        private System.Windows.Forms.Label lbl_public;
        private System.Windows.Forms.ComboBox cb_public;
        private System.Windows.Forms.Label lbl_genre;
        private System.Windows.Forms.ListBox lst_genre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Fermer;
        private System.Windows.Forms.Button btn_Moyen;
        private System.Windows.Forms.Button btn_Petit;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fichier;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catégorie;
        private System.Windows.Forms.ToolStripMenuItem sallesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pdfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmsToolStripMenuItem;
    }
}