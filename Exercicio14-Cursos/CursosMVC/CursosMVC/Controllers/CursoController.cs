using Microsoft.AspNetCore.Mvc;
using CursosMVC.Models;
using System.Collections.Generic;

namespace CursosMVC.Controllers
{
    public class CursoController : Controller
    {
        private List<Curso> CriarCursos()
        {
            List<Curso> cursos = new List<Curso>();

            cursos.Add(new Curso { Id = 1, Nome = "Desenvolvimento de Sistemas", CargaHoraria = 1200, Modalidade = "Presencial", Vagas = 10, Valor = 1500.00m });
            cursos.Add(new Curso { Id = 2, Nome = "Excel Avançado", CargaHoraria = 40, Modalidade = "Online", Vagas = 20, Valor = 300.00m });
            cursos.Add(new Curso { Id = 3, Nome = "Mecânica Industrial", CargaHoraria = 800, Modalidade = "Presencial", Vagas = 0, Valor = 1200.00m });
            cursos.Add(new Curso { Id = 4, Nome = "Power BI", CargaHoraria = 60, Modalidade = "Online", Vagas = 15, Valor = 450.00m });
            cursos.Add(new Curso { Id = 5, Nome = "Redes de Computadores", CargaHoraria = 600, Modalidade = "Presencial", Vagas = 8, Valor = 900.00m });
            cursos.Add(new Curso { Id = 6, Nome = "Lógica de Programação", CargaHoraria = 80, Modalidade = "Online", Vagas = 0, Valor = 350.00m });
            cursos.Add(new Curso { Id = 7, Nome = "Eletricista Industrial", CargaHoraria = 400, Modalidade = "Presencial", Vagas = 12, Valor = 800.00m });
            cursos.Add(new Curso { Id = 8, Nome = "Banco de Dados", CargaHoraria = 100, Modalidade = "Online", Vagas = 25, Valor = 500.00m });
            cursos.Add(new Curso { Id = 9, Nome = "Automação Industrial", CargaHoraria = 500, Modalidade = "Presencial", Vagas = 0, Valor = 1000.00m });
            cursos.Add(new Curso { Id = 10, Nome = "C# Básico", CargaHoraria = 120, Modalidade = "Online", Vagas = 18, Valor = 600.00m });

            return cursos;
        }

        public IActionResult Index()
        {
            return View(CriarCursos());
        }

        public IActionResult Disponiveis()
        {
            List<Curso> cursos = CriarCursos();

            List<Curso> disponiveis = cursos
                .Where(c => c.Vagas > 0)
                .ToList();

            return View(disponiveis);
        }

        public IActionResult Online()
        {
            List<Curso> cursos = CriarCursos();

            List<Curso> online = cursos
                .Where(c => c.Modalidade == "Online")
                .ToList();

            return View(online);
        }

        public IActionResult Presenciais()
        {
            List<Curso> cursos = CriarCursos();

            List<Curso> presenciais = cursos
                .Where(c => c.Modalidade == "Presencial")
                .ToList();

            return View(presenciais);
        }

        public IActionResult Resumo()
        {
            return View(CriarCursos());
        }
    }
}