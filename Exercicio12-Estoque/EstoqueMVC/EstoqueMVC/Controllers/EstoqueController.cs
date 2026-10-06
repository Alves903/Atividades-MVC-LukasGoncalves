using Microsoft.AspNetCore.Mvc;
using EstoqueMVC.Models;
using System.Collections.Generic;

namespace EstoqueMVC.Controllers
{
    public class EstoqueController : Controller
    {
        private List<Produto> CriarProdutos()
        {
            List<Produto> produtos = new List<Produto>();

            produtos.Add(new Produto { Id = 1, Nome = "Teclado", Categoria = "Periféricos", Estoque = 10, EstoqueMinimo = 5, Preco = 120.00m });
            produtos.Add(new Produto { Id = 2, Nome = "Mouse", Categoria = "Periféricos", Estoque = 3, EstoqueMinimo = 5, Preco = 80.00m });
            produtos.Add(new Produto { Id = 3, Nome = "Monitor", Categoria = "Monitores", Estoque = 0, EstoqueMinimo = 2, Preco = 950.00m });
            produtos.Add(new Produto { Id = 4, Nome = "Headset", Categoria = "Áudio", Estoque = 7, EstoqueMinimo = 3, Preco = 150.00m });
            produtos.Add(new Produto { Id = 5, Nome = "Webcam", Categoria = "Periféricos", Estoque = 2, EstoqueMinimo = 4, Preco = 200.00m });
            produtos.Add(new Produto { Id = 6, Nome = "Notebook", Categoria = "Computadores", Estoque = 5, EstoqueMinimo = 2, Preco = 3200.00m });
            produtos.Add(new Produto { Id = 7, Nome = "SSD 1TB", Categoria = "Armazenamento", Estoque = 1, EstoqueMinimo = 3, Preco = 400.00m });
            produtos.Add(new Produto { Id = 8, Nome = "Memória RAM", Categoria = "Hardware", Estoque = 8, EstoqueMinimo = 4, Preco = 350.00m });
            produtos.Add(new Produto { Id = 9, Nome = "Controle", Categoria = "Games", Estoque = 0, EstoqueMinimo = 2, Preco = 280.00m });
            produtos.Add(new Produto { Id = 10, Nome = "Caixa de Som", Categoria = "Áudio", Estoque = 6, EstoqueMinimo = 3, Preco = 180.00m });
            produtos.Add(new Produto { Id = 11, Nome = "Cabo HDMI", Categoria = "Acessórios", Estoque = 4, EstoqueMinimo = 4, Preco = 40.00m });
            produtos.Add(new Produto { Id = 12, Nome = "Pendrive", Categoria = "Armazenamento", Estoque = 12, EstoqueMinimo = 5, Preco = 60.00m });
            produtos.Add(new Produto { Id = 13, Nome = "Roteador", Categoria = "Redes", Estoque = 2, EstoqueMinimo = 3, Preco = 250.00m });
            produtos.Add(new Produto { Id = 14, Nome = "Impressora", Categoria = "Impressão", Estoque = 3, EstoqueMinimo = 2, Preco = 900.00m });
            produtos.Add(new Produto { Id = 15, Nome = "Adaptador USB", Categoria = "Acessórios", Estoque = 0, EstoqueMinimo = 4, Preco = 35.00m });

            return produtos;
        }

        public IActionResult Index()
        {
            return View(CriarProdutos());
        }

        public IActionResult EstoqueBaixo()
        {
            List<Produto> produtos = CriarProdutos();

            List<Produto> estoqueBaixo = produtos
                .Where(p => p.Estoque > 0 && p.Estoque <= p.EstoqueMinimo)
                .ToList();

            return View(estoqueBaixo);
        }

        public IActionResult Esgotados()
        {
            List<Produto> produtos = CriarProdutos();

            List<Produto> esgotados = produtos
                .Where(p => p.Estoque == 0)
                .ToList();

            return View(esgotados);
        }

        public IActionResult Alertas()
        {
            List<Produto> produtos = CriarProdutos();

            List<Produto> alertas = produtos
                .Where(p => p.Estoque <= p.EstoqueMinimo)
                .ToList();

            return View(alertas);
        }
    }
}