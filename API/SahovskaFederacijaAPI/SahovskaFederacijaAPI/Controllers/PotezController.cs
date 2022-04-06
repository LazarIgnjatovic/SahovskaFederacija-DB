using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SahovskaFederacija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SahovskaFederacijaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PotezController : Controller
    {

        [HttpGet]
        [Route("PreuzmiPotez/{idPoteza}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetPartijeTurnira(int idPoteza)
        {
            try
            {
                return new JsonResult(DTOManager.vratiPotez(idPoteza));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajPotezPartije/{idPartije}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddPartijuTurnira([FromBody] PotezPregled p, int idPartije)
        {
            try
            {
                DTOManager.dodajPotez(p,idPartije);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("PromeniPotez")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ChangePartijuTurnira([FromBody] PotezPregled p)
        {
            try
            {
                DTOManager.izmeniPotez(p);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiPotez/{idPoteza}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeletePartiju(int idPoteza)
        {
            try
            {
                DTOManager.obrisiPotez(idPoteza);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}

