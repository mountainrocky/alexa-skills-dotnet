using System;
using System.IO;
using Newtonsoft.Json.Linq;

namespace Alexa.NET.Tests
{
    public static class Utility
    {
        private const string ExamplesPath = "Examples";

        public static bool CompareJson(object actual, string expectedFile)
        {
            var rawSystemJson = AlexaNetSerializer.Serialize(actual);
            var actualJObject = JObject.Parse(rawSystemJson);
            var expected = File.ReadAllText(Path.Combine(ExamplesPath, expectedFile));
            var expectedJObject = JObject.Parse(expected);
            return JToken.DeepEquals(expectedJObject, actualJObject);
        }

        public static T ExampleFileContent<T>(string expectedFile)
        {
            using (var reader = File.OpenRead(Path.Combine(ExamplesPath, expectedFile)))
            {
                return AlexaNetSerializer.DeserializeAsync<T>(reader).Result; // Sorry - small change footprint!
            }
        }

        public static string ExampleFileContent(string expectedFile)
        {
            return File.ReadAllText(Path.Combine(ExamplesPath, expectedFile));
        }
    }
}