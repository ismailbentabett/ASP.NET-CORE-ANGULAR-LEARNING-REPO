using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace InspectionApi
{
    public class Inspection
    {
        public int Id { get; set; }
        [StringLength(20)]
        public string Status { get; set; } = string.Empty;
        [StringLength(200)]
        public string Comments { get; set; } = string.Empty;

        public int InspecionTypeId { get; set; }

        [StringLength(20)]
        public InspecionType InspectionType { get; set; }


    }
}