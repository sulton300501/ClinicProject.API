using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicProject.Domain.Entities.DTOs.GlavniyPageDTOs
{
    public class DokumentLitseniyonDTO
    {
        public IFormFile? Image { get; set; }
        public string? ImageName { get; set; }
        public string? LitsensiyonNumber { get; set; }

    }
}
