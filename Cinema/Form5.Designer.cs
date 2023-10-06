namespace Cinema
{
    partial class Form5
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fichier = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catégorie = new System.Windows.Forms.ToolStripMenuItem();
            this.genreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sallesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Petit = new System.Windows.Forms.TextBox();
            this.Moyen = new System.Windows.Forms.TextBox();
            this.ferme = new System.Windows.Forms.TextBox();
            this.btnajouter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btn_reinitialiser = new System.Windows.Forms.Button();
            this.btn_edition = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.SuspendLayout();
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
            this.menu.Size = new System.Drawing.Size(800, 24);
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
            this.filmsToolStripMenuItem,
            this.projectionsToolStripMenuItem});
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
            this.genreToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.genreToolStripMenuItem.Text = "Genres";
            this.genreToolStripMenuItem.Click += new System.EventHandler(this.genreToolStripMenuItem_Click);
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
            // Petit
            // 
            this.Petit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.Petit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Petit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Petit.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.Petit.ForeColor = System.Drawing.Color.Green;
            this.Petit.Location = new System.Drawing.Point(725, 0);
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
            this.Moyen.Location = new System.Drawing.Point(750, 0);
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
            this.ferme.Location = new System.Drawing.Point(775, 0);
            this.ferme.Name = "ferme";
            this.ferme.Size = new System.Drawing.Size(25, 24);
            this.ferme.TabIndex = 66;
            this.ferme.Text = "⬛";
            this.ferme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ferme.Click += new System.EventHandler(this.ferme_TextChanged);
            // 
            // btnajouter
            // 
            this.btnajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btnajouter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.btnajouter.FlatAppearance.BorderSize = 2;
            this.btnajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajouter.ForeColor = System.Drawing.SystemColors.Control;
            this.btnajouter.Location = new System.Drawing.Point(292, 212);
            this.btnajouter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(205, 49);
            this.btnajouter.TabIndex = 69;
            this.btnajouter.Text = "Générer en pdf";
            this.btnajouter.UseVisualStyleBackColor = false;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(368, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 75;
            this.label2.Text = "Date";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(292, 160);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(205, 20);
            this.dateTimePicker1.TabIndex = 76;
            this.dateTimePicker1.Value = new System.DateTime(2023, 3, 4, 0, 0, 0, 0);
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btn_confirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.btn_confirm.FlatAppearance.BorderSize = 2;
            this.btn_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_confirm.Location = new System.Drawing.Point(292, 212);
            this.btn_confirm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(205, 49);
            this.btn_confirm.TabIndex = 77;
            this.btn_confirm.Text = "Confirmer";
            this.btn_confirm.UseVisualStyleBackColor = false;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_reinitialiser
            // 
            this.btn_reinitialiser.AutoSize = true;
            this.btn_reinitialiser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btn_reinitialiser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.btn_reinitialiser.FlatAppearance.BorderSize = 2;
            this.btn_reinitialiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reinitialiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reinitialiser.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_reinitialiser.Location = new System.Drawing.Point(515, 155);
            this.btn_reinitialiser.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_reinitialiser.Name = "btn_reinitialiser";
            this.btn_reinitialiser.Size = new System.Drawing.Size(109, 34);
            this.btn_reinitialiser.TabIndex = 79;
            this.btn_reinitialiser.Text = "Reinitialiser";
            this.btn_reinitialiser.UseVisualStyleBackColor = false;
            this.btn_reinitialiser.Click += new System.EventHandler(this.btn_reinitialiser_Click);
            // 
            // btn_edition
            // 
            this.btn_edition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btn_edition.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.btn_edition.FlatAppearance.BorderSize = 2;
            this.btn_edition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edition.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_edition.Location = new System.Drawing.Point(292, 285);
            this.btn_edition.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_edition.Name = "btn_edition";
            this.btn_edition.Size = new System.Drawing.Size(205, 49);
            this.btn_edition.TabIndex = 80;
            this.btn_edition.Text = "Editer projection";
            this.btn_edition.UseVisualStyleBackColor = false;
            this.btn_edition.Click += new System.EventHandler(this.btn_edition_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_edition);
            this.Controls.Add(this.btn_reinitialiser);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnajouter);
            this.Controls.Add(this.Petit);
            this.Controls.Add(this.Moyen);
            this.Controls.Add(this.ferme);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fichier;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catégorie;
        private System.Windows.Forms.ToolStripMenuItem genreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sallesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectionsToolStripMenuItem;
        private System.Windows.Forms.TextBox Petit;
        private System.Windows.Forms.TextBox Moyen;
        private System.Windows.Forms.TextBox ferme;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Button btn_reinitialiser;
        private System.Windows.Forms.Button btn_edition;
    }
}