using Piranha.Extend;
using Piranha.Extend.Fields;

[BlockType(Name = "Test", Category = "Content",
    Icon = "fas fa-quote-right", Component = "test-block")]
public class TestBlock : Block
{
    /// <summary>
    /// Gets/sets the text body.
    /// </summary>
    public TextField Body { get; set; }
}