
using Microsoft.AspNetCore.Mvc;
using BackendCore.Models;

namespace BackendCore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehicleElementsController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult GetElement(string id)
        {
            // Dummy data
            var element = new VehicleElement
            {
                Id = "gear_shift",
                Name = "Levier de vitesse",
                DescriptionShort = "Permet de changer les vitesses.",
                DescriptionLong = "Ce levier permet de sélectionner les modes de conduite : D, N, R, P.",
                Models = new List<string> { "Mazda 3", "Toyota Corolla" },
                Audio = new Dictionary<string, string>
                {
                    { "fr", "gear_shift_fr.mp3" },
                    { "en", "gear_shift_en.mp3" }
                },
                Icon = "gear.svg"
            };

            return Ok(element);
        }
    }
}
