using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VetCare_BackEnd.Models;

namespace VetCare_BackEnd.Controllers.V1;

public partial class UserController
{

    [HttpPut("{id}")]

    public async Task<IActionResult> Update([FromRoute] int id, [FromBody] User newUser)
    {

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }


        var UserToUpdate = await _userService.Users.FindAsync(id);

        if (UserToUpdate == null)
        {
            return NotFound("user was not found");
        }

        UserToUpdate.Name = newUser.Name;
        UserToUpdate.LastName = newUser.LastName;
        UserToUpdate.BirthDate = newUser.BirthDate;
        UserToUpdate.DocumentNumber = newUser.DocumentNumber;
        UserToUpdate.Password = newUser.Password;
        UserToUpdate.PhoneNumber = newUser.PhoneNumber;
        UserToUpdate.Email = newUser.Email;
        UserToUpdate.DocumentTypeId = newUser.DocumentTypeId;
        UserToUpdate.RoleId = newUser.RoleId;
        await _userService.SaveChangesAsync();
        return Ok("The user has been updated successfully");

    }


}
