var person = new Person{FName="John",LName="Doe"};
//access record properties
System.Console.WriteLine($"Fisrt Name: {person.FName}");
System.Console.WriteLine($"Last Name: {person.LName}");

System.Console.WriteLine($"Person: {person}");
var anotherPerson = new Person{FName="John",LName="Doe"};
System.Console.WriteLine($"Is two are equal? {person.Equals(anotherPerson)}");