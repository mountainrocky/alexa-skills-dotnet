using System;
using System.Collections.Generic;
using Alexa.NET.ConnectionTasks;
using Alexa.NET.ConnectionTasks.Inputs;


namespace Alexa.NET.Response.Converters
{
    public class ConnectionTaskConverter : ValuesJsonConverter<IConnectionTask>
    {
        public ConnectionTaskConverter() : base(FindType)
        {
        }

        public override bool CanConvert(Type typeToConvert) =>
            typeof(IConnectionTask).IsAssignableFrom(typeToConvert);

        public static Dictionary<string, Func<IConnectionTask>> TaskFactoryFromUri = new Dictionary<string, Func<IConnectionTask>>
        {
            {"PrintPDFRequest/1",() => new PrintPdfV1() },
            {"PrintImageRequest/1", () => new PrintImageV1() },
            {"PrintWebPageRequest/1",() => new PrintWebPageV1()},
            {"ScheduleTaxiReservationRequest/1",() => new ScheduleTaxiReservation() },
            {"ScheduleFoodEstablishmentReservationRequest/1",() => new ScheduleFoodEstablishmentReservation()}
        };

        public static Type FindType(Dictionary<string,string> values)
        {
            var typeKey = values["@type"];
            var versionKey = values["@version"];
            var factoryKey = $"{typeKey}/{versionKey}";
            var hasFactory = TaskFactoryFromUri.ContainsKey(factoryKey);

            if (!hasFactory)
                throw new Exception(
                    $"unable to deserialize response. " +
                    $"unrecognized task type '{typeKey}' with version '{versionKey}'"
                );

            return TaskFactoryFromUri[factoryKey]().GetType();
        }
    }
}