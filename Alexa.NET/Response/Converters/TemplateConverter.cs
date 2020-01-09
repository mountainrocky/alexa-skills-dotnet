using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Alexa.NET.Response.Directive;
using Alexa.NET.Response.Directive.Templates.Types;


namespace Alexa.NET.Response.Converters
{
    public class TemplateConverter : TypeJsonConverter<ITemplate>
    {
        public TemplateConverter() : base(TypeFactories)
        {

        }

        public static Dictionary<string, Func<ITemplate>> TypeFactories = new Dictionary<string, Func<ITemplate>>
        {
            { "BodyTemplate1", () => new BodyTemplate1() },
            { "BodyTemplate2", () => new BodyTemplate2() },
            { "BodyTemplate3", () => new BodyTemplate3() },
            { "BodyTemplate6", () => new BodyTemplate6() },
            { "BodyTemplate7", () => new BodyTemplate7() },
            { "ListTemplate1", () => new ListTemplate1() },
            { "ListTemplate2", () => new ListTemplate2() },
        };
    }
}