using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{
    public class Context : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; } // Informando o EntityFramework informando que tem uma tabela do tipo categoria com o nome Categorias
        public DbSet<Produto> Produtos { get; set; } // Informando o EntityFramework informando que tem uma tabela do tipo Produto com o nome Protudo
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString:@"Server=(localdb)\mssqllocaldb;Database=Cursomvc;Integrated Security=True"); //Configuração do local do banco de dados
        }
    }
}
