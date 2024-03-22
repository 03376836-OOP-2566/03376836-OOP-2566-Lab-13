# Lab 13 Exercise 4

## Add another interface

1.สร้าง console application project

```cmd
dotnet new console --name Lab13_Ex04
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/df6ef37d-ceff-4f4f-a144-a25ee561b3e2)

2.เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
Animal [] animals = new Animal[3];
animals[0] = new Dog();
animals[1] = new Bird();
animals[2] = new Fish();

foreach (var animal in animals)
{
    animal.Move();
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

```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/dfc3c36f-0333-4494-ac5f-6ee71f92e53b)
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/df10cdb9-4eea-49ae-bddb-7c5c3c401c01)

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab13_Ex04
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/1e33057b-fcb5-4b75-ab27-6510bb9594e3)
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/af6ff665-dbee-4d4f-a812-05eccf532e81)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab13_Ex04
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/6704afbe-cc32-4b18-b06c-52bc5b940e98)

7.อธิบายสิ่งที่พบในการทดลอง
