using CsvBlazor.Shared;
using Microsoft.AspNetCore.Mvc;

namespace CsvBlazor.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConfigController : ControllerBase
    {
        [HttpGet("getInternalColumns")]
        public List<ColumnDto> Get()
        {
            return new List<ColumnDto>
            {
                new ColumnDto { Name = "PersonaId", MapTo = "maa" },
                new ColumnDto { Name = "Nombre", MapTo = "" },
                new ColumnDto { Name = "Edad", MapTo = "" }
            };
        }
    }
}
