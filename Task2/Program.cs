


List<Person> people = new List<Person> {
    new Person { Name = "Alice", Age = 25, IsStudent = true },
    new Person { Name = "Bob", Age = 30, IsStudent = false },
    new Person { Name = "Charlie", Age = 20, IsStudent = true },
    new Person { Name = "Dave", Age = 35, IsStudent = false },
    new Person { Name = "Eve", Age = 28, IsStudent = true }
};
foreach (var pers in people.Where(p => p.IsStudent == true))
{
    
}
//{
//    //var avarage = people
//    if ( Person.Age<= 25)
//    {
//        System.Console.WriteLine(Person);
//    }
//}



double student = people.Where(p => p.IsStudent == true).Average(people => people.Age);

Console.WriteLine(student);
    

//double sum =0;
//foreach (var age2 in people.Age)
//{
//    sum +=age2;
//}
//return sum / people.Length;