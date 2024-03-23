# Lab 13 Exercise 6

## Interface (Remote Control)

1.สร้าง console application project

```cmd
dotnet new console --name Lab13_Ex06
```

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/6b8afcad-c280-4ae9-9eb0-9678c866e6e0)

2.เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
Television myTV = new SonyTV();
myTV.Wattage = 100;
myTV.TurnOn();
myTV.ChannelUp();
myTV.ChannelDown();
myTV.TurnOff();

Lamp myLamp = new DesktopLamp();
myLamp.Wattage = 50;
myLamp.TurnOn();
myLamp.ChannelUp();
myLamp.ChannelDown();
myLamp.TurnOff();

interface IRemoteControl
{
    public void TurnOn();
    public void TurnOff();
    public void ChannelUp();
    public void ChannelDown();
}
abstract class PowerAppliance
{
    public bool PowerStatus;
    public int Wattage;
}
class Television : PowerAppliance
{
    public int Channel { get; set; }
}

class Lamp : PowerAppliance
{
}


class SonyTV : Television, IRemoteControl
{
    public void TurnOn() { System.Console.WriteLine("TV Turn on"); PowerStatus = true; }
    public void TurnOff() { System.Console.WriteLine("TV Turn off"); PowerStatus = false; }
    public void ChannelUp() { System.Console.WriteLine("TV Channel up"); }
    public void ChannelDown() { System.Console.WriteLine("TV Channel down"); }
}
class DesktopLamp : Lamp, IRemoteControl
{
    public void TurnOn() { System.Console.WriteLine("Lamp Turn on"); PowerStatus = true; }
    public void TurnOff() { System.Console.WriteLine("Lamp Turn off"); PowerStatus = false; }
    public void ChannelUp() { System.Console.WriteLine("Lamp cannot change channel"); }
    public void ChannelDown() { System.Console.WriteLine("Lamp cannot change channel"); }
}
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/d979e454-5dd8-4e22-bff7-813c568b397a)

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/4d39dbce-100d-4539-8f2d-5c3157f6c73c)

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/3ba9567d-effa-4a62-b737-381f80a13069)

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab13_Ex06
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3


![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/980c26d4-251b-4eba-a186-b4287c2be313)

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/ff47b749-5223-4dce-8f2b-7e457297de5e)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab13_Ex06
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/190aca0b-1b5a-4c90-b8de-a52eda9fe257)

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/f0c28275-499d-4444-95b8-e624c550150b)

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/d5971374-cc59-48aa-a1e4-12be8d7e539e)

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/1d8fd790-b06f-42fd-97b0-d64433f12e77)

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/ad1d3459-db3c-4c9f-a332-117bd7514730)

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/d3431b5f-66f6-4f68-ae74-942801ee24db)

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/d55fc87e-e990-456a-b453-be99a6bf373f)



7.อธิบายสิ่งที่พบในการทดลอง

จากโค้ดเดิมมีปัญหาในที่สร้างอ็อบเจกต์ขึ้นมาใหม่ (instantiation) และการเรียกใช้เมท็อดของอ็อบเจกต์
การสร้างอ็อบเจกต์ขึ้นมาใหม่ การเรียกใช้เมท็อด การสืบทอด
เมื่อแก้ไขโค้ดจะได้ 

ในการทดลองนี้ เรามีการสร้างอินเทอร์เฟซ IRemoteControl ซึ่งรวมเมทอดที่เกี่ยวกับการควบคุมอุปกรณ์รีโมท (remote control) เช่นการเปิด/ปิดและการเปลี่ยนช่องสำหรับทีวีหรือโคมไฟ โดยที่เมทอดเหล่านี้เป็นส่วนหนึ่งของการทำงานของอุปกรณ์ที่ใช้ได้กับรีโมทคอนโทรล

คลาส PowerAppliance เป็นคลาสแม่ที่มีคุณสมบัติเฉพาะของอุปกรณ์ที่มีการใช้พลังงาน (power appliance) เช่น สถานะของพลังงานและกำลังไฟที่ใช้

คลาส Television และ Lamp เป็นคลาสลูกที่สืบทอดจาก PowerAppliance และมีการนิยามเมทอดในอินเทอร์เฟซ IRemoteControl ซึ่งทำให้สามารถควบคุมอุปกรณ์ด้วยรีโมทได้

ในคลาส SonyTV และ DesktopLamp นั้นเป็นการสร้างคลาสที่สืบทอดจาก Television และ Lamp ตามลำดับ ซึ่งทำให้สามารถใช้งานรีโมทคอนโทรลได้โดยตรงโดยไม่ต้องเพิ่มการนิยามเมทอดในคลาสลูกเพิ่มเติม

ในฟังก์ชัน Main ของคลาส Program มีการสร้างอ็อบเจกต์ myTV และ myLamp และเรียกใช้เมทอดต่างๆ ในอินเทอร์เฟซ IRemoteControl ที่ถูกสืบทอดมาโดยตรงจากอ็อบเจกต์ myTV และ myLamp โดยไม่ต้องระบุชนิดของอ็อบเจกต์ที่เกี่ยวข้อง 

เราจะเห็นการแสดงผลดังภาพผลลัพธ์ด้านบน
