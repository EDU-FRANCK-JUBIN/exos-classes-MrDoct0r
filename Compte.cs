using System;

namespace ConsoleApplication3
{
    public class Compte
    {
        private double solde;
        private Client proprietaire;
        private uint code;
        private static uint nombre_compte;

        public uint Code
        {
            get => code;
        }

        public double Solde
        {
            get => solde;
        }

        public Client Proprietaire
        {
            get => proprietaire;
            set => proprietaire = value;
        }

        public Compte(Client proprietaire)
        {
            nombre_compte++;
            code = nombre_compte;
            this.proprietaire = proprietaire;
        }

        public void Crediter(float somme)
        {
            solde += somme;
        }

        public void Crediter(float somme, Compte compte)
        {
            Crediter(somme);
            compte.solde -= somme;
        }

        public void Debiter(float somme)
        {
            solde -= somme;
        }

        public void Debiter(float somme, Compte compte)
        {
            Debiter(somme);
            compte.solde += somme;
        }
        
        public void Resumer()
        {
            Console.WriteLine($"Propriétaire : {proprietaire.Nom} {proprietaire.Prenom} - {Code} - {Solde}");
        }
    }
}