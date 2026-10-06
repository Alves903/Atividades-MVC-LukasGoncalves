using Microsoft.AspNetCore.Mvc;
using ProdutosMVC.Models;
using System.Collections.Generic;

namespace ProdutosMVC.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            List<Produto> produtos = new List<Produto>();

            produtos.Add(new Produto { Id = 1, Nome = "Teclado", Categoria = "Periféricos", Estoque = 10, Preco = 120.00m });
            produtos.Add(new Produto { Id = 2, Nome = "Mouse", Categoria = "Periféricos", Estoque = 15, Preco = 80.00m });
            produtos.Add(new Produto { Id = 3, Nome = "Monitor", Categoria = "Monitores", Estoque = 5, Preco = 950.00m });
            produtos.Add(new Produto { Id = 4, Nome = "Headset", Categoria = "Áudio", Estoque = 0, Preco = 150.00m });
            produtos.Add(new Produto { Id = 5, Nome = "Webcam", Categoria = "Periféricos", Estoque = 7, Preco = 200.00m });
            produtos.Add(new Produto { Id = 6, Nome = "Notebook", Categoria = "Computadores", Estoque = 3, Preco = 3200.00m });
            produtos.Add(new Produto { Id = 7, Nome = "SSD 1TB", Categoria = "Armazenamento", Estoque = 12, Preco = 400.00m });
            produtos.Add(new Produto { Id = 8, Nome = "Memória RAM 16GB", Categoria = "Hardware", Estoque = 8, Preco = 350.00m });
            produtos.Add(new Produto { Id = 9, Nome = "Controle", Categoria = "Games", Estoque = 0, Preco = 280.00m });
            produtos.Add(new Produto { Id = 10, Nome = "Caixa de Som", Categoria = "Áudio", Estoque = 6, Preco = 180.00m });

            return View(produtos);
        }

        public IActionResult Disponiveis()
        {
            List<Produto> produtos = new List<Produto>();

            produtos.Add(new Produto { Id = 1, Nome = "Teclado", Categoria = "Periféricos", Estoque = 10, Preco = 120.00m });
            produtos.Add(new Produto { Id = 2, Nome = "Mouse", Categoria = "Periféricos", Estoque = 15, Preco = 80.00m });
            produtos.Add(new Produto { Id = 3, Nome = "Monitor", Categoria = "Monitores", Estoque = 5, Preco = 950.00m });
            produtos.Add(new Produto { Id = 4, Nome = "Headset", Categoria = "Áudio", Estoque = 0, Preco = 150.00m });
            produtos.Add(new Produto { Id = 5, Nome = "Webcam", Categoria = "Periféricos", Estoque = 7, Preco = 200.00m });
            produtos.Add(new Produto { Id = 6, Nome = "Notebook", Categoria = "Computadores", Estoque = 3, Preco = 3200.00m });
            produtos.Add(new Produto { Id = 7, Nome = "SSD 1TB", Categoria = "Armazenamento", Estoque = 12, Preco = 400.00m });
            produtos.Add(new Produto { Id = 8, Nome = "Memória RAM 16GB", Categoria = "Hardware", Estoque = 8, Preco = 350.00m });
            produtos.Add(new Produto { Id = 9, Nome = "Controle", Categoria = "Games", Estoque = 0, Preco = 280.00m });
            produtos.Add(new Produto { Id = 10, Nome = "Caixa de Som", Categoria = "Áudio", Estoque = 6, Preco = 180.00m });

            List<Produto> disponiveis = produtos.Where(p => p.Estoque > 0).ToList();

            return View(disponiveis);
        }
    }
}