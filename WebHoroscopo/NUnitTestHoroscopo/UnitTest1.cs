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
            //Arange=Preparaci�n
            int dia = 20;
            int mes = 3;
            string esperado = "Piscis: Para los Piscis, el 2021 estar� lleno de un c�mulo de situaciones favorables para casi todos sus asuntos. ";

            HoroscopoController Hor = new HoroscopoController();

            //Act=Ejecuci�n

            string resultado = Hor.HoroscopoGet(dia,mes);

            //Assert=Verificaci�n
            Assert.AreEqual(esperado,resultado);

        }

        [Test]
        public void TestHPost()
        {
            //Arange=Preparaci�n
            int dia = 16;
            int mes = 10;
            string esperado = "Libra: Para Libra el 2021 ser� un a�o lleno de cambios que requerir�n incluso un tiempo de mudanza. ";

            HoroscopoController Hor = new HoroscopoController();

            //Act=Ejecuci�n

            string resultado = Hor.HoroscopoPost(dia,mes);

            //Assert=Verificaci�n
            Assert.AreEqual(esperado,resultado);

        }

    }
}


