using Xunit;
using System.Collections.Specialized;
namespace tfmtools.test;

public class parsertest
{
    [Fact]
    public void test_validate_tfm()
    {
        Assert.True(parsingtools.validate_tfm("test=123&test2=456"));
    }
    
    [Fact]
    public void test_validate_tfm_false()
    {
        Assert.False(parsingtools.validate_tfm("testtest"));
    }
    [Fact]
    public void test_parse_tfm()
    {
        NameValueCollection nvc = parsingtools.parse_tfm("test=123&test2=456");
        Assert.Equal("123", nvc["test"]);
        Assert.Equal("456", nvc["test2"]);
        Assert.Equal(2, nvc.Count);
    }
}