using Microsoft.AspNetCore.Mvc;
using MSPriseDeRendez_Vous.Services;
using MSPriseDeRendezVous.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MSPriseDeRendezVous.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MSPrisedeRendezVousController : ControllerBase
    {
        private readonly IRendezVousService _rendezVousService;

        public MSPrisedeRendezVousController(IRendezVousService rendezVousService)
        {
            _rendezVousService = rendezVousService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<RendezVous>> GetRendezVous()
        {
            var rendezVousList = _rendezVousService.GetRendezVous();
            return Ok(rendezVousList);
        }

        [HttpGet("{id}")]
        public ActionResult<RendezVous> GetRendezVousById(int id)
        {
            var rendezVous = _rendezVousService.GetRendezVousById(id);

            if (rendezVous == null)
            {
                return NotFound();
            }

            return Ok(rendezVous);
        }

        [HttpPost]
        public ActionResult<RendezVous> CreateRendezVous(RendezVous rendezVous)
        {
            var createdRendezVous = _rendezVousService.CreateRendezVous(rendezVous);
            return CreatedAtAction(nameof(GetRendezVousById), new { id = createdRendezVous.Id }, createdRendezVous);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateRendezVous(int id, RendezVous rendezVous)
        {
            if (id != rendezVous.Id)
            {
                return BadRequest();
            }

            var updatedRendezVous = _rendezVousService.UpdateRendezVous(id, rendezVous);

            if (updatedRendezVous == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteRendezVous(int id)
        {
            var deletedRendezVous = _rendezVousService.DeleteRendezVous(id);

            if (deletedRendezVous == null)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
