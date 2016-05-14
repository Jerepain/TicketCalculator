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
            vm.TicketValue = 10;
            vm.Price = 21;
           

            Assert.AreEqual(1, vm.Reste);
            Assert.AreEqual(2, vm.TicketsNumber);
        }
        [TestMethod]
        public void TestMethod2()
        {
            var vm = new MainPageViewModel();
            vm.TicketValue = 10;
            vm.Price = 0;
           
       
            Assert.AreEqual(0, vm.Reste);
            Assert.AreEqual(0, vm.TicketsNumber);
        }
        [TestMethod]
        public void TestMethod3()
        {
            var vm = new MainPageViewModel();
            vm.TicketValue = 0;
            vm.Price = 0;
       
            Assert.AreEqual(0, vm.Reste);
            Assert.AreEqual(0, vm.TicketsNumber);
        }
        [TestMethod]
        public void TestMethod4()
        {
            var vm = new MainPageViewModel();
            vm.TicketValue = 0;
            vm.Price = 10;
         
            Assert.AreEqual(0, vm.Reste);
            Assert.AreEqual(0, vm.TicketsNumber);
        }
    }
}
