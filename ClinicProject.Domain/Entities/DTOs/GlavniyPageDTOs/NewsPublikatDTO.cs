using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicProject.Domain.Entities.DTOs.GlavniyPageDTOs
{
    public class NewsPublikatDTO
    {
        public IFormFile? Image { get; set; }
        public string? ImagePath { get; set; }
        public string? Body { get; set; }
    }
}
