using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IMS.Models;

namespace IMS.Data
{
    public class IMSContext : DbContext
    {
        public IMSContext (DbContextOptions<IMSContext> options)
            : base(options)
        {
        }

        public DbSet<IMS.Models.Course> Course { get; set; }

        public DbSet<IMS.Models.Student> Student { get; set; }

        public DbSet<IMS.Models.ContactUs> ContactUs { get; set; }
    }
}
