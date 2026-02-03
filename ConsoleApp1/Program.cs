// See https://aka.ms/new-console-template for more information
enum type_of_job
{
    full_time,
    part_time
}
enum job_position
{
    admin,
    engineer,
    technician
}
struct employee
{
    public int id;
    public string name;
    public type_of_job job_type;
    public job_position position;
}
class Program
{
    static void Main(string[] args)
    {
        employee emp1;
        Console.WriteLine("enter empeloyee id");
        emp1.id = int.Parse(Console.ReadLine());
        Console.WriteLine("enter empeloyee name");
        emp1.name = Console.ReadLine();
        Console.WriteLine("enter empeloyee type of jop number");
        int type_jop = int.Parse(Console.ReadLine());
        Console.WriteLine("enter empeloyee jop position number");
        int jobb_position = int.Parse(Console.ReadLine());
        emp1.job_type = (type_of_job)type_jop;
        emp1.position = (job_position)jobb_position;
        Console.WriteLine($"Employee ID: {emp1.id}");
        Console.WriteLine($"Employee Name: {emp1.name}");
        Console.WriteLine($"Job Type: {emp1.job_type}");
        Console.WriteLine($"Position: {emp1.position}");
    }
}
