using FundamentosApisASPNET.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FundamentosApisASPNET.Data
{
    public class ApiDbContext : IdentityDbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options): base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }
    }
}
