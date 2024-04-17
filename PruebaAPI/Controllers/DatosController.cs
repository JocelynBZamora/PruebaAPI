using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PruebaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatosController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            string[] datos = new string[] { "Hola Mundo", "Adios" };
            return Ok(datos);
        }
        [HttpGet("numero")]
        public IActionResult GetNumero()
        {
            return Ok(2000);
        }
        [HttpGet("{nombre}")]
        public IActionResult Saludo(string nombre)
        {
            return Ok("Hola "+ nombre);
        }
        [HttpPost]
        public IActionResult Post(int numero) 
        {
            return Ok(numero*numero); 
        }
    }
}
