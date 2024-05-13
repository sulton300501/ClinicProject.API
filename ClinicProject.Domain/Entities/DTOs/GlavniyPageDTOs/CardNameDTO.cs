using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicProject.Domain.Entities.DTOs.GlavniyPageDTOs
{
    public class CardNameDTO
    {

        public string Name { get; set; }
        public string ClinicName { get; set; }
        public string Description { get; set; }
        public IFormFile? ImagePath { get; set; }
        public string ImageUrl { get; set; }


    }
}
