using Microsoft.AspNetCore.Mvc;

namespace OlaMundo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OlaMundoController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Olá Mundo!";
        }

        [HttpGet]
        [Route("[action")]
        public string ObterNome()
        {
            return "Olá Mundo!";
        }

        [HttpPost]
        public string Post([FromBody] OlaMundoParametro pFrase)
        {
            return pFrase.frase;
        }
    }
}