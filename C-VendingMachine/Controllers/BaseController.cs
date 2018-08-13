using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WendingMachine.Models;

namespace WendingMachine.Controllers
{
    public class BaseController:Controller
    {
        public static IList<CansModel> Cans = new List<CansModel>();
        public static CansSetupModel CansSetup = new CansSetupModel(); 
    }
}