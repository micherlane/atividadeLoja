using Microsoft.EntityFrameworkCore;

namespace loja.Models
{
   public class MyDbContext : DbContext
   {
       public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
       {
       }

       public DbSet<Usuario> Usuarios {get; set;}
       public DbSet<Categoria> Categorias {get; set;}
       public DbSet<Produto> Produtos {get; set;}
       public DbSet<Carrinho> Carrinhos{get; set;}

   }
}