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
            Mago Merlin = new Mago("Merlin");
            Orco Adar = new Orco("Adar");
            DarkMagician Aegon = new DarkMagician("Aegon");
            Orco Lur = new Orco("Lur");
            Orco Shar = new Orco("Shar");
            Orco Uf = new Orco("Uf");
            Orco Gor = new Orco("Gor");
            Barbaro Mel = new Barbaro("Mel");
            Barbaro Rodrer = new Barbaro("Rodrer");
            Barbaro Miltin = new Barbaro("Miltin");
            encounter.AddHero(Durin);
            encounter.AddEnemy(Adar);
            encounter.AddEnemy(Lur);
            encounter.AddEnemy(Shar);
            encounter.AddEnemy(Uf);
            encounter.AddEnemy(Gor);
            encounter.AddEnemy(Aegon);
            encounter.AddEnemy(Mel);
            encounter.AddEnemy(Rodrer);
            encounter.AddEnemy(Miltin);
            encounter.DoEncounter();
            Assert.IsTrue(Durin.Vida <= 0);
            Assert.IsTrue(Durin.Vp == 0);

            encounter.AddHero(Legolas);
            encounter.AddHero(Merlin);
            encounter.AddEnemy(Adar);
            encounter.DoEncounter();
            Assert.IsTrue(Adar.Vida <= 0);
            


        }
    }
}

