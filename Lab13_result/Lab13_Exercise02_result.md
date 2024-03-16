## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

![image](https://github.com/Phetteepop/03376836-OOP-2566-Lab-13/assets/144197367/16cb21b5-f37b-4442-97c2-a2b0a005839e)


สามารถ Build ได้ เพราะ Dog เป็นคลาสที่สืบทอดมาจาก Animal ซึ่งเป็น abstract class และ Animal ได้ implement interface IMovable ด้วยเมทอด Move() ดังนั้น Dog จึงต้อง Override เมทอด Move() 

## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![image](https://github.com/Phetteepop/03376836-OOP-2566-Lab-13/assets/144197367/396a7a74-8932-401f-bc00-4764d6cead41)


สามา Run ได้ เพราะ ใช้ Move() จาก object ในอาร์เรย์ IMovable ได้โดยตรง โดยไม่จำเป็นต้องรู้ว่า object นั้นเป็นคลาสชนิดใด ด้วยคุณสมบัติของ Polymorphism ที่เป็นลักษณะของการใช้ Interface

## อธิบายสิ่งที่พบในการทดลอง
- Dog move by running on the ground
- Dog move by running on the ground
- Dog move by running on the ground
