## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

![image](https://github.com/Phetteepop/03376836-OOP-2566-Lab-13/assets/144197367/7ae509ab-f0e6-49d5-89e4-a95f20fdd2ab)

- ไม่สามารถ Build ได้ เพราะ อย่างแรก ISpeakable.Speak() ไม่ได้เพิ่มถูกประกาศลงใน
abstract class Animal


## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![image](https://github.com/Phetteepop/03376836-OOP-2566-Lab-13/assets/144197367/455bcea8-d796-4641-a826-5719aca260bb)


- ไม่สามารถ Run ได้ เพราะ อย่างแรก ISpeakable.Speak() ไม่ได้เพิ่มถูกประกาศลงใน
abstract class Animal



## อธิบายสิ่งที่พบในการทดลอง

โปรแกรมจะแสดงผล 

- Dog move by running on the ground         

- Bird move by flying in the air            

- Fish move by swimming in the water        


## หลังแก้ไขโปรแกรม

![image](https://github.com/Phetteepop/03376836-OOP-2566-Lab-13/assets/144197367/853d52fa-e35e-4a97-a7fa-c1540255034c)
![image](https://github.com/Phetteepop/03376836-OOP-2566-Lab-13/assets/144197367/f328f9c4-3e4f-46e7-8c74-80f3a0102d11)


- ประกาศ abstract public void Speak(); ลงใน abstract class Animal เพื่อเพิ่ม Interface อื่นๆ
- เพื่อให้ animal.Speack(); แสดงผลตามที่กำหนดของ Array
- เพิ่ม Speack () override ไปยัง class Dog, Fish, Bird แล้วกำหนคำการแสดงผล

~~~c#
Animal[] animals = new Animal[3];
animals[0] = new Dog();
animals[1] = new Bird();
animals[2] = new Fish();

foreach (var animal in animals)
{
    animal.Move();
}

interface IMovable
{
    void Move();
}

interface ISpeakable
{
    void Speak();
}

abstract class Animal : IMovable, ISpeakable
{
    public abstract void Move();
    public abstract void Speak();
}

class Dog : Animal
{
    public override void Move()
    {
        System.Console.WriteLine("The dog moves by running on the ground");
    }

    public override void Speak()
    {
        System.Console.WriteLine("The dog barks");
    }
}

class Fish : Animal
{
    public override void Move()
    {
        System.Console.WriteLine("The fish moves by swimming in the water");
    }

    public override void Speak()
    {
        System.Console.WriteLine("The fish makes no sound");
    }
}

class Bird : Animal
{
    public override void Move()
    {
        System.Console.WriteLine("The bird moves by flying in the air");
    }

    public override void Speak()
    {
        System.Console.WriteLine("The bird chirps");
    }
}

~~~
