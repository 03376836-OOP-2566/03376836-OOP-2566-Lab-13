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
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-13/assets/144195708/3f34bce9-56e4-4d10-8db1-7cc29f64600f)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab13_Ex05
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-13/assets/144195708/bc8fe9f3-5fca-44ac-aaab-d368f47214a0)

7.อธิบายสิ่งที่พบในการทดลอง
เกิด Error เพราะ Abstract Class Animal สืบทอดจาก Interface ISpeakable แต่ไม่มีการ override `Speak()` ซึ่งเป็น method ที่ต้องสืบทอดมาจาก Interface ISpeakable
 แต่ทุกคลาสใน Animal มีการเพิ่ม Implement เมทอดใน ISpeakable `Speak()`
