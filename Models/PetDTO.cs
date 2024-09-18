using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VetCare_BackEnd.Models
{
    public class PetDTO
    {
    public required string Name { get; set; }
    public required string Breed { get; set; }
    public required string Weight { get; set; }
    public required DateOnly BirthDate { get; set; }
    public required string Sex { get; set; }
    }
}