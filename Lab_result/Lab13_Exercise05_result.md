## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

![pic](/Pictures/pic-14.png)

สามารถ Build ได้ เพราะ ISpeakable.Speak() ถูกประกาศลง abstract class

 และการสืบทอด Animal.Speak() ถูกเพิ่มไปยัง Bird, Dog, Fish 

## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5


![pic](/Pictures/pic-15.png)

สามารถ Run ได้ เพราะ ทุกคลาสที่สืบทอดมาจาก animal มี Interface Speak() ที่เพิ่มเข้ามาแล้ว และ ถูก override 

## อธิบายสิ่งที่พบในการทดลอง

โปรแกรมจะแสดงผล 

- Dog move by running on the ground         
Dog speak "Bok Bok"
-------
- Bird move by flying in the air            
Bird speak "Jib Jib"
-------
- Fish move by swimming in the water        
Fish can not speak
-------