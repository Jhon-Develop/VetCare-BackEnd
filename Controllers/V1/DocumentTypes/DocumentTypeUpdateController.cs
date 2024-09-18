using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VetCare_BackEnd.Data;
using VetCare_BackEnd.Models;

namespace VetCare_BackEnd.Controllers.V1.DocumentTypes
{

    public partial class DocumentTypeController
    {

        [HttpPut("{id}")]

        public async Task<IActionResult> Update([FromRoute]int id, [FromBody] DocumentType newDocumentTypeName)
        {
            
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }


            var DocumentToUpdate = await _context.DocumentTypes.FindAsync(id);

            if (DocumentToUpdate == null)
            {
                return NotFound("it was not found");
            }

            
            await _context.SaveChangesAsync();
            return Ok("The Document Type Name has been updated successfully");

        }
    }
}