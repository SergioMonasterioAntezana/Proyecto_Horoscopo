using NUnit.Framework;
using WebHoroscopo.Controllers;

namespace Horoscopo
{
    public class TestHoroscopo
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestHGet()
        {
            //Arange=Preparación
            int dia = 20;
            int mes = 3;
            string esperado = "Piscis: Para los Piscis, el 2021 estará lleno de un cúmulo de situaciones favorables para casi todos sus asuntos. ";

            HoroscopoController Hor = new HoroscopoController();

            //Act=Ejecución

            string resultado = Hor.HoroscopoGet(dia, mes);

            //Assert=Verificación
            Assert.AreEqual(esperado, resultado);

        }

    }
}


