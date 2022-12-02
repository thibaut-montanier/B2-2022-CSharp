using CSharpIntro.Model;

namespace CSharpIntro.Services {
    public class PersonnesService {

        private static List<Personne> mesPersonnes = new List<Personne>();
        public static Personne CreerPersonne() {
            Personne maPersonne;

            maPersonne = new Personne();

            maPersonne.Nom = Demande.DemanderString("Quel est ton nom ?");
            maPersonne.Prenom = Demande.DemanderString("Quel est ton prénom ?");
            maPersonne.Age = Demande.DemanderNumeric("Quel est ton age ?");
            maPersonne.Taille = Demande.DemanderNumeric("Quel est ta taille ?");
            // ajout de la personne à la liste
            AddPersonne(maPersonne);
            return maPersonne;
        }

        public static void AddPersonne(Personne p) {
            mesPersonnes.Add(p);
        }


        public static void ModifierPersonneDansListe() {
            // 1. Demander le nom de la personne à modifier
            Personne personneAModifier = TrouvePersonne(mesPersonnes);
            // 3. Si la personne n'a pas été trouvée => on sort de la void (return)
            if (personneAModifier != null) {
                personneAModifier.Nom = Demande.DemanderString("Quel est ton nom ?");
                ///....
            }
            // 4. Si la personne a été trouvée, on met à jour ses informations en les redemandant à l'utilisateur
        }
        /// <summary>
        /// Demande à l'utilisateur le nom de la personne à trouver et la cherche dans la liste
        /// </summary>
        /// <param name="mesPersonnes"></param>
        /// <returns></returns>
        public static Personne TrouvePersonne(List<Personne> mesPersonnes) {
            // 1. Demander le nom de la personne à modifier
            string NomPersonneAModifier = Demande.DemanderString(question: "Nom de la personne à modifier ?");
            // 2. Chercher la bonne personne dans la liste

            Personne personneTrouvee = null;
            // parcourt de l'ensemble des personnes
            foreach (Personne personne in mesPersonnes) {
                // si le nom correspond => on sort récupère la personne dans la variable personneTrouvee et on sort de la boucle
                if (personne.Nom == NomPersonneAModifier) {
                    personneTrouvee = personne;
                    break;
                }
            }
            return personneTrouvee;


            // ou utilisation du first or Default
            return mesPersonnes.FirstOrDefault(pers => pers.Nom == NomPersonneAModifier);
        }



        public static string AfficherMessagePersonnes() {
            // on boucle sur l'ensemble des personnes de la liste
            List<string> resultats = new List<string>();
            foreach (Personne personne in mesPersonnes) {
                // affichage de la personne issue de la liste
                resultats.Add(AfficherMessagePersonne(personne));
            }
            return string.Join("\n", resultats);

        }



        public static string AfficherMessagePersonne(Personne personne) {
            string messageResultat;

            if (personne.Age == 1) {
                // messageResultat = "Bonjour, tu t'appelles " + personne.Prenom + " " + personne.Nom + ", tu as " + personne.Age + " an";
                // messageResultat = string.Format("Bonjour, tu t'appelles {0} {1}, tu as {2} an", personne.Prenom, personne.Nom, personne.Age);
                messageResultat = $"Bonjour, tu t'appelles {personne.Prenom} {personne.Nom}, tu as {personne.Age} an. Tu mesures {personne.Taille} cm.";
            } else if (personne.Age == 0) {
                messageResultat = "Bonjour, tu es un tout jeune bébé.";
            } else {
                messageResultat = $"Bonjour, tu t'appelles {personne.Prenom} {personne.Nom}, tu as {personne.Age} ans. Tu mesures {personne.Taille} cm.";
            }
            return messageResultat;
        }
    }
}
