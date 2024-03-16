## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/Phetteepop/03376836-OOP-2566-Lab-13/assets/144197367/e82862ca-f363-45b9-8272-8ef58e21fcc1)


สามารถ Build ได้ เพราะ ISpeakable.Speak() ถูกประกาศลง abstract class

 และการสืบทอด Animal.Speak() ถูกเพิ่มไปยัง Bird, Dog, Fish 

## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5


![image](https://github.com/Phetteepop/03376836-OOP-2566-Lab-13/assets/144197367/d6e4a82f-95da-4f7d-bf4c-f1b0eea183e9)


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
