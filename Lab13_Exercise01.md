# Lab 13 Exercise 1

## Interface

1.สร้าง console application project

```cmd
dotnet new console --name Lab13_Ex01
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/99082e85-1e63-4998-bf7a-57a189384d00)

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
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/b5ba2b6a-efb3-40b1-9d04-9362319be7b0)

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab13_Ex01
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/39f2a9f5-1dd2-43f7-9254-066bd48385b5)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab13_Ex01
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/4df3c9c6-ffdf-4ed3-9d25-c07ead4c3f54)

7.อธิบายสิ่งที่พบในการทดลอง
