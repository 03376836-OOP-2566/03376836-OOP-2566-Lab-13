## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-13/assets/144196505/8f5058ce-e627-4232-a0b7-818bf2b771ac)

## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-13/assets/144196505/3b9bc99c-a405-4a76-a10a-fbd2804b6451)

## อธิบายสิ่งที่พบในการทดลอง
### interface IMovable เป็นการกำหนดว่าคลาสที่ใช้ Interface จะต้องมี method Move() เพื่อทำการเคลื่อนที่ 
### abstract class Animal : IMovable คลาสที่สืบทอดจะต้องใส่รายละเอียดการทำงานของ method Move() ให้กับตัวของมันเอง เช่น  "Dog move by running on the ground"
### เมื่อเรียกใช้ animal_1.Move(); หรือ animal_2.Move(); จะแสดงข้อความ "Dog move by running on the ground" ตามที่อธิบายข้างต้น
