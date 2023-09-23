using Microsoft.AspNetCore.Mvc;
using MvcApp.Models;

namespace MvcApp.Controllers
{

	public class HomeController : Controller
	{
		List<Person> people = new List<Person>
		{
			new Person (1,"German", 24),
			new Person (2,"Jop",44),
			new Person (3,"Mooff",45)
		};
		[Route("Home/Index")]
		public IActionResult Index()
		{
			return View(people);
		}
	}
}
