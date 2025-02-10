using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiCode.Models
{
    [Table("TraineeTable")]
    public class Trainee
    {
        [Key]
        public int TraineeId { get; set; }
        [Required]
        public string TraineeName { get; set; } = string.Empty;
        [Required]
        public string EmailAddress { get; set; } = string.Empty ;
        [Required]
        public long PhoneNo { get; set; }
    }

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Trainee> Trainees { get; set; }
    }
}
