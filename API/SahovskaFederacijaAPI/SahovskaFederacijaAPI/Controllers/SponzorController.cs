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
    public class SponzorController : Controller
    {

        [HttpGet]
        [Route("PreuzmiSponzora/{idSponzora}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetSponzora(int idSponzora)
        {
            try
            {
                return new JsonResult(DTOManager.vratiSponzora(idSponzora));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajSponzora/{idTurnira}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddPartijuTurnira([FromBody] SponzorPregled s, int idTurnira)
        {
            try
            {
                DTOManager.dodajSponzora(s, idTurnira);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("PromeniSponzora")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ChangePartijuTurnira([FromBody] SponzorPregled s)
        {
            try
            {
                DTOManager.izmeniSponzora(s);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiSponzora")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeletePartiju([FromBody] SponzorPregled s)
        {
            try
            {
                DTOManager.obrisiSponzora(s);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}

