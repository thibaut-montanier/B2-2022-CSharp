using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

internal class Program {
    private static void Main(string[] args) {
        Console.WriteLine("Hello, World!");


        // demander le nom à l'utilisateur
        Console.WriteLine("Quel est ton nom ?");
        string nom;
        nom = Console.ReadLine();

        // demander l'age à l'utilisateur
        int ageNumeric = 0;
        bool lUtilisateurASaisiUnNumeric = false; // l'utilisateur n'a pas encore réalisé de saisie valide

        // tant que l'utilisateur n'a pas réalisé de saisie valide, on lui demande de saisir un numérique
        while (lUtilisateurASaisiUnNumeric == false) {
            // demande de saisie puis lecture
            Console.WriteLine("Quel est ton age ?");
            string ageSaisi = Console.ReadLine();

            // tentative de conversion de texte vers du numérique
            bool ageSaisiEstUnNumeric = int.TryParse(ageSaisi, out ageNumeric);
            // si la tentative est un succès => l'utilisateur a fait une saisie valide
            if (ageSaisiEstUnNumeric) {
                lUtilisateurASaisiUnNumeric = true;
            } else {
                // si la tentative de conversion est un échec, on précise que l'utilisateur n'a pas saisi de numérique 
                Console.WriteLine("L'utilisateur n'a pas saisi un numérique");
            }
        }

        // construction du message de résultat puis affichage de celui-ci
        Program.AfficherMessageResultat(nom, ageNumeric.ToString());

    }


    static void AfficherMessageResultat(string nom, string age) {
        string messageResultat;
        if (age == "1") {
            messageResultat = "Bonjour, tu t'appelles " + nom + ", tu as " + age + " an";
        } else if (age == "1") {
            messageResultat = "Bonjour, tu es un tout jeune bébé";
        } else {
            messageResultat = "Bonjour, tu t'appelles " + nom + ", tu as " + age + " ans";
        }
        Console.WriteLine(messageResultat);
    }
}