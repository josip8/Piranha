using Piranha.AttributeBuilder;
using Piranha.Models;

namespace hoosfone_piranha.Models
{
    [PostType(Title = "Standard post")]
    public class StandardPost  : Post<StandardPost>
    {
    }
}