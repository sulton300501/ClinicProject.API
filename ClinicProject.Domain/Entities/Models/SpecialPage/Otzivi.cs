using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicProject.Domain.Entities.Models.SpecialPage
{
    public class Otzivi
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string DateTime { get; set; }
        public string Description { get; set; }
        public string Brach { get; set; }
        public int Usligi { get; set; }
        public string ImageName { get; set; }
    }
}
