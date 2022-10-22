using NUnit.Framework;
using Library;

namespace Test.Library
{
    public class TestDeElfo
    {
        [Test]
        public void ElfoTest()
        {
            Elfo numberone = new Elfo("Dimitri");
            Elfo numbertwo = new Elfo("Dwight");
            Assert.AreEqual(160, numbertwo.Vida);
            numberone.Atacar(numberone);
            Assert.AreEqual(160, numbertwo.Vida);

            Arco arco = new Arco();
            numberone.EquiparArma( arco );
            Assert.AreEqual(55 + arco.Daño, numberone.Daño);

            numberone.Curar(numbertwo);
            Assert.AreEqual((109), numberone.Vida );

        }
    }
}
