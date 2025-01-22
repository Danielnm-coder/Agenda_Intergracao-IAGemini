using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoGemini.Dtos;
using ProjetoGemini.Services;

namespace ProjetoGemini.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgendaController : ControllerBase
    {
        private readonly GeminiService _geminiService;

        public AgendaController(GeminiService geminiService)
        {
            _geminiService = geminiService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] AgendaRequestDto request)
        {
            return Ok(_geminiService.OrganizarAgenda(request));
        }

        [HttpPost("Busca")]
        public IActionResult Busca([FromBody] string busca)
        {
            return Ok(_geminiService.RealizarBusca(busca));
        }
    }
}



