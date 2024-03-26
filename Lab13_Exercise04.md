# Lab 13 Exercise 4

## Add another interface

1.สร้าง console application project

```cmd
dotnet new console --name Lab13_Ex04
```

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

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab13_Ex04
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

![4](https://github.com/Siriratda/03376836-OOP-2566-Lab-13/assets/144195995/48b15778-e9a9-4242-a954-22146cf860fd)

ไม่สามารถ Build ได้ เพราะ อย่างแรก ISpeakable.Speak() ไม่ได้เพิ่มถูกประกาศลงใน abstract class Animal แก้จากประกาศ abstract public void Speak();เพื่อให้ animal.Speack(); แสดงผลตามที่กำหนดของ Array และ เพิ่ม Speack () override ไปยัง class Dog, Fish, Bird แล้วกำหนคำการแสดงผล

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab13_Ex04
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![4 1](https://github.com/Siriratda/03376836-OOP-2566-Lab-13/assets/144195995/445863ab-1475-4616-8215-bec4e9fcb01a)

7.อธิบายสิ่งที่พบในการทดลอง

ไม่สามารถ Run ได้ เพราะ อย่างแรก ISpeakable.Speak() ไม่ได้เพิ่มถูกประกาศลงใน abstract class Animal แก้จากประกาศ abstract public void Speak();เพื่อให้ animal.Speack(); แสดงผลตามที่กำหนดของ Array และ เพิ่ม Speack () override ไปยัง class Dog, Fish, Bird แล้วกำหนคำการแสดงผล

โปรแกรมจะแสดงผล

Dog move by running on the ground

Bird move by flying in the air

Fish move by swimming in the water
