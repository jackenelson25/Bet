using BetApp.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BetApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : Controller
    {
        private MovieDbContext context;
        public MovieController(MovieDbContext temp)
        {
            context = temp;
        }
        public IEnumerable<MovieData> Get()
        {
            var x = context.Movies
                .Where(m => m.Edited == "Yes")
                .OrderBy(m => m.Title)
                .ToArray();
            return x;
        }
    }
}