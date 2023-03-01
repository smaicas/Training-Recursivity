namespace Dnj.Colab.Training.Recursivity;
public class LuisNode
{
    public LuisNode(int value) => Value = value;

    public int Value { get; set; }
    public List<LuisNode> Childs { get; set; } = new List<LuisNode>();
}
