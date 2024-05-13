using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicProject.Domain.Entities.DTOs.OtzivDTO
{
    public class OtzivCardDTO
    {
        public string Name { get; set; }
        public string Year { get; set; }
        public string Body { get; set; }
        public string ImagePath { get; set; }
        public IFormFile Image { get; set; }

    }
}
