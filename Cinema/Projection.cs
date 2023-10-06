using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Cinema
{
    public partial class Projection : Form
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
        Salle theform2;
        Film theform3;
        Pdf theform5;

        //Initialisation des listes
        List<string> cbfilm = new List<string>();
        List<string> cbsalle = new List<string>();
        List<string> cbhoraire = new List<string>();
        //<-- jusqu'içi
        public Projection()
        {
            InitializeComponent();
        }
        //Code qui s'execute dès que le programme est ouvert
        private void Form4_Load(object sender, EventArgs e)
        {
            
            //Permet de mettre en forme le tableau (datagridview) -->
            grdgenre.RowHeadersVisible = false;
            grdgenre.AllowUserToAddRows = false;
            grdgenre.AllowUserToResizeRows = false;
            grdgenre.AllowUserToResizeColumns = false;
            grdgenre.ColumnCount = 8;
            grdgenre.Columns[0].Width = 70;
            grdgenre.Columns[1].Width = 170;
            grdgenre.Columns[2].Width = 235;
            grdgenre.Columns[3].Width = 170;
            grdgenre.Columns[4].Width = 90;
            grdgenre.Columns[5].Width = 50;
            grdgenre.Columns[6].Width = 108;
            grdgenre.Columns[7].Width = 70;
            grdgenre.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
            grdgenre.Columns[0].HeaderText = "Num";
            grdgenre.Columns[1].HeaderText = "Titre";
            grdgenre.Columns[2].HeaderText = "Description";
            grdgenre.Columns[3].HeaderText = "Public";
            grdgenre.Columns[4].HeaderText = "Genre";
            grdgenre.Columns[5].HeaderText = "Salle";
            grdgenre.Columns[6].HeaderText = "Date";
            grdgenre.Columns[7].HeaderText = "Horaire";
            grdgenre.EditMode = DataGridViewEditMode.EditProgrammatically;
            grdgenre.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdgenre.Columns[4].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            txtnum.Enabled = false;
            cbfilm.Clear();
            cbsalle.Clear();
            cbhoraire.Clear();
            grdgenre.Rows.Clear();
            cbofilm.Items.Clear();
            cbohoraire.Items.Clear();
            cbosalle.Items.Clear();

            //Ouverture de la fonction pour les requêtes SQL
            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            OdbcCommand cmd2 = new OdbcCommand();
            OdbcCommand cmd3 = new OdbcCommand();
            OdbcCommand cmd4 = new OdbcCommand();

            OdbcDataReader lecteur, lecteur2, lecteur3, lecteur4;
            Boolean existedonnee, existedonnee2, existedonnee3, existedonnee4;
            
            cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdciedehkalfevre;uid=root;pwd=";
            cnn.Open();
            //Multiple requêtes Sql
            cmd.CommandText = "select * from film natural join public";
            cmd2.CommandText = "select * from salle";
            cmd3.CommandText = "select * from concerner";
            cmd4.CommandText = "select * from projection natural join film natural join public";

            cmd.Connection = cnn;
            cmd2.Connection = cnn;
            cmd3.Connection = cnn;
            cmd4.Connection = cnn;

            lecteur = cmd.ExecuteReader();
            lecteur2 = cmd2.ExecuteReader();
            lecteur4 = cmd4.ExecuteReader();

            existedonnee = lecteur.Read();
            existedonnee2 = lecteur2.Read();
            existedonnee4 = lecteur4.Read();
            
                //Boucle qui peremt d'afficher toutes les donnée disponible par rapport au titre de films dans un combobox
                while (existedonnee == true)
                {
                    cbfilm.Add(Convert.ToString(lecteur["nofilm"]));
                    cbofilm.Items.Add(lecteur["titre"]);
                    existedonnee = lecteur.Read();
                    //lecteur.Close();
                }

                //Boucle pour ajouter dans le tableau(datagridview) toutes les données demander tel que le titre, la date, l'heure, la salle etc...
                while (existedonnee4 == true)
                {
                    grdgenre.Rows.Add(lecteur4["noproj"], lecteur4["titre"], lecteur4["infoproj"],lecteur4["libpublic"], "", lecteur4["nosalle"], lecteur4["dateproj"], lecteur4["heureproj"]);
                    
                    cmd3.CommandText = "select libgenre from genre natural join concerner where nofilm = " + lecteur4["nofilm"] + "";
                    cmd3.Connection = cnn;

                    txtnum.Text = Convert.ToString(lecteur4["noproj"]);

                    lecteur3 = cmd3.ExecuteReader();
                    existedonnee4 = lecteur4.Read();
                    existedonnee3 = lecteur3.Read();

                        while (existedonnee3 == true)
                        {
                            grdgenre[4, grdgenre.RowCount - 1].Value += lecteur3["libgenre"].ToString() + " \n";

                            existedonnee3 = lecteur3.Read();
                        }

                    lecteur3.Close();
                }

                //Permet d'afficher dans le combobox le numéro des salles
                while (existedonnee2 == true)
                {
                    cbsalle.Add(Convert.ToString(lecteur2["nosalle"]));
                    cbosalle.Items.Add(lecteur2["nosalle"]);

                    existedonnee2 = lecteur2.Read();
                }

            //Fermetures des instances Sql
            
            lecteur2.Close();
            lecteur4.Close();
            cnn.Close();

            //Boucle pour afficher les heures dans un combobox
            for (int h = 8; h<=22; h+=1)
            {
                for (int m = 00; m<=30; m+=30)
                {
                    if (m!=30)
                    {
                        int n = 0;
                        cbohoraire.Items.Add(h+":"+m+n);
                    }
                    else
                    {
                        cbohoraire.Items.Add(h + ":" + m);
                    }
                }
            }
        }

        //Bouton pour ajouter des projections
        private void btnajouter_Click(object sender, EventArgs e)
        {
            //Ouverture de la fonction pour les requêtes SQL
            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            OdbcCommand cmd2 = new OdbcCommand();
            OdbcDataReader lecteur;
            int existedonnee;

                if (cbofilm.Text != "" && cbosalle.Text != "" && dateTimePicker1.Text != "" && cbohoraire.Text != "")
                {
                    //C'est un raccourcis et a la fois un meilleur moyen pour afficher l'heure dans la requete Sql
                    
                    string cbfilms = cbfilm[cbofilm.SelectedIndex];
                    string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                    txt_desc.Text = txt_desc.Text.Replace("'", "\"");    

                    cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdciedehkalfevre;uid=root;pwd=";
                    cnn.Open();

                    //requête Sql permet de rajouter des données dans le table et dans la base donnée
                    cmd.CommandText = "insert into projection (nofilm, nosalle, dateproj, heureproj, infoproj) values ('" + cbfilms + "','" + cbosalle.Text + "','" + date + "','" + cbohoraire.Text + "','"+txt_desc.Text+"')";
                    cmd.Connection = cnn;
                    existedonnee = cmd.ExecuteNonQuery();
                    
                    //Requête Sql
                    cmd2.CommandText = "select * from film";
                    cmd2.Connection = cnn;
                    lecteur = cmd2.ExecuteReader();
                        
                        //Boucle qui permet de savoir si la projection a bien été créer
                        if (existedonnee > 0)
                        {
                            MessageBox.Show("Ajout réussi de la séance");
                            Form4_Load(sender, new EventArgs());
                        }

                        else
                        {
                            MessageBox.Show("Erreur ajout non effectué");
                        }

                        lecteur.Close();
                }

                else
                {
                    MessageBox.Show("Toutes les cases ne sont pas remplit");
                }
            
            cnn.Close();
        }
        
        //Bouton pour supprimer des projections
        private void btnsuppr_Click(object sender, EventArgs e)
        {
            //Ouverture de la fonction pour les requêtes SQL
            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            OdbcDataReader lecteur;
            Boolean existedonnee;

            cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdciedehkalfevre;uid=root;pwd=";
            cnn.Open();

            if (grdgenre.Rows.Count > 0)
            {
                cmd.CommandText = "delete from projection where noproj= '" + grdgenre[0, grdgenre.CurrentCell.RowIndex].Value + "' ";
                cmd.Connection = cnn;

                //Sécurité pour que le programme e crash ps s'il n'y a aucune donnée presente dans les textbox
                if (cbofilm.Text != "" && cbosalle.Text != "")
                {
                    lecteur = cmd.ExecuteReader();
                    existedonnee = lecteur.Read();
                    //Requête Sql pour supprimer les lignes de la base de donnée aussi
                    grdgenre.Rows.RemoveAt(grdgenre.CurrentCell.RowIndex);
                    lecteur.Close();
                }

                else
                {
                    MessageBox.Show("Toutes les cases ne sont pas remplit");
                }

                cnn.Close();
            }
            
            
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

            //Requête Sql pour séléctionner les données en rapport avec le numéro du projet et de les rajouter dans les textbox
            cmd.CommandText = "select * from projection natural join film natural join salle where noproj='" + grdgenre[0, grdgenre.CurrentCell.RowIndex].Value + "'";
            cmd.Connection = cnn;
            lecteur = cmd.ExecuteReader();
            existedonnee = lecteur.Read();

            //Donner ajouter dans les textbox
            txtnum.Text = Convert.ToString(lecteur["noproj"]);
            cbofilm.Text = Convert.ToString(lecteur["titre"]);
            cbosalle.Text = Convert.ToString(lecteur["nosalle"]);
            dateTimePicker1.Text = Convert.ToString(lecteur["dateproj"]);
            cbohoraire.Text = Convert.ToString(lecteur["heureproj"]);

            lecteur.Close();
            cnn.Close();
        }

        //Bouton pour rechercher des projections
        private void btnrecherche_Click(object sender, EventArgs e)
        {
            //Ouverture de la fonction pour les requêtes SQL
            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            OdbcCommand cmd2 = new OdbcCommand();
            OdbcCommand cmd3 = new OdbcCommand();
            OdbcDataReader lecteur, lecteur2, lecteur3;
            Boolean existedonnee, existedonnee2, existedonnee3;

            grdgenre.Rows.Clear();

            cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdciedehkalfevre;uid=root;pwd=";
            cnn.Open();

            //Requête Sql
            cmd.CommandText = "select * from projection natural join film natural join public natural join salle where titre like '" + txtrecherche.Text + "%' and noproj like '" + txtnum_find.Text + "%'";
            cmd.Connection = cnn;

            //Requête Sql
            cmd3.CommandText = "select * from genre natural join salle natural join public";
            cmd3.Connection = cnn;

                //Sécurité pour que le programme ne crash pas
                if (cbofilm.Text != "" && cbosalle.Text != "")
                {
                    lecteur = cmd.ExecuteReader();
                    existedonnee = lecteur.Read();
                    lecteur3 = cmd3.ExecuteReader();
                    existedonnee3 = lecteur3.Read();

                        //Boucle pour actualiser la liste dans le tableau par rapport à ce qui a été rechercher dans le textbox
                        while (existedonnee == true)
                        {
                            grdgenre.Rows.Add(lecteur["noproj"], lecteur["titre"], lecteur["infoproj"],lecteur["libpublic"], "", lecteur["nosalle"], lecteur["dateproj"], lecteur["heureproj"]);

                            cmd2.CommandText = "select libgenre from genre natural join concerner where nofilm = " + lecteur["nofilm"] + "";
                            cmd2.Connection = cnn;
                            lecteur2 = cmd2.ExecuteReader();
                            existedonnee = lecteur.Read();
                            existedonnee2 = lecteur2.Read();
                                
                                //Boucle pour afficher les différents genres dans la même case
                                while (existedonnee2 == true)
                                {
                                    grdgenre[4, grdgenre.RowCount - 1].Value += lecteur2["libgenre"].ToString() + " ";
                                    existedonnee2 = lecteur2.Read();
                                }

                            lecteur2.Close();
                        }

                    lecteur.Close();
                }

                else
                {
                    MessageBox.Show("Toutes les cases ne sont pas remplit");
                }

            cnn.Close();
        }

        //Cette partie de code fait marcher les boutons en haut de l'application par exemple pour les catégories et se déplacer dans les autres onglets -->
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void genreToolStripMenuItem_Click(object sender, EventArgs e)
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
