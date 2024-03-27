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
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-13/assets/144195611/fd9ff8e1-8de1-47e0-8e85-1dc2d538ee1e)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab13_Ex04
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-13/assets/144195611/bf9e2e5b-5092-4114-aa6d-e6352cf027c5)

## แก้ไขการทำงาน 
- ในส่วนของ
```
  abstract class Animal : IMovable, ISpeakable
{
    abstract public void Move();
    public virtual void Speak()
    {
        // 
    }
}
```
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-13/assets/144195611/67dc38be-82db-440a-82fd-b6e0002e7deb)

7.อธิบายสิ่งที่พบในการทดลอง
- ข้อผิดพลาดเนื่องจาก abstract method Speak() ในคลาส Animal ไม่ได้ถูก override ในคลาส Dog, Fish, และ Bird ดังนั้นจึงต้องเพิ่มการ override สำหรับ abstract method Speak() ในคลาสที่สืบทอดมาจาก Animal ด้วย
- เพิ่ม animal.Speak(); ในลูป foreach เพื่อเรียกใช้เมทอด Speak() ของแต่ละสัตว์ได้ทั้งหมดโดยไม่ว่าจะเป็น Dog, Bird, หรือ Fish และในคลาส Animal เพิ่ม virtual method Speak() ซึ่งคลาสที่สืบทอดมาสามารถ override เพื่อให้มีการพิเศษระหว่างการพูดของแต่ละสัตว์ได้
