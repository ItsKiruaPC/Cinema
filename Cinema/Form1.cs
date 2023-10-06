using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Threading;

namespace Cinema
{
    public partial class Form1 : Form
    {
        //parametre pour déplacer la fenetre -->
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        //<--jusqu'içi

        Form2 theform2;
        Form3 theform3;
        Form4 theform4;
        Form5 theform5;
        public Form1()
        {
            InitializeComponent();
        }
        //Code qui s'execute dès que le programme est ouvert
        private void Form1_Load(object sender, EventArgs e)
        {
            grdgenre.RowHeadersVisible = false;
            grdgenre.AllowUserToAddRows= false;
            grdgenre.AllowUserToResizeRows = false;
            grdgenre.AllowUserToResizeColumns = false;
            grdgenre.EditMode = DataGridViewEditMode.EditProgrammatically;
            grdgenre.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdgenre.ColumnCount = 2;
            grdgenre.Columns[0].Width = 120;
            grdgenre.Columns[1].Width = 330;
            grdgenre.Columns[0].HeaderText = "N°";
            grdgenre.Columns[1].HeaderText = "Genre";
            txtnum.Enabled = true;
            grdgenre.Rows.Clear();

            //Ouverture de la fonction pour les requêtes SQL
            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            OdbcDataReader lecteur;
            Boolean existedonnee;
            
            cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdciedekhalfevre;uid=root;pwd=";
            cnn.Open();
            cmd.CommandText = "select nogenre, libgenre from genre";
            cmd.Connection = cnn;
            lecteur = cmd.ExecuteReader();
            existedonnee = lecteur.Read();

            while (existedonnee == true)

            {

                grdgenre.Rows.Add(lecteur["nogenre"], lecteur["libgenre"]);

                existedonnee = lecteur.Read();

            }

            lecteur.Close();

            cnn.Close();


        }
        //Bouton pour ajouter des genres
        private void btnajouter_Click(object sender, EventArgs e)
        {
            //Ouverture de la fonction pour les requêtes SQL
            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            int existedonnee;

            cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdciedekhalfevre;uid=root;pwd=";
            cnn.Open();
            cmd.CommandText = "insert into genre (nogenre,libgenre) values (" + txtnum.Text + ", '" + txtnom.Text + "')";
            cmd.Connection = cnn;
            existedonnee = cmd.ExecuteNonQuery();

            if (existedonnee > 0)
            {
                lblmessage.Text = "Ajout réussi du genre n°" + txtnum.Text;
                grdgenre.Rows.Add(txtnum.Text, txtnom.Text);
            }
            else
            {
                lblmessage.Text = "Erreur ajout non effectué";
            }

            cnn.Close();
        }
        //Bouton pour supprimer des genres
        private void btnsuppr_Click(object sender, EventArgs e)
        {
            //Ouverture de la fonction pour les requêtes SQL
            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            OdbcDataReader lecteur;
            Boolean existedonnee;

            cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdciedekhalfevre;uid=root;pwd=";
            cnn.Open();
            cmd.CommandText = "delete from genre where nogenre= " + grdgenre[0, grdgenre.CurrentCell.RowIndex].Value + " ";
            cmd.Connection = cnn;
            lecteur = cmd.ExecuteReader();
            existedonnee = lecteur.Read();

            grdgenre.Rows.RemoveAt(grdgenre.CurrentCell.RowIndex);

            lecteur.Close();

            cnn.Close();
        }
        //Bouton pour rechercher des genres
        private void btnrecherche_Click(object sender, EventArgs e)
        {
            //Ouverture de la fonction pour les requêtes SQL
            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            OdbcDataReader lecteur;
            Boolean existedonnee;
            
            grdgenre.ColumnCount = 2;
            grdgenre.Columns[0].HeaderText = "N°";
            grdgenre.Columns[1].HeaderText = "Genre";
            grdgenre.Rows.Clear();

            cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdciedekhalfevre;uid=root;pwd=";
            cnn.Open();
            cmd.CommandText = "select * from genre where libgenre like '" + txtrecherche.Text + "%'";
            cmd.Connection = cnn;
            lecteur = cmd.ExecuteReader();
            existedonnee = lecteur.Read();

            while (existedonnee == true)
            {
                grdgenre.Rows.Add(lecteur["nogenre"], lecteur["libgenre"]);
                existedonnee = lecteur.Read();
            }

            lecteur.Close();
            cnn.Close();
        }
        //Bouton modifier pour modifier des genres
        private void btnmodif_Click(object sender, EventArgs e)
        {
            
            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            int existedonnee;

            cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdciedekhalfevre;uid=root;pwd=";
            cnn.Open();
            cmd.CommandText = "update genre set libgenre='" + txtnom.Text + "' where nogenre='"+txtnum.Text+"'";
            cmd.Connection = cnn;
            existedonnee = cmd.ExecuteNonQuery();

            if (existedonnee > 0)
            {
                lblmessage.Visible= true;
                lblmessage.Text = "Modification réussie du genre n°" + txtnum.Text;
                grdgenre[0, grdgenre.CurrentCell.RowIndex].Value = txtnum.Text;
                grdgenre[1, grdgenre.CurrentCell.RowIndex].Value = txtnom.Text;
            }
            else
            {
                lblmessage.Text = "Erreur suppression non effectuée\nOu pas de modification détecter";
            }

            cnn.Close();
        }

