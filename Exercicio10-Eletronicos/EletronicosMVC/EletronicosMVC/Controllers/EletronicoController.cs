using Microsoft.AspNetCore.Mvc;
using EletronicosMVC.Models;
using System.Collections.Generic;

namespace EletronicosMVC.Controllers
{
    public class EletronicoController : Controller
    {
        public IActionResult Index()
        {
            List<Eletronico> eletronicos = new List<Eletronico>();

            eletronicos.Add(new Eletronico { Id = 1, Nome = "Notebook", Marca = "Acer", Categoria = "Computadores", Preco = 3200.00m, Estoque = 5 });
            eletronicos.Add(new Eletronico { Id = 2, Nome = "Smartphone", Marca = "Samsung", Categoria = "Celulares", Preco = 2200.00m, Estoque = 8 });
            eletronicos.Add(new Eletronico { Id = 3, Nome = "Smart TV 50", Marca = "LG", Categoria = "Televisores", Preco = 2800.00m, Estoque = 3 });
            eletronicos.Add(new Eletronico { Id = 4, Nome = "Fone Bluetooth", Marca = "JBL", Categoria = "Áudio", Preco = 350.00m, Estoque = 0 });
            eletronicos.Add(new Eletronico { Id = 5, Nome = "Tablet", Marca = "Samsung", Categoria = "Tablets", Preco = 1800.00m, Estoque = 4 });
            eletronicos.Add(new Eletronico { Id = 6, Nome = "Monitor 24", Marca = "AOC", Categoria = "Monitores", Preco = 900.00m, Estoque = 7 });
            eletronicos.Add(new Eletronico { Id = 7, Nome = "Console", Marca = "Sony", Categoria = "Games", Preco = 4200.00m, Estoque = 2 });
            eletronicos.Add(new Eletronico { Id = 8, Nome = "Caixa de Som", Marca = "JBL", Categoria = "Áudio", Preco = 600.00m, Estoque = 6 });
            eletronicos.Add(new Eletronico { Id = 9, Nome = "Mouse Gamer", Marca = "Logitech", Categoria = "Periféricos", Preco = 250.00m, Estoque = 10 });
            eletronicos.Add(new Eletronico { Id = 10, Nome = "Teclado Mecânico", Marca = "Redragon", Categoria = "Periféricos", Preco = 300.00m, Estoque = 0 });
            eletronicos.Add(new Eletronico { Id = 11, Nome = "Webcam", Marca = "Logitech", Categoria = "Periféricos", Preco = 400.00m, Estoque = 5 });
            eletronicos.Add(new Eletronico { Id = 12, Nome = "Smartwatch", Marca = "Xiaomi", Categoria = "Acessórios", Preco = 500.00m, Estoque = 9 });

            return View(eletronicos);
        }

        public IActionResult EmEstoque()
        {
            List<Eletronico> eletronicos = new List<Eletronico>();

            eletronicos.Add(new Eletronico { Id = 1, Nome = "Notebook", Marca = "Acer", Categoria = "Computadores", Preco = 3200.00m, Estoque = 5 });
            eletronicos.Add(new Eletronico { Id = 2, Nome = "Smartphone", Marca = "Samsung", Categoria = "Celulares", Preco = 2200.00m, Estoque = 8 });
            eletronicos.Add(new Eletronico { Id = 3, Nome = "Smart TV 50", Marca = "LG", Categoria = "Televisores", Preco = 2800.00m, Estoque = 3 });
            eletronicos.Add(new Eletronico { Id = 4, Nome = "Fone Bluetooth", Marca = "JBL", Categoria = "Áudio", Preco = 350.00m, Estoque = 0 });
            eletronicos.Add(new Eletronico { Id = 5, Nome = "Tablet", Marca = "Samsung", Categoria = "Tablets", Preco = 1800.00m, Estoque = 4 });
            eletronicos.Add(new Eletronico { Id = 6, Nome = "Monitor 24", Marca = "AOC", Categoria = "Monitores", Preco = 900.00m, Estoque = 7 });
            eletronicos.Add(new Eletronico { Id = 7, Nome = "Console", Marca = "Sony", Categoria = "Games", Preco = 4200.00m, Estoque = 2 });
            eletronicos.Add(new Eletronico { Id = 8, Nome = "Caixa de Som", Marca = "JBL", Categoria = "Áudio", Preco = 600.00m, Estoque = 6 });
            eletronicos.Add(new Eletronico { Id = 9, Nome = "Mouse Gamer", Marca = "Logitech", Categoria = "Periféricos", Preco = 250.00m, Estoque = 10 });
            eletronicos.Add(new Eletronico { Id = 10, Nome = "Teclado Mecânico", Marca = "Redragon", Categoria = "Periféricos", Preco = 300.00m, Estoque = 0 });
            eletronicos.Add(new Eletronico { Id = 11, Nome = "Webcam", Marca = "Logitech", Categoria = "Periféricos", Preco = 400.00m, Estoque = 5 });
            eletronicos.Add(new Eletronico { Id = 12, Nome = "Smartwatch", Marca = "Xiaomi", Categoria = "Acessórios", Preco = 500.00m, Estoque = 9 });

            List<Eletronico> emEstoque = eletronicos
                .Where(e => e.Estoque > 0)
                .ToList();

            return View(emEstoque);
        }

