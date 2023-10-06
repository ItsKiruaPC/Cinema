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
    public partial class Genre : Form
    {
        //parametre pour déplacer la fenetre -->
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        //<--jusqu'içi

        //Code utile pour ce déplacer dans les autres forms voir tout en bas
        Salle theform2;
        Film theform3;
        Projection theform4;
        Pdf theform5;
        public Genre()
        {
            InitializeComponent();
        }
        //Code qui s'execute dès que le programme est ouvert
        private void Form1_Load(object sender, EventArgs e)
        {
            //Permet de mettre en forme le tableau (datagridview) -->
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
            txtnum.Enabled = false;
            grdgenre.Rows.Clear();

            //Ouverture de la fonction pour les requêtes SQL
            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            OdbcDataReader lecteur;
            Boolean existedonnee;
            
            cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdciedehkalfevre;uid=root;pwd=";
            cnn.Open();

            //Requête de Sql pour séléctioner les numéros de genre et les libéllés
            cmd.CommandText = "select nogenre, libgenre from genre";
            cmd.Connection = cnn;
            lecteur = cmd.ExecuteReader();
            existedonnee = lecteur.Read();

                //Boucle pour afficher dans le tableau les données existante de la requête Sql
                while (existedonnee == true)
                {
                    grdgenre.Rows.Add(lecteur["nogenre"], lecteur["libgenre"]);
                    existedonnee = lecteur.Read();
                }

            //Fermeture du Sql
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
            
            if (txtnum.Text == grdgenre[0, grdgenre.CurrentCell.RowIndex].Value.ToString())
            {
                cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdciedehkalfevre;uid=root;pwd=";
                cnn.Open();

                txtnom.Text = txtnom.Text.Replace("'", "\"");
                //Requête Sql pour ajouter des données(numéro de genre et libéllé) dans la base de donnée 
                cmd.CommandText = "insert into genre (libgenre) values ('" + txtnom.Text + "')";
                cmd.Connection = cnn;
                existedonnee = cmd.ExecuteNonQuery();

                //Boucle pour afficher si les données ont bien été saisie dans la base de donnée et l'afficher dans le tableau
                if (existedonnee > 0)
                {
                    lblmessage.Text = "Ajout réussi du genre n°" + txtnum.Text;
                    grdgenre.Rows.Add(txtnum.Text, txtnom.Text);
                }

                //Sinon alors afficher un message d'erreur
                else
                {
                    lblmessage.Text = "Erreur ajout non effectué";
                }

                
                
            }
            else
            {
                MessageBox.Show("Le genre que vous souhaiter ajouter à déjà un numéro existant");
            }

            //Fermeture du Sql
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

            cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdciedehkalfevre;uid=root;pwd=";
            cnn.Open();

            //Requête Sql pour supprimer les données séléctionner dans le tableau correspondant dans la base de donnée
            cmd.CommandText = "delete from genre where nogenre= " + grdgenre[0, grdgenre.CurrentCell.RowIndex].Value + " ";
            cmd.Connection = cnn;
            lecteur = cmd.ExecuteReader();
            existedonnee = lecteur.Read();

            //Permet de supprimer la ligne séléctionner dans le tableau
            grdgenre.Rows.RemoveAt(grdgenre.CurrentCell.RowIndex);

            //Fermeture du Sql
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

            //Permet de mettre en forme le tableau (datagridview) -->
            grdgenre.ColumnCount = 2;
            grdgenre.Columns[0].HeaderText = "N°";
            grdgenre.Columns[1].HeaderText = "Genre";
            grdgenre.Rows.Clear();

            cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdciedehkalfevre;uid=root;pwd=";
            cnn.Open();

            //Requête Sql pour séléctionner les données correspondant à la recherche
            cmd.CommandText = "select * from genre where libgenre like '" + txtrecherche.Text + "%'";
            cmd.Connection = cnn;
            lecteur = cmd.ExecuteReader();
            existedonnee = lecteur.Read();

                //Boucle pour afficher dans le tableau les données s'il en y a, associé à la requête Sql
                while (existedonnee == true)
                {
                    grdgenre.Rows.Add(lecteur["nogenre"], lecteur["libgenre"]);
                    existedonnee = lecteur.Read();
                }

            //Fermeture du Sql
            lecteur.Close();
            cnn.Close();
        }
        //Bouton modifier pour modifier des genres
        private void btnmodif_Click(object sender, EventArgs e)
        {
            //Ouverture de la fonction pour les requêtes SQL
            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            int existedonnee;

            cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdciedehkalfevre;uid=root;pwd=";
            cnn.Open();

            //Requête Sql pour mettre à jour les données en fonction de ce qui est écrit dans les textbox
            cmd.CommandText = "update genre set libgenre='" + txtnom.Text + "' where nogenre='"+txtnum.Text+"'";
            cmd.Connection = cnn;
            existedonnee = cmd.ExecuteNonQuery();

                //Boucle pour modifier les données dans le tableau s'il y en a, et afficher un message
                if (existedonnee > 0)
                {
                    lblmessage.Visible= true;
                    lblmessage.Text = "Modification réussie du genre n°" + txtnum.Text;
                    grdgenre.Rows.Add(txtnum.Text, txtnom.Text);
                    grdgenre[0, grdgenre.CurrentCell.RowIndex].Value = txtnum.Text;
                    grdgenre[1, grdgenre.CurrentCell.RowIndex].Value = txtnom.Text;
                }

                //Sinon afficher un message comme quoi il n'y a pas eu de modificaton
                else
                {
                    lblmessage.Text = "Erreur pas de modification détecter";
                }

            //Fermeture du Sql
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

            cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdciedehkalfevre;uid=root;pwd=";
            cnn.Open();

            //Requête Sql pour séléctionner les données de la table genre en fonction de la ligne séléctionner dans le tableau (datagridview)
            cmd.CommandText = "select * from genre where nogenre= " + grdgenre[0, grdgenre.CurrentCell.RowIndex].Value + " ";
            cmd.Connection = cnn;
            lecteur = cmd.ExecuteReader();
            existedonnee = lecteur.Read();

            //Données à afficher dans les textbox une fois que l'on clique sur la ligne
            txtnum.Text = Convert.ToString(lecteur["nogenre"]);
            txtnom.Text = Convert.ToString(lecteur["libgenre"]);
            
            //Fermeture du Sql
            lecteur.Close();
            cnn.Close();
        }
        //J'ai créer ce bouton pour si, il y a un problème d'actualisation de tableau ou autre
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

            cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdciedehkalfevre;uid=root;pwd=";
            cnn.Open();

            //Requête Sql qui séléctionner les données dans la table genre
            cmd.CommandText = "select * from genre";
            cmd.Connection = cnn;
            lecteur = cmd.ExecuteReader();
            existedonnee = lecteur.Read();

                //Boucle qui s'effectue s'il y a des données
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
                theform2 = new Salle();
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
                theform3 = new Film();
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
                theform4 = new Projection();
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
                theform5 = new Pdf();
                theform5.Show();
            }
            else
            {
                theform5.Activate();
            }
        }
        //<-- jusqu'içi

        //Içi c'est la partie du code pour les boutons en haut a droite de l'application et pour que l'application bouge aussi-->
        private void menu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btn_Petit_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Moyen_Click(object sender, EventArgs e)
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

        private void btn_Fermer_Click(object sender, EventArgs e)
        {
            Close();
        }
        //<-- jusqu'içi
    }
}
