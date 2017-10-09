using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GlobalWeatherTest.GlobalWeatherReference.Fakes;
using Microsoft.QualityTools.Testing.Fakes;
using GlobalWeatherTest.GlobalWeatherReference;

namespace GlobalWeatherTest.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            using (ShimsContext.Create())
            {
                WebServiceHelper();

                string endpoint = "GlobalWeatherSoap12";
                GlobalWeatherSoapClient client = new GlobalWeatherSoapClient(endpoint);

                string citiesList = client.GetCitiesByCountry("China");

                Assert.AreEqual("Fake Cities", citiesList);
            }
        }

        public void WebServiceHelper()
        {
            ShimGlobalWeatherSoapClient.AllInstances.GetCitiesByCountryString = (service, countryName) =>
            {
                return "Fake Cities";
            };
        }
    }
}
