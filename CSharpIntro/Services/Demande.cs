
namespace CSharpIntro.Services {
    public class Demande {
        
        public virtual string DemanderString(string question) {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        public string DemanderString(string question, int TailleMinimum, int TailleMaximum) {
            bool SaisieOK = false;
            string resultat = "";
            // tant que l'utilisateur n'a pas réalisé de saisie valide, on lui demande de saisir un numérique
            while (!SaisieOK) {
                // demande de saisie puis lecture
                Console.WriteLine(question);
                resultat = Console.ReadLine();

                // tentative de conversion de texte vers du numérique
                if (resultat.Length >= TailleMinimum && resultat.Length <= TailleMaximum) {
                    SaisieOK = true;
                }
            }
            return resultat;
        }
        public virtual int DemanderNumeric(string question) {
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

    }
}
