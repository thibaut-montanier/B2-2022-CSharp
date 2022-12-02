using CSharpIntro.Model;
using CSharpIntro.Services;
using CSharpIntro.Tests.Mock;
using NUnit.Framework;
using System.Security;

namespace CSharpIntro.Tests {
    public class PersonnesServiceTest {

        private PersonnesService personnesService;
        [SetUp]
        public void Setup() {
            personnesService = new PersonnesService();
            personnesService.myDemande = new Demande();
        }

        [Ignore("Ne fonctionne pas encore, besoin de faire un mock sur le service Demande")]
        [Test]      
        public void CreerPersonneTest() {
            // on ne sait pas faire.
            Personne p = personnesService.CreerPersonne();

            Assert.IsNotNull(p);
        }

        [TestCase("Bonjour, tu t'appelles Tutu Toto, tu as 17 ans. Tu mesures 170 cm.", 17)]
        [TestCase("Bonjour, tu t'appelles Tutu Toto, tu as 1 an. Tu mesures 170 cm.", 1)]
        [TestCase("Bonjour, tu es un tout jeune b�b�.", 0)]
        public void AfficherMessagePersonneTest(string expected, int age) {
            Personne p = new Personne() {
                Nom = "Toto",
                Prenom = "Tutu",
                Age = age,
                Taille = 170
            };
            string Message = personnesService.AfficherMessagePersonne(p);
            Assert.AreEqual(expected, Message);
        }

        [Test]
        public void AfficherMessagePersonnesTest() {
            Personne p1 = new Personne() {
                Nom = "Toto",
                Prenom = "Tutu",
                Age = 0,
                Taille = 170
            };
            personnesService.AddPersonne(p1);
            Personne p2 = new Personne() {
                Nom = "Jean",
                Prenom = "Pierre",
                Age = 1,
                Taille = 170
            };
            personnesService.AddPersonne(p2);
            Personne p3= new Personne() {
                Nom = "Michel",
                Prenom = "Paul",
                Age = 17,
                Taille = 170
            };
            personnesService.AddPersonne(p3);
            string Message = personnesService.AfficherMessagePersonnes();

            string expected = "Bonjour, tu es un tout jeune b�b�.\n" +
                "Bonjour, tu t'appelles Pierre Jean, tu as 1 an. Tu mesures 170 cm.\n" +
                "Bonjour, tu t'appelles Paul Michel, tu as 17 ans. Tu mesures 170 cm.";
                
            Assert.AreEqual(expected, Message);

        }


        [Test]
        public void AfficherMessagePersonnesTest_1Personne() {
            Personne p1 = new Personne() {
                Nom = "Toto",
                Prenom = "Tutu",
                Age = 0,
                Taille = 170
            };
            personnesService.AddPersonne(p1);
            string Message = personnesService.AfficherMessagePersonnes();

            string expected = "Bonjour, tu es un tout jeune b�b�.";

            Assert.AreEqual(expected, Message);

        }



    }
}