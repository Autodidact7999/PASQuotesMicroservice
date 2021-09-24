using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PolicyAdmin.QuotesMS.API.Services;
using PolicyAdmin.QuotesMS.API.Repository;
using PolicyAdmin.QuotesMS.API.Controllers;
using Moq;
using Microsoft.AspNetCore.Mvc;
using PolicyAdmin.QuotesMS.API.Interface;
using System.Net.Http;

namespace QuotesTest
{
    public class ControllerTests
    {
        [SetUp]
        public void Setup()
        {

        }
        public QuotesController quotesController;
        Mock<IQuoteRepository> mock = new Mock<IQuoteRepository>();
        var mockFactory = new Mock<IHttpClientFactory>();
        public ControllerTests()
        {
            quotesController = new QuotesController(mock.Object,mockFactory);
        }

        [TestCase(3, 4, "Factory Equipment")]
        [TestCase(6, 8, "Factory Equipment")]
        [TestCase(10, 10, "Property in Transit")]
        [TestCase(7, 6, "Property in Transit")]
        [TestCase(2, 1, "Building")]
        [TestCase(6, 7, "Building")]
        public void QuotesForPolicy_ValidData_String_Pass(int PropertyValue, int BusinessValue, string PropertyType)
        {
            mock.Setup(s => s.getQuotesForPolicy(3, 4, PropertyType.Building)).Returns("50000");
            mock.Setup(s => s.QuotesForPolicyService(6, 8, "Factory Equipment")).Returns("15000");
            mock.Setup(s => s.QuotesForPolicyService(10, 10, "Property in Transit")).Returns("120000");
            mock.Setup(s => s.QuotesForPolicyService(7, 6, "Property in Transit")).Returns("80000");
            mock.Setup(s => s.QuotesForPolicyService(2, 1, "Building")).Returns("40000");
            mock.Setup(s => s.QuotesForPolicyService(6, 7, "Building")).Returns("79000");

            var response = quotesController.getQuotesForPolicy(PropertyValue, BusinessValue, PropertyType) as OkObjectResult;

            Assert.AreEqual(200, response.StatusCode);
        }


        [TestCase(0, 5, "Factory Equipment")]
        [TestCase(1, 12, "Factory Equipment")]
        [TestCase(3, 499, "Property in Transit")]
        [TestCase(4, 9, "Property in Transit")]
        [TestCase(-1, 5, "Building")]
        [TestCase(99, 10, "Building")]
        [TestCase(1, 2, "Account")]
        [TestCase(-1, -2, "Clerk")]
        public void QuotesForPolicy_ValidData_String_Fail(int PropertyValue, int BusinessValue, string PropertyType)
        {

            mock.Setup(s => s.QuotesForPolicyService(PropertyValue, BusinessValue, PropertyType)).Returns("No Quotes, Contact Insurance Provider");

            var response = quotesController.getQuotesForPolicy(PropertyValue, BusinessValue, PropertyType) as BadRequestResult;

            Assert.AreEqual(400, response.StatusCode);

        }
    }
}