using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace InspectionApi
{
    public class InspecionType
    {
             public int Id { get; set; }
        [StringLength(20)] 
        public string inspectionName  { get; set; } = string.Empty;
    }
}