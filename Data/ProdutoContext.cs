using Microsoft.EntityFrameworkCore;
using ProdutoApp.Models;

namespace ProdutoApp.Data
{
    public class ProdutoContext : DbContext
    {
        public ProdutoContext(DbContextOptions<ProdutoContext> options) : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }  
    }
}
