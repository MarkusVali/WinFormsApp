using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp
{
    public class Species
    {
        public int SpeciesId { get; set; }

        public string? SpeciesName { get; set; }

        public int FursonaTypeId { get; set; }
        public virtual FursonaType FursonaType { get; set; } = null!;
    }
}
