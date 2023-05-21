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
                new ColumnDto { Name = "PersonaId", ColumnType = ColumnType.String  },
                new ColumnDto { Name = "DateOfBirth", ColumnType = ColumnType.Date  },
                new ColumnDto { Name = "Age", ColumnType = ColumnType.String }
            };
        }
    }
}
