using Xunit;

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
}