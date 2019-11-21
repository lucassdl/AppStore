using LL.Store.UI.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;

namespace LL.Store.Tests.UI.Controllers
{
    [TestClass, TestCategory("Controllers/HomeController")]
    public class HomeControllerTest
    {
        /// <summary>
        /// Método que testa se o método /Home/Index retorna uma View
        /// </summary>
        [TestMethod]
        public void TesteDoMetodoIndexHome()
        {
            //arrange
            var homeController = new HomeController();

            //act
            var result = homeController.Index();

            //assert
            Assert.AreEqual(typeof(ViewResult), result.GetType());
        }
    }
}
