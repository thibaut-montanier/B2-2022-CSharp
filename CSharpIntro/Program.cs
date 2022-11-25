using CSharpIntro.Model;

internal class Program {

    private static void Main(string[] args) {

        //// demander le nom à l'utilisateur
        bool Quitter = false;
        string MessageMenu = "Menu\n" +
"1. Créer une personne\n" +
"2. Afficher la personne créée\n" +
"Q. Quitter";
        List<Personne> mesPersonnes = new List<Personne>();
        while (!Quitter) {

            string choix = DemanderString(MessageMenu);
            if (choix == "1") {
                // création de la personne
                Personne maPersonne = CreerPersonne();
                // ajout de la personne à la liste des personnes
                mesPersonnes.Add(maPersonne);
            } else if (choix == "2") {
                // on boucle sur l'ensemble des personnes de la liste
                foreach(Personne personne in mesPersonnes) {
                    // affichage de la personne issue de la liste
                    AfficherMessagePersonne(personne);
                }
            } else if (choix == "Q") {
                Quitter= true;
            }
        }
    }

    static Personne CreerPersonne() {
        Personne maPersonne;

        maPersonne = new Personne();

        maPersonne.Nom = DemanderString("Quel est ton nom ?");
        maPersonne.Prenom = DemanderString("Quel est ton prénom ?");
        maPersonne.Age = DemanderNumeric("Quel est ton age ?");
        maPersonne.Taille = DemanderNumeric("Quel est ta taille ?");

        return maPersonne;
    }

    static string DemanderString(string question) {
        Console.WriteLine(question);
        return Console.ReadLine();
    }
    static int DemanderNumeric(string question) {
        int ageNumeric = 0;
        bool lUtilisateurASaisiUnNumericPositif = false; // l'utilisateur n'a pas encore réalisé de saisie valide

        // tant que l'utilisateur n'a pas réalisé de saisie valide, on lui demande de saisir un numérique
        while (lUtilisateurASaisiUnNumericPositif == false) {
            // demande de saisie puis lecture
            Console.WriteLine(question);
            string ageSaisi = Console.ReadLine();

            // tentative de conversion de texte vers du numérique
            bool ageSaisiEstUnNumeric = int.TryParse(ageSaisi, out ageNumeric);
            // si la tentative est un succès => l'utilisateur a fait une saisie valide
            if (ageSaisiEstUnNumeric) {
                lUtilisateurASaisiUnNumericPositif = ageNumeric >= 0;
            } else {
                // si la tentative de conversion est un échec, on précise que l'utilisateur n'a pas saisi de numérique 
                Console.WriteLine("L'utilisateur n'a pas saisi un numérique");
            }
        }
        return ageNumeric;
    }


    static void AfficherMessagePersonne(Personne personne) {
        string messageResultat;
        if (personne.Age == 1) {
            messageResultat = "Bonjour, tu t'appelles " + personne.Prenom + " " + personne.Nom + ", tu as " + personne.Age + " an";
        } else if (personne.Age == 0) {
            messageResultat = "Bonjour, tu es un tout jeune bébé";
        } else {
            messageResultat = "Bonjour, tu t'appelles " + personne.Prenom + " " + personne.Nom + ", tu as " + personne.Age + " ans";
        }
        Console.WriteLine(messageResultat);
    }

}