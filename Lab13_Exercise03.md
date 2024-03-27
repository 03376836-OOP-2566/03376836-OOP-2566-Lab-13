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
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-13/assets/144195611/05c6e5b5-9b80-4e25-bd2c-8756c05de86e)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab13_Ex03
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-13/assets/144195611/ea94c3b9-110f-4721-997a-cc7e9c671134)

7.อธิบายสิ่งที่พบในการทดลอง
- สร้างอาร์เรย์ animals ซึ่งเป็นอาร์เรย์ของอ็อบเจกต์ชนิด Animal และเก็บอ็อบเจกต์ของคลาสที่สืบทอดมาจาก Animal เช่น Dog, Bird, และ Fish
- ในการวนลูป foreach เมื่อเข้าถึงแต่ละอ็อบเจกต์ในอาร์เรย์ animals จะเป็นชนิดของ Animal ซึ่งเป็นคลาสที่สืบทอดมาจาก IMovable interface และโอเวอร์ไรด์เมทอด Move() ตามที่กำหนดในแต่ละคลาสที่สืบทอด
