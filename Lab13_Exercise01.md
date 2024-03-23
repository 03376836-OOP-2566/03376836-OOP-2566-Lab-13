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

จากการทดลองนี้เป็นการสร้างอ็อบเจกต์ animal_1 และ animal_2 จากคลาส Dog และเรียกใช้งานเมทอด Move() บนทั้งสองอ็อบเจกต์ เพื่อทดสอบการใช้งานการสืบทอดคลาสและการใช้งานอินเทอร์เฟซใน C#

เริ่มต้นที่การสร้างอ็อบเจกต์ animal_1 จากคลาส Dog และเรียกใช้งานเมทอด Move() บน animal_1 โดยตรง ซึ่งในกรณีนี้ Move() เป็นเมทอดที่ถูกสืบทอดมาจากคลาส Dog และทำการพิมพ์ข้อความ "Dog move by running on the ground" ออกทางหน้าจอ

จากนั้นเราสร้างอ็อบเจกต์ animal_2 จากคลาส Dog แต่กำหนดให้เป็นอ็อบเจกต์ของอินเทอร์เฟซ IMovable ซึ่งเป็นอินเทอร์เฟซที่มีเมทอด Move() เพียงเดียว ซึ่งเมื่อเรียกใช้งานเมทอด Move() บน animal_2 ก็จะทำการเรียกใช้งานเมทอด Move() ที่ถูกโอเวอร์ไรด์ในคลาส Dog เช่นกัน
อินเทอร์เฟซ IMovable ถูกนำมาใช้ในการกำหนดและบังคับให้คลาส Dog มีเมทอด Move() ตามที่กำหนดไว้ในอินเทอร์เฟซ ซึ่งช่วยให้มั่นใจได้ว่าทุกคลาสที่สืบทอดจาก Animal จะต้องมีเมทอด Move() อย่างที่กำหนดในอินเทอร์เฟซ นอกจากนี้ การใช้อินเทอร์เฟซยังช่วยในการลดความผูกพันและเพิ่มความยืดหยุ่นในการออกแบบระบบของโปรแกรมได้ด้วย

ดังแสดงผลลัพธ์ดังด้านบน
