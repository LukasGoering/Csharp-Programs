using System;

public class Person
{
    // Define properties
    public string Name { get; set; }

    public int Age { get; set; }

    // Constructor
    public Person(string name, int age) {
        Name = name;
        Age = age;
    }

    // Methods
    public void Greet() {
        Console.WriteLine("Hello " + Name + "!");
    }

    public static void Main() {

    // Create two persons
    Person lukas = new Person("Lukas", 28);
    Person sophia = new Person("Sophia", 27);
    Person benny = new Person("Benny", 6);

    lukas.Greet();
    sophia.Greet();
    benny.Greet();

    benny.Name = "Benny Ajax Ratzmatatz Rantanplan Waldi";

    benny.Greet();

    }
}