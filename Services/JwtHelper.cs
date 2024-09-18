using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;

namespace VetCare_BackEnd.Services
{
    public class JwtHelper
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public JwtHelper(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<string> GetIdFromJWT()
        {

            var httpContext = _httpContextAccessor.HttpContext;
            if (httpContext != null)
            {
                // Acceder al JWT token desde el encabezado de autorización
                var token = httpContext.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
                if (token != null)
                {
                    // Decodificar el token y extraer la información que necesitas
                    var jwtSecurityToken = new JwtSecurityTokenHandler().ReadJwtToken(token);
                    var userId = jwtSecurityToken.Claims.FirstOrDefault(c => c.Type == "id")?.Value;
                    return userId;
                }
            }

            return null;
        }
    }
}