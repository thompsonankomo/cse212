public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        if (value < Data) {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        // Check if the value is greater than or equal to the current node's data
        if (value >= Data)
        {
            // If it is, check if there is a right child node
            if (Right == null)
                return false; // If there is no right child node, the value is not found

            // If the value matches the right child node, return true
            if (value == Right.Data)
                return true;

            // If the value is not found in the right child node, 
            //recursively search in the right subtree
            else if (Right.Contains(value))
                return true;

            // If the value is not found in the right subtree, return false
            return false;
        }
        else
        {
            // Check if the value is less than the current node's data
            if (Left == null)
                return false; // If there is no left child node, the value is not found

            // If the value matches the left child node, return true
            if (value == Left.Data)
                return true;

            // If the value is not found in the left child node, recursively search in the left subtree
            else if (Left.Contains(value))
                return true;

            // If the value is not found in the left subtree, return false
            return false;
        }
    }



    public int GetHeight()  {
        // TODO Start Problem 4
        // Recursively calculate the subtrees
        int leftHeight = Left == null ? -1 : Left.GetHeight();
        int rightHeight = Right == null ? -1 : Right.GetHeight();

        // Returns the max height of both subtrees plus 1 for the current node
        return 1 + Math.Max(leftHeight, rightHeight);
    }
}