using System;
using System.Collections.Generic;
using System.Text;

namespace Alexa.NET.Response.Converters
{
    public class TypeJsonConverter<T>:DiscriminatorJsonConverter<T>
    {
        public TypeJsonConverter(Dictionary<string,Func<T>> typeFactories) : base("type", t => typeFactories.ContainsKey(t) ? typeFactories[t]().GetType() : null)
        {
        }
    }
}
