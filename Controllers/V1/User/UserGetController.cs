using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using VetCare_BackEnd.Data;
using VetCare_BackEnd.Models;

namespace VetCare_BackEnd.Controllers.V1
{

    public partial class UserController
    {


        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers(
            [FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10

        )


        {
            if (pageNumber < 1)
            {
                return BadRequest("The number page must be equal or greater than 1");
            }

            if (pageSize < 1)
            {
                return BadRequest("The page Size  must be equal or greater than 1");
            }
            var Users = await _userService.Users
             .Skip((pageNumber - 1) * pageSize)
             .Take(pageSize)
             .ToListAsync();
            return Ok(Users);
        }

        //GET /Users/ id/{id}

        [HttpGet("{id}")]
        public async Task<ActionResult> GetUserById(int id)
        {
            var Usersearch = await _userService.Users.FindAsync(id);
            return Ok(Usersearch);
        }

        [HttpGet("findByName/{name}")]

        public async Task<ActionResult<IEnumerable<User>>> GetUserByname([FromRoute]string name)
        {
            var Usersearch = await _userService.Users.FirstOrDefaultAsync(p => p.Name.Contains(name));
            if (Usersearch == null)
            {
                return NotFound("This name is not in our sistem"); // Return 404 if the user is not found
            }
            return Ok(Usersearch);
        }

        [HttpGet("FindByInitial/{initial}")]

        public async Task<ActionResult> GetUserByLetter(string initial)
        {
            var Usersearch = await _userService.Users.Where(p => p.Name.StartsWith(initial)).ToListAsync();
            if (Usersearch == null)
            {
                return NotFound("There is Not a name that start with that letter");
            }
            return Ok(Usersearch);
        }


        [HttpGet("getbykeyword")]
    public async Task<IActionResult> GetByKeyword([FromQuery] string keyword)
    {
        if(string.IsNullOrEmpty(keyword))
        {
            return BadRequest("Keyword is required");
        }

        var users = await _userService.Users.ToListAsync();

        var result = users.Where(r => 
            r.Name.Contains(keyword, System.StringComparison.OrdinalIgnoreCase)).
        ToList();
        
        if(result.Count() == 0)
        {
            return NotFound("No roles found with that keyword");
        }
        return Ok(result);
    }

    }

}


