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
    public class EnumMemberStringConverter<T>: JsonConverter<T>
    {
        public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return ToEnum(reader.GetString(),typeToConvert);
        }

        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
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

        private static T ToEnum(string str, Type enumType)
        {
            if (!enumType.IsEnum && enumType.GenericTypeArguments.Any())
            {
                enumType = enumType.GenericTypeArguments.First();
            }

            if (string.IsNullOrWhiteSpace(str))
            {
                return default(T);
            }

            foreach (var name in Enum.GetNames(enumType))

            {
                var enumMemberAttribute = ((EnumMemberAttribute[])enumType.GetTypeInfo().GetField(name).GetCustomAttributes(typeof(EnumMemberAttribute), true)).FirstOrDefault();
                if (enumMemberAttribute != null && enumMemberAttribute.Value == str) return (T)Enum.Parse(enumType, name);
            }
            return default(T);
        }
    }
}
