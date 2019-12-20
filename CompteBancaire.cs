namespace ConsoleApplication3
{
    public class CompteBancaire
    {
        private string titulaire;
        private double solde;
        private string devise;
        private static int NombreDeComptes = 0;

        public CompteBancaire(string titulaire, double solde, string devise)
        {
            this.titulaire = titulaire;
            this.solde = solde;
            this.devise = devise;
        }

        public void Crediter(double montant)
        {
            solde += montant;
        }

        public void Debiter(double montant)
        {
            solde -= montant;
        }
        
        // Renvoie la description du code
        public string Decrire()
        {
            return $"Ce compte appartient à {titulaire}, son solde est de {solde} {devise}";
        }
    }
}