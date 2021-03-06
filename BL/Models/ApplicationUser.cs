using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    
      public  class ApplicationUser:IdentityUser
      {
        public int SSN { get; set; }

        public string ImagePath { get; set; }
        public string TripId { get; set; }
       
        public int CarId { get; set; }


        [ForeignKey("CarId")]
        public virtual Car Car { get; set; }


        [InverseProperty("Clients")]
        public virtual Trip Passenger { get; set; }
        [InverseProperty("Captain")]
        public virtual Trip Driver { get; set; }

      }
    public class ApplicationDBContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDBContext() : base()
        {

        }
        public ApplicationDBContext (DbContextOptions<ApplicationDBContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder) //added by mark
        {
            base.OnModelCreating(builder);
        }


        public DbSet<Car> Cars { get; set; }
        public DbSet<Trip> Trips { get; set; }

    }
   
   
}
