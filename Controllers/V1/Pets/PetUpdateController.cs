using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VetCare_BackEnd.Models;

namespace VetCare_BackEnd.Controllers.V1.Pets
{
    public partial class PetController
    {
        /// <summary>
        /// Update a pet
        /// </summary>
        /// <param name="_petDTO">New data to change in the pet</param>
        /// <param name="id">The id of the pet that is going to be update</param>
        /// <returns>An 200 http alert</returns>
        [HttpPut("UpdatePet/{id}")]
        public async Task<IActionResult> UpdatePet([FromForm]PetDTO _petDTO, int id)
        {
            if (_petDTO == null)
            {
                return BadRequest("Pet data is null");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var petToConvert = await _context.Pets.FindAsync(id);

            if (petToConvert == null)
            {
                return NotFound("Pet not found");
            }

            // ------------ Asi seria codigo Spaghetti --------------------

            // petToConvert.Name = _petDTO.Name.ToLower();

            // petToConvert.Breed = _petDTO.Breed.ToLower();

            // petToConvert.Weight = _petDTO.Weight.ToUpper();

            // -----------------------------------------------------------


            if (_petDTO.BirthDate.Year > DateTime.Now.Year)
            {
                return BadRequest("We have not yet reached the target date");
            }

            // ------------ Asi seria codigo Spaghetti --------------------

            // petToConvert.BirthDate = _petDTO.BirthDate;

            // petToConvert.Sex = _petDTO.Sex.ToLower();

            // --------------------------------------------------------------

            if (petToConvert.ImagePath == null)
            {
                return BadRequest("No data in the storage");
            }
            if (petToConvert.DeleteHash == null)
            {
                return BadRequest("No data in the 'deleteHash' field");
            }
            if (_petDTO.Image == null)
            {
                return BadRequest("No data in the image field");
            }

            // Esto va a la entidad Pet y le cambia los valores que encuentre iguales a los del DTO
            _context.Entry(petToConvert).CurrentValues.SetValues(_petDTO);

            var deleteHash = petToConvert.DeleteHash;

            await _imageHelper.DeleteImage(deleteHash);

            var jsonResponse = await _imageHelper.PostImage(_petDTO.Image);

            petToConvert.ImagePath = jsonResponse["data"]?["link"]?.ToString();

            petToConvert.DeleteHash = jsonResponse["data"]?["deletehash"]?.ToString();

            // Esto me marca la entidad Pet como modificada
            _context.Entry(petToConvert).State = EntityState.Modified;

            await _context.SaveChangesAsync();
            return Ok("Pet Updated successfully");


        }
    }
}