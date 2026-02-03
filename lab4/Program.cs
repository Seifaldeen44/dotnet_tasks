// See https://aka.ms/new-console-template for more information
//^1

// class Date
// {
//     int year;
//     int month;
//     int day;
//         public Date(int y) : this(y, 1, 1)
//     {
//     }

//     public Date(int y, int m) : this(y, m, 1)
//     {
//     }

//     public Date(int y, int m, int d)
//     {
//         year = y;
//         month = m;
//         day = d;
//     }

// }

//^2


// StaticCounter c1 = new StaticCounter();
// StaticCounter c2 = new StaticCounter();
// StaticCounter c3 = new StaticCounter();

// Console.WriteLine("the number of objects are: "+StaticCounter.getCounter());
// Console.WriteLine("the id of the object: "+c3.instanceId());

// class StaticCounter
// {
//     int id;
//     static int counter;
//     static StaticCounter()
//     {
//         counter = 0;
//     }
//     public StaticCounter()
//     {
//         counter++;
//         this.id = counter;
//     }
//     public static int getCounter()
//     {
//         return counter;
//     }

//     public int instanceId()
//     {
//         return this.id;
//     }
// }

//^3



// class Employee
// {
//     int id;
//     String name;
//     float baseSalary;

//     public Employee(int id, String name, float salary)
//     {
//         this.id = id;
//         this.name = name;
//         this.baseSalary = salary;
//     }

//     public int Id
//     {
//         set{this.id = value;}
//         get{return id;}
//     }

//     public String Name
//     {
//         set{this .name = value;}
//         get{return this.name;}
//     }

//     public float BaseSalary
//     {
//         set{this.baseSalary = value;}
//         get{return this.baseSalary;}
//     }

// }

// class Manager : Employee
// {
//     float bonus;
//     int teamSize;

//     public Manager(int id, String name, int salary, float bonus, int teamSize)
//         :base (id,name,salary)
//     {
//         this.bonus = bonus;
//         this.teamSize = teamSize;
//     }

//     public float Bonus
//     {
//         set{this.bonus = value;}
//         get{return this.bonus;}
//     }

//     public int TeamSize
//     {
//         set{this.teamSize = value;}
//         get{return this.teamSize;}
//     }
// }

// class Developer : Employee
// {
//     String language;
//     String[] projects;

//     public Developer(int id, String name, float salary, String language, String[] projects)
//         : base(id, name, salary)
//     {
//         this.language = language;
//         this.projects = projects;
//     }

//     public String Language
//     {
//         set { this.language = value; }
//         get { return this.language; }
//     }

//     public String[] Projects
//     {
//         set { this.projects = value; }
//         get { return this.projects; }
//     }
// }

// class Intern : Employee
// {
//     String university;
//     int duration;

//     public Intern(int id, String name, float salary, String university, int duration)
//         : base(id, name, salary)
//     {
//         this.university = university;
//         this.duration = duration;
//     }

//     public String University
//     {
//         set { this.university = value; }
//         get { return this.university; }
//     }

//     public int Duration
//     {
//         set { this.duration = value; }
//         get { return this.duration; }
//     }
// }

///////////////////////////////////////////////////

// //^4

// Shape c = new Circle(5);
// Shape r = new Rectangle(4, 6);
// Shape t = new Triangle(3, 7);

// Console.WriteLine("Area of Circle: " + c.area());
// Console.WriteLine("Area of Rectangle: " + r.area());
// Console.WriteLine("Area of Triangle: " + t.area());

// class Shape{
//     public virtual double area(){
//         return 0;
//     }
// }
// class Circle : Shape{
//     double radius;
//     public Circle(double r){
//         radius = r;
//     }
//     public override double area(){
//         return Math.PI * radius * radius;
//     }
// }
// class Rectangle : Shape{
//     double length;
//     double width;
//     public Rectangle(double l, double w){
//         length = l;
//         width = w;
//     }
//     public override double area(){
//         return length * width;
//     }
// }
// class Triangle : Shape{
//     double b;
//     double h;
//     public Triangle(double baseLength, double height){
//         b = baseLength;
//         h = height; 
//     }
//     public override double area(){
//         return 0.5 * b * h;
//     }
// }

//^5



// abstract class Animal
// {
//     public abstract void MakeSound();
//     public abstract void Move();

//     public void Sleep()
//     {
//         Console.WriteLine("Sleeping...");
//     }
// }

// class Dog : Animal
// {
//     public override void MakeSound()
//     {
//         Console.WriteLine("Woof! Woof!");
//     }

//     public override void Move()
//     {
//         Console.WriteLine("Running on four legs!");
//     }
// }

// class Cat : Animal
// {
//     public override void MakeSound()
//     {
//         Console.WriteLine("Meow!");
//     }

//     public override void Move()
//     {
//         Console.WriteLine("Walking quietly!");
//     }
// }

// class Bird : Animal
// {
//     public override void MakeSound()
//     {
//         Console.WriteLine("Tweet!");
//     }

//     public override void Move()
//     {
//         Console.WriteLine("Flying in the sky!");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Animal[] animals =
//         {
//             new Dog(),
//             new Cat(),
//             new Bird()
//         };

//         foreach (Animal a in animals)
//         {
//             a.MakeSound();
//             a.Move();
//             a.Sleep();
//         }
//     }
// }

//^6


// interface IMovable
// {
//     void Move();
//     void Stop();
//     int GetSpeed();
// }

// interface IChargeable
// {
//     void Charge();
//     int GetBatteryLevel();
// }

// class Car : IMovable
// {
//     int speed;

//     public void Move()
//     {
//         speed = 60;
//     }

//     public void Stop()
//     {
//         speed = 0;
//     }

//     public int GetSpeed()
//     {
//         return speed;
//     }
// }

// class Robot : IMovable, IChargeable
// {
//     int speed;
//     int batteryLevel;

//     public void Move()
//     {
//         if (batteryLevel > 0)
//         {
//             speed = 10;
//             batteryLevel -= 10;
//         }
//     }

//     public void Stop()
//     {
//         speed = 0;
//     }

//     public int GetSpeed()
//     {
//         return speed;
//     }

//     public void Charge()
//     {
//         batteryLevel = 100;
//     }

//     public int GetBatteryLevel()
//     {
//         return batteryLevel;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         IMovable car = new Car();
//         car.Move();
//         Console.WriteLine(car.GetSpeed());
//         car.Stop();

//         Robot robot = new Robot();
//         robot.Charge();
//         robot.Move();
//         Console.WriteLine(robot.GetSpeed());
//         Console.WriteLine(robot.GetBatteryLevel());
//     }
// }

//^7


// class Student
// {
//     int age;
//     string name;
//     int id;

//     public int Id
//     {
//         get { return id; }
//     }

//     public string Name
//     {
//         get { return name; }
//         set
//         {
//             if (!string.IsNullOrEmpty(value))
//                 name = value;
//         }
//     }

//     public int Age
//     {
//         get { return age; }
//         set
//         {
//             if (value >= 16 && value <= 100)
//                 age = value;
//         }
//     }

//     public Student(int id)
//     {
//         this.id = id;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Student s = new Student(1);
//         s.Name = "Ahmed";
//         s.Age = 20;
//         Console.WriteLine(s.Name);
//         Console.WriteLine(s.Age);

//         s.Age = 10;
//         Console.WriteLine(s.Age);
//     }
// }