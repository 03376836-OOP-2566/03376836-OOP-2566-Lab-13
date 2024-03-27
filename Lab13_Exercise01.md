# Lab 13 Exercise 1

## Interface

1.สร้าง console application project

```cmd
dotnet new console --name Lab13_Ex01
```

2.เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
var animal_1 = new Dog();
animal_1.Move();

IMovable animal_2 = new Dog();
animal_2.Move();

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
dotnet build  Lab13_Ex01
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-13/assets/144195708/4ebc3ff8-d603-43d6-aa6c-9cfa7324a3e7)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab13_Ex01
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-13/assets/144195708/6d683bb6-a5ad-401c-a944-3538f26615ef)

7.อธิบายสิ่งที่พบในการทดลอง

แสดงผล

Dog move by running on the ground

Dog move by running on the ground
