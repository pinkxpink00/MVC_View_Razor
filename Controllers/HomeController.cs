using Microsoft.AspNetCore.Mvc;

namespace MvcApp.Controllers
{
	[Route("Home")]
	public class HomeController : Controller
	{
		[Route("Index")]
		public string Index(int id) => $"Index Page. Id:{id}";
		[Route("About")]
		public string About(string name, int age)=>$"About page. Name:{name}, Age:{age}";
	}
}
