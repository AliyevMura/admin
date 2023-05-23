﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebFrontToBack.DAL;
using WebFrontToBack.ViewModel;

namespace WebFrontToBack.Controllers
{

    public class HomeController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public HomeController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }




        //public async Task<IActionResult> Index()
        //{
        //    HomeVM homeVM = new HomeVM() { 
        //    Sliders= await _appDbContext.Sliders.ToListAsync(),
        //        RecentWorks = await _appDbContext.RecentWorks.ToListAsync(),
        //    Categories = await _appDbContext.Categories.Where(c=>!c.IsDeleted).ToListAsync(),
        //    //Services= await _appDbContext.Services

        //    //    .Include(s => s.Category)
        //    //    .Include(s => s.ServiceImages)


        //    //    .OrderByDescending(s => s.Id)
        //    //    .Where(s=>!s.IsDeleted)
        //    //    .Take(8)
        //    //    .ToListAsync()
        //    };
        //    return View(homeVM);
        //}
        public async Task<IActionResult> Index()
        {
            //HttpContext.Session.SetString("name", "Murad");
            HomeVM homeVM = new HomeVM()
            {
                Categories = await _appDbContext.Categories.Where(c => !c.IsDeleted).ToListAsync()
            };
            return View(homeVM);
        }

        //public IActionResult GetSession()
        //{
        //  //string name = HttpContext.Session.GetString("name");
        //    return Json(name);
        //}
    }
}