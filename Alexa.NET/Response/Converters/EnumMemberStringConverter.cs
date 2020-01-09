using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Alexa.NET.Response.Converters
{
    public class EnumMemberStringConverter: JsonConverter<object>
    {
        public override bool CanConvert(Type typeToConvert)
        {
            return typeToConvert.IsEnum;
        }

        public override object Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return ToEnum(reader.GetString(),typeToConvert);
        }

        public override void Write(Utf8JsonWriter writer, object value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(ToEnumString(value));
        }

        private static string ToEnumString(object type)
        {
            var enumType = type.GetType();
            var name = Enum.GetName(enumType, type);
            var enumMemberAttribute = ((EnumMemberAttribute[])enumType.GetTypeInfo().GetField(name).GetCustomAttributes(typeof(EnumMemberAttribute), true)).FirstOrDefault();
            return enumMemberAttribute?.Value ?? type.ToString();
        }

        private static object ToEnum(string str, Type enumType)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return null;
            }

            foreach (var name in Enum.GetNames(enumType))

            {
                var enumMemberAttribute = ((EnumMemberAttribute[])enumType.GetTypeInfo().GetField(name).GetCustomAttributes(typeof(EnumMemberAttribute), true)).FirstOrDefault();
                if (enumMemberAttribute != null && enumMemberAttribute.Value == str) return Enum.Parse(enumType, name);
            }
            return null;
        }
    }
}
