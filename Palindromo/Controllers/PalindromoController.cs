using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


//UNIVERSIDAD TECNOLOGICA METROPOLITANA
// JOEL IVAN CHUC UC
//APLICACIONES WEB ORIENTADAS A SERVICIOS
//CARLOS MANUEL MEZQUITA ALVARADO
// PALINDROMOS
// 4 ° B
//PARCIAL 1
// SEPTIEMBRE - DICIEMBRE 2021




namespace Palindromo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PalindromoController : ControllerBase
    {
        [HttpGet]
        public IActionResult PalindromoResultado(string guardar)
        {
            //DECLARACÍON DE VARIABLES

            var P = new Palindromos();
            P.palindromo = guardar;
            var PFinal = string.Empty;
            var Pcontar = guardar;
            int i = Pcontar.Length;
            var PalindrFinal = "";


            //OPERACIONES - CALCULOS - DESARROLLO //
            for (int n = i - 1; n >= 0; n--)
            {

            }

            for (int j = i - 1; j >= 0; j--)
            {
                PFinal = PFinal + Pcontar[j];
            }

            if (PFinal.ToLower().Replace(" ", string.Empty) == Pcontar.ToLower().Replace(" ", string.Empty))
            {
                PalindrFinal = (Pcontar + " ES UN PALINDROMO.");
            }

            else
            {
                PalindrFinal = (Pcontar + " NO ES UN PALINDROMO.");
            }

            // RESULTADO //
            int Palabras = Pcontar.Length - Pcontar.Replace(" ", string.Empty).Count() + 1;
            var ResultadoInvert = ("LA PALABRA: " + PalindrFinal.ToLower() + " INVERTIDO SERIA: " + PFinal.ToLower() + ", TIENE UN TOTAL DE: " + Palabras + " PALABRAS");
            return Ok(ResultadoInvert.ToLower());
            //LOWER para diferenciar entre mayusculas y minisculas


        }
    }
}
