
// //^1
class Person
{
    public string Name { get; set; }="Unknown";
    public int Age { get; set; }=0;
    public String city {get; set;}="Unknown";
}

// class Program
// {
//     static void Main(string[] args)
//     {
//         Person person = new Person
//         {
//             Name = "Alice",
//             Age = 30,
//             city = "New York"
//         };
//         Person person2 = new Person();


//         Console.WriteLine($"Name: {person.Name}, Age: {person.Age}, City: {person.city}");
//         Console.WriteLine($"Name: {person2.Name}, Age: {person2.Age}, City: {person2.city}");
//     }
// }

//^2

// class Rectangle
// {
//     private static int counter;
//     static Rectangle()
//     {
//         counter=0;
//     }
//     public Rectangle()
//     {
//         id = ++counter;
//     }
//     public double Length { get; set; }
//     public double Width { get; set; }
//     public string Color { get; set; }="Red";
//     public string unit { get; set; }="cm";
//     public int id{get;}
//     public double area => Length * Width;
// }

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Rectangle rect1 = new Rectangle { Length = 5, Width = 10 };
//         Rectangle rect2 = new Rectangle { Length = 3, Width = 4, Color="Blue" };

//         Console.WriteLine($"Rectangle {rect1.id}: Length={rect1.Length}{rect1.unit}, Width={rect1.Width}{rect1.unit}, Color={rect1.Color}, Area={rect1.area}{rect1.unit}²");
//         Console.WriteLine($"Rectangle {rect2.id}: Length={rect2.Length}{rect2.unit}, Width={rect2.Width}{rect2.unit}, Color={rect2.Color}, Area={rect2.area}{rect2.unit}²");
//     }
// }

//^3

// class Gradebook
// {
//     private int [] grades;
//     public Gradebook(int size)
//     {
//         grades = new int[size];
//     }

//     public int Size
//     {
//         get
//         {
//             return grades.Length;
//         }
//     }

//     public int this[int index]
//     {
//         get
//         {
//             return grades[index];
//         }
//         set
//         {
//             grades[index] = value;
//         }
//     }

// }

// public class program
// {
//     public static void Main()
//     {
//         Gradebook b1 = new Gradebook(3);
//         b1[0] = 20;
//         b1[1] = 30;
//         b1[2] = 40;

//         for(int i = 0; i<b1.Size ; i++)
//         {
//             System.Console.WriteLine(b1[i]);
//         }
//     }
// }

//^4

// public class Collections
// {

//     int index;
//     string[]keys;
//     string[]values;
//     public Collections(int size)
//     {
//         index = 0;
//         keys = new string[size];
//         values = new string[size];
//     }
//     string findValue(string key)
//     {
//         for(int i = 0 ; i< keys.Length;i++ )
//         {
//             if(keys[i] == key)
//             {
//                 return values[i];
//             }
//         }
//         return "there is no value of the key you have sent";
//     }

//     void putAtKey(string key, string value)
//     {
//         for(int i = 0 ; i< keys.Length;i++ )
//         {
//             if(keys[i] == key)
//             {
//                 values[i] = value;
//                 return;
//             }
//         }

//             if(index < keys.Length)
//             {
//                 keys[index] = key;
//                 values[index] = value;
//                 index++;
//             }

//     }

//     public string this[string key]
//     {
//         get
//         {
//             return findValue(key);
//         }
//         set
//         {
//             putAtKey(key,value);
//         }
//     }
// }

// public class program
// {
//     public static void Main()
//     {
//         Collections c1 = new Collections(5);
//         c1["a1"] = "level a1 in english";
//         c1["a1"] = "level a1 in frensh";
//         c1["a12"] = "level a1 in english";


//         System.Console.WriteLine(c1["a1"]);
//         System.Console.WriteLine(c1["a12"]);
//     }
// }

//^5


//  using System.Collections;
// public class program
// {
//     public static void Main()
//     {
//         ArrayList cart = new ArrayList();
//         cart.Add(42);
//         cart.Add("hello");
//         cart.Add(3.14);
//         cart.Add(DateTime.Now);
//         foreach(var i in cart)
//         {
//             System.Console.WriteLine(i);
//         }

//         cart.Remove(42);
//         System.Console.WriteLine("*******************");
//         foreach(var i in cart)
//         {
//             System.Console.WriteLine(i);
//         }
//         System.Console.WriteLine(cart.Contains(3.14));
//     }
// }


//^6
//! please remove the comment of the class person at the first line to make this main fuction works
// public class program
// {
//     public static void Main()
//     {
//         var persons = new List<Person>
//         {
//             new Person { Name = "ahmed", Age = 30, city = "Ngsg" },
//             new Person { Name = "seif", Age = 25, city = "Lsss" },
//             new Person { Name = "hoda", Age = 35, city = "hhh" }
//         };

//         Person found = persons.Find(s => s.Age > 30);
//         System.Console.WriteLine(found.Name);

//         persons.Sort((a,b) => b.Age.CompareTo(a.Age));
        
//     }
// }

//^7

class calculator
{
    public static int divide(int x, int y)
    {
        try
        {
            return x/y;
        }
        catch(DivideByZeroException e)
        {
            System.Console.WriteLine(e);
            return -1;
        }
        catch (FormatException e)
        {
            System.Console.WriteLine(e);
            return -1;
        }

        catch (Exception e)
        {
            System.Console.WriteLine(e);
            return -1;
        }
    }
}

public class program
{
    public static void Main()
    {
        
        
        System.Console.WriteLine(calculator.divide(5,0));
    }
}

//^8

//