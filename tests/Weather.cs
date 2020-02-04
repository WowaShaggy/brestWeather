using System;
using System.Collections.Generic;
using System.Diagnostics;
using Amazon.SimpleSystemsManagement.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;
using RestSharp.Serialization.Json;
using Assert = NUnit.Framework.Assert;

namespace BrestWeatherRestSharp
{
    [TestClass]
    public class Weather : TestBase
    {
        private readonly string operation = "weather";

        [TestMethod]
        public void GetResponseByIdAsString2()
        {
            QueryBuilder query = new QueryBuilder().withOperation(operation).byId("629634");
            var content = query.ExecuteContent();

            Assert.IsNotNull(content);
            Assert.IsTrue(content.Contains("Brest"));
        }

        [TestMethod]
        public void GetResponseByLocationAsJson()
        {
            QueryBuilder query = new QueryBuilder().withOperation(operation).byCityName("Brest");
            var response = query.ExecuteResponse();

            JObject obs = JObject.Parse(response.Content);
            Assert.That(obs["name"].ToString, Is.EqualTo("Brest"), "That is another city");
        }

        [TestMethod]
        public void GetResponseByLocationAsJsonInCelcium()
        {
            QueryBuilder query = new QueryBuilder().withOperation(operation).byCityName("Brest").withUnits("metric");
            var response = query.ExecuteResponse();

            JObject obs = JObject.Parse(response.Content);
            Assert.That(obs["name"].ToString, Is.EqualTo("Brest"), "That is another city");
            Assert.That(obs["main"]["temp"].ToObject<double>, Is.GreaterThan(0), "It's unexpected cold today as for Brest");
        }
    }
}
