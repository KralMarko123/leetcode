
namespace Leetcode.Exercises.CSharp.Medium
{
    /**
    * Your MinStack object will be instantiated and called as such:
    * MinStack obj = new MinStack();
    * obj.Push(val);
    * obj.Pop();
    * int param_3 = obj.Top();
    * int param_4 = obj.GetMin();
    */
    public class MinStack
    {
        private List<int> Elements;
        private List<int> MinimalElements;

        public MinStack()
        {
            Elements = new List<int>();
            MinimalElements = new List<int>();
        }

        public void Push(int val)
        {
            if (Elements.Count == 0 || val <= MinimalElements.Last()) MinimalElements.Add(val);
            Elements.Add(val);
        }

        public void Pop()
        {
            if (Elements.ElementAt(Elements.Count - 1) == MinimalElements.Last())
                MinimalElements.RemoveAt(MinimalElements.Count - 1);

            Elements.RemoveAt(Elements.Count - 1);
        }

        public int Top()
        {
            return Elements.Last();
        }

        public int GetMin()
        {
            return MinimalElements.Last();
        }
    }
}
