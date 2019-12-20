using System;

namespace ConsoleApplication3
{
    public class Client
    {
        private string cin;
        private string nom;
        private string prenom;
        private string tel;

        public string Cin
        {
            get => cin;
            set => cin = value;
        }

        public string Nom
        {
            get => nom;
            set => nom = value;
        }

        public string Prenom
        {
            get => prenom;
            set => prenom = value;
        }

        public string Tel
        {
            get => tel;
            set => tel = value;
        }

        public Client(string cin, string nom, string prenom, string tel)
        {
            this.cin = cin;
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
        }

        public Client(string cin, string nom, string prenom)
        {
            this.cin = cin;
            this.nom = nom;
            this.prenom = prenom;
        }

        public void Afficher()
        {
            Console.WriteLine($"{Nom} {Prenom} {Cin} {Tel}");
        }
    }
}