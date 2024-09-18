using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VetCare_BackEnd.Models
{
    [Table("appointments")]
    public class Appointment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime StartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateOnly EndDate { get; set; }

        [Required]
        public bool Available { get; set; }

        //Delete the length restriction
        public string? Description { get; set; }

        // Foreign Keys
        public required int PetId { get; set; }
        public required int AppointmentTypeId { get; set; }

        // Navigation properties
        [NotMapped]
        [ForeignKey("PetId")]
        public Pet? Pet { get; set; }

        [NotMapped]
        [ForeignKey("AppointmentTypeId")]
        public AppointmentType? AppointmentType { get; set; }
    }
}