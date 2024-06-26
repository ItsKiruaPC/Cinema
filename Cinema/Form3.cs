﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class Form3 : Form
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
        Form2 theform2;
        Form4 theform4;
        Form5 theform5;
        
        //Initialisation des listes
        List<string> cbpubs = new List<string>();
        List<string> lsgenres = new List<string>();
        //<-- jusqu'içi
        public Form3()
        {
            InitializeComponent();
        }
        //Code qui s'execute dès que le programme est ouvert
        private void Form3_Load(object sender, EventArgs e)
        {
            
            grdgenre.RowHeadersVisible = false;
            grdgenre.AllowUserToAddRows = false;
            grdgenre.AllowUserToResizeRows = false;
            grdgenre.AllowUserToResizeColumns = false;
            grdgenre.EditMode = DataGridViewEditMode.EditProgrammatically;
            grdgenre.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            lst_genre.SelectionMode = SelectionMode.MultiSimple;
            grdgenre.ColumnCount = 4;
            grdgenre.Columns[0].Width = 40;
            grdgenre.Columns[1].Width = 150;
            grdgenre.Columns[2].Width = 170;
            grdgenre.Columns[3].Width = 108;
            grdgenre.Columns[0].HeaderText = "N°";
            grdgenre.Columns[1].HeaderText = "Film";
            grdgenre.Columns[2].HeaderText = "Public";
            grdgenre.Columns[3].HeaderText = "Genre";
            txtnum.Enabled = false;
            grdgenre.Rows.Clear();
            
            
            //-------------------------------------------------------------------
            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            OdbcCommand cmd2 = new OdbcCommand();
            OdbcCommand cmd3 = new OdbcCommand();
            OdbcCommand cmd4 = new OdbcCommand();
            OdbcDataReader lecteur, lecteur2, lecteur3, lecteur4;
            Boolean existedonnee, existedonnee2, existedonnee3, existedonnee4;

            
            cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdciedekhalfevre;uid=root;pwd=";
            cnn.Open();

            int num = Convert.ToInt32(grdgenre.Rows.Count);

            cmd.CommandText = "select * from public";
            cmd2.CommandText = "select * from film inner join public on film.nopublic=public.nopublic";
            cmd3.CommandText = "select * from genre";
            cmd4.CommandText = "select * from concerner";

            cmd.Connection = cnn;
            cmd2.Connection = cnn;
            cmd3.Connection = cnn;
            cmd4.Connection = cnn;

            lecteur = cmd.ExecuteReader();
            lecteur2 = cmd2.ExecuteReader();
            lecteur3 = cmd3.ExecuteReader();

            existedonnee = lecteur.Read();
            existedonnee2 = lecteur2.Read();
            existedonnee3 = lecteur3.Read();

            txtnum.Text = Convert.ToString(num);

            while (existedonnee == true)
            {

                cbpubs.Add(Convert.ToString(lecteur["nopublic"]));
                cb_public.Items.Add(lecteur["libpublic"]);
                existedonnee = lecteur.Read();

            }


            while (existedonnee2 == true)
            {

                grdgenre.Rows.Add(lecteur2["nofilm"], lecteur2["titre"],lecteur2["libpublic"], "");
                cmd4.CommandText = "select libgenre from genre natural join concerner where nofilm = " + lecteur2["nofilm"] + "";
                cmd4.Connection = cnn;
                lecteur4 = cmd4.ExecuteReader();
                existedonnee4 = lecteur4.Read();

                while (existedonnee4 == true)
                {
                    grdgenre[3, grdgenre.RowCount - 1].Value += lecteur4["libgenre"].ToString() + " \n";
                    existedonnee4 = lecteur4.Read();
                }
                
                lecteur4.Close();
                existedonnee2 = lecteur2.Read();

            }
                

            while (existedonnee3 == true)
            {
                lsgenres.Add(Convert.ToString(lecteur3["nogenre"]));
                lst_genre.Items.Add(lecteur3["libgenre"]);
                existedonnee3 = lecteur3.Read();

            }

            lecteur.Close();
            lecteur2.Close();
            lecteur3.Close();
            
            cnn.Close();

            grdgenre.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            OdbcCommand cmd2 = new OdbcCommand();
            OdbcCommand cmd3 = new OdbcCommand();
            OdbcCommand cmd4 = new OdbcCommand();
            int existedonnee;

            cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdciedekhalfevre;uid=root;pwd=";
            cnn.Open();

            if (txtnom.Text != "" && txtnum.Text != "" && cb_public.Text != "" && lst_genre.Text != "")
            {
                string strgenres = "";
                string cbpub = cbpubs[cb_public.SelectedIndex];

                cmd.CommandText = "insert into film (titre,nopublic) values ('" + txtnom.Text + "'," + cbpub + ")";
                cmd.Connection = cnn;
                existedonnee = cmd.ExecuteNonQuery();
                cmd3.CommandText = "select max(nofilm) from film";
                cmd3.Connection = cnn;
                int noderfilm = Convert.ToInt32(cmd3.ExecuteScalar());

                for (int i=0; i< lst_genre.Items.Count; i++)
                {

                    if (lst_genre.GetSelected(i) == true)
                    {
                        cmd4.CommandText = "insert into concerner(nofilm, nogenre) values ('"+ noderfilm +"', '" + lsgenres[i]+"')";
                        cmd4.Connection = cnn;
                        cmd4.ExecuteNonQuery();
                        strgenres += lst_genre.Items[i].ToString()+" ";

                    }

                }      

                if (existedonnee > 0)
                {
                    MessageBox.Show("Ajout réussi du film");
                    Form3_Load(sender, new EventArgs());
                }

                else
                {
                    MessageBox.Show("Erreur ajout non effectué");
                }

            }

            else
            {
                MessageBox.Show("Toutes les cases ne sont pas remplit");
            }
            cnn.Close();
        }
        private void btnsuppr_Click(object sender, EventArgs e)
        {
            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            OdbcCommand cmd2 = new OdbcCommand();
            OdbcDataReader lecteur, lecteur2;
            Boolean existedonnee, existedonnee2;

            cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdciedekhalfevre;uid=root;pwd=";
            cnn.Open();

            cmd.CommandText = "delete from film where nofilm= " + grdgenre[0, grdgenre.CurrentCell.RowIndex].Value + " ";
            cmd.Connection = cnn;

            cmd2.CommandText = "delete from concerner where nofilm= " + grdgenre[0, grdgenre.CurrentCell.RowIndex].Value + " ";
            cmd2.Connection = cnn;

            if (txtnom.Text != "" && txtnum.Text != "")
            {
                lecteur2 = cmd2.ExecuteReader();
                lecteur = cmd.ExecuteReader();
                

                existedonnee = lecteur.Read();
                existedonnee2 = lecteur2.Read();
                grdgenre.Rows.RemoveAt(grdgenre.CurrentCell.RowIndex);
                lecteur.Close();
                lecteur2.Close();
            }

            else
            {
                MessageBox.Show("Toutes les cases ne sont pas remplit");
            }

            cnn.Close();
        }

        private void btnrecherche_Click(object sender, EventArgs e)
        {
            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            OdbcCommand cmd2 = new OdbcCommand();
            OdbcDataReader lecteur, lecteur2;
            Boolean existedonnee, existedonnee2;


            grdgenre.ColumnCount = 4;
            grdgenre.Columns[0].HeaderText = "N°";
            grdgenre.Columns[1].HeaderText = "Film";
            grdgenre.Columns[2].HeaderText = "Public";
            grdgenre.Columns[3].HeaderText = "Genre";
            grdgenre.Rows.Clear();

            cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdciedekhalfevre;uid=root;pwd=";
            cnn.Open();

            cmd.CommandText = "select * from film inner join public on film.nopublic=public.nopublic where titre like '" + txtrecherche.Text + "%'";
            cmd2.CommandText = "select * from genre";
            cmd.Connection = cnn;
            cmd2.Connection = cnn;

            if (txtnom.Text != "" && txtnum.Text != "")
            {
                lecteur = cmd.ExecuteReader();
                lecteur2 = cmd2.ExecuteReader();
                existedonnee = lecteur.Read();
                existedonnee2 = lecteur2.Read();

                while (existedonnee == true)
                {

                    grdgenre.Rows.Add(lecteur["nofilm"], lecteur["titre"], lecteur["libpublic"], lecteur2["libgenre"]);

                    existedonnee = lecteur.Read();
                    existedonnee2 = lecteur2.Read();

                }

                lecteur.Close();
                lecteur2.Close();
            }

            else
            {
                MessageBox.Show("Toutes les cases ne sont pas remplit");
            }

            cnn.Close();
        }
        private void grdgenre_CellCenter(object sender, DataGridViewCellEventArgs e)
        {
            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            OdbcDataReader lecteur;

            Boolean existedonnee;
            lst_genre.SelectedIndex = -1;

            int num = Convert.ToInt32(grdgenre.Rows.Count);
            cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdciedekhalfevre;uid=root;pwd=";
            cnn.Open();

            cmd.CommandText = "select * from film inner join public on film.nopublic=public.nopublic where nofilm= '" + grdgenre[0, grdgenre.CurrentCell.RowIndex].Value + "'";

            cmd.Connection = cnn;

            lecteur = cmd.ExecuteReader();
            existedonnee = lecteur.Read();

            txtnum.Text = Convert.ToString(lecteur["nofilm"]);
            txtnom.Text = Convert.ToString(lecteur["titre"]);
            cb_public.Text = Convert.ToString(lecteur["libpublic"]);

            lecteur.Close();

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
                theform1 = new Form1();
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
                theform2 = new Form2();
                theform2.Show();
            }

            else
            {
                theform2.Activate();
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
