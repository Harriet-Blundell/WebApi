using System;
using WebApi;
using Xunit;
using WebApi.Controllers;
using System.Collections.Generic;

namespace WebApiTests
{
    public class ElephantTests
    {
        [Fact]
        public void GetGreetingReturnsNonEmptyString()
        {
            var testGreetingController = new GreetingController();
            var testData = testGreetingController.GetString();

            Assert.True(testData.Length > 0);
        }

        [Fact]
        public async void GetAllElephantsReturnsNonEmptyList()
        {
            var elephant1 = new Elephant();
            var elephant2 = new Elephant();
            var listOfElephants = new List<Elephant>()
            {
                elephant1,
                elephant2
            };

            var testGreetingController = new GreetingController();
            var testElephantData = await testGreetingController.GetElephantList();

            Assert.True(testElephantData.Count > 0);
        }
    }
}
