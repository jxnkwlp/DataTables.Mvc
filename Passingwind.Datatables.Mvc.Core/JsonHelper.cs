using System;
using Newtonsoft.Json;

namespace Passingwind.Datatables.Mvc
{
    static class JsonHelper
    {
        public static object DeserializeObject(string value)
        {
            return JsonConvert.DeserializeObject(value);
        }

        public static object DeserializeObject(string value, Type type)
        {
            return JsonConvert.DeserializeObject(value, type);
        }

        public static T DeserializeObject<T>(string value)
        {
            return JsonConvert.DeserializeObject<T>(value);
        }

        public static T DeserializeObject<T>(string value, T anonymousTypeObject)
        {
            return JsonConvert.DeserializeAnonymousType<T>(value, anonymousTypeObject);
        }

        public static string SerializeObject(object value, bool indented = false)
        {
            var setting = new JsonSerializerSettings() { };

            if (indented)
                setting.Formatting = Formatting.Indented;

            return JsonConvert.SerializeObject(value, setting);
        }
    }
}