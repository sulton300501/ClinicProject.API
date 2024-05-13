using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicProject.Domain.Entities.DTOs.GlavniyPageDTOs
{
    public class SpecialCardDTO
    {

        public IFormFile Image { get; set; }
        public string ImageUrl { get; set; }
        public string Country { get; set; }
        public string Name { get; set; }
        public string ClinicName { get; set; }
        public string SpecialDegree { get; set; }
        public string WorkYear { get; set; }
        public string JobName { get; set; }

    }
}
