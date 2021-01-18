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

            string resultado = Hor.HoroscopoGet(dia,mes);

            //Assert=Verificación
            Assert.AreEqual(esperado,resultado);

        }

        [Test]
        public void TestHPost()
        {
            //Arange=Preparación
            int dia = 16;
            int mes = 10;
            string esperado = "Libra: Para Libra el 2021 será un año lleno de cambios que requerirán incluso un tiempo de mudanza. ";

            HoroscopoController Hor = new HoroscopoController();

            //Act=Ejecución

            string resultado = Hor.HoroscopoPost(dia,mes);

            //Assert=Verificación
            Assert.AreEqual(esperado,resultado);

        }

    }
}


