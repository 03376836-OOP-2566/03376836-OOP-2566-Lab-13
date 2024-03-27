# Lab 13 Exercise 6

## Interface (Remote Control)

1.สร้าง console application project

```cmd
dotnet new console --name Lab13_Ex06
```

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

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab13_Ex06
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง
# แก้ไข
เกิด Error เนื่องจากมีการเรียกใช้เมทอดที่ไม่ถูกต้องในคลาส Television และ Lamp ซึ่งไม่ได้มีการ override เมทอดจาก IRemoteControl

 หลังแก้โค้ด โดย เพิ่ม method เหล่านั้นให้ตรงกับ method ใน IRemoteControl
 ![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-13/assets/144195708/c602dcf3-32fd-4125-8b8a-e4cf83331826)
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-13/assets/144195708/c7ab6780-715e-48dc-b2e4-b9bc3afb209d)
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-13/assets/144195708/1b8db0de-41f6-465d-8e6f-354771a4c22f)

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-13/assets/144195708/dc86e4a5-bcfa-4859-b7ba-f9817d04ce50)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab13_Ex06
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-13/assets/144195708/9023f324-5e6e-4d96-910b-3ae82e6f9ed2)

7.อธิบายสิ่งที่พบในการทดลอง

เกิด Error เนื่องจากมีการเรียกใช้เมทอดที่ไม่ถูกต้องในคลาส Television และ Lamp ซึ่งไม่ได้มีการ override เมทอดจาก IRemoteControl

เเสดงผล

TV Turn on

TV Channel up

TV Channel down

TV Turn off

Lamp Turn on

Lamp cannot change channel

Lamp cannot change channel

Lamp Turn off
