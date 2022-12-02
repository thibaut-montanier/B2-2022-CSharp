using CSharpIntro.Model;
using CSharpIntro.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntro.Tests.Mock {
   class PersonnesServiceMock : PersonnesService {

        public override Personne CreerPersonne() {
            return new Personne() {
                Nom = "Paulo",
                Prenom = "Jean",
                Age = 23,
                Taille = 212
            };
        }
    }
}
