using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Alcoholemia.Api.Infrectuctura;

/*Nombre de la escuela: Universidad Tecnologica Metropolitana
Asignatura: Aplicaciones Web Orientadas a Servicios
Nombre del Maestro: Chuc Uc Joel Ivan
Nombre de la actividad: Actividad 2
Nombre del alumno: Pedro Victor Ruvalcaba Novelo
Cuatrimestre: 4
Grupo: B
Parcial: 2
*/

namespace Alcoholemia.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Alcoholimetro : ControllerBase
    {
        [HttpGet]
        public string resultado (string bebida, double cantidad, double peso)

        {

            double alcoholnivel;

            var repositorio = new OperacionA();

            alcoholnivel = repositorio.PruebaAlcoholemia(bebida, cantidad, peso);

            if(alcoholnivel <= 0.8)

            {

                return "Puede seguir su camino";

            }

            else

            {

                return "Usted esta detenido por borracho";

            }
        }
    }
}
