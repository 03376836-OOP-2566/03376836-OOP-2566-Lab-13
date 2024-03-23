# Lab 13 Exercise 5

## Implement added interface

1.สร้าง console application project

```cmd
dotnet new console --name Lab13_Ex05
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/4ef3c405-2b48-47fa-823f-40d697685fbc)

2.เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
Animal[] animals = new Animal[3];
animals[0] = new Dog();
animals[1] = new Bird();
animals[2] = new Fish();

foreach (var animal in animals)
{
    animal.Move();
    animal.Speak();
    System.Console.WriteLine("-------");
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
    abstract public void Speak();
}
class Dog : Animal
{
    public override void Move()
    {
        System.Console.WriteLine("Dog move by running on the ground");
    }
    public override void Speak()
    {
        System.Console.WriteLine(@"Dog speak ""Bok Bok""");
    }
}
class Fish : Animal
{
    public override void Move()
    {
        System.Console.WriteLine("Fish move by swimming in the water");
    }
    public override void Speak()
    {
        System.Console.WriteLine("Fish can not speak");
    }
}
class Bird : Animal
{
    public override void Move()
    {
        System.Console.WriteLine("Bird move by flying in the air");
    }
    public override void Speak()
    {
        System.Console.WriteLine(@"Bird speak ""Jib Jib""");
    }
}

```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/d01149db-da30-4e09-ab94-6baddc56454d)

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/1d4bf68f-9ece-4415-a973-420d55630db8)
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/dc1a1bbb-6805-40dd-ab3e-1c5711f8f724)

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab13_Ex05
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/32eb37b5-fcd2-4dc6-b2fb-13361934cf09)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab13_Ex05
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/1dfc21ee-3de9-4fc7-a0f9-6f61492267f3)

7.อธิบายสิ่งที่พบในการทดลอง

จากการทดลองนี้เรามีโค้ดที่สร้างอาร์เรย์ของ Animal ที่มีขนาด 3 สมาชิก และกำหนดให้สมาชิกแต่ละตัวของอาร์เรย์เป็น instances ของคลาส Dog, Bird, และ Fish ตามลำดับ เพื่อทดสอบการเรียกใช้เมทอด Move() และ Speak() ในแต่ละสัตว์ โดย Animal สืบทอด IMovable และ ISpeakable และจำเป็นต้องโอเวอร์ไรด์เมทอด Move() และ Speak() ตามลำดับให้กับทุกคลาสที่สืบทอดจาก Animal

ในแต่ละคลาสลูกของ Animal เราได้โอเวอร์ไรด์เมทอด Move() และ Speak() ตามลำดับเพื่อนำมาใช้งานตามลำดับของแต่ละสัตว์ โดยใน Dog เราแสดงการเคลื่อนที่ของหมาและเสียงพูดของหมา ใน Fish เราแสดงการเคลื่อนที่ของปลาและบอกว่าปลาไม่สามารถพูดได้ และใน Bird เราแสดงการเคลื่อนที่ของนกและเสียงพูดของนก

ในการใช้ลูป foreach เราได้ใช้เมทอด Move() และ Speak() ของแต่ละสัตว์ในอาร์เรย์เพื่อแสดงผลลัพธ์ของการเคลื่อนที่และการพูดของแต่ละสัตว์ และใช้ System.Console.WriteLine("-------"); เพื่อแสดงเส้นคั่นระหว่างการแสดงผลของแต่ละสัตว์ เพื่อเพิ่มความชัดเจนและอ่านง่ายของผลลัพธ์ที่แสดงออกมาในหน้าจอ เราจะเห็นการแสดงผลออกมาดังภาพด้านบนจากการรันคำสั่งในข้อ 5
