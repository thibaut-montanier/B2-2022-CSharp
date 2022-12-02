using CSharpIntro.Model;
using CSharpIntro.Services;

internal class Program {

    private static void Main(string[] args) {

        //// demander le nom à l'utilisateur
        bool Quitter = false;
        string MessageMenu = "Menu\n" +
"1. Créer une personne\n" +
"2. Afficher la personne créée\n" +
"3. Modifier Personne Dans Liste\n" +
"5. Creer une matière (Nom, Code, Niveau, NbHeures)\n" +
"6. Afficher les matières (Nom, Code, Niveau, NbHeures)\n" +
"7. Lier un enseignant à une matière\n" +
"Q. Quitter";
        PersonnesService personnesService = new PersonnesService();
        while (!Quitter) {

            string choix = Demande.DemanderString(MessageMenu, 1, 1);
            if (choix == "1") {
                // création de la personne
                Personne maPersonne = personnesService.CreerPersonne();
            } else if (choix == "2") {
                Console.WriteLine(personnesService.AfficherMessagePersonnes());
            } else if (choix == "3") {
                personnesService.ModifierPersonneDansListe();
            } else if (choix == "Q") {
                Quitter = true;
            }
        }
    }
}