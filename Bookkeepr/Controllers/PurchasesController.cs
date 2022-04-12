using Microsoft.AspNetCore.Mvc;
using DataModels.Models;

namespace Bookkeepr.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PurchasesController : Controller
    {
        [HttpGet]
        public Purchase Get()
        {
            return new Purchase { Id = 1, BookId = 1, Date = DateTime.Now, Price = 15.5, UserId = 1};
        }
    }
}