        //Ceci à été créer pour que les données de la ligne du tableau une fois cliquer soient transferer dans les textbox
        private void grdgenre_CellCenter(object sender, DataGridViewCellEventArgs e)
        {
            //Ouverture de la fonction pour les requêtes SQL
            OdbcConnection cnn = new OdbcConnection();

            OdbcCommand cmd = new OdbcCommand();

            OdbcDataReader lecteur;

            Boolean existedonnee;

            cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdciedekhalfevre;uid=root;pwd=";

            cnn.Open();

            cmd.CommandText = "select * from genre where nogenre= " + grdgenre[0, grdgenre.CurrentCell.RowIndex].Value + " ";

            cmd.Connection = cnn;

            lecteur = cmd.ExecuteReader();

            existedonnee = lecteur.Read();
            //Données à afficher dans les textbox une fois que l'on clique sur la ligne
            txtnum.Text = Convert.ToString(lecteur["nogenre"]);
            txtnom.Text = Convert.ToString(lecteur["libgenre"]);
            
                lecteur.Close();

            cnn.Close();
        }
        //Si il y'a un problème d'actualisation de tableau ou autre j'ai créer ce bouton pour
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            

            //Permet de mettre en forme le tableau (datagridview) -->
            grdgenre.ColumnCount = 2;
            grdgenre.Columns[0].HeaderText = "N°";
            grdgenre.Columns[1].HeaderText = "Genre";
            grdgenre.Rows.Clear();
            //<-- jusqu'içi

            //Ouverture de la fonction pour les requêtes SQL
            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            OdbcDataReader lecteur;
            Boolean existedonnee;

            cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdciedekhalfevre;uid=root;pwd=";

            cnn.Open();

            cmd.CommandText = "select * from genre";

            cmd.Connection = cnn;

            lecteur = cmd.ExecuteReader();

            existedonnee = lecteur.Read();

            while (existedonnee == true)

            {
                //Les données à afficher dans le tableau
                grdgenre.Rows.Add(lecteur["nogenre"], lecteur["libgenre"]);

                existedonnee = lecteur.Read();

            }

            lecteur.Close();

            cnn.Close();
            //<-- jusqu'içi
        }
        //Cette partie de code fait marcher les boutons en haut de l'application par exemple pour les catégories et se déplacer dans les autres onglets -->
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sallesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (theform2 == null || theform2.IsDisposed == true)
            {
                theform2 = new Form2();
                theform2.Show();
            }
            else
            {
                theform2.Activate();
            }
        }

        private void filmsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (theform3 == null || theform3.IsDisposed == true)
            {
                theform3 = new Form3();
                theform3.Show();
            }
            else
            {
                theform3.Activate();
            }
        }

        private void projectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (theform4 == null || theform4.IsDisposed == true)
            {
                theform4 = new Form4();
                theform4.Show();
            }
            else
            {
                theform4.Activate();
            }
        }
        private void pdfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (theform5 == null || theform5.IsDisposed == true)
            {
                theform5 = new Form5();
                theform5.Show();
            }
            else
            {
                theform5.Activate();
            }
        }
        //<-- jusqu'içi
        //Içi c'est la partie du code pour les boutons en haut a droite de l'application et pour que l'application bouge aussi-->
        private void ferme_TextChanged(object sender, EventArgs e)
        {
            Close();
        }
        private void menu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Petit_TextChanged(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Moyen_TextChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;   
            }
        }
        //<-- jusqu'içi

        
    }
}
