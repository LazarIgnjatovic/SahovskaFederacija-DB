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
    public class PartijaController : Controller
    {

        [HttpGet]
        [Route("PreuzmiPartiju/{idPartije}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetPartijeTurnira(int idPartije)
        {
            try
            {
                return new JsonResult(DTOManager.vratiPartiju(idPartije));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpGet]
        [Route("PreuzmiPotezePartije/{idPartije}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetPotezePartije(int idPartije)
        {
            try
            {
                return new JsonResult(DTOManager.vratiPotezePartije(idPartije));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost]
        [Route("DodajPartijuTurnira/{idTurnira},{beli},{crni},{isMajstor},{idS}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddPartijuTurnira(int idTurnira,[FromBody] PartijaPregled p,int beli,int crni,bool isMajstor,int idS)
        {
            try
            {
                DTOManager.dodajPartijuTurnira(idTurnira,p,beli,crni,isMajstor,idS);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("PromeniPartijuTurnira/{idTurnira},{beli},{crni},{isMajstor},{idS}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ChangePartijuTurnira(int idTurnira, [FromBody] PartijaPregled p, int beli, int crni, bool isMajstor, int idS)
        {
            try
            {
                DTOManager.izmeniPartijuTurnira(idTurnira, p, beli, crni, isMajstor, idS);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiPartiju/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeletePartiju(int id)
        {
            try
            {
                DTOManager.obrisiPartiju(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
