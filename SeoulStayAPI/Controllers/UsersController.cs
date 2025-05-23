using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SeoulStayAPI.Context;
using SeoulStayAPI.Models;

namespace SeoulStayAPI.Controllers
{
    [Route("api/[controller]/{action}")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly AppDbContext db;

        public UsersController(AppDbContext context)
        {
            db = context;
        }

        [HttpPost]
        public ActionResult PostUser(User newUser)
        {
            var user = db.Users.FirstOrDefault(u => u.Username == newUser.Username && u.Password == newUser.Password);
            if (user == null)
            {
                return NotFound("No");
            }
            return Ok("Yes");
        }

    }
}
