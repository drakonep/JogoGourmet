namespace JogoGourmet;

public class TreeNode
{
    public string Value { get; set; }
    public TreeNode Parent { get; set; }
    public TreeNode Left { get; set; }
    public TreeNode Right { get; set; }

    public TreeNode(string value, TreeNode parent)
    {
        Value = value;
        Left = null;
        Right = null;
        Parent = parent;
    }

    public void AddLeft(string value)
    {
        this.Left = new TreeNode(value, this);
    }

    public void AddRight(string value)
    {
        this.Right = new TreeNode(value, this);
    }

    public void AddNode(string? newCat, string? newFood)
    {
        if (newCat == null || newFood == null)
            return;

        var oldNode = new TreeNode(this.Value, this.Parent);
        oldNode.Left = this.Left;
        oldNode.Right = this.Right;

        this.Value = newCat;
        this.Left = oldNode;
        this.Right = new TreeNode(newFood, this);
    }
}

public class BinaryTree
{
    public TreeNode Root { get; private set; }

    public BinaryTree(TreeNode root)
    {
        Root = root;
    }

    public BinaryTree()
    {
        Init();
    }

    public void Init()
    {
        Root = new TreeNode("massa", null);
        Root.AddRight("lasanha");
        Root.AddLeft("bolo de chocolate");
    }
}