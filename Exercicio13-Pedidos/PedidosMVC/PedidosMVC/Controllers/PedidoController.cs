using Microsoft.AspNetCore.Mvc;
using PedidosMVC.Models;
using System.Collections.Generic;

namespace PedidosMVC.Controllers
{
    public class PedidoController : Controller
    {
        private List<Pedido> CriarPedidos()
        {
            List<Pedido> pedidos = new List<Pedido>();

            pedidos.Add(new Pedido { Id = 1, Cliente = "Lucas", Produto = "X-Burguer", Quantidade = 2, PrecoUnitario = 25.00m, Status = "Recebido" });
            pedidos.Add(new Pedido { Id = 2, Cliente = "Marina", Produto = "X-Salada", Quantidade = 1, PrecoUnitario = 28.00m, Status = "Em preparo" });
            pedidos.Add(new Pedido { Id = 3, Cliente = "Pedro", Produto = "Batata Frita", Quantidade = 2, PrecoUnitario = 15.00m, Status = "Pronto" });
            pedidos.Add(new Pedido { Id = 4, Cliente = "Ana", Produto = "Pizza", Quantidade = 1, PrecoUnitario = 45.00m, Status = "Entregue" });
            pedidos.Add(new Pedido { Id = 5, Cliente = "João", Produto = "X-Bacon", Quantidade = 2, PrecoUnitario = 30.00m, Status = "Em preparo" });
            pedidos.Add(new Pedido { Id = 6, Cliente = "Carlos", Produto = "Refrigerante", Quantidade = 3, PrecoUnitario = 7.00m, Status = "Recebido" });
            pedidos.Add(new Pedido { Id = 7, Cliente = "Beatriz", Produto = "Hot Dog", Quantidade = 2, PrecoUnitario = 18.00m, Status = "Pronto" });
            pedidos.Add(new Pedido { Id = 8, Cliente = "Rafael", Produto = "Pizza", Quantidade = 2, PrecoUnitario = 45.00m, Status = "Entregue" });
            pedidos.Add(new Pedido { Id = 9, Cliente = "Fernanda", Produto = "X-Tudo", Quantidade = 1, PrecoUnitario = 35.00m, Status = "Em preparo" });
            pedidos.Add(new Pedido { Id = 10, Cliente = "Gabriel", Produto = "Suco", Quantidade = 2, PrecoUnitario = 10.00m, Status = "Entregue" });

            return pedidos;
        }

        public IActionResult Index()
        {
            return View(CriarPedidos());
        }

        public IActionResult EmPreparo()
        {
            List<Pedido> pedidos = CriarPedidos();

            List<Pedido> emPreparo = pedidos
                .Where(p => p.Status == "Em preparo")
                .ToList();

            return View(emPreparo);
        }

        public IActionResult Prontos()
        {
            List<Pedido> pedidos = CriarPedidos();

            List<Pedido> prontos = pedidos
                .Where(p => p.Status == "Pronto")
                .ToList();

            return View(prontos);
        }

        public IActionResult Entregues()
        {
            List<Pedido> pedidos = CriarPedidos();

            List<Pedido> entregues = pedidos
                .Where(p => p.Status == "Entregue")
                .ToList();

            return View(entregues);
        }

        public IActionResult Resumo()
        {
            return View(CriarPedidos());
        }
    }
}