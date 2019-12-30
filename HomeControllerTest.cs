using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RealEstateAgents.Controllers;
using RealEstateAgents.Models;

namespace RealEstateAgents.UnitTests
{
    [TestClass]
    public class RealEstateAgentTests
    {
        List<RealEstateAgent> realEstateAgent = new List<RealEstateAgent>();

        [TestMethod]
        public async Task GetRealEstateAgents_SaleInAmsterdam_ReturnsToIndexView()
        {
            var homeController = new HomeController();

            var result = await homeController.GetRealEstateAgents("");

            Assert.AreEqual("Index", result.ViewName);
        }

        [TestMethod]
        public async Task GetRealEstateAgents_SaleInAmsterdamWithGarden_ReturnsToIndexView()
        {
            var homeController = new HomeController();

            var result = await homeController.GetRealEstateAgents("tuin");

            Assert.AreEqual("Index", result.ViewName);
        }
    }
}
