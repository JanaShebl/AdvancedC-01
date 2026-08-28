namespace AdvancedC_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            // Q1: What is a generic class? Why use generics?
            // generic class => allows you to write the class without declare the type , type is speccified when creating an object
            // why? generics provide better performance , can be reused , provide clean code and type dafety(no boxing & unboxing)

            #endregion

            #region Q2

            // Q2: Write a generic class Container<T> with Add and Get methods.

            #endregion

            #region Q3

            // Q3:What are multiple type parameters? Write Pair<TKey,TValue >.
            // multiple type parameters used in generics when class , interface and method needs more than data type
            //Pair<int, string> pair = new Pair<int, string>(1,"Jana");

            #endregion

            #region Q4

            // Q4: What is a generic method? Write Swap<T> method.
            // generic method => method that the developer doesn't know the type of its parameter or its return type (method that can work with different data types)

            #endregion

            #region Q5

            // Q5: Write a generic method FindMax<T> that finds maximum value
            //int a = 10;
            //int b = 2;
            //Console.WriteLine(FindMax(a, b));

            #endregion
        }

        #region Methods
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        } 

        public static T FindMax<T>(T a, T b) where T:IComparable
        {
            if (a.CompareTo(b)>0) { return a; }
            return b;
        }


        #endregion

    }
}
