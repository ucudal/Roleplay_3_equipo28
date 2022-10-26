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
            Assert.AreEqual(Pablo.Vp, 0);
            encounter.DoEncounters(Pablo, Fahr);
            Assert.AreEqual(Pablo.Vp, 50);
            Assert.False(Fahr.Vivo());
        }
    }
}

