using CSharpIntro.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntro.Services {
    public class MatieresService {
        public Demande myDemande;

        public PersonnesService myPersonnesService;
        public List<Matiere>  mesMatieres = new List<Matiere>();

        public MatieresService() { 
        }
        public Matiere CreerMatiere() {
            Matiere maMatiere = new Matiere();

            maMatiere.Code = myDemande.DemanderString("Code de la matière ? "); 
            maMatiere.Niveau = myDemande.DemanderString("Niveau de la matière ? "); 
            maMatiere.NbHeures = myDemande.DemanderNumeric("Nombre d'heures ?");
            // recherche de l'enseignant
            maMatiere.EstEnseignePar = myPersonnesService.TrouvePersonne("Nom de l'enseignant ?");

            // ajout de la matière enseignée à la liste des matières enseignées par l'enseignant
            if (maMatiere.EstEnseignePar != null) {
                maMatiere.EstEnseignePar.Enseigne.Add(maMatiere);
            }

            mesMatieres.Add(maMatiere);
            return maMatiere;

        }

        public void AfficherMatieres() {
            foreach(Matiere maMatiere in mesMatieres) {
                Console.WriteLine(maMatiere.Code);  
                Console.WriteLine(maMatiere.EstEnseignePar.Nom);  
            }
        }
    }
}
