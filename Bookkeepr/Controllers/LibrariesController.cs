using Microsoft.AspNetCore.Mvc;
using DataModels.Models;

namespace Bookkeepr.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LibrariesController : ControllerBase
    {
        [HttpGet]
        public Library Get()
        {
            return new Library 
            { 
                Id = 1, 
                Name = "Agnija's library", 
                Purchases = new List<Purchase> 
                { 
                    new Purchase 
                    { 
                        Id = 1, 
                        BookId = 1, 
                        Date = DateTime.Now, 
                        Price = 15.5, 
                        UserId = 1 
                    } 
                } 
            };
        }
    }
}
