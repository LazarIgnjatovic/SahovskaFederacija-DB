using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SahovskaFederacija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SahovskaFederacijaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TurnirController : Controller
    {
        [HttpGet]
        [Route("PreuzmiTurnire")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetTurniri()
        {
            try
            {
                return new JsonResult(DTOManager.vratiSveTurnire());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpGet]
        [Route("PreuzmiSponzoreTurnira/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetSponzoriTurnira(int id)
        {
            try
            {
                return new JsonResult(DTOManager.vratiSponzoreTurnira(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpGet]
        [Route("PreuzmiPartijeTurnira/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetPartijeTurnira(int id)
        {
            try
            {
                return new JsonResult(DTOManager.vratiPartijeTurnira(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiOrganizatoreTurnira/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetOrganizatoriTurnira(int id)
        {
            try
            {
                return new JsonResult(DTOManager.vratiOrganizatoreTurnira(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajTurnir")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddTurnir([FromBody] TurnirPregled t)
        {
            try
            {
                DTOManager.dodajTurnir(t);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPut]
        [Route("DodajPartijuTurnira/{idTurnira},{beli},{crni},{isMajstor},{idS}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddPartijuTurnira(int idTurnira, [FromBody] PartijaPregled p, int beli, int crni, bool isMajstor, int idS)
        {
            try
            {
                DTOManager.dodajPartijuTurnira(idTurnira, p, beli, crni, isMajstor, idS);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPut]
        [Route("DodajOrganizatoraTurnira/{idTur},{idOrg}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddOrganizatoriTurnira(int idTur, int idOrg)
        {
            try
            {
                DTOManager.dodajOrganizatoraTurnira(idTur,idOrg);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPut]
        [Route("ObrisiOrganizatoraTurnira/{idTur},{idOrg}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteOrganizatoriTurnira(int idTur, int idOrg)
        {
            try
            {
                DTOManager.obrisiOrganizatoraTurnira(idTur,idOrg);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("PromeniTurnir")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ChangeTurnir([FromBody] TurnirPregled t)
        {
            try
            {
                DTOManager.izmeniTurnir(t);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiTurnir/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteTurnir(int id)
        {
            try
            {
                DTOManager.obrisiTurnir(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}
