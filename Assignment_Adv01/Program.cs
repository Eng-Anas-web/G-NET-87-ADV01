using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace Assignment_Adv01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            //Q1: What is a generic class? Why use generics?
            //A: A class that is defined using a data type that is not specified in advance, allowing it to work with different data types without rewriting the code for each type.
            //Because it provides type safety, code reusability, better performance, and cleaner code.
            #endregion

            #region Question02
            //Q2: Write a generic class Container<T> with Add and Get methods.
            //    Public static class Container<T>
            //{
            //    public T Add();
            //    public T Get();
            //}
            #endregion

            #region Question03
            //Q3:What are multiple type parameters? Write Pair<TKey, TValue>.
            //A: It is a class that uses multiple unspecified types.

            //    Public static class Pair <T1 , T2>
            //{
            ////
            //}
            #endregion

            #region Question04
            //Q4: What is a generic method? Write Swap<T> method.
            //It is a method defined with an unspecified type parameter (<T>), allowing it to work with different data types without the need to create an overload for each type separately.

            //Public static void Swap<T>(T a, T b);
            #endregion

            #region Question05
            //Q5: Write a generic method FindMax<T> that finds maximum value

            //     public static T FindMax<T>(T a, T b) where T : IComparable<T>
            //{
            //    return a.CompareTo(b) > 0 ? a : b;
            //}

            #endregion

            #region Question06
            //Q6: What is a generic interface? Write IRepository<T>. 
            //It is a contract that defines a set of methods or properties using a generic type parameter (<T>), without specifying the actual data type during the definition.

        //    public interface IRepository<T>
        //{
         
        //    IEnumerable<T> GetAll();

        //    T GetById(int id);

        //    void Add(T entity);
             
        //    void Update(T entity);
        //    void Delete(int id);
        //}
            #endregion


      } 
    } 
  }
