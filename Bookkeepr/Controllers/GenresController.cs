using Microsoft.AspNetCore.Mvc;
using DataModels.Models;
namespace Bookkeepr.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GenresController : Controller
    {
        [HttpGet]
        public Genre Get()
        {
            return new Genre{ Id = 1, Name = "Gothic"};
        }
    }
}
