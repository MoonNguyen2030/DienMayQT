using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DienmayQT.Controllers;
using System.Web.Mvc;
using DienmayQT.Models;
using System.Collections.Generic;
using System.Linq;

namespace DienmayQT.Tests.Controllers {
    [TestClass]
    public class QuanlyBSPTest {
        [TestMethod]
        public void TestIndex() {
            var controller =  new QuanlyBSPController();
            var result = controller.Index() as ViewResult;
            var db = new CS4PEEntities();

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result.Model,typeof(List<BangSanPham>));
            Assert.AreEqual(db.BangSanPhams.Count(),((List<BangSanPham>)result.Model).Count);


        }
    }
}
