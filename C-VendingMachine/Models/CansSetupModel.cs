using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WendingMachine.Models
{
    public class CansSetupModel
    {
        public int Dollar { get; set; }
        public int Cents { get; set; }
        public List<CansModel> CansDetail { get; set; }

        public string SelectedFalvor { get; set; }
        public double Amount { get; set; }
        public double MoneyinMachine { get; set; }
        public double MoneyCCPayment { get; set; }
    }
}
