namespace Cinema
{
    partial class Connection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connection));
            this.txt_mdp = new System.Windows.Forms.TextBox();
            this.txt_identifiant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_connexion = new System.Windows.Forms.Button();
            this.btn_creer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_mdp
            // 
            this.txt_mdp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.txt_mdp.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_mdp.Location = new System.Drawing.Point(231, 146);
            this.txt_mdp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_mdp.Name = "txt_mdp";
            this.txt_mdp.Size = new System.Drawing.Size(236, 26);
            this.txt_mdp.TabIndex = 2;
            // 
            // txt_identifiant
            // 
            this.txt_identifiant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.txt_identifiant.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_identifiant.Location = new System.Drawing.Point(207, 85);
            this.txt_identifiant.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_identifiant.Name = "txt_identifiant";
            this.txt_identifiant.Size = new System.Drawing.Size(211, 26);
            this.txt_identifiant.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(40, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Identifiant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(40, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mot de passe";
            // 
            // btn_connexion
            // 
            this.btn_connexion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.btn_connexion.FlatAppearance.BorderSize = 2;
            this.btn_connexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_connexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connexion.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_connexion.Location = new System.Drawing.Point(362, 211);
            this.btn_connexion.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_connexion.Name = "btn_connexion";
            this.btn_connexion.Size = new System.Drawing.Size(164, 65);
            this.btn_connexion.TabIndex = 4;
            this.btn_connexion.Text = "Connexion";
            this.btn_connexion.UseVisualStyleBackColor = true;
            this.btn_connexion.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // btn_creer
            // 
            this.btn_creer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.btn_creer.FlatAppearance.BorderSize = 2;
            this.btn_creer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_creer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_creer.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_creer.Location = new System.Drawing.Point(46, 211);
            this.btn_creer.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_creer.Name = "btn_creer";
            this.btn_creer.Size = new System.Drawing.Size(164, 65);
            this.btn_creer.TabIndex = 3;
            this.btn_creer.Text = "Créer";
            this.btn_creer.UseVisualStyleBackColor = true;
            this.btn_creer.Click += new System.EventHandler(this.btn_creer_Click);
            // 
            // Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(49)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(598, 286);
            this.Controls.Add(this.btn_creer);
            this.Controls.Add(this.btn_connexion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_identifiant);
            this.Controls.Add(this.txt_mdp);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Connection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.Form0_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_identifiant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_connexion;
        private System.Windows.Forms.Button btn_creer;
        private System.Windows.Forms.TextBox txt_mdp;
    }
}