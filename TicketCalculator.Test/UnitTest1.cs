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
            var vm = new MainPageViewModel();
            ICommand c = vm.ComputeCommand;


        }
    }
}
