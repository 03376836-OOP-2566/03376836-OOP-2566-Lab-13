## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

![pic](/Pictures/pic-1.png)

สามารถ Build ได้ เพราะ abstract class Animal มี Interface IMovable ด้วย Method Move() และถูก override ใน class Dog : Animal ให้แสดงผลตามที่กำหนด

## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![pic](/Pictures/pic-2.png)

## อธิบายสิ่งที่พบในการทดลอง

สามารถ Run ได้ เพราะใช้งานInterface IMovable สามารถใช้ Polymorphism ในการประกาศตัวแปร animal_2 โดยให้มีชนิดเป็น IMovable และกำหนดให้เป็น object ของคลาส Dog 

โปรแกรมจะแสดงผล

- Dog move by running on the ground
- Dog move by running on the ground