using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DiceRoller.Models;


namespace DiceRoller.Controllers
{
    
    public class HomeController : Controller
    {
        [HttpGet]
        public ViewResult Index()
        {
            DiceVM d = new DiceVM();
            return View(d);
        }

        [HttpPost]
        public ViewResult Index(DiceVM dice)
        {
            dice.GetTotal(dice.selectedDie, dice.amount);
            return View(dice);
        }
    }
}
