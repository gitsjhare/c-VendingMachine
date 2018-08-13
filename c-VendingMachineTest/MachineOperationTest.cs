using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WendingMachine.Controllers;
using WendingMachine.Models;

namespace c_VendingMachineTest
{
    [TestClass]
   public class MachineOperationTest
    {
        private HomeController MachineController;
        private CansSetupModel canssetupmodel;


        [TestInitialize]
        public void Initlize()
        {
            MachineController = new HomeController();
            canssetupmodel = new CansSetupModel();
            canssetupmodel.CansDetail = new System.Collections.Generic.List<CansModel>();
            canssetupmodel.CansDetail.Add(new CansModel() { Flavor = "TestFalvor", Quentity = 20 });
            canssetupmodel.SelectedFalvor = "TestFlavor";
            canssetupmodel.Amount = 4.5D;
        }

        [TestCleanup]
        public void Cleanup()
        {
            MachineController = null;
            canssetupmodel = null;
        }

        [TestMethod]
        public void MachineOperation_Index()
        {
            var Result = MachineController.Index() as ViewResult;
            Assert.IsNotNull(Result);
            Assert.IsInstanceOfType(Result, typeof(ViewResult));
        }

       
    }
}
