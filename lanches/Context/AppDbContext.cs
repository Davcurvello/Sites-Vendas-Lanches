using lanches.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace lanches.Context
{
    public class AppDbContext : IdentityDbContext <IdentityUser>
    //public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public DbSet<Lanche> Lanches { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet <CarrinhoCompraItem> CarrinhoCompraItens { get; set; }
        public DbSet<Pedido> Pedidos { get; set;}

        public DbSet<PedidoDetalhe> PedidoDetalhes { get; set; }




      
        //public IEnumerable<object> CarrinhoCompraItens { get; internal set; }
    }
}
