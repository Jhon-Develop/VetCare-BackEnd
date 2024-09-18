
using Microsoft.AspNetCore.Mvc;
using VetCare_BackEnd.Models;

namespace VetCare_BackEnd.Controllers.V1;

    public partial class UserController 
    {
        

        [HttpPost("create")]
        public async Task<IActionResult> Create(User newUser)
        {
            _userService.Users.Add(newUser);
            await _userService.SaveChangesAsync();
            return Ok("usuario creado");
        }


    }
