using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WendingMachine.Controllers;
using WendingMachine.Models;

namespace c_VendingMachineTest
{
    [TestClass]
    public class SetupMachineTest
    {
        private SetupController setupController;
        private CansSetupModel canssetupmodel;

        [TestInitialize]
        public void Initlize()
        {
            setupController = new SetupController();
            canssetupmodel = new CansSetupModel();
        }
        [TestCleanup]
        public void CleanUp()
        {
            setupController = null;
            canssetupmodel = null;
        }
        [TestMethod]
        public void Index()
        {
           var Result= setupController.Index() as ViewResult;
            Assert.IsNotNull(Result);
            Assert.IsInstanceOfType(Result, typeof(ViewResult));
            var ResultModel = Result.Model as CansSetupModel;
            Assert.IsTrue(ResultModel.CansDetail.Count > 0);
        }

        [TestMethod]
        public void SetupCans()
        {
            canssetupmodel.Amount = 10;
            var Result = setupController.SetupCans(canssetupmodel) as ViewResult;

            Assert.IsNotNull(Result);
            Assert.IsInstanceOfType(Result, typeof(ViewResult));

            var ResultModel = Result.Model as CansSetupModel;
            Assert.IsTrue(ResultModel.Amount == 10);

        }
    }
}
