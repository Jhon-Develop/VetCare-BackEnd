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
    [HttpDelete("{id}")]

    public async Task<IActionResult> Delete ([FromRoute] int id)
    {
        var deleteDocumentType= await _context.DocumentTypes.FindAsync( id);


        if( deleteDocumentType==null)
        {
            return NotFound (new {Message= "The document Type that your are looking for is not found"});
        }

        _context.DocumentTypes.Remove(deleteDocumentType);

        await _context.SaveChangesAsync();
        return Ok("The document Type has been deleted");
    }




}
