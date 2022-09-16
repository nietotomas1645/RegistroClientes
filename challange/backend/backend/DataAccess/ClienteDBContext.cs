using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.DataAccess
{
    public class ClienteDBContext : DbContext
    {
        public ClienteDBContext(DbContextOptions<ClienteDBContext> options) : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
