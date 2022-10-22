using NUnit.Framework;
using Library;

namespace Test.Library
{
   public class TestAlMago
    {       
        [Test]
        public void  MagoTesteado()
        {
        Mago newmago = new Mago("Merlin");
        Mago secondmago = new Mago("Oscurus");
        Assert.AreEqual(60, newmago.Vida );
        newmago.Atacar(newmago);
        Assert.AreEqual(-34, newmago.Vida );

        LibroDeMagia libroDeMagia = new LibroDeMagia();
        newmago.EquiparMagia(libroDeMagia);
        Assert.AreEqual(180, newmago.Daño);

        newmago.Tempestad();
        Assert.AreEqual(360, newmago.Daño);
        }

            
            string expectedName="Merlin";
            Assert.AreEqual(mago.Name,expectedName);
            Assert.AreEqual(mago.Arma,arma);
            Assert.AreEqual(mago.Armadura,armadura);


        } */

        [Test]
        public void TestArco()
        {
            Arco arco = new Arco();
            Assert.AreEqual("Arco", arco.Nombre);
            Assert.AreEqual(80, arco.Daño);
        }

        [Test]
        public void PersonajeTest()
        {
            Personaje personaje = new Personaje();
            personaje.Vida = 100;
            Assert.True(personaje.Vivo());
            personaje.Vida = -1;
            Assert.False(personaje.Vivo());
        }
        
    }
}
