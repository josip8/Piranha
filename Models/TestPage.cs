using Piranha.AttributeBuilder;
using Piranha.Models;

namespace hoosfone_piranha.Models
{
    [PageType(Title = "Test page")]
    [PageTypeRoute(Title = "Default", Route = "/test")]
    public class TestPage  : Page<TestPage>
    {
    }
}