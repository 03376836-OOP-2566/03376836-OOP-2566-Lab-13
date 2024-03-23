# Lab 13 Exercise 3

## Call from abstract class references

1.สร้าง console application project

```cmd
dotnet new console --name Lab13_Ex03
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
dotnet build  Lab13_Ex03
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/VisawaPRO/03376836-OOP-2566-Lab-13/assets/144195555/f79f3c8b-7998-41f7-b64d-7731bb2289a8)
### สามารถ Build ได้ เพราะเรียกใช้จาก abstract class Animal : IMovable ที่สืบทอดมาจาก interface IMovable Method Move()
5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab13_Ex03
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/VisawaPRO/03376836-OOP-2566-Lab-13/assets/144195555/6dab2c94-5ea9-4fa1-acb5-bd6a10314139)
### สามารถ Run ได้ การอ้างอิงถึงอ็อบเจกต์ของคลาสที่เป็น abstract class ในรูปแบบของตัวแปรที่ประกาศโดยใช้ประเภทของ abstract class นั้น ๆ
7.อธิบายสิ่งที่พบในการทดลอง
### โปรแกรมจะแสดงผล
### Dog move by running on the ground
### Bird move by flying in the air
### Fish move by swimming in the water
