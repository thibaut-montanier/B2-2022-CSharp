internal class Program {

    private static void Main(string[] args) {

        //// demander le nom à l'utilisateur

        string nom = DemanderString("Quel est ton nom ?");
        int age = DemanderNumeric("Quel est ton age ?");
        int taille = DemanderNumeric("Quel est ta taille ?");

        
        AfficherMessageResultat(nom, age, taille);

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


    static void AfficherMessageResultat(string nom, int age, int taille) {
        string messageResultat;
        if (age == 1) {
            messageResultat = "Bonjour, tu t'appelles " + nom + ", tu as " + age + " an";
        } else if (age == 0) {
            messageResultat = "Bonjour, tu es un tout jeune bébé";
        } else {
            messageResultat = "Bonjour, tu t'appelles " + nom + ", tu as " + age + " ans";
        }
        Console.WriteLine(messageResultat);
    }

}