class BinarySearchTree<T> : BinaryTree<T> where T : IComparable<T>
{
    public void Add(T value)
    {
        BinaryTreeNode<T> node = new BinaryTreeNode<T>(value);
        if(this.root == null)
        {
            this.root = node;
        }
        else
        {
            BinaryTreeNode<T> ptr = this.root;
            while(true)
            {
                if(ptr.GetValue().CompareTo(value) >= 0)
                {
                    if(ptr.Left() == null)
                    {
                        ptr.SetLeft(node);
                        break;
                    }
                    else
                    {
                        ptr = ptr.Left();
                    }
                }
                else
                {
                    if(ptr.Right() == null)
                    {
                        ptr.SetRight(node);
                        break;
                    }
                    else
                    {
                        ptr = ptr.Right();
                    }
                }
            }
        }
        this.length++;
    }
}