using Microsoft.EntityFrameworkCore;
using Monkey_Finances.Models;

namespace Monkey_Finances.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options): base(options)
        {

        }

        public DbSet<RegistroModel> Registro { get; set; }
    }
}
