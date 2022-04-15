using Microsoft.AspNetCore.Mvc;
using DataModels.Models;

namespace Bookkeepr.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : Controller
    {
        [HttpGet]
        public Book Get()
        {
            return new Book
            {
                Id = 1,
                Author = "Elizabeth Kostova",
                Description =
                    "The Historian is a story of a young woman plunged into a labyrinth where the secrets of her family's past connect to an inconceivable evil",
                Genres = new List<Genre>
                {
                    new() {Id = 1, Name = "Gothic"}
                },
                Publisher = "Back Bay Books", Title = "The Historian",
                Rating = 3.9,
                Year = 2010
            };
        }
    }
}