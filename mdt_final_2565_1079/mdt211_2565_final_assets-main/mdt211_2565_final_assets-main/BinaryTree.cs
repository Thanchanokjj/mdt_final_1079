class BinaryTree<T> where T : IComparable<T>
{
    protected BinaryTreeNode<T> root = null;
    protected int length = 0;

    public void Add(T value)
    {
        BinaryTreeNode<T> node = new BinaryTreeNode<T>(value);
        if(this.root == null)
        {
            this.root = node;
        }
        else
        {
            Queue<BinaryTreeNode<T>> nodeQueue = new Queue<BinaryTreeNode<T>>();
            nodeQueue.Push(this.root);

            BinaryTreeNode<T> ptr;
            while(nodeQueue.GetLength() > 0)
            {
                ptr = nodeQueue.Pop();
                if(ptr.Left() == null)
                {
                    ptr.SetLeft(node);
                    break;
                }
                else if(ptr.Right() == null)
                {
                    ptr.SetRight(node);
                    break;
                }
                else
                {
                    nodeQueue.Push(ptr.Left());
                    nodeQueue.Push(ptr.Right());
                }
            }
        }
        this.length++;
    }

    public void AddLeft(int index, T value)
    {
        BinaryTreeNode<T> node = new BinaryTreeNode<T>(value);
        if(index == -1)
        {
            node.SetLeft(this.root);
            this.root = node;
        }
        else
        {
            BinaryTreeNode<T> ptr = this.GetBinaryTreeNode(index);
            node.SetLeft(ptr.Left());
            ptr.SetLeft(node);
        }
        this.length++;
    }

    public void AddRight(int index, T value)
    {
        BinaryTreeNode<T> node = new BinaryTreeNode<T>(value);
        if(index == -1)
        {
            node.SetLeft(this.root);
            this.root = node;
        }
        else
        {
            BinaryTreeNode<T> ptr = this.GetBinaryTreeNode(index);
            node.SetRight(ptr.Right());
            ptr.SetRight(node);
        }
        this.length++;
    }

    public void Remove(int index)
    {
        if(index == 0)
        {
            BinaryTreeNode<T> ptr = this.root;
            this.root = ptr.Left();
            if(this.root.Right() != null)
            {
                this.root.SetLeft(this.root.Right());
                this.root.SetRight(null);
            }
        }
        else
        {
            BinaryTreeNode<T> previousPtr = this.GetBinaryTreeNode(index-1);
            if(previousPtr.Left() != null)
            {
                BinaryTreeNode<T> ptr = previousPtr.Left();

                if(ptr.Right() != null)
                {
                    previousPtr.SetLeft(ptr.Left());
                    ptr.Right().SetRight(ptr.Right());
                }
                else
                {
                    previousPtr.SetLeft(ptr.Right());
                }
            }
            else
            {
                BinaryTreeNode<T> ptr = previousPtr.Right();

                if(ptr.Left() != null)
                {
                    previousPtr.SetRight(ptr.Left());
                    ptr.Left().SetRight(ptr.Right());
                }
                else
                {
                    previousPtr.SetRight(ptr.Right());
                }
            }
        }
        this.length--;
    }

    public int GetLength()
    {
        return this.length;
    }

    public T Get(int index)
    {
        BinaryTreeNode<T> ptr = this.GetBinaryTreeNode(index);
        return ptr.GetValue();
    }

    private BinaryTreeNode<T> GetBinaryTreeNode(int index)
    {
        int traverseStep = index;
        return this.Traverse(this.root, ref traverseStep);
    }

    private BinaryTreeNode<T> Traverse(BinaryTreeNode<T> currentBinaryTreeNode, ref int traverseStep)
    {
        BinaryTreeNode<T> ptr = currentBinaryTreeNode;

        if(traverseStep > 0 && currentBinaryTreeNode.Left() != null)
        {
            traverseStep--;
            ptr = this.Traverse(currentBinaryTreeNode.Left(), ref traverseStep);
        }

        if(traverseStep > 0 && currentBinaryTreeNode.Right() != null)
        {
            traverseStep--;
            ptr = this.Traverse(currentBinaryTreeNode.Right(), ref traverseStep);
        }

        return ptr;
    }

    private BinaryTreeNode<T> Search(T value)
    {
        Queue<BinaryTreeNode<T>> nodeQueue = new Queue<BinaryTreeNode<T>>();
        nodeQueue.Push(this.root);

        BinaryTreeNode<T> ptr;
        while(nodeQueue.GetLength() > 0)
        {
            ptr = nodeQueue.Pop();
            if(ptr.GetValue().CompareTo(value) == 0)
            {
                return ptr;
            }
            else
            {
                if(ptr.Left() != null)
                {
                    nodeQueue.Push(ptr.Left());
                }
                if(ptr.Right() != null)
                {
                    nodeQueue.Push(ptr.Right());
                }
            }
        }

        return null;
    }
}