# Lab 13 Exercise 5

## Implement added interface

1.สร้าง console application project

```cmd
dotnet new console --name Lab13_Ex05
```

2.เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
Animal[] animals = new Animal[3];
animals[0] = new Dog();
animals[1] = new Bird();
animals[2] = new Fish();

foreach (var animal in animals)
{
    animal.Move();
    animal.Speak();
    System.Console.WriteLine("-------");
}

interface IMovable
{
    public void Move();
}
interface ISpeakable
{
    public void Speak();
}

abstract class Animal : IMovable, ISpeakable
{
    abstract public void Move();
    abstract public void Speak();
}
class Dog : Animal
{
    public override void Move()
    {
        System.Console.WriteLine("Dog move by running on the ground");
    }
    public override void Speak()
    {
        System.Console.WriteLine(@"Dog speak ""Bok Bok""");
    }
}
class Fish : Animal
{
    public override void Move()
    {
        System.Console.WriteLine("Fish move by swimming in the water");
    }
    public override void Speak()
    {
        System.Console.WriteLine("Fish can not speak");
    }
}
class Bird : Animal
{
    public override void Move()
    {
        System.Console.WriteLine("Bird move by flying in the air");
    }
    public override void Speak()
    {
        System.Console.WriteLine(@"Bird speak ""Jib Jib""");
    }
}

```

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab13_Ex05
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

<img width="562" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-13/assets/144195963/fcbdee38-409a-4c1c-b3d4-708613036f10">

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab13_Ex05
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

<img width="440" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-13/assets/144195963/968e1f1e-1b82-4807-a029-f45f3b03e584">

7.อธิบายสิ่งที่พบในการทดลอง

โปรแกรมจะแสดงผล

Dog move by running on the ground

Dog speak "Bok Bok"

Bird move by flying in the air

Bird speak "Jib Jib"

Fish move by swimming in the water

Fish can not speak
