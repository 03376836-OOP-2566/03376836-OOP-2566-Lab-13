using System;

interface IMovable
{
    void Move();
}

interface ISpeakable
{
    void Speak();
}

abstract class Animal : IMovable, ISpeakable
{
    public abstract void Move();
    public abstract void Speak();
}

class Dog : Animal
{
    public override void Move()
    {
        Console.WriteLine("Dog move by running on the ground");
    }

    public override void Speak()
    {
        Console.WriteLine("Dog says: Woof!");
    }
}

class Fish : Animal
{
    public override void Move()
    {
        Console.WriteLine("Fish move by swimming in the water");
    }

    public override void Speak()
    {
        Console.WriteLine("Fish cannot speak");
    }
}

class Bird : Animal
{
    public override void Move()
    {
        Console.WriteLine("Bird move by flying in the air");
    }

    public override void Speak()
    {
        Console.WriteLine("Bird says: Chirp!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal[] animals = new Animal[3];
        animals[0] = new Dog();
        animals[1] = new Bird();
        animals[2] = new Fish();

        foreach (var animal in animals)
        {
            animal.Move();
            animal.Speak();
            Console.WriteLine();
        }
    }
}
