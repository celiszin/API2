using System.Collections.Generic;
using EstoqueManager.Models;
using Microsoft.EntityFrameworkCore;

namespace EstoqueManager.Models
{
    public class AppDbSeed
    {
        public AppDbSeed (ModelBuilder builder)
        {
            List<Produto> Produtos = new()
            {
                new Produto { ProdutoId = 1, Nome = "Eletronicos"}

            };
            builder.Entity<Produto>().HasData(Produtos);

            List<Produto> produtos = new()
            {
                // Eletronicos
                new Produto { ProdutoId = 1, Numero = 1,  Nome = "Monitor Accer 23.8 Polegadas", Descricao = "Monitor Gamer Acer Nitro Kg243y G0bi, 23.8 Polegadas, Full HD, 120Hz, 1ms"}
            };
            builder.Entity<Produto>().HasData(produtos);
        }
    }
}