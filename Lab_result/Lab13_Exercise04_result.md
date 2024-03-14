## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-13/assets/144196505/20529cee-2785-4c69-9a76-93bf1b86353a)

## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-13/assets/144196505/2f018e38-043f-44a3-b5b3-2d6f96817a12)

## อธิบายสิ่งที่พบในการทดลอง
### เกิด Error เพราะ Abstract Class Animal สืบทอดจาก Interface ISpeakable แต่ไม่มีการ override `Speak()` ซึ่งเป็น method ที่ต้องสืบทอดมาจาก Interface ISpeakable

## หลังแก้ไขโค้ด โดย 1.เพิ่ม virtual/override ให้ method `Speak()` ในคลาส animal หรือ ปิดการทำงานของ method `Speak()` ไป
```
abstract class Animal : IMovable, ISpeakable
{
    abstract public void Move();
    public virtual void Speak()
    {
        // ไม่มีการทำงานอะไร ใส่กัน Error
    }
}
```
![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-13/assets/144196505/ce517364-20c7-4c22-93d3-d21545d73d2b)
