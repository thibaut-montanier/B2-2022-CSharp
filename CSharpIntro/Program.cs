using CSharpIntro.Model;
using System.Runtime.InteropServices;

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
                AfficherMessagePersonnes(mesPersonnes);
            } else if (choix == "3") {
                ModifierPersonneDansListe(mesPersonnes);
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


    static void ModifierPersonneDansListe(List<Personne> mesPersonnes) {
        // 1. Demander le nom de la personne à modifier
        // 2. Chercher la bonne personne dans la liste
        // 3. Si la personne n'a pas été trouvée => on sort de la void (return)
        // 4. Si la personne a été trouvée, on met à jour ses informations en les redemandant à l'utilisateur
    }
    static void AfficherMessagePersonnes(List<Personne> personnes) {
        // on boucle sur l'ensemble des personnes de la liste
        foreach (Personne personne in personnes) {
            // affichage de la personne issue de la liste
            AfficherMessagePersonne(personne);
        }
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