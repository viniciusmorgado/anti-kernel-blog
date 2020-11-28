using Piranha.AttributeBuilder;
using Piranha.Models;

namespace AntiKenerlBlog.Models
{
    [PageType(Title = "Standard archive", IsArchive = true)]
    public class StandardArchive : Page<StandardArchive>
    {
    }
}