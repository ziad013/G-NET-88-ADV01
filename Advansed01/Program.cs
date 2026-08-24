namespace Advansed01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            //What is a generic class? Why use generics?

            //Class works with a type parameter,code reuseability and avoid dublicated
            #endregion
            #region Question02
            //  Write a generic class Container<T> with Add and Get methods.

            //Container<int> container = new Container<int>();
            //container.Add(5);
            //Console.WriteLine(container.get());
            #endregion
            #region Question03
            //What are multiple type parameters? Write Pair<TKey, TValue>

            //Generic class can accept more than one type

            //Pair<int, string> pair = new Pair<int, string>(5, "Ziad");
            #endregion
            #region Question04
            //What is a generic method? Write Swap<T> method.

            //uses a type parameter (T)

            //int x = 5; int y = 10;
            ////Swap(ref x, ref y);
            //Swap<int>(ref x, ref y);
            //Console.WriteLine($"X = {x} , Y = {y}");
            #endregion
            #region Question05
            // Write a generic method FindMax<T> that finds maximum value

            //int[] items = {20, 5, 6, 7, 2 };
            //Console.WriteLine(FindMax(items));
            #endregion
        }

        public static void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
        public static T FindMax<T>(T[] items) where T : IComparable
        {
            T max = items[0];
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].CompareTo(max) > 0)
                {
                    max = items[i];
                }
            }
            return max;
        }
    }
}
