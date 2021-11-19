namespace tfmtools;
public static class parsingtools
{
    public static bool validate_tfm(string tfm_string )
    {
        return(tfm_string.Contains("&") && tfm_string.Contains("="));
    }

}
