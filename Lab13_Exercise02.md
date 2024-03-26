# Lab 13 Exercise 2

## call from interface references

1.สร้าง console application project

```cmd
dotnet new console --name Lab13_Ex02
```

2.เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
IMovable [] animals = new Animal[3];
animals[0] = new Dog();
animals[1] = new Dog();
animals[2] = new Dog();

foreach (var animal in animals)
{
    animal.Move();
}

interface IMovable
{
    public void Move();
}

abstract class Animal : IMovable
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

```

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab13_Ex02
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

<img width="547" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-13/assets/144195963/31996f5f-a285-4284-90cb-5ffa1c0a5e7d">

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab13_Ex02
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

<img width="482" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-13/assets/144195963/7ddf39da-3d29-4abc-94f4-9032867c9702">

7.อธิบายสิ่งที่พบในการทดลอง

Dog move by running on the ground
Dog move by running on the ground
Dog move by running on the ground
