using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace KiddosBlazor.Server.Helpers
{
    internal static class JsonLoader
    {
        public static T Load<T>(string jsonPath) where T : class
        {
            var assemblyPath = Path.GetDirectoryName(typeof(JsonLoader).GetTypeInfo().Assembly.Location);
            var filePath = Path.Combine(@"C:\Git\github\KiddosBlazor\KiddosBlazor.Server\", jsonPath);
            var json = File.ReadAllText(filePath);

            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
