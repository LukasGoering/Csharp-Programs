using System;

public interface IAnimal
{
    void Eat();
}

public class Program
{
    public static void Main(string[] args)
    {
        List<Animal> animals = new List<Animal>();
        animals.Add(new Dog());
        animals.Add(new Cat());

        foreach (Animal animal in animals)
        {
            animal.MakeSound();
            animal.Eat();
        }
    }
}

public class Animal
{
    public virtual void MakeSound()
        {
            Console.WriteLine("Some generic animal sound.");
        }

    public virtual void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Woef!");
    }

    public override void Eat()
    {
        Console.WriteLine("Eats dog stuff");
    }

}

public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow!");
    }

    public override void Eat()
    {
        Console.WriteLine("Eat cat stuff");
    }
}