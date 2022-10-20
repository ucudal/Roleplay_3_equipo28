using NUnit.Framework;
using Library;

namespace Test.Library
{
   public class TestAlMago
    {
/*         [Test]
        public void Comprobaciondelestadodelamgo()
        {
            
            Arma arma= new Arma("Baston del empirio");
            Armadura armadura = new Armadura("Capa de hojas de abedul");
            Librodemagia librodemagia = new Librodemagia("Librodemagianegra");

            
            Personaje mago = new MAgo("Merlin", arma, armadura, librodemagia);

            
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
