using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WendingMachine.Models;

namespace WendingMachine.Controllers
{
    public class SetupController : BaseController
    {
       
        public IActionResult Index()
        {
            if (Cans.Count <= 0)
            {
                for(int i = 0; i < 10; i++)
                {
                    Cans.Add(new CansModel());
                }

                CansSetup.CansDetail = Cans.ToList();
            }
            return View(CansSetup);
        }
        [HttpPost]
        public IActionResult SetupCans(CansSetupModel cansetup){
            CansSetup=cansetup;
            return View("Index",cansetup);
        }
    }
}