// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


List<Person> people = new List<Person> {
    new Person { Name = "Alice", Age = 25, IsStudent = true },
    new Person { Name = "Bob", Age = 30, IsStudent = false },
    new Person { Name = "Charlie", Age = 20, IsStudent = true },
    new Person { Name = "Dave", Age = 35, IsStudent = false },
    new Person { Name = "Eve", Age = 28, IsStudent = true }
};

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public bool IsStudent { get; set; }
}



