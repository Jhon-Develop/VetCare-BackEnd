
using Microsoft.AspNetCore.Mvc;
using VetCare_BackEnd.Data;


namespace VetCare_BackEnd.Controllers.V1;


[ApiController]
[Route("api/v1/users")]
public partial class UserController : ControllerBase
{
    private readonly ApplicationDbContext _userService;

    public UserController(ApplicationDbContext userservice)
    {
        _userService = userservice;
    }
}
