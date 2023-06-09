///
 /// Code generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
 ///

namespace SDK.Utils;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

internal class FlexibleObjectDeserializer: JsonConverter
{
    public override bool CanConvert(Type objectType) =>
        objectType == typeof(object);

    public override bool CanWrite => false;

    public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
    {
        var token = JToken.ReadFrom(reader);

        if (token is JArray)
        {
            return new List<object>(token.Select(t =>
            {
                return t.ToString();
            }));
        }

        return token.ToObject(objectType);
    }

    public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer) =>
        throw new NotImplementedException();
}