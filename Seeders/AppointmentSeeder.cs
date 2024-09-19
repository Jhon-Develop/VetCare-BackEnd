using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VetCare_BackEnd.Models;

namespace VetCare_BackEnd.Seeders
{
    public class AppointmentSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>().HasData(
                new Appointment { Id = 1, StartDate = new DateTime(2023, 08, 22, 06, 51, 58), EndDate = new DateTime(2023, 08, 22, 06, 51, 58), Available = false, Description = "cardiology", PetId = 1, AppointmentTypeId = 2},
                new Appointment { Id = 2, StartDate = new DateTime(2023, 07, 22, 06, 51, 58), EndDate = new DateTime(2023, 08, 22, 06, 51, 58), Available = true, PetId = 2, AppointmentTypeId = 1},
                new Appointment { Id = 3, StartDate = new DateTime(2023, 06, 22, 06, 51, 58), EndDate = new DateTime(2023, 08, 22, 06, 51, 58), Available = false, Description = "cardiology", PetId = 3, AppointmentTypeId = 2},
                new Appointment { Id = 4, StartDate = new DateTime(2023, 05, 22, 06, 51, 58), EndDate = new DateTime(2023, 08, 22, 06, 51, 58), Available = true, PetId = 4, AppointmentTypeId = 1},
                new Appointment { Id = 5, StartDate = new DateTime(2023, 04, 22, 06, 51, 58), EndDate = new DateTime(2023, 08, 22, 06, 51, 58), Available = false, Description = "cardiology", PetId = 5, AppointmentTypeId = 2},
                new Appointment { Id = 6, StartDate = new DateTime(2023, 03, 22, 06, 51, 58), EndDate = new DateTime(2023, 08, 22, 06, 51, 58), Available = true, PetId = 6, AppointmentTypeId = 1},
                new Appointment { Id = 7, StartDate = new DateTime(2023, 02, 22, 06, 51, 58), EndDate = new DateTime(2023, 08, 22, 06, 51, 58), Available = false, Description = "cardiology", PetId = 6, AppointmentTypeId = 2},
                new Appointment { Id = 8, StartDate = new DateTime(2023, 01, 22, 06, 51, 58), EndDate = new DateTime(2023, 08, 22, 06, 51, 58), Available = true, PetId = 7, AppointmentTypeId = 1}
            );
        }
    }
}