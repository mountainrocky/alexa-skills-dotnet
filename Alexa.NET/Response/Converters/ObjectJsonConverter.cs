using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Alexa.NET.Response.Converters
{
    public class ValuesJsonConverter<T> : JsonConverter<T>
    {
        protected ValuesJsonConverter(Func<Dictionary<string, string>, Type> typeConverter)
        {
            TypeConverter = typeConverter;
        }

        public Func<Dictionary<string, string>, Type> TypeConverter { get; set; }

        public static T LoadFromValues(ref Utf8JsonReader reader, Func<Dictionary<string, string>, Type> converter, JsonSerializerOptions options)
        {
            var dReader = reader;
            if (dReader.TokenType != JsonTokenType.StartObject)
            {
                throw new InvalidOperationException("Bad position for a JSON object");
            }

            var dictionary = new Dictionary<string, string>();
            while (dReader.Read() && dReader.TokenType == JsonTokenType.PropertyName)
            {
                var key = dReader.GetString();
                dReader.Read();
                if (dReader.TokenType == JsonTokenType.String)
                {
                    dictionary.Add(key, dReader.GetString());
                }
            }

            var type = converter(dictionary);
            return (T)JsonSerializer.Deserialize(ref reader, type, options);
        }

        public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return LoadFromValues(ref reader, TypeConverter, options);
        }

        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value.GetType(), options);
        }
    }
}
