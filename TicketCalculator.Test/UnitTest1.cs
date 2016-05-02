using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TicketCalculator.Test
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestCoreDivision()
        {
            var a = Core.Compute.division(8, 8);
            Assert.AreEqual(1,a);
        }

        [TestMethod]
        public void TestCoreReste()
        {
            var a = Core.Compute.reste(1.88, 1);
            Assert.AreEqual(0.88,a);
        }

        [TestMethod]
        public void TestCoreTicketsToGive()
        {
            var a = Core.Compute.division(8, 8);
            Assert.AreEqual(1,a);
        }
    
        [TestMethod]
        public void TestMethod1()
        {
            var vm = new MainPageViewModel();
            vm.TicketValue = 10;
            vm.Price = 21;
           
            var c = vm.ComputeCommand;
            c.Execute(this);
            Assert.AreEqual(1, vm.Reste);
            Assert.AreEqual(2, vm.TicketsNumber);
        }
        [TestMethod]
        public void TestMethod2()
        {
            var vm = new MainPageViewModel();
            vm.TicketValue = 10;
            vm.Price = 0;
           
            var c = vm.ComputeCommand;
            c.Execute(this);
            Assert.AreEqual(0, vm.Reste);
            Assert.AreEqual(0, vm.TicketsNumber);
        }
        [TestMethod]
        public void TestMethod3()
        {
            var vm = new MainPageViewModel();
            vm.TicketValue = 0;
            vm.Price = 0;
           
            var c = vm.ComputeCommand;
            c.Execute(this);
            Assert.AreEqual(0, vm.Reste);
            Assert.AreEqual(0, vm.TicketsNumber);
        }
        [TestMethod]
        public void TestMethod4()
        {
            var vm = new MainPageViewModel();
            vm.TicketValue = 0;
            vm.Price = 10;
           
            var c = vm.ComputeCommand;
            c.Execute(this);
            Assert.AreEqual(0, vm.Reste);
            Assert.AreEqual(0, vm.TicketsNumber);
        }
    }
}
