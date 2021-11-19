using System.Collections.Specialized;
namespace tfmtools;
    public static class documenttools
    {
        public static string GenerateDocument(NameValueCollection nameValueCollection, string template)
        {
            string result = template;
            foreach (string key in nameValueCollection.AllKeys)
            {
                result = result.Replace("{" + key + "}", nameValueCollection[key]);
            }
            return result;
        }
    }
