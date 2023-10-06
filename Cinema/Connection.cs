using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class Connection : Form
    {
        //Création d'une liste
        List<Identifiant> lesidentifiants = new List<Identifiant>();

        //Code utile pour ce déplacer dans les autres forms voir dans les boucles pour les connections
        Genre theform1;
        public Connection()
        {
            InitializeComponent();
        }
        
        private void Form0_Load(object sender, EventArgs e)
        {
            //Permet de cacher le bouton btn_ajouter pour qu'il n'y ait pas de conection s'il n'y a pas de compte ce qui permet aussi d'éviter de mauvaise manoeuvre
            btn_connexion.Visible = false;
        }
        private void btn_creer_Click(object sender, EventArgs e)
        {
            // Permet d'être sûr que tout les textbox sont remplit et que le compte ait ien été créer
            if (txt_identifiant.Text != "" && txt_mdp.Text != "")
            {
                MessageBox.Show("Votre compte à bien était créer");

                //Création d'un objet
                lesidentifiants.Add(new Identifiant(txt_identifiant.Text, txt_mdp.Text));

                //Permet de remettre vide les cases une fois le compte créer
                txt_identifiant.Text = "";
                txt_mdp.Text = "";
                btn_connexion.Visible = true;
                btn_creer.Visible = false;
            }
            else
            {
                MessageBox.Show("Il y a des cases non replit");
            }
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            //Création d'une boucle foreach suivi de condition if qui permettent de voir si ce que l'on écrit dans le textbox pour créer son compte correspond a ce qu'il faut pour être connecter
            foreach (var login in lesidentifiants)
            {
                if (txt_identifiant.Text == login.getnom() && txt_mdp.Text == login.getmdp())
                {
                    //Adrien
                    if (login.getnom() == "Adrien" && login.getmdp() == "31082004")
                    {
                        MessageBox.Show("Bienvenu(e) " + login.getnom() + " (compte admin)");

                        theform1 = new Genre();
                        theform1.Show();
                    }

                    //Rayan
                    else if (login.getnom() == "Rayan" && login.getmdp() == "01102004")
                    {
                        MessageBox.Show("Bienvenu(e) " + login.getnom() + " (compte admin)");

                        theform1 = new Genre();
                        theform1.Show();
                    }

                    //Utilisateur
                    else if (login.getnom() != "Adrien" && login.getnom() != "Rayan")
                    {
                        MessageBox.Show("Bienvenu(e) " + login.getnom() + " (Compte utilisateur)");

                        theform1 = new Genre();
                        theform1.Show();
                    }

                }

                else if (txt_identifiant.Text != login.getnom() || txt_mdp.Text != login.getmdp())
                {
                    if (txt_identifiant.Text == "Adrien" && txt_mdp.Text != "31082004" || txt_identifiant.Text == "Rayan" && txt_mdp.Text != "01102004")
                    {
                        MessageBox.Show("L'identifiant ou le mot de passe n'est pas celui de votre compte admin");
                    }

                    else
                    {
                        MessageBox.Show("L'identifiant ou le mot de passe ne sont pas les même que ceux créer");
                    }

                }

                else
                {
                    MessageBox.Show("Il y a une erreur entre la création de votre compte et ce que vous avez écrit");
                }
            }
        }
    }
}
