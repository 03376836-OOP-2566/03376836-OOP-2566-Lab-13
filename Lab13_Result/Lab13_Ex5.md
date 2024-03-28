# 3 # 
![image](https://github.com/ThanaloekKaisai/03376836-OOP-2566-Lab-13/assets/144195683/d8da1ade-09dd-4108-8da0-e2de12426de3)
สามารถ Build ได้ เพราะ ISpeakable.Speak() ถูกประกาศลง abstract class
และการสืบทอด Animal.Speak() ถูกเพิ่มไปยัง Bird, Dog, Fish


# 5 # 
![image](https://github.com/ThanaloekKaisai/03376836-OOP-2566-Lab-13/assets/144195683/7c32e04e-6ffd-4990-8630-d660e354c0ee)
สามารถ Run ได้ เพราะ ทุกคลาสที่สืบทอดมาจาก animal มี Interface Speak() ที่เพิ่มเข้ามาแล้ว และ ถูก override

# อธิบายสิ่งที่พบในการทดลอง #
```
โปรแกรมจะแสดงผล
Dog move by running on the ground
Dog speak "Bok Bok"
Bird move by flying in the air
Bird speak "Jib Jib"
Fish move by swimming in the water
Fish can not speak
