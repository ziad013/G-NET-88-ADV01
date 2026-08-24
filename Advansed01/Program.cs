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
            #region Question06


            //IRepository<Product> repository = new ProductRepository();

            //repository.Add(new Product(1, "Laotop", 15000));
            //repository.Add(new Product(2, "Phone", 9000));
            //repository.Add(new Product(3, "Tv", 20000));

            //repository.Delete(3);

            //repository.Get(2);


            #endregion
            #region Question07
            //What is the 'struct' constraint? Write an example.

            //T must be a value type.

            //Print(5);//valid
            //Print('A');//valid
            //Print("Hello");//Invalid
            #endregion
            #region Question08
            //What is the 'class' constraint? Write an example.

            //T must be a reference type.

            //Print(5);//Invalid
            //Print('A');//Invalid
            //Print("Hello");//valid
            //int[] items = { 1, 2, 3, 4, 5 };
            //Print(string.Join(", ", items));//Valid
            #endregion
            #region Question09
            //What is the 'new()' constraint? Write an example.

            //T must have a parameterless constructor

            //Product p = Create<Product>();

            #endregion
        }

        #region Swap
        public static void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
        #endregion
        #region FindMax
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
        #endregion
        #region Struct
        //static void Print<T>(T value) where T : struct
        //{
        //    Console.WriteLine(value);
        //}
        #endregion
        #region Class
        static void Print<T>(T value) where T : class
        {
            Console.WriteLine(value);
        }
        #endregion
        #region New()
        static T Create<T>() where T : new()
        {
            return new T();
        }
        #endregion
    }
}
