using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VetCare_BackEnd.Data;
using VetCare_BackEnd.Services;

namespace VetCare_BackEnd.Controllers.V1.Pets
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public partial class PetController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly JwtHelper _jwtHelper;

        public PetController(ApplicationDbContext context, JwtHelper jwtHelper)
        {
            _context = context;
            _jwtHelper = jwtHelper;
        }
    }
}