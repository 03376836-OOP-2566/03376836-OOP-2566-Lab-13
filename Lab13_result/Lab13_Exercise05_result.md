### บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![13-5 run1](https://github.com/kanoksiriboonkam/03376836-OOP-2566-Lab-13/assets/144196048/dda340f1-cdba-46dc-bdd4-c4102504a1cc)

สามารถ Build ได้ เพราะ ISpeakable.Speak() ถูกประกาศลง abstract class และการสืบทอด Animal.Speak() ถูกเพิ่มไปยัง Bird, Dog, Fish
### บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![13-5 run2](https://github.com/kanoksiriboonkam/03376836-OOP-2566-Lab-13/assets/144196048/becf25d4-e6e2-4560-a8ec-5d9a34b41437)

สามารถ Run ได้ เพราะ ทุกคลาสที่สืบทอดมาจาก animal มี Interface Speak() ที่เพิ่มเข้ามาแล้ว และ ถูก override
### อธิบายสิ่งที่พบในการทดลอง
โปรแกรมจะแสดงผล

Dog move by running on the ground

Dog speak "Bok Bok"

Bird move by flying in the air

Bird speak "Jib Jib"

Fish move by swimming in the water

Fish can not speak
