using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebHoroscopo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HoroscopoController : Controller
    {
        [HttpGet]

        public string HoroscopoGet(int dia, int mes)
        {
            if (dia > 31 || dia < 1)
            {
                return "Fuera del rango";
            }
            if (mes > 12 || mes < 1)
            {
                return "Fuera del rango";
            }

            if ((dia >= 21 && mes == 3) || (dia <= 20 && mes == 4))
            {
                return "Aries:  Tiene un año de acontecimimentos importantes. ";
            }

            if ((dia >= 21 && mes == 4) || (dia <= 20 && mes == 5))
            {
                return "Tauro:  Los Tauro experimentarán muchos cambios en el 2021 con respecto al amor, el trabajo y la rutina diaria. ";
            }

            if ((dia >= 21 && mes == 5) || (dia <= 21 && mes == 6))
            {
                return "Geminis: Lastimosamente, el 2021 será una época de tomar decisiones difíciles en el ámbito laboral y en las relaciones. ";

            }

            if ((dia >= 22 && mes == 6) || (dia <= 22 && mes == 7))
            {
                return "Cancer: Cáncer deberá hacer muchos sacrificios en el 2021 para poder culminar tus proyectos postergados, independizarte, terminar estudios o cualquier otra actividad productiva. ";
            }

            if ((dia >= 23 && mes == 7) || (dia <= 23 && mes == 8))
            {
                return "Leo: Para el 2021 Leo romperá la rutina. Conocerás nuevas personas y tu conducta social será impredecible, tomando decisiones de manera impulsiva que podrían tener consecuencias indeseables. ";
            }

            if ((dia >= 24 && mes == 8) || (dia <= 22 && mes == 9))
            {
                return "Virgo: Virgo podrá ser dueño de su propio destino en el 2021. ";
            }

            if ((dia >= 23 && mes == 9) || (dia <= 22 && mes == 10))
            {
                return "Libra: Para Libra el 2021 será un año lleno de cambios que requerirán incluso un tiempo de mudanza. ";
            }

            if ((dia >= 23 && mes == 10) || (dia <= 22 && mes == 11))
            {
                return "Escorpio: El estado mental de Escorpio será más metódico y disciplinado en el 2021. ";
            }

            if ((dia >= 23 && mes == 11) || (dia <= 22 && mes == 12))
            {
                return "Sagitario: Gran año para los Sagitario. ";

            }

            if ((dia >= 23 && mes == 12) || (dia <= 20 && mes == 1))
            {
                return "Capricornio: En el 2021 se podrán hacer realidad tus proyectos más ambiciosos, pero antes habrá un periodo muy difícil. ";

            }

            if ((dia >= 21 && mes == 1) || (dia <= 19 && mes == 2))
            {
                return "Acuario: Acuario pasará por tiempos increíbles de renovación e innovación en el 2021. ";

            }

            if ((dia >= 20 && mes == 2) || (dia <= 20 && mes == 3))
            {
                return "Piscis: Para los Piscis, el 2021 estará lleno de un cúmulo de situaciones favorables para casi todos sus asuntos. ";

            }


            return "";
        }
        
    }
}


