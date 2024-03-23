# Lab 13 Exercise 4

## Add another interface

1.สร้าง console application project

```cmd
dotnet new console --name Lab13_Ex04
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/df6ef37d-ceff-4f4f-a144-a25ee561b3e2)

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
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/dfc3c36f-0333-4494-ac5f-6ee71f92e53b)

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/df10cdb9-4eea-49ae-bddb-7c5c3c401c01)

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab13_Ex04
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/1e33057b-fcb5-4b75-ab27-6510bb9594e3)

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/af6ff665-dbee-4d4f-a812-05eccf532e81)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab13_Ex04
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/6704afbe-cc32-4b18-b06c-52bc5b940e98)

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง


![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/bcab9ba4-9f9c-4770-bb59-29e45ab51a71)

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/1f36d652-353c-4d79-b602-659289e18718)


![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/92bfe9f8-8f90-49ff-9585-64a7598c9b8f)

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/1e0101f6-0a15-4e4e-a75b-5992a804c75d)


![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/17f3f8b8-bd72-409e-92b6-5bc454c7e954)

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/d1783bfa-20f5-4670-9de4-f1c3eb8a153c)


7.อธิบายสิ่งที่พบในการทดลอง

จากโค้ดเดิมมีข้อผิลพลาด เนื่องจากไม่ได้ให้การสืบทอด ISpeakable ในคลาส Animal และยังไม่มีการสร้างเมทอด Speak() ในคลาส Animal ซึ่งทำให้ไม่สามารถเรียกใช้เมทอด Speak() ได้ในลูป foreach โดยตรง นอกจากนี้ยังต้องแก้ไขประเภทของ animals เป็น Animal[] เนื่องจากการสร้างอาร์เรย์ด้วยประเภท ISpeakable[] ไม่สามารถรับคลาสที่ไม่ได้สืบทอดจาก ISpeakable ได้ และยังไม่สามารถเรียกใช้ Speak() ได้แม้ว่าทุกคลาสในอาร์เรย์จะมีเมทอด Speak() ด้วยกัน เมื่อทำการแก้ไขจะได้ผลลัพธ์ดังนี้
จากการทดลอง เรามีโปรแกรมที่สร้างอาร์เรย์ของ Animal ที่มีขนาด 3 สมาชิก และกำหนดให้สมาชิกแต่ละตัวของอาร์เรย์เป็น instances ของคลาส Dog, Bird, และ Fish ตามลำดับ เพื่อทดสอบการเรียกใช้เมทอด Move() และ Speak() ในแต่ละสัตว์ โดยอินสแตนซ์ของ Animal สามารถเรียกใช้เมทอด Move() และ Speak() ได้เนื่องจาก Animal ได้สืบทอด IMovable และ ISpeakable ซึ่งกำหนดเมทอด Move() และ Speak() ตามลำดับให้กับทุกคลาสที่สืบทอดจาก Animal โดย Dog, Bird, และ Fish ได้โอเวอร์ไรด์เมทอดเหล่านี้ตามลำดับเพื่อนำมาใช้งานตามลำดับของแต่ละสัตว์และแสดงผลการทำงานด้วยคำสั่ง Console.WriteLine() ในแต่ละคลาสลูกของ Animal เมื่อเรียกใช้เมทอด Move() และ Speak() ที่ได้รับการโอเวอร์ไรด์ ลูป foreach ถูกใช้เพื่อวนลูปผ่านทุกสัตว์ในอาร์เรย์และเรียกใช้เมทอด Move() และ Speak() ของแต่ละสัตว์เพื่อแสดงผลลัพธ์ที่ความหมายและพฤติกรรมของแต่ละสัตว์ในการเคลื่อนที่และการพูดออกมาทางหน้าจอหนึ่งรอบการทำงาน โดยใช้ Console.WriteLine() เพื่อเพิ่มบรรทัดว่างระหว่างการแสดงผลของสัตว์แต่ละตัว เพื่อความชัดเจนและอ่านง่ายของผลลัพธ์ที่แสดงออกมาในหน้าจอ
