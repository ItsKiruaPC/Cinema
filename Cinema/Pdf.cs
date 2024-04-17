using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.Odbc;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Cinema
{
    public partial class Pdf : Form
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
        Projection theform4;

        //Initialisation des listes
        List<string> cbfilm = new List<string>();
        List<string> cbhoraire = new List<string>();
        List<string> cbdate = new List<string>();
        List<string> lesgenres = new List<string>();
        //<-- jusqu'içi
        public Pdf()
        {
            InitializeComponent();
        }
        //Code qui s'execute dès que le programme est ouvert
        private void Form5_Load(object sender, EventArgs e)
        {
            
            btnajouter.Visible = false;
        }
        //Bouton pour confirmer la date
        private void btn_confirm_Click(object sender, EventArgs e)
        {
            //Ouverture de la fonction pour les requêtes SQL
            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();

            
            //C'est un raccourcis et a la fois un meilleur moyen pour afficher l'heure dans la requete Sql
            string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            
            cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdciedehkalfevre;uid=root;pwd=";
            cnn.Open();

            //Requête Sql
            cmd.CommandText = "select count(noproj) from projection where dateproj ='" + date +"'";
            cmd.Connection = cnn;
            
            //Permet de compter le nombre de projection de la requête Sql
            int i = Convert.ToInt32(cmd.ExecuteScalar());

            //Création d'une boucle if pour que s'il n'y a pas de projection au jour demander l'application ne crash pas
                if ( i> 0)
                {
                    MessageBox.Show("Il y a " + i + " film(s) disponible pour cette date");
                    btn_confirm.Visible = false;
                    btnajouter.Visible = true;
                    dateTimePicker1.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Veuillez choisir une date avec une projection");
                }
        }

        //Bouton pour créer un Pdf
        private void btnajouter_Click(object sender, EventArgs e)
        {
            //Ouverture de la fonction pour les requêtes SQL
            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            OdbcCommand cmd2 = new OdbcCommand();
            OdbcDataReader lecteur;
            Boolean existedonnee;

            
            
            //C'est un raccourcis et a la fois un meilleur moyen pour afficher l'heure dans la requete Sql
            string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            
            cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdciedehkalfevre;uid=root;pwd=";
            cnn.Open();

            //Requête Sql
            cmd.CommandText = "select * from projection natural join film where dateproj='" + date + "' order by heureproj";
            cmd.Connection = cnn;
            lecteur = cmd.ExecuteReader();
            existedonnee = lecteur.Read();

            //Permet de créer un Pdf de taille A4
            Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 15);
            //Donne le nom au Pdf içi Projection.pdf
            PdfWriter.GetInstance(pdfDoc, new FileStream("Projection.pdf", FileMode.Create));
            //Cela ouvre le Pdf
            pdfDoc.Open();

            System.Drawing.Image image = System.Drawing.Image.FromFile("Pathe_logo.png");
            iTextSharp.text.Image iTextImage = iTextSharp.text.Image.GetInstance(image, System.Drawing.Imaging.ImageFormat.Png);
            iTextImage.ScaleAbsolute(120, 90);
            pdfDoc.Add(iTextImage);

            iTextSharp.text.Font Gras = FontFactory.GetFont("Arial", 30, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            iTextSharp.text.Font Normal = FontFactory.GetFont("Arial", 20, iTextSharp.text.Font.UNDERLINE, BaseColor.BLACK);
            iTextSharp.text.Font Header = FontFactory.GetFont("Arial", 15,iTextSharp.text.Font.BOLD, BaseColor.BLACK);

            //Permet de créer des paragraphes
            Paragraph titre = new Paragraph(new Chunk("Cinéma Pathé Gaumont Macon", Gras));
            //Permet d'aligner au milieu
            titre.Alignment = Element.ALIGN_CENTER;
            //Permet de l'ajouter dans le Pdf
            pdfDoc.Add(titre);

            //Permet de créer des paragraphes
            Paragraph line = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1)));
            //Permet de l'ajouter dans le Pdf
            pdfDoc.Add(line);

            //Paramêtre utilisé pour un meilleur affichage seulement la date dans le paragraphe du Pdf 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";

            //Permet de créer des paragraphes
            Paragraph soustitre = new Paragraph(new Chunk("Planning des projections pour le " + dateTimePicker1.Text, Normal));
            //Permet d'espacer avant et après le paragraphe
            soustitre.SpacingBefore = 50f;
            soustitre.SpacingAfter = 30f;
            //Permet de créer des paragraphes
            soustitre.Alignment = Element.ALIGN_CENTER;
            //Permet de l'ajouter dans le Pdf
            pdfDoc.Add(soustitre);

            //Permet de créer des entêtes pour le tableau avec le style d'écriture Header (définis plus haut) -->
            PdfPTable table = new PdfPTable(4);
            PdfPCell header = new PdfPCell(new Phrase("Titre",Header));
            PdfPCell header2 = new PdfPCell(new Phrase("Salle",Header));
            PdfPCell header3 = new PdfPCell(new Phrase("Date",Header));
            PdfPCell header4 = new PdfPCell(new Phrase("Heure",Header));

            //Paramètre appliqué aux entêtes pour un alignement au milieu
            header.HorizontalAlignment = 1;
            header2.HorizontalAlignment = 1;
            header3.HorizontalAlignment = 1;
            header4.HorizontalAlignment = 1;
            header.PaddingBottom= 10f;
            
            //Permet d'afficher dans le pdf les entêtes
            table.AddCell(header);
            table.AddCell(header2);
            table.AddCell(header3);
            table.AddCell(header4);

            //Permet de définir une taille à la ligne
            table.DefaultCell.FixedHeight = 20f;
            table.SpacingBefore = 20f;

                //Permet d'utiliser les données contenue dans la base de donnée et de les reutiliser pour les mettre dans des cellules/cases
                while (existedonnee == true)
                {
                    table.AddCell(lecteur["titre"].ToString());
                    table.AddCell(lecteur["nosalle"].ToString());
                    table.AddCell(lecteur["dateproj"].ToString());
                    table.AddCell(lecteur["heureproj"].ToString());

                    existedonnee = lecteur.Read();
                }

            //Permet d'afficher dans le pdf le tableau
            pdfDoc.Add(table);
            
            lecteur.Close();
            cnn.Close();

            //Ferme le Pdf
            pdfDoc.Close();

            //Ouvrir le Pdf juste après avoir été créer
            System.Diagnostics.Process.Start("Projection.pdf");
        }
        //Bouton pour reinitialiser la date choisi pour en reprendre une autre
        private void btn_reinitialiser_Click(object sender, EventArgs e)
        {
            btn_confirm.Visible = true;
            btnajouter.Visible = false;
            dateTimePicker1.Enabled = true;
        }
        //Bouton pour permettre de revenir dans le form des projections pour modifier des données si besoin
        private void btn_edition_Click(object sender, EventArgs e)
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
        //jusqu'içi

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
