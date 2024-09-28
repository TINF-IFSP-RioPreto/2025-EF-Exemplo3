using Microsoft.EntityFrameworkCore;

namespace EF.Exemplo3;

public class ProdutoDbContext : DbContext
{
    public DbSet<Produto> tblProdutos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseNpgsql(@"Host=10.0.1.95;" +
                                 "Username=netuser;" +
                                 "Password=netpassword;" +
                                 "Database=exemplo3");
    }
}
