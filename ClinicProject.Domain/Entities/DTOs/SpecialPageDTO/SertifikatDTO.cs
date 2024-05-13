using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicProject.Domain.Entities.DTOs.SpecialPageDTO
{
    public class SertifikatDTO
    {
        public IFormFile? Image {  get; set; }
        public string? ImagePath { get; set; }
        public string? SertifikatNumber { get; set; }
    }
}
