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
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-13/assets/144195611/67937d9a-c22c-4eb5-8b8f-9c8e2ca452e8)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab13_Ex01
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-13/assets/144195611/a6596ac9-6592-488d-a57a-4472dd721862)

7.อธิบายสิ่งที่พบในการทดลอง
- Movable เป็น Interface ที่มีเฉพาะเมทอด Move() ที่ไม่มีการระบุการทำงานภายใน
- Animal เป็นคลาส abstract ซึ่งใช้ Interface IMovable โดยมีการสืบทอดมาและต้องโอเวอร์ไรด์เมทอด Move() ตามที่กำหนดใน Interface
- Dog เป็นคลาสที่สืบทอดมาจาก Animal และมีการโอเวอร์ไรด์เมทอด Move() ตามที่กำหนดใน Animal
