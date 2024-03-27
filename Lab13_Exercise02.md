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
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-13/assets/144195611/16041b0b-d2d5-4558-9aed-a53fa92a6d35)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab13_Ex02
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-13/assets/144195611/a7c0e3e2-3d30-4e9d-b159-6eec58603c21)

7.อธิบายสิ่งที่พบในการทดลอง
- สร้างอาร์เรย์ animals ซึ่งเป็นอาร์เรย์ของอ็อบเจกต์ชนิด IMovable แต่เก็บอ็อบเจกต์ของ Dog ซึ่งเป็นคลาสที่สืบทอดมาจาก Animal ซึ่งโอเวอร์ไรด์เมทอด Move() ตามที่กำหนดใน Animal และ IMovable interface
