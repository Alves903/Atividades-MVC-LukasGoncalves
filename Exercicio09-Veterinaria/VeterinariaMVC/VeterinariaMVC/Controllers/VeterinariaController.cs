using Microsoft.AspNetCore.Mvc;
using VeterinariaMVC.Models;
using System.Collections.Generic;

namespace VeterinariaMVC.Controllers
{
    public class VeterinariaController : Controller
    {
        public IActionResult Index()
        {
            List<Animal> animais = new List<Animal>();

            animais.Add(new Animal { Id = 1, Nome = "Rex", Especie = "Cachorro", Idade = 5, Dono = "Carlos" });
            animais.Add(new Animal { Id = 2, Nome = "Mia", Especie = "Gato", Idade = 3, Dono = "Ana" });
            animais.Add(new Animal { Id = 3, Nome = "Thor", Especie = "Cachorro", Idade = 4, Dono = "Pedro" });
            animais.Add(new Animal { Id = 4, Nome = "Luna", Especie = "Gato", Idade = 2, Dono = "Marina" });
            animais.Add(new Animal { Id = 5, Nome = "Bob", Especie = "Cachorro", Idade = 6, Dono = "João" });
            animais.Add(new Animal { Id = 6, Nome = "Nina", Especie = "Gato", Idade = 1, Dono = "Beatriz" });
            animais.Add(new Animal { Id = 7, Nome = "Max", Especie = "Cachorro", Idade = 7, Dono = "Rafael" });
            animais.Add(new Animal { Id = 8, Nome = "Mel", Especie = "Gato", Idade = 4, Dono = "Fernanda" });

            return View(animais);
        }

        public IActionResult Cachorros()
        {
            List<Animal> animais = new List<Animal>();

            animais.Add(new Animal { Id = 1, Nome = "Rex", Especie = "Cachorro", Idade = 5, Dono = "Carlos" });
            animais.Add(new Animal { Id = 2, Nome = "Mia", Especie = "Gato", Idade = 3, Dono = "Ana" });
            animais.Add(new Animal { Id = 3, Nome = "Thor", Especie = "Cachorro", Idade = 4, Dono = "Pedro" });
            animais.Add(new Animal { Id = 4, Nome = "Luna", Especie = "Gato", Idade = 2, Dono = "Marina" });
            animais.Add(new Animal { Id = 5, Nome = "Bob", Especie = "Cachorro", Idade = 6, Dono = "João" });
            animais.Add(new Animal { Id = 6, Nome = "Nina", Especie = "Gato", Idade = 1, Dono = "Beatriz" });
            animais.Add(new Animal { Id = 7, Nome = "Max", Especie = "Cachorro", Idade = 7, Dono = "Rafael" });
            animais.Add(new Animal { Id = 8, Nome = "Mel", Especie = "Gato", Idade = 4, Dono = "Fernanda" });

            List<Animal> cachorros = animais
                .Where(a => a.Especie == "Cachorro")
                .ToList();

            return View(cachorros);
        }

        public IActionResult Gatos()
        {
            List<Animal> animais = new List<Animal>();

            animais.Add(new Animal { Id = 1, Nome = "Rex", Especie = "Cachorro", Idade = 5, Dono = "Carlos" });
            animais.Add(new Animal { Id = 2, Nome = "Mia", Especie = "Gato", Idade = 3, Dono = "Ana" });
            animais.Add(new Animal { Id = 3, Nome = "Thor", Especie = "Cachorro", Idade = 4, Dono = "Pedro" });
            animais.Add(new Animal { Id = 4, Nome = "Luna", Especie = "Gato", Idade = 2, Dono = "Marina" });
            animais.Add(new Animal { Id = 5, Nome = "Bob", Especie = "Cachorro", Idade = 6, Dono = "João" });
            animais.Add(new Animal { Id = 6, Nome = "Nina", Especie = "Gato", Idade = 1, Dono = "Beatriz" });
            animais.Add(new Animal { Id = 7, Nome = "Max", Especie = "Cachorro", Idade = 7, Dono = "Rafael" });
            animais.Add(new Animal { Id = 8, Nome = "Mel", Especie = "Gato", Idade = 4, Dono = "Fernanda" });

            List<Animal> gatos = animais
                .Where(a => a.Especie == "Gato")
                .ToList();

            return View(gatos);
        }
    }
}