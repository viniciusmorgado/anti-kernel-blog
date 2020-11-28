using Piranha.AttributeBuilder;
using Piranha.Models;

namespace AntiKenerlBlog.Models
{
    [PostType(Title = "Standard post")]
    public class StandardPost  : Post<StandardPost>
    {
    }
}