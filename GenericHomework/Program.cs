using System;



namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(1234);
            stack.Push(246);
            stack.Push(141921);
            stack.Push(0);

            int[] stackData = new int[stack.Count];
            stack.CopyTo(stackData);

            foreach (int i in stackData)
            {
                Console.WriteLine(i);
            }
        }
    }


    class Stack<T>
    {
        List<T> stack = new List<T>();
        public int Count 
        { 
            get 
            { 
                return stack.Count;
            }
        }
        public void Push(T value)
        {
            stack.Add(value);
        }

        public T Pop()
        {
            T value = stack.Last();
            stack.Remove(stack.Last());
            return value;
        }

        public T[] CopyTo(T[] array)
        {
            T[] stackArray = stack.ToArray();
            Array.Reverse(stackArray);

            for (int i = stackArray.Length - 1; i >= 0; i--)
            {
                array[i] = stackArray[i];
            }

            return array;
        }

        public void Clear()
        {
            stack.Clear();
        }

        public T Peek()
        {
            return stack.Last();
        }
    }
}
//checked
