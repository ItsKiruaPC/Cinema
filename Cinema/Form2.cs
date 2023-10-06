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
    public partial class Form2 : Form
    {
        //parametre pour déplacer la fenetre -->
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        //<--jusqu'içi

        Form1 theform1;
        Form3 theform3;
        Form4 theform4;
        Form5 theform5;
        public Form2()
        {
            InitializeComponent();
        }
        //Code qui s'execute dès que le programme est ouvert
        private void Form2_Load(object sender, EventArgs e)
        {
            grdgenre.RowHeadersVisible = false;
            grdgenre.AllowUserToAddRows = false;
            grdgenre.AllowUserToResizeRows = false;
            grdgenre.AllowUserToResizeColumns = false;
            grdgenre.EditMode = DataGridViewEditMode.EditProgrammatically;
            grdgenre.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdgenre.ColumnCount = 2;
            grdgenre.Columns[0].Width = 120;
            grdgenre.Columns[1].Width = 330;
            grdgenre.Columns[0].HeaderText = "Salle";
            grdgenre.Columns[1].HeaderText = "Places";
            
            
            
            OdbcConnection cnn = new OdbcConnection();

            OdbcCommand cmd = new OdbcCommand();

            OdbcDataReader lecteur;

            Boolean existedonnee;

            grdgenre.Rows.Clear();

            cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdciedekhalfevre;uid=root;pwd=";

            cnn.Open();

            cmd.CommandText = "select nosalle, nbplaces from salle";

            cmd.Connection = cnn;

            lecteur = cmd.ExecuteReader();

            existedonnee = lecteur.Read();

            while (existedonnee == true)

            {

                grdgenre.Rows.Add(lecteur["nosalle"], lecteur["nbplaces"]);

                existedonnee = lecteur.Read();

            }

            lecteur.Close();

            cnn.Close();


        }

        private void btnajouter_Click_1(object sender, EventArgs e)
        {
            OdbcConnection cnn = new OdbcConnection();

            OdbcCommand cmd = new OdbcCommand();

            int existedonnee;

            cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdciedekhalfevre;uid=root;pwd=";

            cnn.Open();

            cmd.CommandText = "insert into salle (nosalle,nbplaces) values ('" + txtnum.Text + "', '" + txtnom.Text + "')";

            cmd.Connection = cnn;

            existedonnee = cmd.ExecuteNonQuery();

            if (existedonnee > 0)
            {
                lblmessage.Text = "Ajout réussi de la salle n°" + txtnum.Text;
                grdgenre.Rows.Add(txtnum.Text, txtnom.Text);


            }
            else
            {
                lblmessage.Text = "Erreur ajout non effectué";
            }



            cnn.Close();
        }

        private void btnsuppr_Click_1(object sender, EventArgs e)
        {
            OdbcConnection cnn = new OdbcConnection();

            OdbcCommand cmd = new OdbcCommand();

            OdbcDataReader lecteur;

            Boolean existedonnee;

            cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdciedekhalfevre;uid=root;pwd=";

            cnn.Open();

            cmd.CommandText = "delete from salle where nosalle= '" + grdgenre[0, grdgenre.CurrentCell.RowIndex].Value + "' ";

            cmd.Connection = cnn;

            lecteur = cmd.ExecuteReader();

            existedonnee = lecteur.Read();
            grdgenre.Rows.RemoveAt(grdgenre.CurrentCell.RowIndex);
            lecteur.Close();

            cnn.Close();
        }

        private void btnrecherche_Click(object sender, EventArgs e)
        {
            OdbcConnection cnn = new OdbcConnection();

            OdbcCommand cmd = new OdbcCommand();

            OdbcDataReader lecteur;

            Boolean existedonnee;


            grdgenre.ColumnCount = 2;
            grdgenre.Columns[0].HeaderText = "Salle";
            grdgenre.Columns[1].HeaderText = "Places";
            grdgenre.Rows.Clear();

            cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdciedekhalfevre;uid=root;pwd=";

            cnn.Open();

            cmd.CommandText = "select * from salle where nosalle like '" + txtrecherche.Text + "%'";

            cmd.Connection = cnn;

            lecteur = cmd.ExecuteReader();

            existedonnee = lecteur.Read();

            while (existedonnee == true)

            {

                grdgenre.Rows.Add(lecteur["nosalle"], lecteur["nbplaces"]);

                existedonnee = lecteur.Read();

            }

            lecteur.Close();

            cnn.Close();
        }

        private void btnmodif_Click_1(object sender, EventArgs e)
        {
            int existedonnee;
            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdciedekhalfevre;uid=root;pwd=";
            cnn.Open();
            cmd.CommandText = "update salle set nbplaces='" + txtnom.Text + "' where nosalle='" + txtnum.Text + "'";
            cmd.Connection = cnn;
            existedonnee = cmd.ExecuteNonQuery();
            if (existedonnee > 0)
            {
                lblmessage.Visible = true;
                lblmessage.Text = "Modification réussie de la salle n°" + txtnum.Text;
                

            }
            else
            {
                lblmessage.Text = "Erreur suppression non effectuée\nOu pas de modification détecter";
            }

            cnn.Close();
        }

        private void grdgenre_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            OdbcConnection cnn = new OdbcConnection();

            OdbcCommand cmd = new OdbcCommand();

            OdbcDataReader lecteur;

            Boolean existedonnee;

            cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdciedekhalfevre;uid=root;pwd=";

            cnn.Open();

            cmd.CommandText = "select * from salle where nosalle= '" + grdgenre[0, grdgenre.CurrentCell.RowIndex].Value + "' ";

            cmd.Connection = cnn;

            lecteur = cmd.ExecuteReader();

            existedonnee = lecteur.Read();

            txtnum.Text = Convert.ToString(lecteur["nosalle"]);
            txtnom.Text = Convert.ToString(lecteur["nbplaces"]);

            lecteur.Close();

            cnn.Close();
        }
        private void lblmessage_Click(object sender, EventArgs e)
        {
            lblmessage.Visible = false;
        }

        private void btn_refresh_Click_1(object sender, EventArgs e)
        {
            OdbcConnection cnn = new OdbcConnection();

            OdbcCommand cmd = new OdbcCommand();

            OdbcDataReader lecteur;

            Boolean existedonnee;


            grdgenre.ColumnCount = 2;
            grdgenre.Columns[0].HeaderText = "Salle";
            grdgenre.Columns[1].HeaderText = "Places";
            grdgenre.Rows.Clear();

            cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdciedekhalfevre;uid=root;pwd=";

            cnn.Open();

            cmd.CommandText = "select * from salle";

            cmd.Connection = cnn;

            lecteur = cmd.ExecuteReader();

            existedonnee = lecteur.Read();

            while (existedonnee == true)

            {

                grdgenre.Rows.Add(lecteur["nosalle"], lecteur["nbplaces"]);

                existedonnee = lecteur.Read();

            }

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
                theform1 = new Form1();
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

        private void Petit_TextChanged(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
