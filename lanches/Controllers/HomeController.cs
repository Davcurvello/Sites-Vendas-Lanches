using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using lanches.Models;
using lanches.Repositories;
using lanches.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace lanches.Controllers
{
  
    public class HomeController : Controller
    {
        private readonly ILancheRepository _lancheRepository;

        public HomeController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;

        }
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                LanchesPreferidos = _lancheRepository.LanchesPreferidos

            };
            return View(homeViewModel);
  

            
        }

        public ViewResult AccessDenied()
        {
            return View();
        }


    }
}
