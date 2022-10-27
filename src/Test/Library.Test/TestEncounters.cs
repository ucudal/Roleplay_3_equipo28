using NUnit.Framework;
using Library;

namespace Test.Library
{
    public class TestEncounters
    {
        [Test]
        public void Encounters()
        {
            Encounters encounter = new Encounters();
            Enano Durin = new Enano("Durin");
            Elfo Legolas = new Elfo("Legolas");
            Mago Gandalf = new Mago("Gandalf");
            Orco Adar = new Orco("Adar");
            Orco Fahr = new Orco("Fahr");
            Orco Lur = new Orco("Lur");
            Orco Shar = new Orco("Shar");
            Orco Uf = new Orco("Uf");
            Orco Gor = new Orco("Gor");
            encounter.AddHero(Durin);
            encounter.AddEnemy(Adar);
            encounter.AddEnemy(Lur);
            encounter.AddEnemy(Shar);
            encounter.AddEnemy(Uf);
            encounter.AddEnemy(Gor);
            encounter.AddEnemy(Fahr);
            encounter.DoEncounter();
            Assert.IsTrue(Durin.Vida <= 0);
            Assert.IsTrue(Durin.Vp == 0);

            encounter.AddHero(Legolas);
            encounter.AddHero(Gandalf);
            encounter.AddEnemy(Adar);
            encounter.DoEncounter();
            Assert.IsTrue(Adar.Vida <= 0);
            


        }
    }
}

