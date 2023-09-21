using Microsoft.AspNetCore.Mvc;

namespace MvcApp.Controllers
{
	public class HomeController : Controller
	{
		public string Index(int id) => $"Index Page. Id:{id}";
		public string About(string name, int age)=>$"About page. Name:{name}, Age:{age}";
	}
}
