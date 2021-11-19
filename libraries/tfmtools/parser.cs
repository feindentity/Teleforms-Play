using System.Collections.Specialized;

namespace tfmtools;
public static class parsingtools
{
    public static bool validate_tfm(string tfm_string )
    {
        return(tfm_string.Contains("&") && tfm_string.Contains("="));
    }
    public static NameValueCollection parse_tfm(string tfm_string)
    {
        NameValueCollection nvc = new NameValueCollection();
        string[] tfm_array = tfm_string.Split('&');
        foreach (string tfm_item in tfm_array)
        {
            string[] tfm_item_array = tfm_item.Split('=');
            nvc.Add(tfm_item_array[0], tfm_item_array[1]);
        }
        return nvc;
    }
}
