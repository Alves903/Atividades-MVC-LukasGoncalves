using Microsoft.AspNetCore.Mvc;
using FuncionariosMVC.Models;
using System.Collections.Generic;

namespace FuncionariosMVC.Controllers
{
    public class FuncionarioController : Controller
    {
        private List<Funcionario> CriarFuncionarios()
        {
            List<Funcionario> funcionarios = new List<Funcionario>();

            funcionarios.Add(new Funcionario { Id = 1, Nome = "Lucas", Cargo = "Desenvolvedor", Departamento = "TI", Salario = 4500.00m, Ativo = true });
            funcionarios.Add(new Funcionario { Id = 2, Nome = "Marina", Cargo = "Analista", Departamento = "Financeiro", Salario = 3800.00m, Ativo = true });
            funcionarios.Add(new Funcionario { Id = 3, Nome = "Pedro", Cargo = "Auxiliar", Departamento = "Produção", Salario = 2200.00m, Ativo = true });
            funcionarios.Add(new Funcionario { Id = 4, Nome = "Ana", Cargo = "Gerente", Departamento = "RH", Salario = 6500.00m, Ativo = true });
            funcionarios.Add(new Funcionario { Id = 5, Nome = "João", Cargo = "Técnico", Departamento = "TI", Salario = 3200.00m, Ativo = false });
            funcionarios.Add(new Funcionario { Id = 6, Nome = "Carlos", Cargo = "Supervisor", Departamento = "Produção", Salario = 5200.00m, Ativo = true });
            funcionarios.Add(new Funcionario { Id = 7, Nome = "Beatriz", Cargo = "Assistente", Departamento = "RH", Salario = 2400.00m, Ativo = true });
            funcionarios.Add(new Funcionario { Id = 8, Nome = "Rafael", Cargo = "Desenvolvedor", Departamento = "TI", Salario = 5600.00m, Ativo = true });
            funcionarios.Add(new Funcionario { Id = 9, Nome = "Fernanda", Cargo = "Analista", Departamento = "Financeiro", Salario = 4100.00m, Ativo = false });
            funcionarios.Add(new Funcionario { Id = 10, Nome = "Gabriel", Cargo = "Auxiliar", Departamento = "Produção", Salario = 2100.00m, Ativo = true });
            funcionarios.Add(new Funcionario { Id = 11, Nome = "Juliana", Cargo = "Coordenadora", Departamento = "RH", Salario = 5900.00m, Ativo = true });
            funcionarios.Add(new Funcionario { Id = 12, Nome = "Mateus", Cargo = "Suporte", Departamento = "TI", Salario = 2800.00m, Ativo = false });
            funcionarios.Add(new Funcionario { Id = 13, Nome = "Larissa", Cargo = "Assistente", Departamento = "Financeiro", Salario = 2300.00m, Ativo = true });
            funcionarios.Add(new Funcionario { Id = 14, Nome = "Bruno", Cargo = "Operador", Departamento = "Produção", Salario = 2600.00m, Ativo = true });
            funcionarios.Add(new Funcionario { Id = 15, Nome = "Camila", Cargo = "Gerente", Departamento = "Financeiro", Salario = 7000.00m, Ativo = false });

            return funcionarios;
        }

        public IActionResult Index()
        {
            return View(CriarFuncionarios());
        }

        public IActionResult Ativos()
        {
            List<Funcionario> funcionarios = CriarFuncionarios();

            List<Funcionario> ativos = funcionarios
                .Where(f => f.Ativo)
                .ToList();

            return View(ativos);
        }

        public IActionResult Inativos()
        {
            List<Funcionario> funcionarios = CriarFuncionarios();

            List<Funcionario> inativos = funcionarios
                .Where(f => !f.Ativo)
                .ToList();

            return View(inativos);
        }

        public IActionResult Departamento(string nome)
        {
            List<Funcionario> funcionarios = CriarFuncionarios();

            List<Funcionario> departamento = funcionarios
                .Where(f => f.Departamento == nome)
                .ToList();

            return View(departamento);
        }

        public IActionResult Dashboard()
        {
            return View(CriarFuncionarios());
        }
    }
}