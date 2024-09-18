using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySqlX.XDevAPI.CRUD;
using VetCare_BackEnd.Data;

namespace VetCare_BackEnd.Controllers.V1;


    public partial class UserController
    {
        [HttpDelete]

        public async Task<ActionResult> Delete (int id)
        {
            var Usersearch = await _userService.Users.FindAsync(id);
            _userService.Users.Remove(Usersearch);
            _userService.SaveChanges();
            return Ok("The user has been deleted ");
        }

    }




