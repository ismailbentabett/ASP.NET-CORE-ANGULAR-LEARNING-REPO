using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace InspectionApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Inspection> Inspections { get; set; }
        public DbSet<InspecionType> InspecionTypes { get; set; }
        public DbSet<Status> Statuses { get; set; }

    }

}