using Bunit;
using Dj.Components.Pages;
using Xunit;
using Dj;

public class HomePageTests : TestContext
{
    [Fact]
    public void HomePage_RendersCorrectly()
    {
        var component = RenderComponent<Home>();

        var h1Element = component.Find("h1.display-1");

        Assert.Equal("DJ Asistent", h1Element.TextContent.Trim());
    }

    [Fact]
    public void HomePage_ContainsMoreAboutUsButton()
    {
        var component = RenderComponent<Home>();

        var button = component.Find("a.btn.btn-primary");
        Assert.Equal("Več o nas", button.InnerHtml);
    }

    [Fact]
    public void HomePage_ContainsFunctionalitiesButton()
    {
        var component = RenderComponent<Home>();

        var button = component.Find("a.btn.btn-secondary");
        Assert.Equal("Funkcionalnosti", button.InnerHtml);
    }

    [Fact]
    public void HomePage_DisplaysFeaturesSection()
    {
        var component = RenderComponent<Home>();

        var featuresSection = component.Find("#features");
        Assert.NotNull(featuresSection);
    }

    [Fact]
    public void HomePage_ShowsAboutSection()
    {
        var component = RenderComponent<Home>();

        var aboutSection = component.Find("#about");
        Assert.NotNull(aboutSection);
    }
}