        public IActionResult Perifericos()
        {
            List<Eletronico> eletronicos = new List<Eletronico>();

            eletronicos.Add(new Eletronico { Id = 1, Nome = "Notebook", Marca = "Acer", Categoria = "Computadores", Preco = 3200.00m, Estoque = 5 });
            eletronicos.Add(new Eletronico { Id = 2, Nome = "Smartphone", Marca = "Samsung", Categoria = "Celulares", Preco = 2200.00m, Estoque = 8 });
            eletronicos.Add(new Eletronico { Id = 3, Nome = "Smart TV 50", Marca = "LG", Categoria = "Televisores", Preco = 2800.00m, Estoque = 3 });
            eletronicos.Add(new Eletronico { Id = 4, Nome = "Fone Bluetooth", Marca = "JBL", Categoria = "Áudio", Preco = 350.00m, Estoque = 0 });
            eletronicos.Add(new Eletronico { Id = 5, Nome = "Tablet", Marca = "Samsung", Categoria = "Tablets", Preco = 1800.00m, Estoque = 4 });
            eletronicos.Add(new Eletronico { Id = 6, Nome = "Monitor 24", Marca = "AOC", Categoria = "Monitores", Preco = 900.00m, Estoque = 7 });
            eletronicos.Add(new Eletronico { Id = 7, Nome = "Console", Marca = "Sony", Categoria = "Games", Preco = 4200.00m, Estoque = 2 });
            eletronicos.Add(new Eletronico { Id = 8, Nome = "Caixa de Som", Marca = "JBL", Categoria = "Áudio", Preco = 600.00m, Estoque = 6 });
            eletronicos.Add(new Eletronico { Id = 9, Nome = "Mouse Gamer", Marca = "Logitech", Categoria = "Periféricos", Preco = 250.00m, Estoque = 10 });
            eletronicos.Add(new Eletronico { Id = 10, Nome = "Teclado Mecânico", Marca = "Redragon", Categoria = "Periféricos", Preco = 300.00m, Estoque = 0 });
            eletronicos.Add(new Eletronico { Id = 11, Nome = "Webcam", Marca = "Logitech", Categoria = "Periféricos", Preco = 400.00m, Estoque = 5 });
            eletronicos.Add(new Eletronico { Id = 12, Nome = "Smartwatch", Marca = "Xiaomi", Categoria = "Acessórios", Preco = 500.00m, Estoque = 9 });

            List<Eletronico> perifericos = eletronicos
                .Where(e => e.Categoria == "Periféricos")
                .ToList();

            return View(perifericos);
        }

        public IActionResult PrecoBaixo()
        {
            List<Eletronico> eletronicos = new List<Eletronico>();

            eletronicos.Add(new Eletronico { Id = 1, Nome = "Notebook", Marca = "Acer", Categoria = "Computadores", Preco = 3200.00m, Estoque = 5 });
            eletronicos.Add(new Eletronico { Id = 2, Nome = "Smartphone", Marca = "Samsung", Categoria = "Celulares", Preco = 2200.00m, Estoque = 8 });
            eletronicos.Add(new Eletronico { Id = 3, Nome = "Smart TV 50", Marca = "LG", Categoria = "Televisores", Preco = 2800.00m, Estoque = 3 });
            eletronicos.Add(new Eletronico { Id = 4, Nome = "Fone Bluetooth", Marca = "JBL", Categoria = "Áudio", Preco = 350.00m, Estoque = 0 });
            eletronicos.Add(new Eletronico { Id = 5, Nome = "Tablet", Marca = "Samsung", Categoria = "Tablets", Preco = 1800.00m, Estoque = 4 });
            eletronicos.Add(new Eletronico { Id = 6, Nome = "Monitor 24", Marca = "AOC", Categoria = "Monitores", Preco = 900.00m, Estoque = 7 });
            eletronicos.Add(new Eletronico { Id = 7, Nome = "Console", Marca = "Sony", Categoria = "Games", Preco = 4200.00m, Estoque = 2 });
            eletronicos.Add(new Eletronico { Id = 8, Nome = "Caixa de Som", Marca = "JBL", Categoria = "Áudio", Preco = 600.00m, Estoque = 6 });
            eletronicos.Add(new Eletronico { Id = 9, Nome = "Mouse Gamer", Marca = "Logitech", Categoria = "Periféricos", Preco = 250.00m, Estoque = 10 });
            eletronicos.Add(new Eletronico { Id = 10, Nome = "Teclado Mecânico", Marca = "Redragon", Categoria = "Periféricos", Preco = 300.00m, Estoque = 0 });
            eletronicos.Add(new Eletronico { Id = 11, Nome = "Webcam", Marca = "Logitech", Categoria = "Periféricos", Preco = 400.00m, Estoque = 5 });
            eletronicos.Add(new Eletronico { Id = 12, Nome = "Smartwatch", Marca = "Xiaomi", Categoria = "Acessórios", Preco = 500.00m, Estoque = 9 });

            List<Eletronico> precoBaixo = eletronicos
                .Where(e => e.Preco < 1000)
                .ToList();

            return View(precoBaixo);
        }
    }
}