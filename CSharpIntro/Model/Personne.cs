using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntro.Model {
    public class Personne {

        public string Nom { get; set; }

        public string Prenom { get; set; }
        public int Age { get; set; }


        public int Taille { get; set; }

        public List<Matiere> Enseigne { get;set ; } = new List<Matiere>();

    }
}
