using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicProject.Domain.Entities.Models.Otziv
{
    public class OtzivCard
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Year { get; set; }
        public string Body { get; set; }
        public string Image {  get; set; }

    }
}
