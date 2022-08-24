namespace LinkedListSpace
{
    public class TreeNode
    {
        public int data { get; set; }

        private TreeNode _left;
        private TreeNode _right;
        public TreeNode Left
        {
            get { return _left; }
            set { _left = value; }
        }
        public TreeNode Right
        {
            get { return _right; }
            set { _right = value; }
        }

        public TreeNode(int item)
        {
            data = item;
            _left = _right = null;
        }
    }
}
