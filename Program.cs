class Mylms
{
    public string Name;
    public string Email;
    public string Password;
    public string Role;

    public Mylms(string name, string email, string password, string role)
    {
        Name = name;
        Email = email;
        Password = password;
        Role = role;
    }
    public void display_info()
    {
        Console.WriteLine($"Name: {Name}| Email: {Email}| Role: {Role}");
    }
}

class Student : Mylms
{
    public string ClassName;

    public Student(string name, string email, string password, string role, string className) : base(name, email, password, role)
    {
        ClassName = className;
    }
    public void SubmitAssignment() {
        Console.WriteLine($"Student {Name} has submitted assignment");
    }
}
class Teacher : Mylms
{
    public string Subject;

    public Teacher(string name, string email, string password, string role, string subject) : base(name, email, password, role)
    {
        Subject = subject;
    }
    public void Grade()
    {
        Console.WriteLine($"Teacher {Name} has graded assignment");
    }
}