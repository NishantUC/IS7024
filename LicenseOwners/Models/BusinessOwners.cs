﻿
namespace QuickTypeOwners
{
    using System;
    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class BusinessOwners
    {
        [JsonProperty("account_number")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long AccountNumber { get; set; }

        [JsonProperty("doing_business_as_name")]
        public string DoingBusinessAsName { get; set; }

        [JsonProperty("owner_first_name")]
        public string OwnerFirstName { get; set; }

        [JsonProperty("owner_middle_initial")]
        public string OwnerMiddleInitial { get; set; }

        [JsonProperty("owner_last_name")]
        public string OwnerLastName { get; set; }

        [JsonProperty("owner_title")]
        public string OwnerTitle { get; set; }
    }

    public partial class BusinessOwners
    {
        public static BusinessOwners[] FromJson(string json) => JsonConvert.DeserializeObject<BusinessOwners[]>(json, QuickTypeOwners.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this BusinessOwners[] self) => JsonConvert.SerializeObject(self, QuickTypeOwners.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }
}
