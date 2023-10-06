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
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Cinema
{
    public partial class Form5 : Form
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
        Form3 theform3;
        Form4 theform4;

        //Initialisation des listes
        List<string> cbfilm = new List<string>();
        List<string> cbhoraire = new List<string>();
        List<string> cbdate = new List<string>();
        List<string> lesgenres = new List<string>();
        //<-- jusqu'içi
        public Form5()
        {
            InitializeComponent();
        }
        //Code qui s'execute dès que le programme est ouvert
        private void Form5_Load(object sender, EventArgs e)
        {
            btnajouter.Visible = false;

            
        }
        private void btn_confirm_Click(object sender, EventArgs e)
        {
            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            
            OdbcDataReader lecteur;
            int existedonnee;
            string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdciedekhalfevre;uid=root;pwd=";
            cnn.Open();
            cmd.CommandText = "select count(noproj) from projection where dateproj ='" + date +"'";
            cmd.Connection = cnn;
            
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            if ( i> 0)
            {
                
                MessageBox.Show("Il y a " + i + " film(s) disponible pour cette date");
                btn_confirm.Visible = false;
                btnajouter.Visible = true;
            }
            else
            {
                MessageBox.Show("Veuillez choisir une date avec une projection");
            }
            
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            OdbcCommand cmd2 = new OdbcCommand();

            OdbcDataReader lecteur;
            Boolean existedonnee;
            string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdciedekhalfevre;uid=root;pwd=";
            cnn.Open();
            
            cmd.CommandText = "select * from projection natural join film where dateproj='" + date + "' order by heureproj";

            cmd.Connection = cnn;

            lecteur = cmd.ExecuteReader();

            existedonnee = lecteur.Read();


            Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 15);
            PdfWriter.GetInstance(pdfDoc, new FileStream("Projection.pdf", FileMode.Create));
            pdfDoc.Open();


            iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance("C://Users/asus/Desktop/Cinéma/Objets/Pathe_logo.png");
            image.ScaleAbsolute(120, 90);
            pdfDoc.Add(image);

            iTextSharp.text.Font Gras = FontFactory.GetFont("Arial", 30, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            iTextSharp.text.Font Normal = FontFactory.GetFont("Arial", 20, iTextSharp.text.Font.UNDERLINE, BaseColor.BLACK);
            iTextSharp.text.Font Header = FontFactory.GetFont("Arial", 15,iTextSharp.text.Font.BOLD, BaseColor.BLACK);

            Paragraph titre = new Paragraph(new Chunk("Cinéma Pathé Gaumont Macon", Gras));
            titre.Alignment = Element.ALIGN_CENTER;
            pdfDoc.Add(titre);

            Paragraph line = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1)));
            pdfDoc.Add(line);

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";

            Paragraph soustitre = new Paragraph(new Chunk("Planning des projections pour le " + dateTimePicker1.Text, Normal));
            soustitre.SpacingBefore = 50f;
            soustitre.SpacingAfter = 30f;
            soustitre.Alignment = Element.ALIGN_CENTER;
            pdfDoc.Add(soustitre);

            PdfPTable table = new PdfPTable(4);
            PdfPCell header = new PdfPCell(new Phrase("Titre",Header));
            PdfPCell header2 = new PdfPCell(new Phrase("Salle",Header));
            PdfPCell header3 = new PdfPCell(new Phrase("Date",Header));
            PdfPCell header4 = new PdfPCell(new Phrase("Heure",Header));

            header.HorizontalAlignment = 1;
            header2.HorizontalAlignment = 1;
            header3.HorizontalAlignment = 1;
            header4.HorizontalAlignment = 1;
            header.PaddingBottom= 10f;
            
            table.AddCell(header);
            table.AddCell(header2);
            table.AddCell(header3);
            table.AddCell(header4);

            table.DefaultCell.FixedHeight = 20f;
            

            while (existedonnee == true)
            {
                table.AddCell(lecteur["titre"].ToString());
                table.AddCell(lecteur["nosalle"].ToString());
                table.AddCell(lecteur["dateproj"].ToString());
                table.AddCell(lecteur["heureproj"].ToString());

                existedonnee = lecteur.Read();
            }

            table.SpacingBefore = 20f;

            pdfDoc.Add(table);

            pdfDoc.Close();

            lecteur.Close();

            cnn.Close();


        }
        private void btn_reinitialiser_Click(object sender, EventArgs e)
        {
            btn_confirm.Visible = true;
            btnajouter.Visible = false;
        }
        private void btn_edition_Click(object sender, EventArgs e)
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
        //jusqu'içi
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
