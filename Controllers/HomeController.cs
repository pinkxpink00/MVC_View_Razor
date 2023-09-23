﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using MvcApp.Models;

namespace MvcApp.Controllers
{
	[Route("Home/Index")]
	public class HomeController : Controller
	{
		public IActionResult Create()=> View();

		[HttpPost]
		public string Create(Person person)
        {
            if (ModelState.IsValid)
                return $"{person.Name} - {person.Age}";

            string errorMessages = "";
            
            foreach (var item in ModelState)
            {
                
                if (item.Value.ValidationState == ModelValidationState.Invalid)
                {
                    errorMessages = $"{errorMessages}\nОшибки для свойства {item.Key}:\n";
                    
                    foreach (var error in item.Value.Errors)
                    {
                        errorMessages = $"{errorMessages}{error.ErrorMessage}\n";
                    }
                }
            }
            return errorMessages;
        }
	}
}
