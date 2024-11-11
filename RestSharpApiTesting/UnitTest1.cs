using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace RestSharpApiTesting
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            string bearerToken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJJZCI6IjEiLCJGaXJzdE5hbWUiOiJTYXVmaWsgVGVjaG5vbG9naWVzIFRlY2hub2xvZ2llcyIsIkxhc3ROYW1lIjoiVGVjaG5vbG9naWVzIiwiRW1haWwiOiJzYXVmaWt0ZXN0ZXJzQG1haWxpbmF0b3IuY29tIiwiVXNlck5hbWUiOiJhZG1pbiIsIlJvbGUiOiIxIiwiR3VpZCI6IjFiNzg0MTA1LTM2ZjgtNDI2OS05Yzg2LTc3NDMwZjY0ZDA5MCIsIklzRnJhbmNoaXNlIjoiRmFsc2UiLCJDb21wYW55R3VpZCI6IjZmOWYxNWMzLTU4YmEtNDUzYy04MDU3LWQ1YWY1NTBjZWQzOSIsIlBhcmVudENvbXBhbnlHdWlkIjoiNmY5ZjE1YzMtNThiYS00NTNjLTgwNTctZDVhZjU1MGNlZDM5IiwiQ29tcGFueU5hbWUiOiJDb3JlIExNUyIsIkNvbXBhbnlJZCI6IjEiLCJQYXJlbnRDb21wYW55SWQiOiIwIiwiRG9tYWluVXJsIjoiaHR0cHM6Ly9jb3JlLWxtcy5jYWxpYmVybWF0cml4LmNvbSIsIkZhbWlseUlkIjoiMCIsIklzSW1wZXJzb25hdGluZyI6IkZhbHNlIiwiSW1wZXJzb25hdGVBZG1pblVzZXJuYW1lIjoiIiwiUGF5bWVudEdhdGV3YXkiOiIxIiwiRGVmYXVsdFRpbWVab25lIjoiUGFraXN0YW4gU3RhbmRhcmQgVGltZSIsIlBvcnRhbFVybCI6Imh0dHBzOi8vY2VkdXQtZGV2LWN1cy1wb3J0YWwtYXBwLTAxLmF6dXJld2Vic2l0ZXMubmV0IiwiRnJhbmNoaXNlU2VjdXJlVXJsIjoiaHR0cHM6Ly9zZWN1cmUtY29yZS1sbXMuY2FsaWJlcm1hdHJpeC5jb20iLCJTZWN1cmVDb21wYW55SWQiOiIxNTM2IiwiZXhwIjoxNzMzOTI5MTI4LCJpc3MiOiJDYWxpbWF0aWMuY29tIiwiYXVkIjoibG9jYWxob3N0In0.KAqkGSm2x-M9edHMCEKkF2-Zgy913Ybe6Mk-qHcv200";

            var client = new RestClient("https://angular-api.calibermatrix.com/api/Student/students");
            var request = new RestRequest("Students/{studentID}", Method.Get);
            request.AddUrlSegment("franchiseID", 3350);
            request.AddHeader("Authorization", $"Bearer {bearerToken}");
            var response = client.Execute(request);

            var output = JsonSerializer.Deserialize<Dictionary<string, string>>(response.Content);
            var result = output ["studentID"];

            JObject obs = JObject.Parse(response.Content);
            Assert.That(obs["studentID"],Is.EqualTo(3350), "StudentID is Not Correct");
        }
    }
}
