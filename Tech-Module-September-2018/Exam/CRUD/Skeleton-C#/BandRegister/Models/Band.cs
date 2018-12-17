using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BandRegister.Models
{
    public class Band
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Members { get; set; }

        public float Honorarium { get; set; }

        public string Genre { get; set; }
    }
}
