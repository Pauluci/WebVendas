using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebVendas.Models;

namespace WebVendas.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department { id = 1, Name = "Eletronics"});
            list.Add(new Department { id = 2, Name = "Fashion"});
            list.Add(new Department { id = 3, Name = "Cars"});
            list.Add(new Department { id = 4, Name = "Motorcile"});
            return View(list);
        }
    }
}
