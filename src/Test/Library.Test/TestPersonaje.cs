/*using NUnit.Framework;
using Library;

namespace Test.Library
{
    public class TestPersonaje
    {
        [Test]
        public void PersonajeTest()
        {
            Enano playerone = new Enano("José");
            Enano playertwo = new Enano("Mario");
            Assert.AreEqual(200, playertwo.Vida);
            playerone.Atacar(playertwo);
            Assert.AreEqual(164, playertwo.Vida);

            Hacha hacha = new Hacha();
            playerone.EquiparItem( hacha );
            Assert.AreEqual(40 + hacha.Daño, playerone.Daño);

            playerone.Borrachera();
            Assert.AreEqual((40+hacha.Daño)*2, playerone.Daño );

        }
    }
}
*/
