using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VetCare_BackEnd.Data;

namespace VetCare_BackEnd.Controllers.V1.DocumentTypes
{
    [ApiController]
    [Route("api/v1/DocumentTypes")]
    public partial class DocumentTypeController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public DocumentTypeController(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}