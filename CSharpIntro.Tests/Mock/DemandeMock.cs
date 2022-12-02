using CSharpIntro.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntro.Tests.Mock {
    class DemandeMock : Demande {
        public override string DemanderString(string question) {
            if (question == "Quel est ton nom ?") {
                return "NOMDEFAMILLE";
            } else {
                return "Prenom";
            }
        }

        public override int DemanderNumeric(string question) {
            return 0;
        }
    }
}
