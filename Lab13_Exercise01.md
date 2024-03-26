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

![1](https://github.com/Siriratda/03376836-OOP-2566-Lab-13/assets/144195995/00fc13b5-e862-4eb9-9d29-dd5086edfaa2)

สามารถ Build ได้ เพราะ abstract class Animal มี Interface IMovable ด้วย Method Move() และถูก override ใน class Dog : Animal ให้แสดงผลตามที่กำหนด

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab13_Ex01
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![1 1](https://github.com/Siriratda/03376836-OOP-2566-Lab-13/assets/144195995/c97280db-f3fb-4d1f-b027-2cf7569cb52f)

7.อธิบายสิ่งที่พบในการทดลอง

สามารถ Run ได้ เพราะใช้งานInterface IMovable สามารถใช้ Polymorphism ในการประกาศตัวแปร animal_2 โดยให้มีชนิดเป็น IMovable และกำหนดให้เป็น object ของคลาส Dog

โปรแกรมจะแสดงผล

Dog move by running on the ground

Dog move by running on the ground
