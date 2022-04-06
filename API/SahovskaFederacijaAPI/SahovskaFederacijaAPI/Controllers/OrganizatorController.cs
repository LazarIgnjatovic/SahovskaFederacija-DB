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
    public class OrganizatorController : Controller
    {
        [HttpGet]
        [Route("PreuzmiOrganizatore")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetOrganizatori()
        {
            try
            {
                return new JsonResult(DTOManager.vratiOrganizatore());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajOrganizatora")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddOrganizatori([FromBody] OrganizatorPregled o)
        {
            try
            {
                DTOManager.dodajOrganizatora(o);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("PromeniOrganizatora")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ChangeOrganizator([FromBody] OrganizatorPregled o)
        {
            try
            {
                DTOManager.izmeniOrganizatora(o);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiOrganizatora/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteOrganizator(int id)
        {
            try
            {
                DTOManager.obrisiOrganizatora(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
