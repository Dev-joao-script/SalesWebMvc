﻿using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using System.Collections.Generic;

namespace SalesWebMvc.Controllers {
    public class DepartmentsController : Controller {
        public IActionResult Index() {
            List<Department> list = new List<Department> {
                new Department {
                    Id = 1, 
                    Name = "Carros"
                },
                new Department {
                    Id=2,
                    Name = "Aeronaves"
                }
            };
            return View(list);
        }
    }
}