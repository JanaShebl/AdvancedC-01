using System.Collections;

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

            #region Q6

            // Q6: What is a generic interface? Write IRepository<T>.
            // generic interface => interface that work with different data types using type parameter

            #endregion

            #region Q7

            // Q7: What is the 'struct' constraint? Write an example.
            // struct constraint => allows only value type like int,double,struct and nullable
            //testStruct<int>(2);
            //testStruct<string>("jana");

            #endregion

            #region Q8

            // Q8: What is the 'class' constraint? Write an example.
            // 'class' constraint allows only ref. type like string,array,interfaces and classes

            //testClass<int>(2);
            //testClass<string>("jana");

            #endregion

            #region Q9

            // Q9: What is the 'new()' constraint? Write an example.
            // requires parameterless ctor (it allows you to createnew instance)

            #endregion

            #region Q10

            // Q10: What is the interface constraint? Write an example.
            // interface constraint requires that the type must implepment this interface

            #endregion

            #region Q11

            // Q11: What is the base class constraint? Write an example.
            // the generic type must be derived from this base class

            #endregion

            #region Q12

            // Q12: How do you apply multiple constraints? Write an example.
            // we must follow order when we write the multiple constraints (base class -> interface -> new())

            #endregion

            #region Q13

            // Q13: What does the 'default' keyword do in generics?
            // بترجع ال default بتاع كل داتا تايب
            // int = 0 , string = null  ...etc

            #endregion

            #region Q14

            // Q14: Write a SafeList<T> that returns default when the index is invalid.

            #endregion

            #region Q15 

            // Q15: What is covariance? Explain the 'out' keyword.
            // covariance allows the derived type to be assigned to a base class ensuring the type safety , out keyword is used with the genirec type as a covariant

            #endregion

            #region Q16

            // Q16: What is contravariance? Explain the 'in' keyword.
            // allows the base type to be assigned to a derived class , (in) is used to make the generic type contravariance

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

        public static T testStruct<T>(T a) where T:struct
        {  return a; }

        public static T testClass<T>(T a) where T : class {  return a; }

        public static T testNew<T>() where T : new()
        {
            return new T();
        }

    }

        #endregion

    }
