﻿using Microsoft.AspNetCore.Mvc;
using WebListaC2.Models;

namespace WebListaC2.Controllers
{
    public class PersonsController : Controller
    {
        public List<Person> persons = new List<Person>
        {
            new Person { PersonId = 1, FirstName = "John", LastName = "Doe", Age = 25 },
            new Person { PersonId = 2, FirstName = "Juan", LastName = "Perez", Age = 22 },
            new Person { PersonId = 3, FirstName = "Tom", LastName = "Smith", Age = 30 }
        };

        public IActionResult Index()
        {
            return View(persons);
        }

        //método para llamar el formulario
        public IActionResult Create() 
        { 
            return View(); 
        }

        //método para guardarel registro
        [HttpPost]
        public IActionResult Create(Person person)
        {
            new Person 
            { 
                PersonId = person.PersonId, FirstName = person.FirstName, 
                LastName = person.LastName, 
                Age = person.Age 
            };

            persons.Add(person);
            return RedirectToAction("Index");
        }



    }
}
