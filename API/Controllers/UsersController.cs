using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using API.Data;
using API.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Authorization;

namespace API.Controllers
{
   
    //[EnableCors("AllowOrigin")]
    public class UsersController : BaseApiController
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            this._context = context;
        }
       
        [HttpGet]
        [AllowAnonymous]
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
        [Authorize]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user =await _context.Users.FindAsync(id);
            return Ok(user);
        }
    }
}