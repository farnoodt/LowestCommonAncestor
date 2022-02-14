// See https://aka.ms/new-console-template for more information
using TreePractice;



Node tree = new Node(5);
tree.left = new Node(4);
//tree.left.left = new Node(3);
tree.right = new Node(6);
tree.right.right = new Node(7);
tree.right.left = new Node(3);
//Console.WriteLine(IsBST(tree));


Node LCA(Node root, Node r1, Node r2)
{
    if (root == r1 || root == r2)
        return root;

    Node left = LCA(root.left, r1, r2);
    Node right = LCA(root.right, r1, r2);

    if (right == null && left == null)
        return null;

    if (right != null && left != null)
        return root;

    return (right != null) ? right : left;
}


