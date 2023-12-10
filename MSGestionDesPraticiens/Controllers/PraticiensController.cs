using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MSGestionDesPraticiens.Models;
using MSGestionDesPraticiens.Services;

namespace MSGestionDesPraticiens.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PraticiensController : ControllerBase
    {
    private readonly IPraticienService _praticienService;

        public PraticiensController(IPraticienService praticienService)
        {
            _praticienService = praticienService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Praticien>> GetPraticiens()
        {
            var praticiens = _praticienService.GetPraticiens();
            return Ok(praticiens);
        }

        [HttpGet("{id}")]
        public ActionResult<Praticien> GetPraticienById(int id)
        {
            var praticien = _praticienService.GetPraticienById(id);

            if (praticien == null)
            {
                return NotFound();
            }

            return Ok(praticien);
        }

        [HttpPost]
        public ActionResult<Praticien> CreatePraticien(Praticien praticien)
        {
            var createdPraticien = _praticienService.CreatePraticien(praticien);
            return CreatedAtAction(nameof(GetPraticienById), new { id = createdPraticien.Id }, createdPraticien);
        }

        [HttpPut("{id}")]
        public IActionResult UpdatePraticien(int id, Praticien praticien)
        {
            if (id != praticien.Id)
            {
                return BadRequest();
            }

            var updatedPraticien = _praticienService.UpdatePraticien(id, praticien);

            if (updatedPraticien == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePraticien(int id)
        {
            var deletedPraticien = _praticienService.DeletePraticien(id);

            if (deletedPraticien == null)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}

