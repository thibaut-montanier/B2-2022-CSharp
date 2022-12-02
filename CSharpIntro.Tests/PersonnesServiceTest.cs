using CSharpIntro.Model;
using CSharpIntro.Services;
using System.Security;

namespace CSharpIntro.Tests {
    public class Tests {
        [SetUp]
        public void Setup() {
        }

        
        public void CreerPersonneTest() {
            // on ne sait pas faire.
            Personne p = PersonnesService.CreerPersonne();

            Assert.IsNotNull(p);
        }

        [Test]
        public void AfficherMessagePersonneTest() {
            Personne p = new Personne() {
                Nom = "Toto",
                Prenom = "Tutu",
                Age = 17,
                Taille = 170
            };

            string Message = PersonnesService.AfficherMessagePersonne(p);

            string expected = "Bonjour, tu t'appelles Tutu Toto, tu as 17 ans. Tu mesures 170 cm.";
            Assert.AreEqual(expected, Message);

        }


        [Test]
        public void AfficherMessagePersonnesTest() {

            string Message = PersonnesService.AfficherMessagePersonnes();

            string expected = "??";
            Assert.AreEqual(expected, Message);

        }


    }
}