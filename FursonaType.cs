using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp
{
    public class FursonaType
    {
        public int FursonaTypeId { get; set; }

        public string? FursonaTypeName { get; set; }

        public virtual ObservableCollectionListSource<Species> Speciess { get; } = new();
    }
}
