using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RunApp.Data;
using RunApp.Repository;
using RunApp.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RunApp.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IDashboardRepository _dashboardRespository;

        public DashboardController(IDashboardRepository dashboardRespository)
        {
            _dashboardRespository = dashboardRespository;
        }
        public async Task<IActionResult> Index()
        {
            var userRaces = await _dashboardRespository.GetAllUserRaces();
            var userClubs = await _dashboardRespository.GetAllUserClubs();
            var dashboardViewModel = new DashboardViewModel()
            {
                Races = userRaces,
                Clubs = userClubs
            };
            return View(dashboardViewModel);
        }
    }
}

