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
            Enano Pablo = new Enano("Pablo");
            Orco Fahr = new Orco("Fahr");
            encounter.AddHero(Pablo);
            encounter.AddEnemy(Fahr);
            encounter.DoEncounter();
            Assert.IsTrue(Pablo.Vida > 0);
            Assert.IsTrue(Fahr.Vida < 0);
            Assert.IsTrue(Pablo.Vp == Fahr.Vp);


        }
    }
}

