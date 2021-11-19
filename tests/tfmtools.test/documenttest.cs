using Xunit;
using System.Collections.Specialized;
using tfmtools;
public static class documenttoolsTest
{
    [Fact]
    public static void test_GenerateDocument()
    {
        NameValueCollection nameValueCollection = new NameValueCollection();
        nameValueCollection.Add("test", "123");
        nameValueCollection.Add("test2", "456");
        string template = "<html><body><div id=\"test\">{test}</div><div id=\"test2\">{test2}</div></body></html>";
        string result = documenttools.GenerateDocument(nameValueCollection, template);
        Assert.Equal("<html><body><div id=\"test\">123</div><div id=\"test2\">456</div></body></html>", result);
    }
}
