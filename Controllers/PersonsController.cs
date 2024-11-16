using Microsoft.AspNetCore.Mvc;
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
    }
}
