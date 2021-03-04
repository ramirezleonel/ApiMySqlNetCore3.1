using Microsoft.EntityFrameworkCore;
using ApiNet.Models;



namespace ApiNet.Models
{ public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }

        public DbSet<ApiNet.Models.Usuarios> Usuarios { get; set; }
    }
}