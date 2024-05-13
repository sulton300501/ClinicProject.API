using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicProject.Domain.Entities.DTOs.SpecialPageDTO
{
    public class OtziviDTO
    {
        public IFormFile ImageName { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string DateTime { get; set; }
        public string Description { get; set; }
        public string Brach { get; set; }
        public int Usligi { get; set; }

        public IFormFile ImageUrlName { get; set; }
        public string ImageUrl { get; set; }
    }
}
