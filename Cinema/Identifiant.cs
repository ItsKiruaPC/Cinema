namespace Cinema
{
    internal class Identifiant
    {
        public string nom;
        public string mdp;
        

        public Identifiant(string unNom, string unMdp)
        {
            nom = unNom;
            mdp = unMdp;
        }

        public string getnom() 
        { 
            return nom; 
        }
        public string getmdp()
        {
            return mdp;
        }

            
    }
}
