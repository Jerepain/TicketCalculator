using System;
using System.Windows.Input;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TicketCalculator.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var vm = new MainPageViewModel
            {
                TicketValue = 10,
                Price = 21
            };

            var c = vm.ComputeCommand;
            c.Execute(this);
            Assert.AreEqual(1, vm.Reste);
            Assert.AreEqual(2, vm.TicketsNumber);
        }
    }
}
