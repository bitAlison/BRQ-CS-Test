using System.Text.Json;

namespace LibTrade.Extensions
{
    public static class JsonExtensions
    {
        public static string ToJson<T>(this T Model)
        {
            return JsonSerializer.Serialize(Model);
        }

        public static T ToJson<T>(this string Json)
        {
            return JsonSerializer.Deserialize<T>(Json);
        }
    }
}
