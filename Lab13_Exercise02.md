# Lab 13 Exercise 2

## call from interface references

1.สร้าง console application project

```cmd
dotnet new console --name Lab13_Ex02
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/a756853e-86f3-428d-803b-8610e43da86d)

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
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/0198b4cd-1b62-4585-8186-e713dd4f9022)
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/51f2353c-487b-4c80-b41f-7701d52dcee7)

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab13_Ex02
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/0997e2d8-67a2-4c59-a299-69b51369ae98)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab13_Ex02
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/5917e649-e545-48a0-a3ee-e34539dcb511)

7.อธิบายสิ่งที่พบในการทดลอง

จากในการทดลองนี้เราสร้างโครงสร้างโปรแกรมที่ใช้หลักการโปรแกรมเชิงวัตถุ (OOP) และใช้การสืบทอดคลาสและอินเทอร์เฟซใน C#

การสืบทอดคลาส (Inheritance): โค้ดมีการสร้างคลาส Animal เป็นคลาสหลัก และคลาส Dog, Fish, และ Bird ที่สืบทอดจาก Animal โดยมีการโอเวอร์ไรด์เมทอด Move() เพื่อให้แต่ละสัตว์มีพฤติกรรมการเคลื่อนไหวที่แตกต่างกัน

การใช้อินเทอร์เฟซ (Interface): มีการสร้างอินเทอร์เฟซ IMovable เพื่อให้มีเมทอด Move() ที่ถูกบังคับให้มีการทำงานในคลาสที่ใช้อินเทอร์เฟซนี้ และใช้เมทอด Move() ในอินเทอร์เฟซเพื่อกำหนดพฤติกรรมการเคลื่อนไหวของสัตว์ทั้งหมด

การใช้งานอาร์เรย์แบบ Polymorphism: โค้ดมีการใช้อาร์เรย์ IMovable[] animals ซึ่งเก็บอ็อบเจกต์ที่เป็นตัวแทนของหลายๆ สัตว์ และใช้ลูป foreach เพื่อเรียกใช้งานเมทอด Move() ในแต่ละอ็อบเจกต์ ซึ่งเมทอดที่ถูกเรียกใช้จะมีการเรียกใช้งานเมทอดที่ถูกโอเวอร์ไรด์ในคลาสของแต่ละสัตว์

การใช้งานคำสำคัญ override, sealed, และ new: โค้ดมีการใช้งานคำสำคัญ override เพื่อโอเวอร์ไรด์เมทอดในคลาสที่สืบทอด รวมถึงการใช้งาน sealed เพื่อปิดการโอเวอร์ไรด์เมทอดในคลาส Derived_1 และการใช้งาน new เพื่อเรียกใช้งานเมทอดใหม่ในคลาส Derived_2 ที่ไม่ได้สืบทอดมาจาก Derived_1

การใช้งานและการแปลงชนิด (Type Casting): ในบางส่วนของโค้ดมีการแปลงชนิดของอ็อบเจกต์ เช่น Dog ถูกแปลงให้เป็นชนิด IMovable เพื่อใช้ในการจัดการข้อมูลที่มีความยืดหยุ่นและความสามารถในการเปลี่ยนแปลงระหว่างอ็อบเจกต์

การใช้งานและการสร้างอ็อบเจกต์ (Object Creation and Usage): โค้ดมีการสร้างอ็อบเจกต์ของคลาสและใช้งานเมทอดที่ถูกโอเวอร์ไรด์ในแต่ละคลาส

ผลลัพธ์ของการทดลองนี้ช่วยให้เราเข้าใจถึงหลักการใช้งานการสืบทอดคลาสและอินเทอร์เฟซในการพัฒนาโปรแกรมด้วย C# และเข้าใจถึงความสำคัญของพฤติกรรม Polymorphism และการใช้งานและการสร้างอ็อบเจกต์ใน OOP อย่างถูกต้องและเหมาะสม

ดังภาพด้านบน
