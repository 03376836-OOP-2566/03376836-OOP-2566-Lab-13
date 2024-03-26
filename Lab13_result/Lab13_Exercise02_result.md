### บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![13-2 run1](https://github.com/kanoksiriboonkam/03376836-OOP-2566-Lab-13/assets/144196048/e5c2c7f6-9f6c-4c51-973b-81b9879a1656)
 
สามารถ Build ได้ เพราะ Dog เป็นคลาสที่สืบทอดมาจาก Animal ซึ่งเป็น abstract class และ Animal ได้ implement interface IMovable ด้วยเมทอด Move() ดังนั้น Dog จึงต้อง Override เมทอด Move()
### บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![13-2 run2](https://github.com/kanoksiriboonkam/03376836-OOP-2566-Lab-13/assets/144196048/9afbf5c0-f301-4d2f-a773-4f5fd82bfe9a)

สามา Run ได้ เพราะ ใช้ Move() จาก object ในอาร์เรย์ IMovable ได้โดยตรง โดยไม่จำเป็นต้องรู้ว่า object นั้นเป็นคลาสชนิดใด ด้วยคุณสมบัติของ Polymorphism ที่เป็นลักษณะของการใช้ Interface
### อธิบายสิ่งที่พบในการทดลอง
Dog move by running on the ground

Dog move by running on the ground

Dog move by running on the ground
