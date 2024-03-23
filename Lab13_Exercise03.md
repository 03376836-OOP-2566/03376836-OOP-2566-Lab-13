# Lab 13 Exercise 3

## Call from abstract class references

1.สร้าง console application project

```cmd
dotnet new console --name Lab13_Ex03
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/42ece336-aba5-4a0c-a162-86ce58f34812)

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
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/0941c354-ee5d-48af-9e75-52da75bf6c5d)

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/012ad924-8c5f-4739-a809-86bae7fbed23)

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/a72949c9-1c63-4f58-8408-73a350dad7df)

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab13_Ex03
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/9a4bd92b-1999-4a57-9297-3a6f87639fe5)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab13_Ex03
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/aa8ad4a5-753a-46ac-99b9-168706c5963c)

7.อธิบายสิ่งที่พบในการทดลอง

จากการทดลองนี้เป็นการสร้างโครงสร้างข้อมูลที่ใช้การสืบทอดคลาสและการใช้อินเทอร์เฟซ

การใช้งานการสืบทอดคลาส (Inheritance): โค้ดสร้างคลาส Animal เป็นคลาสหลักที่มีเมทอด Move() เป็น abstract ซึ่งจะถูกโอเวอร์ไรด์ในคลาสที่สืบทอด และมีคลาส Dog, Fish, และ Bird ที่สืบทอดมาจาก Animal และทำการโอเวอร์ไรด์เมทอด Move() ในแต่ละคลาสเพื่อกำหนดพฤติกรรมการเคลื่อนไหวของสัตว์แต่ละชนิด

การใช้งานอินเทอร์เฟซ (Interface): โค้ดมีการสร้างอินเทอร์เฟซ IMovable เพื่อกำหนดเมทอด Move() ซึ่งใช้ในการกำหนดพฤติกรรมของการเคลื่อนไหว และคลาส Animal ได้ใช้อินเทอร์เฟซนี้เป็นตัวกำหนดพฤติกรรมการเคลื่อนไหวของสัตว์ทั้งหมด

การใช้งานอาร์เรย์แบบ Polymorphism: โค้ดมีการสร้างอาร์เรย์ Animal[] animals เพื่อใส่อ็อบเจกต์ของคลาสที่สืบทอดมาจาก Animal ซึ่งได้รวมถึง Dog, Fish, และ Bird และใช้ลูป foreach เพื่อเรียกใช้เมทอด Move() ในแต่ละอ็อบเจกต์ ผลลัพธ์ที่ได้จะแตกต่างตามพฤติกรรมของเมทอด Move() ในแต่ละคลาส

เราจะเห็นการแสดงผลออกมาตามคำสั่งที่แตกต่างกันดังภาพด้านบน

ผลลัพธ์ของการทดลองนี้ช่วยให้เข้าใจการสร้างโครงสร้างข้อมูลโปรแกรมและการใช้งานการสืบทอดคลาสและอินเทอร์เฟซในภาษา C# รวมถึงการใช้งาน Polymorphism เพื่อจัดการกับอ็อบเจกต์ที่มีลักษณะและพฤติกรรมที่แตกต่างกัน


