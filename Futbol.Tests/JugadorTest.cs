using Futbol.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Futbol.Tests
{
    [TestClass]
    public class JugadorTest
    {
        public Jugador Roman { get; set; }
        public Jugador Marcelo { get; set; }
        private void Instanciar()
        {
            Roman = new Jugador()
            {
                Altura = 1.74,
                Peso = 82,
                Nombre = "Juan",
                Apellido = "Riquelme",
                Equipo = "Boca"
            };

            Marcelo = new Jugador()
            {
                Altura = 1.7,
                Peso = 70,
                Nombre = "Marcelo",
                Apellido = "Gallardo",
                Equipo = "River"
            };
        }

        
        [TestMethod]
        public void TestEquipo()
        {
            Instanciar();
            
            Assert.IsTrue(Roman.SosDe("Boca"));
            Assert.IsFalse(Roman.SosDe("River"));

            Assert.IsTrue(Marcelo.SosDe("River"));
            Assert.IsFalse(Marcelo.SosDe("Boca"));
        }

        [TestMethod]
        public void TestIMC()
        {
            Instanciar();

            Assert.AreEqual(27.08, Roman.IMC, delta: 0.01);
            Assert.AreEqual(24.22, Marcelo.IMC, delta: 0.01);
        }
    }
}
