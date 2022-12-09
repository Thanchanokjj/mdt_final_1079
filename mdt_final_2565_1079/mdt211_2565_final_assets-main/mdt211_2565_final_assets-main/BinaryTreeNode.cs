class BinaryTreeNode<T> where T : IComparable<T>
{
    private T value;
    private BinaryTreeNode<T> left = null;
    private BinaryTreeNode<T> right = null;

    public BinaryTreeNode(T value)
    {
        this.SetValue(value);
    }

    public void SetLeft(BinaryTreeNode<T> left)
    {
        this.left = left;
    }

    public void SetRight(BinaryTreeNode<T> right)
    {
        this.right = right;
    }

    public BinaryTreeNode<T> Left()
    {
        return this.left;
    }

    public BinaryTreeNode<T> Right()
    {
        return this.right;
    }

    public T GetValue()
    {
        return this.value;
    }

    public void SetValue(T value)
    {
        this.value = value;
    }
}