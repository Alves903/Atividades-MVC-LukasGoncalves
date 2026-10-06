using Microsoft.AspNetCore.Mvc;
using BibliotecaMVC.Models;
using System.Collections.Generic;

namespace BibliotecaMVC.Controllers
{
    public class BibliotecaController : Controller
    {
        public IActionResult Index()
        {
            List<Livro> livros = new List<Livro>();

            livros.Add(new Livro { Id = 1, Titulo = "Dom Casmurro", Autor = "Machado de Assis", Ano = 1899, Disponivel = true });
            livros.Add(new Livro { Id = 2, Titulo = "O Pequeno Príncipe", Autor = "Antoine de Saint-Exupéry", Ano = 1943, Disponivel = false });
            livros.Add(new Livro { Id = 3, Titulo = "1984", Autor = "George Orwell", Ano = 1949, Disponivel = true });
            livros.Add(new Livro { Id = 4, Titulo = "Harry Potter e a Pedra Filosofal", Autor = "J.K. Rowling", Ano = 1997, Disponivel = true });
            livros.Add(new Livro { Id = 5, Titulo = "O Hobbit", Autor = "J.R.R. Tolkien", Ano = 1937, Disponivel = false });
            livros.Add(new Livro { Id = 6, Titulo = "Capitães da Areia", Autor = "Jorge Amado", Ano = 1937, Disponivel = true });
            livros.Add(new Livro { Id = 7, Titulo = "A Revolução dos Bichos", Autor = "George Orwell", Ano = 1945, Disponivel = true });
            livros.Add(new Livro { Id = 8, Titulo = "Memórias Póstumas de Brás Cubas", Autor = "Machado de Assis", Ano = 1881, Disponivel = false });
            livros.Add(new Livro { Id = 9, Titulo = "Percy Jackson e o Ladrão de Raios", Autor = "Rick Riordan", Ano = 2005, Disponivel = true });
            livros.Add(new Livro { Id = 10, Titulo = "Jogos Vorazes", Autor = "Suzanne Collins", Ano = 2008, Disponivel = true });

            return View(livros);
        }

        public IActionResult Disponiveis()
        {
            List<Livro> livros = new List<Livro>();

            livros.Add(new Livro { Id = 1, Titulo = "Dom Casmurro", Autor = "Machado de Assis", Ano = 1899, Disponivel = true });
            livros.Add(new Livro { Id = 2, Titulo = "O Pequeno Príncipe", Autor = "Antoine de Saint-Exupéry", Ano = 1943, Disponivel = false });
            livros.Add(new Livro { Id = 3, Titulo = "1984", Autor = "George Orwell", Ano = 1949, Disponivel = true });
            livros.Add(new Livro { Id = 4, Titulo = "Harry Potter e a Pedra Filosofal", Autor = "J.K. Rowling", Ano = 1997, Disponivel = true });
            livros.Add(new Livro { Id = 5, Titulo = "O Hobbit", Autor = "J.R.R. Tolkien", Ano = 1937, Disponivel = false });
            livros.Add(new Livro { Id = 6, Titulo = "Capitães da Areia", Autor = "Jorge Amado", Ano = 1937, Disponivel = true });
            livros.Add(new Livro { Id = 7, Titulo = "A Revolução dos Bichos", Autor = "George Orwell", Ano = 1945, Disponivel = true });
            livros.Add(new Livro { Id = 8, Titulo = "Memórias Póstumas de Brás Cubas", Autor = "Machado de Assis", Ano = 1881, Disponivel = false });
            livros.Add(new Livro { Id = 9, Titulo = "Percy Jackson e o Ladrão de Raios", Autor = "Rick Riordan", Ano = 2005, Disponivel = true });
            livros.Add(new Livro { Id = 10, Titulo = "Jogos Vorazes", Autor = "Suzanne Collins", Ano = 2008, Disponivel = true });

            List<Livro> disponiveis = livros.Where(l => l.Disponivel).ToList();

            return View(disponiveis);
        }
    }
}