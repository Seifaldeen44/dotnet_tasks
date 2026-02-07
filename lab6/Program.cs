using System;
using System.Collections;
using System.Collections.Generic;
// class Program
// {
    //^1
    // public delegate void MathOperation(double x, double y);

    // static void Sum(double x, double y) => Console.WriteLine(x + y);
    // static void Multiply(double x, double y) => System.Console.WriteLine(x * y);
    // static void Divide(double x, double y) => System.Console.WriteLine(x / y);

    // static void Main()
    // {
    //     MathOperation operation = Sum;
    //     operation += Multiply;
    //     operation += Divide;

    //     operation(10, 5);
    // }

// }

//^3

using System;
using System.Collections.Generic;

// class Program
// {
//     public delegate bool infilter(int value);

//     static infilter isEven = e => e % 2 == 0;
//     static infilter isOdd = e => e % 2 == 1;
//     static infilter isGreaterThan5 = e => e > 5;

//     public static List<int> filterArray(int[] array, infilter filter)
//     {
//         List<int> result = new List<int>();

//         foreach (var i in array)
//         {
//             if (filter(i))
//                 result.Add(i);
//         }

//         return result;
//     }

//     static void Main()
//     {
//         int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8 };

//         var evens = filterArray(nums, isEven);

//         foreach (var n in evens)
//             Console.WriteLine(n);
//     }
// }

//^ 3  &&. 4
// public class Program
// {
//     public delegate bool infilter(int value);
//     infilter filter = delegate (int value)
//     {
//         return value % 2 == 0;
//     };
// }
//^5 

// static class pogram
// {
//     public delegate bool infilter(int value);
//     public static List<int> iseven(List<int> numbers , infilter filter)
//     {
//         List<int> result = new List<int>();
//         foreach (var i in numbers)
//         {
//             if (filter(i))
//                 result.Add(i);
//         }
//         return result;
//     }
//     public static void Main()
//     {
//         infilter filter = value => value%2 == 0;
//         List<int> numbers = new List<int> {1,2,3,4,5,6,7,8};

//         var evens = iseven(numbers, filter);

//         foreach (var n in evens)
//             Console.WriteLine(n);
//     }

// }

//^6

// class person
// {
//     public string name;
//     public int age;

//     public person(string name, int age)
//     {
//         this.name = name;
//         this.age = age;
//     }
// }

// class Program
// {
//     public static void Main()
//     {
//         List<person> persons = new List<person> {new person("ahmed" , 50),new person("seif" , 56),new person("ali" , 30)};
//         persons.Sort((a,b) => b.age.CompareTo(a.age));
//         foreach(var i in persons)
//         {
//             System.Console.WriteLine($"name is {i.name} and the age is {i.age}");
//         }
//         System.Console.WriteLine("******************************");
//         persons.Sort((a,b) => a.age.CompareTo(b.age));
//         foreach(var i in persons)
//         {
//             System.Console.WriteLine($"name is {i.name} and the age is {i.age}");
//         }
//         System.Console.WriteLine("******************************");
//         persons.Sort((a,b) => b.name.CompareTo(a.name));
//         foreach(var i in persons)
//         {
//             System.Console.WriteLine($"name is {i.name} and the age is {i.age}");
//         }
//         System.Console.WriteLine("******************************");
//         persons.Sort((a,b) => a.name.CompareTo(b.name));
//         foreach(var i in persons)
//         {
//             System.Console.WriteLine($"name is {i.name} and the age is {i.age}");
//         }
//         System.Console.WriteLine("******************************");

//     }
// }

