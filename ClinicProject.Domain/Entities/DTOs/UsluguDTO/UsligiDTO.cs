using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicProject.Domain.Entities.DTOs.UslugiDTO
{
    public class UsligiDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public IFormFile Image { get; set; }
        public string ImageUrl { get; set; }
    }
}
