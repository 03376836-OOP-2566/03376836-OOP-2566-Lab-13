# Lab 13 Exercise 7

## Interface (var variables)

1.สร้าง console application project

```cmd
dotnet new console --name Lab13_Ex07
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/1d997402-3523-4d63-81c8-8c5d605c0eea)

2.เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
var myTV = new SonyTV();
myTV.Wattage = 100;
myTV.TurnOn();
myTV.ChannelUp();
myTV.ChannelDown();
myTV.TurnOff();

var myLamp = new DesktopLamp();
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
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/a1b67879-6def-4c3d-a216-48e22bab0c02)
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/fb648d64-fb76-4b18-98f3-6085300d0ac4)
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/781b561f-a3ba-4322-b744-48eaac57bcb6)

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab13_Ex07
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/7ea93400-9786-4291-9071-1237e8471211)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab13_Ex07
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-13/assets/144197034/28856535-3296-415c-adaa-7960e4a16228)

7.อธิบายสิ่งที่พบในการทดลอง

จากในการทดลองนี้ เรามีการสร้างคลาส Television และ Lamp ที่เป็นคลาสที่สืบทอดจากคลาส PowerAppliance ซึ่งมีเมทอดและแอตทริบิวต์ที่เกี่ยวข้องกับการควบคุมอุปกรณ์ที่ใช้พลังงาน โดย Television มีเพิ่มเติมช่องสำหรับเก็บข้อมูลช่องทางด้วย

คลาส SonyTV และ DesktopLamp นั้นเป็นคลาสที่สืบทอดจาก Television และ Lamp ตามลำดับ และในที่นี้เราได้นิยามเมทอดในอินเทอร์เฟซ IRemoteControl ให้ทั้งสองคลาสนี้เพื่อให้สามารถควบคุมได้ด้วยรีโมทคอนโทรล

โดยเมื่อสร้างอ็อบเจกต์ myTV และ myLamp แล้ว เราสามารถเรียกใช้เมทอด TurnOn() TurnOff() ChannelUp() และ ChannelDown() ได้โดยตรง โดยไม่จำเป็นต้องระบุชนิดของอ็อบเจกต์ ซึ่งเป็นการนำเอาพลังของการสืบทอดคลาสมาใช้งานอย่างเหมาะสม

ในการทดลองนี้ มีการสร้างคลาส Television และ Lamp ที่เป็นคลาสที่สืบทอดจากคลาส PowerAppliance เพื่อเพิ่มความสามารถในการควบคุมอุปกรณ์ที่ใช้พลังงาน โดย Television มีการเพิ่มคุณสมบัติเพิ่มเติมเกี่ยวกับช่องสำหรับเก็บข้อมูลช่องทางด้วย

SonyTV และ DesktopLamp สืบทอดจาก Television และ Lamp ตามลำดับ และนำเข้าอินเทอร์เฟซ IRemoteControl เพื่อให้สามารถควบคุมอุปกรณ์ได้ผ่านรีโมทคอนโทรล

เมื่อสร้างอ็อบเจกต์ myTV และ myLamp จะสามารถเรียกใช้เมทอด TurnOn() TurnOff() ChannelUp() และ ChannelDown() ได้โดยตรง โดยไม่ต้องระบุชนิดของอ็อบเจกต์ ซึ่งเป็นการใช้งานการสืบทอดคลาสอย่างเหมาะสมและสะดวกในการใช้งาน

เราจะเห็นการแสดงผลดังผลลัพธ์ด้านบน ซึ่งมีความเหมือนกับ  Lab 13 Exercise 6 ก่อนหน้านี้ ที่มีการแก้ไขความผิดพลาด มีการแสดงผลของทางข้อความเหมือนกัน
