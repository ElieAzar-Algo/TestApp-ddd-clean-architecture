using Microsoft.EntityFrameworkCore;
using QCS.Domain.Entities;

namespace QCS.Domain.Context
{
    public class QCSContext : DbContext
    {
        public QCSContext(DbContextOptions<QCSContext> options): base(options)
        {

        }
        public DbSet<Users> Users {get; set;}

    }

}