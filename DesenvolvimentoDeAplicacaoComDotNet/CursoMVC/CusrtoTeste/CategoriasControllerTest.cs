using CursoAPI.Controllers;
using CursoMVC.Models;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CusrtoTeste
{
    public class CategoriasControllerTest
    {
        private readonly Mock<DbSet<Categoria>> _mockSet;
        private readonly Mock<Context> _mockContext;
        private readonly Categoria _categoria;
        public CategoriasControllerTest()
        {
            _mockSet = new Mock<DbSet<Categoria>>();
            _mockContext = new Mock<Context>();
            _categoria = new Categoria { Id = 1, Descricao = "Teste Categoria" };

            _mockContext.Setup(m => m.Categorias).Returns(_mockSet.Object); // Definindo o que o Mock Context tem que passar

            _mockContext.Setup(m => m.Categorias.FindAsync(1)).ReturnsAsync(_categoria); //Vai Retornar a Categoria de teste




        }

        [Fact]
        public async Task Get_Categoria()
        {
            var service = new CategoriasController(_mockContext.Object);


            await service.GetCategoria(1);

            _mockSet.Verify(m => m.FindAsync(1), Times.Once());

        }

        //REsolver o problema do teste e criar os novos testes para as outras caterorias (Delete_Categoria, Get_Categoria, Post_Categoria e Put_Categoria)



    }
}
