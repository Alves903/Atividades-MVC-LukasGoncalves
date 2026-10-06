using Microsoft.AspNetCore.Mvc;
using AlunosMVC.Models;
using System.Collections.Generic;

namespace AlunosMVC.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            List<Aluno> alunos = new List<Aluno>();

            alunos.Add(new Aluno { Id = 1, Nome = "Lucas", Idade = 17, Curso = "Desenvolvimento de Sistemas" });
            alunos.Add(new Aluno { Id = 2, Nome = "Marina", Idade = 17, Curso = "Administração" });
            alunos.Add(new Aluno { Id = 3, Nome = "Pedro", Idade = 18, Curso = "Mecânica" });
            alunos.Add(new Aluno { Id = 4, Nome = "Ana", Idade = 16, Curso = "Eletroeletrônica" });
            alunos.Add(new Aluno { Id = 5, Nome = "João", Idade = 17, Curso = "Redes de Computadores" });
            alunos.Add(new Aluno { Id = 6, Nome = "Carlos", Idade = 18, Curso = "Logística" });
            alunos.Add(new Aluno { Id = 7, Nome = "Beatriz", Idade = 16, Curso = "Desenvolvimento de Sistemas" });
            alunos.Add(new Aluno { Id = 8, Nome = "Rafael", Idade = 17, Curso = "Mecânica" });

            return View(alunos);
        }

        public IActionResult Detalhes(int id)
        {
            List<Aluno> alunos = new List<Aluno>();

            alunos.Add(new Aluno { Id = 1, Nome = "Lucas", Idade = 17, Curso = "Desenvolvimento de Sistemas" });
            alunos.Add(new Aluno { Id = 2, Nome = "Marina", Idade = 17, Curso = "Administração" });
            alunos.Add(new Aluno { Id = 3, Nome = "Pedro", Idade = 18, Curso = "Mecânica" });
            alunos.Add(new Aluno { Id = 4, Nome = "Ana", Idade = 16, Curso = "Eletroeletrônica" });
            alunos.Add(new Aluno { Id = 5, Nome = "João", Idade = 17, Curso = "Redes de Computadores" });
            alunos.Add(new Aluno { Id = 6, Nome = "Carlos", Idade = 18, Curso = "Logística" });
            alunos.Add(new Aluno { Id = 7, Nome = "Beatriz", Idade = 16, Curso = "Desenvolvimento de Sistemas" });
            alunos.Add(new Aluno { Id = 8, Nome = "Rafael", Idade = 17, Curso = "Mecânica" });

            Aluno aluno = alunos.FirstOrDefault(a => a.Id == id);

            return View(aluno);
        }
    }
}