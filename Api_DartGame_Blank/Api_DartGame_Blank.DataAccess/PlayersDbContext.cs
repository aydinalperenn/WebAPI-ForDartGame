using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi_DartGame.Entities;

namespace Api_DartGame_Blank.DataAccess
{
    public class PlayersDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            // ------------------  CHANGE THE FOLLOWING CHANGES ACCORDING TO YOUR OWN DATABASE INFORMATION AS IN THE EXAMPLE  ---------------------------------

            // SAMPLE:
            optionsBuilder.UseSqlServer("Server=YOURSERVER; Database=YOURDATABASE;uid=YOURID;pwd=YOURPASSWORD;Integrated Security=True; MultipleActiveResultSets=True; TrustServerCertificate=True ");
        }

        public DbSet<Players> Playerss { get; set; }
    }
}
