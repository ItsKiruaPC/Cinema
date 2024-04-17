using System;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Cinema
{
    public partial class Salle : Form
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
        Genre theform1;
        Film theform3;
        Projection theform4;
        Pdf theform5;
        public Salle()
        {
            InitializeComponent();
        }
        //Code qui s'execute dès que le programme est ouvert
        private void Form2_Load(object sender, EventArgs e)
        {
            //Permet de mettre en forme le tableau (datagridview) -->
            grdgenre.RowHeadersVisible = false;
            grdgenre.AllowUserToAddRows = false;
            grdgenre.AllowUserToResizeRows = false;
            grdgenre.AllowUserToResizeColumns = false;
            txtnum.Enabled = false;
            grdgenre.EditMode = DataGridViewEditMode.EditProgrammatically;
            grdgenre.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdgenre.ColumnCount = 2;
            grdgenre.Columns[0].Width = 120;
            grdgenre.Columns[1].Width = 330;
            grdgenre.Columns[0].HeaderText = "Salle";
            grdgenre.Columns[1].HeaderText = "Places";


            //Ouverture de la fonction pour les requêtes SQL
            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            OdbcDataReader lecteur;
            Boolean existedonnee;

            //Permet de supprimer les lignes
            grdgenre.Rows.Clear();

            cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdciedehkalfevre;uid=root;pwd=";
            cnn.Open();

            //Requête Sql qui permet d'afficher les catégories numéro de salle et le nombre de place de la table salle
            cmd.CommandText = "select nosalle, nbplaces from salle";
            cmd.Connection = cnn;
            lecteur = cmd.ExecuteReader();
            existedonnee = lecteur.Read();

                //Boucle pour s'il y a des données alors les ajouter dans le tableau
                while (existedonnee == true)
                {
                    grdgenre.Rows.Add(lecteur["nosalle"], lecteur["nbplaces"]);
                    existedonnee = lecteur.Read();
                }

            //Ferme la requête Sql
            lecteur.Close();
            cnn.Close();
        }

        //Bouton pour ajouter des salles
        private void btnajouter_Click_1(object sender, EventArgs e)
        {
            //Ouverture de la fonction pour les requêtes SQL
            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            int existedonnee;

            if (txtnum.Text != grdgenre[0, grdgenre.CurrentCell.RowIndex].Value.ToString())
            {
                cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdciedehkalfevre;uid=root;pwd=";
                cnn.Open();

                //Requête Sql pour inserer une nouvelle salle avec un numéro de salle et un nombre de place
                cmd.CommandText = "insert into salle (nosalle,nbplaces) values ('" + txtnum.Text + "', '" + txtnom.Text + "')";
                cmd.Connection = cnn;
                existedonnee = cmd.ExecuteNonQuery();

                //Boucle pour afficher si toutes les données ont été insérer alors afficher que cela a marcher grâce à un message
                if (existedonnee > 0)
                {
                    lblmessage.Text = "Ajout réussi de la salle n°" + txtnum.Text;
                    grdgenre.Rows.Add(txtnum.Text, txtnom.Text);
                }
                //Si les données n'ont pas été alors il affiche un message pour dire que cela ne marche pas
                else
                {
                    lblmessage.Text = "Erreur ajout non effectué";
                }

                //Fermeture de la requête Sql
                cnn.Close();
            }
            
            
        }

        //Bouton pour supprimer des salles
        private void btnsuppr_Click_1(object sender, EventArgs e)
        {
            //Ouverture de la fonction pour les requêtes SQL
            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            OdbcDataReader lecteur;
            Boolean existedonnee;

            cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdciedehkalfevre;uid=root;pwd=";
            cnn.Open();

            //Requête Sql pour supprimer la table séléctioner dans la base de donnée
            cmd.CommandText = "delete from salle where nosalle= '" + grdgenre[0, grdgenre.CurrentCell.RowIndex].Value + "' ";
            cmd.Connection = cnn;
            lecteur = cmd.ExecuteReader();
            existedonnee = lecteur.Read();

            //Permet de supprimer la line séléctionné dans le tableau
            grdgenre.Rows.RemoveAt(grdgenre.CurrentCell.RowIndex);

            lecteur.Close();
            cnn.Close();
        }

        //Bouton pour rechercher des salles
        private void btnrecherche_Click(object sender, EventArgs e)
        {
            //Ouverture de la fonction pour les requêtes SQL
            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            OdbcDataReader lecteur;
            Boolean existedonnee;

            //Permet de mettre en forme le tableau (datagridview) -->
            grdgenre.ColumnCount = 2;
            grdgenre.Columns[0].HeaderText = "Salle";
            grdgenre.Columns[1].HeaderText = "Places";
            grdgenre.Rows.Clear();

            cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdciedehkalfevre;uid=root;pwd=";
            cnn.Open();

            //Requête Sql pour séléctionner les salles correspondant à la recherche
            cmd.CommandText = "select * from salle where nosalle like ?";
            cmd.Parameters.AddWithValue("1", "%" + txtrecherche.Text + "%");
            cmd.Connection = cnn;
            lecteur = cmd.ExecuteReader();
            existedonnee = lecteur.Read();

            //Boucle qui affiche s'il y a des données alors les ajouter dans le tableau
            while (existedonnee == true)
                {
                    grdgenre.Rows.Add(lecteur["nosalle"], lecteur["nbplaces"]);
                    existedonnee = lecteur.Read();
                }

            //Fermeture de la requête Sql
            lecteur.Close();
            cnn.Close();
        }

        //Bouton modifier pour modifier des salles
        private void btnmodif_Click_1(object sender, EventArgs e)
        {
            //Ouverture de la fonction pour les requêtes SQL
            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            int existedonnee;

            cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdciedehkalfevre;uid=root;pwd=";
            cnn.Open();

            //Requête Sql qui modifier les données dans la base de donnée par celle écrite dans les textbox
            cmd.CommandText = "update salle set nbplaces='" + txtnom.Text + "' where nosalle='" + txtnum.Text + "'";
            cmd.Connection = cnn;
            existedonnee = cmd.ExecuteNonQuery();

                //s'il y a des données modifié alors il affichera un message pour le dire
                if (existedonnee > 0)
                {
                    lblmessage.Visible = true;
                    lblmessage.Text = "Modification réussie de la salle n°" + txtnum.Text;
                    grdgenre.Rows.Add(txtnum.Text, txtnom.Text);
                }

                //s'il y a des données qui n'ont pas pu être modifié il affichera un message l'expliquant
                else
                {
                    lblmessage.Text = "Erreur pas de modification détecter";
                }

            //Fermeture du Sql
            cnn.Close();
        }

        //Ceci à été créer pour que les données de la ligne du tableau une fois cliquer soient transferer dans les textbox
        private void grdgenre_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Ouverture de la fonction pour les requêtes SQL
            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            OdbcDataReader lecteur;
            Boolean existedonnee;

            cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdciedehkalfevre;uid=root;pwd=";
            cnn.Open();

            //Requête Sql qui permet d'afficher toutes les informations correspondant au numéro de film de ligne séléctionné
            cmd.CommandText = "select * from salle where nosalle= '" + grdgenre[0, grdgenre.CurrentCell.RowIndex].Value + "' ";
            cmd.Connection = cnn;
            lecteur = cmd.ExecuteReader();
            existedonnee = lecteur.Read();

            //Permet d'afficher le contenu des données récuperer dans la requête Sql est de les affichers dans les textbox
            txtnum.Text = Convert.ToString(lecteur["nosalle"]);
            txtnom.Text = Convert.ToString(lecteur["nbplaces"]);

            //Fermeture du Sql
            lecteur.Close();
            cnn.Close();
        }

        //J'ai créer ce bouton pour si, il y a un problème d'actualisation de tableau ou autre
        private void btn_refresh_Click_1(object sender, EventArgs e)
        {
            //Ouverture de la fonction pour les requêtes SQL
            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            OdbcDataReader lecteur;
            Boolean existedonnee;

            //Permet de mettre en forme le tableau (datagridview) -->
            grdgenre.ColumnCount = 2;
            grdgenre.Columns[0].HeaderText = "Salle";
            grdgenre.Columns[1].HeaderText = "Places";
            grdgenre.Rows.Clear();

            cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdciedehkalfevre;uid=root;pwd=";
            cnn.Open();

            //Requête Sql qui permet de séléctionner toutes les données disponible dans la table salle
            cmd.CommandText = "select * from salle";
            cmd.Connection = cnn;
            lecteur = cmd.ExecuteReader();
            existedonnee = lecteur.Read();

                //Boucle pour afficher les données s'il y en a dans la table
                while (existedonnee == true)
                {
                    grdgenre.Rows.Add(lecteur["nosalle"], lecteur["nbplaces"]);
                    existedonnee = lecteur.Read();
                }

            //Fermeture du Sql
            lecteur.Close();
            cnn.Close();
        }
        //Cette partie de code fait marcher les boutons en haut de l'application par exemple pour les catégories et se déplacer dans les autres onglets -->
        private void quitterToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void genreToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (theform1 == null || theform1.IsDisposed == true)
            {
                theform1 = new Genre();
                theform1.Show();
            }
            else
            {
                theform1.Activate();
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
        private void menu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        //<-- jusqu'içi
    }
}
