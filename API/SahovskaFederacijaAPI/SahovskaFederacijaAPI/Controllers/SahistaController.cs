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
    public class SahistaController : ControllerBase
    {
       [HttpGet]
       [Route("PreuzmiSahiste")]
       [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetSahisti()
        {
            try
            {
                return new JsonResult(DTOManager.vratiSveSahiste());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiSahistu/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetSahista(int id)
        {
            try
            {
                return new JsonResult(DTOManager.vratiSahistu(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajSahistu")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddSahista([FromBody] SahistaPregled s)
        {
            try
            {
                DTOManager.dodajSahistu(s);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("PromeniSahistu")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ChangeSahista([FromBody] SahistaPregled s)
        {
            try
            {
                DTOManager.azurirajSahistu(s);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiSahistu/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteSahista(int id)
        {
            try
            {
                List<int> ids = new List<int> { id };
                DTOManager.obrisiSahiste(ids);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
