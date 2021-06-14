using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using API.Data;
using API.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    //[EnableCors("AllowOrigin")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            this._context = context;
        }
       
        [HttpGet]
        // public ActionResult<IEnumerable<AppUser>> GetUsers(){
            
        //     var user=_context.Users.ToList();
        //     return user;
        // }
         public async Task<IActionResult> GetUsers()
        {
            var user =await _context.Users.ToListAsync();
            return Ok(user);
        }

        //  [HttpGet("{id}")]
        // public ActionResult<AppUser> GetUser(int id){
            
        //     var user=_context.Users.Find(id);
        //     return user;
        // }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user =await _context.Users.FindAsync(id);
            return Ok(user);
        }
    }
}