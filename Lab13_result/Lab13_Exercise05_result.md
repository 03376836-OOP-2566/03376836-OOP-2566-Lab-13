### บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/VisawaPRO/03376836-OOP-2566-Lab-13/assets/144195555/d89563ac-b7eb-41cf-adfe-6729a12fc99a)
สามารถ Build ได้ เพราะ ISpeakable.Speak() ถูกประกาศลง abstract class และการสืบทอด Animal.Speak() ถูกเพิ่มไปยัง Bird, Dog, Fish
### บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/VisawaPRO/03376836-OOP-2566-Lab-13/assets/144195555/c5d78ffc-cab5-491a-b87f-8770cfd0cb66)
สามารถ Run ได้ เพราะ ทุกคลาสที่สืบทอดมาจาก animal มี Interface Speak() ที่เพิ่มเข้ามาแล้ว และ ถูก override
### อธิบายสิ่งที่พบในการทดลอง
โปรแกรมจะแสดงผล

Dog move by running on the ground

Dog speak "Bok Bok"

Bird move by flying in the air

Bird speak "Jib Jib"

Fish move by swimming in the water

Fish can not speak




