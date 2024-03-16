## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

![pic](/Pictures/pic-7.png)

![pic](/Pictures/pic-8.png)

- ไม่สามารถ Build ได้ เพราะ อย่างแรก ISpeakable.Speak() ไม่ได้เพิ่มถูกประกาศลงใน
abstract class Animal

 - อย่างที่สอง ต้องเพิ่ม การสืบทอด Animal.Speak() ไปยังคลาส Bird, Dog, Fish

## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![pic](/Pictures/pic-9.png)

![pic](/Pictures/pic-10.png)

- ไม่สามารถ Run ได้ เพราะ อย่างแรก ISpeakable.Speak() ไม่ได้เพิ่มถูกประกาศลงใน
abstract class Animal

 - อย่างที่สอง ต้องเพิ่ม การสืบทอด Animal.Speak() ไปยังคลาส Bird, Dog, Fish


## อธิบายสิ่งที่พบในการทดลอง

โปรแกรมจะแสดงผล 

- Dog move by running on the ground         
Dog says: Woof!
- Bird move by flying in the air            
Bird says: Chirp chirp!
- Fish move by swimming in the water        
Fish says: ... (no sound)

## หลังแก้ไขโปรแกรม

![pic](/Pictures/pic-11.png)
![pic](/Pictures/pic-12.png)
![pic](/Pictures/pic-13.png)

ประกาศ abstract public void Speak(); ลงใน abstract class Animal เพื่อเพิ่ม Interface อื่นๆ

~~~c#
abstract class Animal : IMovable, ISpeakable
{
    abstract public void Move();
    abstract public void Speak();
}
~~~
เพื่อให้ animal.Speack(); แสดงผลตามที่กำหนดของ Array
~~~c#
foreach (var animal in animals)
{
    animal.Move();
    animal.Speak();
}
~~~
เพิ่ม Speack () override ไปยัง class Dog, Fish, Bird แล้วกำหนคำการแสดงผล
~~~c#
public override void Speak() 
{
    System.Console.WriteLine("Dog says: Woof!");
}
~~~
~~~c#
public override void Speak() 
{
    System.Console.WriteLine("Fish says: ... (no sound)");
}
~~~
~~~c#
public override void Speak() 
{
    System.Console.WriteLine("Bird says: Chirp chirp!");
}
~~~