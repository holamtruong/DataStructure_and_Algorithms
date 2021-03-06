// CÂY NHỊ PHÂN
public class Node{
    public int data;
    public Node left;
    public Node right;
    public Node(int value){
        data = value;
        left = null;
        right = null;
}   
public void Insert(int value){
        if (value >= data)
        {
            if (right == null)
                right = new Node(value);
            else
                right.Insert(value);
        }
        else
        {
            if (left == null)
                left = new Node(value);
            else
                left.Insert(value);
        }
    }
    
public bool Search(int value){
        if (value == data)
            return true;
        else if (value < data && left != null)
            return left.Search(value);
        else if (right != null)
            return right.Search(value);
        else
            return false;
    }
    public void Sort()
    {
        if (left != null)
            left.Sort();
        Console.Write(data + " ");
        if (right != null)
            right.Sort();
    }
    public int CountLeaf()
    {
        if (left == null && right == null)
            return 1;
        int countLeft = 0;
        int countRight = 0;
        if (left != null)
            countLeft = left.CountLeaf();
        if (right != null)
            countRight = right.CountLeaf();
        return countLeft + countRight;
    }
    public int Height()
    {
        if (left == null && right == null)
            return 1;
        int countLeft = 0;
        int countRight = 0;
        if (left != null)
            countLeft = left.Height();
        if (right != null)
            countRight = right.Height();
        if (countLeft > countRight)
            return (countLeft + 1);
        else
            return (countRight + 1);
    }
}

// BinaryTree ---------------------
public class BinaryTree{
    public Node root;
    public BinaryTree(){
        root = null;
    }
    public void Insert(int value){
        if (root == null)
            root = new Node(value);
        else
            root.Insert(value);
    }
    public bool Search(int data){
        if (root != null)
            return root.Search(data);
        else
            return false;
    }
    public void Sort(){
        if (root != null)
            root.Sort();
    }
    public int CountLeaf(){
        if (root != null)
            return root.CountLeaf();
        else
            return 0;
    }
    public int Height(){
        if (root != null)
            return root.Height();
        else
            return 0;
    }
}
