namespace JogoGourmet;

internal class Program
{
    private static BinaryTree tree = null;

    public static void Main(string[] args)
    {
        tree = new BinaryTree();

        while (true)
        {
            Console.WriteLine("--- Pense em um prato que você gosta.");
            CheckNode(tree.Root);
            Console.WriteLine("-----------------------");
        }
    }

    public static void CheckNode(TreeNode node)
    {
        Console.WriteLine($"--- O prato que você pensou é {node.Value}?");
        Console.WriteLine("--- Digite 's' para sim e 'n' para não.");

        if (CheckResponse())
        {
            if (node.Right is null)
            {
                Console.WriteLine("--- Acertei!");
                return;
            }

            CheckNode(node.Right);
        }
        else
        {
            if (node.Left is null)
            {
                Console.WriteLine("--- Qual prato você pensou?");
                var newFood = Console.ReadLine();

                Console.WriteLine($"--- {newFood} é ______ mas {node.Value} não.");
                var newCat = Console.ReadLine();

                node.AddNode(newCat, newFood);

                return;
            }

            CheckNode(node.Left);
        }
    }


    public static bool CheckResponse()
    {
        if (Console.ReadLine() == "s")
            return true;
        else
            return false;
    }
}