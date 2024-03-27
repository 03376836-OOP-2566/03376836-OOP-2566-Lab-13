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
# แก้ไข
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-13/assets/144195708/d9bb98ed-7d33-4079-901c-64b7b15a4d67)
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-13/assets/144195708/1bda8019-a187-43d7-951b-e7bec322a69b)


4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-13/assets/144195708/b73b839f-9239-44c9-b6aa-758ebc29d7fd)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab13_Ex04
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-13/assets/144195708/6d238f73-3257-4eec-833b-deb7add0d9d9)

7.อธิบายสิ่งที่พบในการทดลอง
แสดงผล

Dog move by running on the ground

Bird move by flying in the air

Fish move by swimming in the water
