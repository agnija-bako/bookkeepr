using Microsoft.AspNetCore.Mvc;
using DataModels.Models;

namespace Bookkeepr.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
       [HttpGet]
        public User Get()
        {
            return new User 
            { 
                Id = 1, 
                Name = "Agnija Bako",
                Email = "agnijabako@something.com", 
                Libraries = new List<Library>() 
                { 
                    new Library 
                    { 
                        Id = 1, 
                        Name = "Agnija's library" 
                    } 
                } 
            };
        }
    }
}
