using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Person.Common.DTO;

namespace PersonAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {

        public async Task<long> Save(string json)
        {
            return default(long);
        }

        public async Task<string> GetAll(GetAllRequestDTO request)
        {
            return default(string);
        }
    }
}
