# 3 #
![image](https://github.com/ThanaloekKaisai/03376836-OOP-2566-Lab-13/assets/144195683/4d9c43f2-6b51-4bc8-9e11-e61b45176e07)
สามารถ Build ได้ เพราะ Dog เป็นคลาสที่สืบทอดมาจาก Animal ซึ่งเป็น abstract class และ Animal ได้ implement interface IMovable ด้วยเมทอด Move() ดังนั้น Dog จึงต้อง Override เมทอด Move()

# 5 #
![image](https://github.com/ThanaloekKaisai/03376836-OOP-2566-Lab-13/assets/144195683/b4042d83-7ddc-4712-972a-d7754a005d74)
สามา Run ได้ เพราะ ใช้ Move() จาก object ในอาร์เรย์ IMovable ได้โดยตรง โดยไม่จำเป็นต้องรู้ว่า object นั้นเป็นคลาสชนิดใด ด้วยคุณสมบัติของ Polymorphism ที่เป็นลักษณะของการใช้ Interface
# อธิบายสิ่งที่พบในการทดลอง #
```
Dog move by running on the ground
Dog move by running on the ground
Dog move by running on the ground
