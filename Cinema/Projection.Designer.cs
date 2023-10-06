namespace Cinema
{
    partial class Projection
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Projection));
            this.lblmessage = new System.Windows.Forms.Label();
            this.lbl_film = new System.Windows.Forms.Label();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnrecherche = new System.Windows.Forms.Button();
            this.txtrecherche = new System.Windows.Forms.TextBox();
            this.btnsuppr = new System.Windows.Forms.Button();
            this.btnajouter = new System.Windows.Forms.Button();
            this.grdgenre = new System.Windows.Forms.DataGridView();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_salle = new System.Windows.Forms.Label();
            this.lbl_horaire = new System.Windows.Forms.Label();
            this.cbofilm = new System.Windows.Forms.ComboBox();
            this.cbosalle = new System.Windows.Forms.ComboBox();
            this.cbohoraire = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtnum_find = new System.Windows.Forms.TextBox();
            this.lbl_titre = new System.Windows.Forms.Label();
            this.lbl_num = new System.Windows.Forms.Label();
            this.Application = new System.Windows.Forms.Label();
            this.loupe = new System.Windows.Forms.PictureBox();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.lbl_description = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Fermer = new System.Windows.Forms.Button();
            this.btn_Moyen = new System.Windows.Forms.Button();
            this.btn_Petit = new System.Windows.Forms.Button();
            this.fichier = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catégorie = new System.Windows.Forms.ToolStripMenuItem();
            this.genreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sallesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.grdgenre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loupe)).BeginInit();
            this.panel1.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblmessage
            // 
            this.lblmessage.AutoSize = true;
            this.lblmessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmessage.Location = new System.Drawing.Point(772, 745);
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.Size = new System.Drawing.Size(0, 29);
            this.lblmessage.TabIndex = 44;
            // 
            // lbl_film
            // 
            this.lbl_film.AutoSize = true;
            this.lbl_film.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_film.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_film.Location = new System.Drawing.Point(1886, 465);
            this.lbl_film.Name = "lbl_film";
            this.lbl_film.Size = new System.Drawing.Size(42, 20);
            this.lbl_film.TabIndex = 43;
            this.lbl_film.Text = "Film";
            this.lbl_film.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numero.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_numero.Location = new System.Drawing.Point(1886, 391);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(27, 20);
            this.lbl_numero.TabIndex = 42;
            this.lbl_numero.Text = "N°";
            this.lbl_numero.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtnum
            // 
            this.txtnum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.txtnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum.ForeColor = System.Drawing.SystemColors.Control;
            this.txtnum.Location = new System.Drawing.Point(1882, 415);
            this.txtnum.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(64, 26);
            this.txtnum.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Merriweather", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(1842, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 33);
            this.label1.TabIndex = 39;
            this.label1.Text = "Modifier les projections";
            // 
            // btnrecherche
            // 
            this.btnrecherche.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.btnrecherche.FlatAppearance.BorderSize = 2;
            this.btnrecherche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrecherche.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrecherche.ForeColor = System.Drawing.SystemColors.Control;
            this.btnrecherche.Location = new System.Drawing.Point(1164, 249);
            this.btnrecherche.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnrecherche.Name = "btnrecherche";
            this.btnrecherche.Size = new System.Drawing.Size(132, 57);
            this.btnrecherche.TabIndex = 3;
            this.btnrecherche.Text = "Rechercher";
            this.btnrecherche.UseVisualStyleBackColor = true;
            this.btnrecherche.Click += new System.EventHandler(this.btnrecherche_Click);
            // 
            // txtrecherche
            // 
            this.txtrecherche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.txtrecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrecherche.ForeColor = System.Drawing.SystemColors.Control;
            this.txtrecherche.Location = new System.Drawing.Point(900, 258);
            this.txtrecherche.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtrecherche.Name = "txtrecherche";
            this.txtrecherche.Size = new System.Drawing.Size(241, 35);
            this.txtrecherche.TabIndex = 2;
            // 
            // btnsuppr
            // 
            this.btnsuppr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btnsuppr.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.btnsuppr.FlatAppearance.BorderSize = 2;
            this.btnsuppr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsuppr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuppr.ForeColor = System.Drawing.SystemColors.Control;
            this.btnsuppr.Location = new System.Drawing.Point(1890, 1102);
            this.btnsuppr.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnsuppr.Name = "btnsuppr";
            this.btnsuppr.Size = new System.Drawing.Size(159, 75);
            this.btnsuppr.TabIndex = 12;
            this.btnsuppr.Text = "Supprimer";
            this.btnsuppr.UseVisualStyleBackColor = false;
            this.btnsuppr.Click += new System.EventHandler(this.btnsuppr_Click);
            // 
            // btnajouter
            // 
            this.btnajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btnajouter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.btnajouter.FlatAppearance.BorderSize = 2;
            this.btnajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajouter.ForeColor = System.Drawing.SystemColors.Control;
            this.btnajouter.Location = new System.Drawing.Point(1890, 960);
            this.btnajouter.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(159, 75);
            this.btnajouter.TabIndex = 10;
            this.btnajouter.Text = "Ajouter";
            this.btnajouter.UseVisualStyleBackColor = false;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // grdgenre
            // 
            this.grdgenre.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdgenre.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdgenre.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.grdgenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdgenre.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdgenre.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.grdgenre.Location = new System.Drawing.Point(258, 315);
            this.grdgenre.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grdgenre.Name = "grdgenre";
            this.grdgenre.RowHeadersWidth = 51;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grdgenre.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.grdgenre.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdgenre.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.grdgenre.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdgenre.RowTemplate.Height = 24;
            this.grdgenre.Size = new System.Drawing.Size(1466, 1008);
            this.grdgenre.TabIndex = 45;
            this.grdgenre.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdgenre_CellCenter);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_date.Location = new System.Drawing.Point(1886, 612);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(48, 20);
            this.lbl_date.TabIndex = 51;
            this.lbl_date.Text = "Date";
            this.lbl_date.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_salle
            // 
            this.lbl_salle.AutoSize = true;
            this.lbl_salle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_salle.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_salle.Location = new System.Drawing.Point(1886, 538);
            this.lbl_salle.Name = "lbl_salle";
            this.lbl_salle.Size = new System.Drawing.Size(49, 20);
            this.lbl_salle.TabIndex = 50;
            this.lbl_salle.Text = "Salle";
            this.lbl_salle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_horaire
            // 
            this.lbl_horaire.AutoSize = true;
            this.lbl_horaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_horaire.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_horaire.Location = new System.Drawing.Point(1886, 689);
            this.lbl_horaire.Name = "lbl_horaire";
            this.lbl_horaire.Size = new System.Drawing.Size(68, 20);
            this.lbl_horaire.TabIndex = 54;
            this.lbl_horaire.Text = "Horaire";
            this.lbl_horaire.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbofilm
            // 
            this.cbofilm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.cbofilm.ForeColor = System.Drawing.SystemColors.Control;
            this.cbofilm.FormattingEnabled = true;
            this.cbofilm.Location = new System.Drawing.Point(1882, 489);
            this.cbofilm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbofilm.Name = "cbofilm";
            this.cbofilm.Size = new System.Drawing.Size(180, 28);
            this.cbofilm.TabIndex = 5;
            // 
            // cbosalle
            // 
            this.cbosalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.cbosalle.ForeColor = System.Drawing.SystemColors.Control;
            this.cbosalle.FormattingEnabled = true;
            this.cbosalle.Location = new System.Drawing.Point(1882, 563);
            this.cbosalle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbosalle.Name = "cbosalle";
            this.cbosalle.Size = new System.Drawing.Size(180, 28);
            this.cbosalle.TabIndex = 6;
            // 
            // cbohoraire
            // 
            this.cbohoraire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.cbohoraire.ForeColor = System.Drawing.SystemColors.Control;
            this.cbohoraire.FormattingEnabled = true;
            this.cbohoraire.Location = new System.Drawing.Point(1882, 714);
            this.cbohoraire.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbohoraire.Name = "cbohoraire";
            this.cbohoraire.Size = new System.Drawing.Size(180, 28);
            this.cbohoraire.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.Control;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker1.Location = new System.Drawing.Point(1882, 637);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.Size = new System.Drawing.Size(180, 26);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Value = new System.DateTime(2023, 2, 24, 19, 0, 7, 0);
            // 
            // txtnum_find
            // 
            this.txtnum_find.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.txtnum_find.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum_find.ForeColor = System.Drawing.SystemColors.Control;
            this.txtnum_find.Location = new System.Drawing.Point(802, 258);
            this.txtnum_find.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtnum_find.Name = "txtnum_find";
            this.txtnum_find.Size = new System.Drawing.Size(74, 35);
            this.txtnum_find.TabIndex = 1;
            // 
            // lbl_titre
            // 
            this.lbl_titre.AutoSize = true;
            this.lbl_titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_titre.Location = new System.Drawing.Point(987, 217);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(56, 25);
            this.lbl_titre.TabIndex = 60;
            this.lbl_titre.Text = "Titre";
            this.lbl_titre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_num
            // 
            this.lbl_num.AutoSize = true;
            this.lbl_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_num.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_num.Location = new System.Drawing.Point(810, 217);
            this.lbl_num.Name = "lbl_num";
            this.lbl_num.Size = new System.Drawing.Size(56, 25);
            this.lbl_num.TabIndex = 61;
            this.lbl_num.Text = "Num";
            this.lbl_num.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Application
            // 
            this.Application.AutoSize = true;
            this.Application.Font = new System.Drawing.Font("Merriweather", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Application.ForeColor = System.Drawing.SystemColors.Control;
            this.Application.Location = new System.Drawing.Point(748, 82);
            this.Application.Name = "Application";
            this.Application.Size = new System.Drawing.Size(635, 80);
            this.Application.TabIndex = 65;
            this.Application.Text = "Projection des films";
            this.Application.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // loupe
            // 
            this.loupe.BackColor = System.Drawing.Color.Transparent;
            this.loupe.Image = ((System.Drawing.Image)(resources.GetObject("loupe.Image")));
            this.loupe.Location = new System.Drawing.Point(1108, 262);
            this.loupe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loupe.Name = "loupe";
            this.loupe.Size = new System.Drawing.Size(32, 34);
            this.loupe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loupe.TabIndex = 66;
            this.loupe.TabStop = false;
            // 
            // txt_desc
            // 
            this.txt_desc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.txt_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_desc.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_desc.Location = new System.Drawing.Point(1882, 791);
            this.txt_desc.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_desc.Multiline = true;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(250, 132);
            this.txt_desc.TabIndex = 9;
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_description.Location = new System.Drawing.Point(1886, 766);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(100, 20);
            this.lbl_description.TabIndex = 68;
            this.lbl_description.Text = "Description";
            this.lbl_description.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Fermer);
            this.panel1.Controls.Add(this.btn_Moyen);
            this.panel1.Controls.Add(this.btn_Petit);
            this.panel1.Location = new System.Drawing.Point(2049, 0);
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
            // fichier
            // 
            this.fichier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.fichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichier.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fichier.ForeColor = System.Drawing.SystemColors.Control;
            this.fichier.Margin = new System.Windows.Forms.Padding(0, 0, 0, -1);
            this.fichier.Name = "fichier";
            this.fichier.Size = new System.Drawing.Size(78, 35);
            this.fichier.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.quitterToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(169, 34);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // catégorie
            // 
            this.catégorie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.catégorie.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genreToolStripMenuItem,
            this.sallesToolStripMenuItem,
            this.filmsToolStripMenuItem,
            this.pdfToolStripMenuItem});
            this.catégorie.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.catégorie.ForeColor = System.Drawing.SystemColors.Control;
            this.catégorie.Margin = new System.Windows.Forms.Padding(0, 0, 0, -1);
            this.catégorie.Name = "catégorie";
            this.catégorie.Size = new System.Drawing.Size(112, 35);
            this.catégorie.Text = "Catégories";
            // 
            // genreToolStripMenuItem
            // 
            this.genreToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.genreToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.genreToolStripMenuItem.Name = "genreToolStripMenuItem";
            this.genreToolStripMenuItem.Size = new System.Drawing.Size(168, 34);
            this.genreToolStripMenuItem.Text = "Genres";
            this.genreToolStripMenuItem.Click += new System.EventHandler(this.genreToolStripMenuItem_Click);
            // 
            // sallesToolStripMenuItem
            // 
            this.sallesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.sallesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.sallesToolStripMenuItem.Name = "sallesToolStripMenuItem";
            this.sallesToolStripMenuItem.Size = new System.Drawing.Size(168, 34);
            this.sallesToolStripMenuItem.Text = "Salles";
            this.sallesToolStripMenuItem.Click += new System.EventHandler(this.sallesToolStripMenuItem_Click);
            // 
            // filmsToolStripMenuItem
            // 
            this.filmsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.filmsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.filmsToolStripMenuItem.Name = "filmsToolStripMenuItem";
            this.filmsToolStripMenuItem.Size = new System.Drawing.Size(168, 34);
            this.filmsToolStripMenuItem.Text = "Films";
            this.filmsToolStripMenuItem.Click += new System.EventHandler(this.filmsToolStripMenuItem_Click);
            // 
            // pdfToolStripMenuItem
            // 
            this.pdfToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.pdfToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.pdfToolStripMenuItem.Name = "pdfToolStripMenuItem";
            this.pdfToolStripMenuItem.Size = new System.Drawing.Size(168, 34);
            this.pdfToolStripMenuItem.Text = "Pdf";
            this.pdfToolStripMenuItem.Click += new System.EventHandler(this.pdfToolStripMenuItem_Click);
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
            this.menu.Size = new System.Drawing.Size(2184, 30);
            this.menu.TabIndex = 47;
            this.menu.Text = "menuStrip1";
            this.menu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menu_MouseDown);
            // 
            // Projection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(2184, 1428);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.loupe);
            this.Controls.Add(this.Application);
            this.Controls.Add(this.lbl_num);
            this.Controls.Add(this.lbl_titre);
            this.Controls.Add(this.txtnum_find);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbohoraire);
            this.Controls.Add(this.cbosalle);
            this.Controls.Add(this.cbofilm);
            this.Controls.Add(this.lbl_horaire);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_salle);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.lblmessage);
            this.Controls.Add(this.lbl_film);
            this.Controls.Add(this.lbl_numero);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnrecherche);
            this.Controls.Add(this.txtrecherche);
            this.Controls.Add(this.btnsuppr);
            this.Controls.Add(this.btnajouter);
            this.Controls.Add(this.grdgenre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Projection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projections";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdgenre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loupe)).EndInit();
            this.panel1.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblmessage;
        private System.Windows.Forms.Label lbl_film;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnrecherche;
        private System.Windows.Forms.TextBox txtrecherche;
        private System.Windows.Forms.Button btnsuppr;
        private System.Windows.Forms.Button btnajouter;
        internal System.Windows.Forms.DataGridView grdgenre;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_salle;
        private System.Windows.Forms.Label lbl_horaire;
        private System.Windows.Forms.ComboBox cbofilm;
        private System.Windows.Forms.ComboBox cbosalle;
        private System.Windows.Forms.ComboBox cbohoraire;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtnum_find;
        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.Label lbl_num;
        private System.Windows.Forms.Label Application;
        private System.Windows.Forms.PictureBox loupe;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Fermer;
        private System.Windows.Forms.Button btn_Moyen;
        private System.Windows.Forms.Button btn_Petit;
        private System.Windows.Forms.ToolStripMenuItem fichier;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catégorie;
        private System.Windows.Forms.ToolStripMenuItem genreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sallesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pdfToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menu;
    }
}