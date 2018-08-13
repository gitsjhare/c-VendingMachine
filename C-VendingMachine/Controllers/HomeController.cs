using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WendingMachine.Models;

namespace WendingMachine.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View(CansSetup);
        }

        [HttpPost]
        public IActionResult UpdateMachine(CansSetupModel canssetup,string MethodToPay)
        {
            foreach(var ProcessOrder in CansSetup.CansDetail.Where(x=>x.Flavor!=null))
            {
                if (ProcessOrder.Flavor.ToString().Trim().Equals(canssetup.SelectedFalvor.ToString().Trim()))
                {
                    ProcessOrder.Quentity--;
                }
            }
            if (MethodToPay == "cash")
            {
                CansSetup.MoneyinMachine += canssetup.Amount;
            }
            if(MethodToPay== "cc")
            {
                CansSetup.MoneyCCPayment += canssetup.Amount;
            }
            return View("Index", CansSetup);
        }
    }
}
