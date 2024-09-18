using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VetCare_BackEnd.Data;
using VetCare_BackEnd.Models;

namespace VetCare_BackEnd.Controllers.V1.DocumentTypes;


public partial class DocumentTypeController
{


    [HttpPost()]
    public async Task<IActionResult> Create([FromBody] DocumentType newDocumentType)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        _context.DocumentTypes.Add(newDocumentType);
        await _context.SaveChangesAsync();
        return Ok("user add succesfuly");
    }



}
