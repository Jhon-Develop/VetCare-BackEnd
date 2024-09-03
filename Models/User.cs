using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VetCare_BackEnd.Models
{
    [Table("users")]
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "The input is too long")]
        [MinLength(3, ErrorMessage = "The input is too short")]
        public required string Name { get; set; }


        [Required]
        [MaxLength(100, ErrorMessage = "The input is too long")]
        [MinLength(3, ErrorMessage = "The input is too short")]
        public required string LastName { get; set; }

        
        [DataType(DataType.Date)]
        public DateOnly? BirthDate { get; set; }

        [Required]
        [MaxLength(15, ErrorMessage = "The input is too long")]
        public required string DocumentNumber { get; set; }

        [Required]
        [MaxLength(200, ErrorMessage = "The input is too long")]
        public required string Password { get; set; }


        [Required]
        [MaxLength(15, ErrorMessage = "The input is too long")]
        [Phone(ErrorMessage = "The phone format is not valid, you can use this example format if you want => ### ### ## ##")]
        public required string PhoneNumber { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "The input is too long")]
        [EmailAddress(ErrorMessage = "The email format is not valid")]
        public required string Email { get; set; }

        // Foreign Keys
        public int DocumentType_id { get; set; }
        public int Role_id { get; set; }


        // Navigation properties
        [ForeignKey("Role_id")]
        public Role? Role { get; set; }

        [ForeignKey("DocumentType_id")]
        public DocumentType? DocumentType { get; set; }


    }
}