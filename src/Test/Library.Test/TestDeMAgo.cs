using NUnit.Framework;

namespace Test.Library
{
   public class TestAlMago
    {
        [Test]
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


        }
        }
    }
