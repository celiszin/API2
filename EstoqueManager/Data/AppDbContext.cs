using Microsoft.EntityFrameworkCore;
using EstoqueManager.Models;

namespace EstoqueManager.Data;

public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Funcionario> Funcionarios { get; set; }
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Cliente_Foto> Cliente_Fotos { get; set; }

}