using Microsoft.AspNetCore.Mvc;
using NotasMVC.Models;
using System.Collections.Generic;

namespace NotasMVC.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            List<Aluno> alunos = new List<Aluno>();

            alunos.Add(new Aluno { Id = 1, Nome = "Lucas", Curso = "Desenvolvimento de Sistemas", Nota1 = 8.0m, Nota2 = 7.5m, Nota3 = 9.0m });
            alunos.Add(new Aluno { Id = 2, Nome = "Marina", Curso = "Administração", Nota1 = 6.0m, Nota2 = 7.0m, Nota3 = 6.5m });
            alunos.Add(new Aluno { Id = 3, Nome = "Pedro", Curso = "Mecânica", Nota1 = 5.0m, Nota2 = 4.5m, Nota3 = 5.5m });
            alunos.Add(new Aluno { Id = 4, Nome = "Ana", Curso = "Eletroeletrônica", Nota1 = 3.0m, Nota2 = 2.5m, Nota3 = 4.0m });
            alunos.Add(new Aluno { Id = 5, Nome = "João", Curso = "Redes", Nota1 = 9.0m, Nota2 = 8.5m, Nota3 = 8.0m });
            alunos.Add(new Aluno { Id = 6, Nome = "Carlos", Curso = "Logística", Nota1 = 4.0m, Nota2 = 4.5m, Nota3 = 5.0m });
            alunos.Add(new Aluno { Id = 7, Nome = "Beatriz", Curso = "Desenvolvimento de Sistemas", Nota1 = 7.0m, Nota2 = 6.5m, Nota3 = 7.5m });
            alunos.Add(new Aluno { Id = 8, Nome = "Rafael", Curso = "Mecânica", Nota1 = 2.0m, Nota2 = 3.0m, Nota3 = 3.5m });
            alunos.Add(new Aluno { Id = 9, Nome = "Fernanda", Curso = "Administração", Nota1 = 5.5m, Nota2 = 5.0m, Nota3 = 4.5m });
            alunos.Add(new Aluno { Id = 10, Nome = "Gabriel", Curso = "Redes", Nota1 = 8.0m, Nota2 = 9.0m, Nota3 = 7.0m });

            return View(alunos);
        }

        public IActionResult Aprovados()
        {
            List<Aluno> alunos = new List<Aluno>();

            alunos.Add(new Aluno { Id = 1, Nome = "Lucas", Curso = "Desenvolvimento de Sistemas", Nota1 = 8.0m, Nota2 = 7.5m, Nota3 = 9.0m });
            alunos.Add(new Aluno { Id = 2, Nome = "Marina", Curso = "Administração", Nota1 = 6.0m, Nota2 = 7.0m, Nota3 = 6.5m });
            alunos.Add(new Aluno { Id = 3, Nome = "Pedro", Curso = "Mecânica", Nota1 = 5.0m, Nota2 = 4.5m, Nota3 = 5.5m });
            alunos.Add(new Aluno { Id = 4, Nome = "Ana", Curso = "Eletroeletrônica", Nota1 = 3.0m, Nota2 = 2.5m, Nota3 = 4.0m });
            alunos.Add(new Aluno { Id = 5, Nome = "João", Curso = "Redes", Nota1 = 9.0m, Nota2 = 8.5m, Nota3 = 8.0m });
            alunos.Add(new Aluno { Id = 6, Nome = "Carlos", Curso = "Logística", Nota1 = 4.0m, Nota2 = 4.5m, Nota3 = 5.0m });
            alunos.Add(new Aluno { Id = 7, Nome = "Beatriz", Curso = "Desenvolvimento de Sistemas", Nota1 = 7.0m, Nota2 = 6.5m, Nota3 = 7.5m });
            alunos.Add(new Aluno { Id = 8, Nome = "Rafael", Curso = "Mecânica", Nota1 = 2.0m, Nota2 = 3.0m, Nota3 = 3.5m });
            alunos.Add(new Aluno { Id = 9, Nome = "Fernanda", Curso = "Administração", Nota1 = 5.5m, Nota2 = 5.0m, Nota3 = 4.5m });
            alunos.Add(new Aluno { Id = 10, Nome = "Gabriel", Curso = "Redes", Nota1 = 8.0m, Nota2 = 9.0m, Nota3 = 7.0m });

            List<Aluno> aprovados = alunos
                .Where(a => (a.Nota1 + a.Nota2 + a.Nota3) / 3 >= 6)
                .ToList();

            return View(aprovados);
        }

        public IActionResult Recuperacao()
        {
            List<Aluno> alunos = new List<Aluno>();

            alunos.Add(new Aluno { Id = 1, Nome = "Lucas", Curso = "Desenvolvimento de Sistemas", Nota1 = 8.0m, Nota2 = 7.5m, Nota3 = 9.0m });
            alunos.Add(new Aluno { Id = 2, Nome = "Marina", Curso = "Administração", Nota1 = 6.0m, Nota2 = 7.0m, Nota3 = 6.5m });
            alunos.Add(new Aluno { Id = 3, Nome = "Pedro", Curso = "Mecânica", Nota1 = 5.0m, Nota2 = 4.5m, Nota3 = 5.5m });
            alunos.Add(new Aluno { Id = 4, Nome = "Ana", Curso = "Eletroeletrônica", Nota1 = 3.0m, Nota2 = 2.5m, Nota3 = 4.0m });
            alunos.Add(new Aluno { Id = 5, Nome = "João", Curso = "Redes", Nota1 = 9.0m, Nota2 = 8.5m, Nota3 = 8.0m });
            alunos.Add(new Aluno { Id = 6, Nome = "Carlos", Curso = "Logística", Nota1 = 4.0m, Nota2 = 4.5m, Nota3 = 5.0m });
            alunos.Add(new Aluno { Id = 7, Nome = "Beatriz", Curso = "Desenvolvimento de Sistemas", Nota1 = 7.0m, Nota2 = 6.5m, Nota3 = 7.5m });
            alunos.Add(new Aluno { Id = 8, Nome = "Rafael", Curso = "Mecânica", Nota1 = 2.0m, Nota2 = 3.0m, Nota3 = 3.5m });
            alunos.Add(new Aluno { Id = 9, Nome = "Fernanda", Curso = "Administração", Nota1 = 5.5m, Nota2 = 5.0m, Nota3 = 4.5m });
            alunos.Add(new Aluno { Id = 10, Nome = "Gabriel", Curso = "Redes", Nota1 = 8.0m, Nota2 = 9.0m, Nota3 = 7.0m });

            List<Aluno> recuperacao = alunos
                .Where(a =>
                    (a.Nota1 + a.Nota2 + a.Nota3) / 3 >= 4 &&
                    (a.Nota1 + a.Nota2 + a.Nota3) / 3 < 6)
                .ToList();

            return View(recuperacao);
        }

        public IActionResult Reprovados()
        {
            List<Aluno> alunos = new List<Aluno>();

            alunos.Add(new Aluno { Id = 1, Nome = "Lucas", Curso = "Desenvolvimento de Sistemas", Nota1 = 8.0m, Nota2 = 7.5m, Nota3 = 9.0m });
            alunos.Add(new Aluno { Id = 2, Nome = "Marina", Curso = "Administração", Nota1 = 6.0m, Nota2 = 7.0m, Nota3 = 6.5m });
            alunos.Add(new Aluno { Id = 3, Nome = "Pedro", Curso = "Mecânica", Nota1 = 5.0m, Nota2 = 4.5m, Nota3 = 5.5m });
            alunos.Add(new Aluno { Id = 4, Nome = "Ana", Curso = "Eletroeletrônica", Nota1 = 3.0m, Nota2 = 2.5m, Nota3 = 4.0m });
            alunos.Add(new Aluno { Id = 5, Nome = "João", Curso = "Redes", Nota1 = 9.0m, Nota2 = 8.5m, Nota3 = 8.0m });
            alunos.Add(new Aluno { Id = 6, Nome = "Carlos", Curso = "Logística", Nota1 = 4.0m, Nota2 = 4.5m, Nota3 = 5.0m });
            alunos.Add(new Aluno { Id = 7, Nome = "Beatriz", Curso = "Desenvolvimento de Sistemas", Nota1 = 7.0m, Nota2 = 6.5m, Nota3 = 7.5m });
            alunos.Add(new Aluno { Id = 8, Nome = "Rafael", Curso = "Mecânica", Nota1 = 2.0m, Nota2 = 3.0m, Nota3 = 3.5m });
            alunos.Add(new Aluno { Id = 9, Nome = "Fernanda", Curso = "Administração", Nota1 = 5.5m, Nota2 = 5.0m, Nota3 = 4.5m });
            alunos.Add(new Aluno { Id = 10, Nome = "Gabriel", Curso = "Redes", Nota1 = 8.0m, Nota2 = 9.0m, Nota3 = 7.0m });

            List<Aluno> reprovados = alunos
                .Where(a => (a.Nota1 + a.Nota2 + a.Nota3) / 3 < 4)
                .ToList();

            return View(reprovados);
        }
    }
}