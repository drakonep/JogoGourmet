namespace JogoGourmet.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var tree = new BinaryTree();
        var node = tree.Root;

        Assert.Equal("massa", node.Value);
        Assert.Equal("lasanha", node.Right.Value);
        Assert.Equal("bolo de chocolate", node.Left.Value);
        
        node.Right.AddNode("fino", "macarrao");
        Assert.Equal("macarrao", node.Right.Right.Value);
        
        node.Right.AddNode("rapido", "miojo");
        Assert.Equal("miojo", node.Right.Right.Value);
        Assert.Equal("macarrao", node.Right.Left.Right.Value);
        
        node.Left.AddNode("frito", "coxinha");
        Assert.Equal("coxinha", node.Left.Right.Value);
        
        node.Left.AddNode("salgado", "joelho");
        Assert.Equal("joelho", node.Left.Right.Value);
        
    }
    
}
