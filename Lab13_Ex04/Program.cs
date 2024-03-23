// See https://aka.ms/new-console-template for more information
interface IMovable
{
    public void Move();
}

abstract class Animal : IMovable
{
    public abstract void Move(); // Abstract method for movement behavior
}

class Dog : Animal
{
    public override void Move()
    {
        System.Console.WriteLine("Dog move by running on the ground");
    }
}

class Fish : Animal
{
    public override void Move()
    {
        System.Console.WriteLine("Fish move by swimming in the water");
    }
}

class Bird : Animal
{
    public override void Move()
    {
        System.Console.WriteLine("Bird move by flying in the air");
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
            animal.Move(); // Call the appropriate Move() implementation
        }
    }
}
