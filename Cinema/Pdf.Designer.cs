namespace Cinema
{
    partial class Pdf
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
            this.btnajouter = new System.Windows.Forms.Button();
            this.lbl_date = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btn_reinitialiser = new System.Windows.Forms.Button();
            this.btn_edition = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Fermer = new System.Windows.Forms.Button();
            this.btn_Moyen = new System.Windows.Forms.Button();
            this.btn_Petit = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fichier = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catégorie = new System.Windows.Forms.ToolStripMenuItem();
            this.filmsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sallesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnajouter
            // 
            this.btnajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btnajouter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.btnajouter.FlatAppearance.BorderSize = 2;
            this.btnajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajouter.ForeColor = System.Drawing.SystemColors.Control;
            this.btnajouter.Location = new System.Drawing.Point(438, 326);
            this.btnajouter.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(308, 75);
            this.btnajouter.TabIndex = 5;
            this.btnajouter.Text = "Générer en pdf";
            this.btnajouter.UseVisualStyleBackColor = false;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // lbl_date
            // 
            this.lbl_date.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_date.Location = new System.Drawing.Point(552, 177);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(57, 25);
            this.lbl_date.TabIndex = 75;
            this.lbl_date.Text = "Date";
            this.lbl_date.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(438, 246);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(306, 26);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2023, 3, 4, 0, 0, 0, 0);
            // 
            // btn_confirm
            // 
            this.btn_confirm.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btn_confirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.btn_confirm.FlatAppearance.BorderSize = 2;
            this.btn_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_confirm.Location = new System.Drawing.Point(438, 326);
            this.btn_confirm.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(308, 75);
            this.btn_confirm.TabIndex = 3;
            this.btn_confirm.Text = "Confirmer";
            this.btn_confirm.UseVisualStyleBackColor = false;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_reinitialiser
            // 
            this.btn_reinitialiser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_reinitialiser.AutoSize = true;
            this.btn_reinitialiser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btn_reinitialiser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.btn_reinitialiser.FlatAppearance.BorderSize = 2;
            this.btn_reinitialiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reinitialiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reinitialiser.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_reinitialiser.Location = new System.Drawing.Point(772, 238);
            this.btn_reinitialiser.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_reinitialiser.Name = "btn_reinitialiser";
            this.btn_reinitialiser.Size = new System.Drawing.Size(164, 52);
            this.btn_reinitialiser.TabIndex = 2;
            this.btn_reinitialiser.Text = "Reinitialiser";
            this.btn_reinitialiser.UseVisualStyleBackColor = false;
            this.btn_reinitialiser.Click += new System.EventHandler(this.btn_reinitialiser_Click);
            // 
            // btn_edition
            // 
            this.btn_edition.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_edition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btn_edition.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.btn_edition.FlatAppearance.BorderSize = 2;
            this.btn_edition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edition.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_edition.Location = new System.Drawing.Point(438, 438);
            this.btn_edition.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_edition.Name = "btn_edition";
            this.btn_edition.Size = new System.Drawing.Size(308, 75);
            this.btn_edition.TabIndex = 4;
            this.btn_edition.Text = "Editer projection";
            this.btn_edition.UseVisualStyleBackColor = false;
            this.btn_edition.Click += new System.EventHandler(this.btn_edition_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btn_Fermer);
            this.panel1.Controls.Add(this.btn_Moyen);
            this.panel1.Controls.Add(this.btn_Petit);
            this.panel1.Location = new System.Drawing.Point(1065, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 37);
            this.panel1.TabIndex = 76;
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
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.fichier, this.catégorie });
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.menu.Size = new System.Drawing.Size(1200, 30);
            this.menu.TabIndex = 77;
            this.menu.Text = "menuStrip1";
            this.menu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menu_MouseDown);
            // 
            // fichier
            // 
            this.fichier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.fichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.quitterToolStripMenuItem });
            this.fichier.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fichier.ForeColor = System.Drawing.SystemColors.Control;
            this.fichier.Margin = new System.Windows.Forms.Padding(0, 0, 0, -1);
            this.fichier.Name = "fichier";
            this.fichier.Size = new System.Drawing.Size(74, 29);
            this.fichier.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.quitterToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(139, 30);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // catégorie
            // 
            this.catégorie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.catégorie.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.filmsToolStripMenuItem, this.sallesToolStripMenuItem, this.pdfToolStripMenuItem, this.projectionsToolStripMenuItem });
            this.catégorie.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.catégorie.ForeColor = System.Drawing.SystemColors.Control;
            this.catégorie.Margin = new System.Windows.Forms.Padding(0, 0, 0, -1);
            this.catégorie.Name = "catégorie";
            this.catégorie.Size = new System.Drawing.Size(108, 29);
            this.catégorie.Text = "Catégories";
            // 
            // filmsToolStripMenuItem
            // 
            this.filmsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.filmsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.filmsToolStripMenuItem.Name = "filmsToolStripMenuItem";
            this.filmsToolStripMenuItem.Size = new System.Drawing.Size(171, 30);
            this.filmsToolStripMenuItem.Text = "Genres";
            this.filmsToolStripMenuItem.Click += new System.EventHandler(this.genreToolStripMenuItem_Click);
            // 
            // sallesToolStripMenuItem
            // 
            this.sallesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.sallesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.sallesToolStripMenuItem.Name = "sallesToolStripMenuItem";
            this.sallesToolStripMenuItem.Size = new System.Drawing.Size(171, 30);
            this.sallesToolStripMenuItem.Text = "Salles";
            this.sallesToolStripMenuItem.Click += new System.EventHandler(this.sallesToolStripMenuItem_Click);
            // 
            // pdfToolStripMenuItem
            // 
            this.pdfToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.pdfToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.pdfToolStripMenuItem.Name = "pdfToolStripMenuItem";
            this.pdfToolStripMenuItem.Size = new System.Drawing.Size(171, 30);
            this.pdfToolStripMenuItem.Text = "Films";
            this.pdfToolStripMenuItem.Click += new System.EventHandler(this.filmsToolStripMenuItem_Click);
            // 
            // projectionsToolStripMenuItem
            // 
            this.projectionsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.projectionsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.projectionsToolStripMenuItem.Name = "projectionsToolStripMenuItem";
            this.projectionsToolStripMenuItem.Size = new System.Drawing.Size(171, 30);
            this.projectionsToolStripMenuItem.Text = "Projections";
            this.projectionsToolStripMenuItem.Click += new System.EventHandler(this.projectionsToolStripMenuItem_Click);
            // 
            // Pdf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_edition);
            this.Controls.Add(this.btn_reinitialiser);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.btnajouter);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Pdf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Générateur Pdf";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.panel1.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Button btn_reinitialiser;
        private System.Windows.Forms.Button btn_edition;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Fermer;
        private System.Windows.Forms.Button btn_Moyen;
        private System.Windows.Forms.Button btn_Petit;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fichier;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catégorie;
        private System.Windows.Forms.ToolStripMenuItem sallesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pdfToolStripMenuItem;
    }
}