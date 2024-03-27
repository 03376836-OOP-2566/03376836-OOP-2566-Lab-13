# Lab 13 Exercise 7

## Interface (var variables)

1.สร้าง console application project

```cmd
dotnet new console --name Lab13_Ex07
```

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

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab13_Ex07
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-13/assets/144195611/cc1f8c90-58f8-4809-8d44-0f66a9dc2945)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab13_Ex07
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-13/assets/144195611/c5e49458-38ad-40a1-a609-87276b669375)

7.อธิบายสิ่งที่พบในการทดลอง
- ใช้ interface IRemoteControl ในการควบคุมการทำงานของอุปกรณ์ที่ใช้ไฟฟ้าและมีการควบคุมช่องสัญญาณด้วย โดยมี Television และ Lamp เป็นคลาสที่สืบทอดคุณสมบัติจาก PowerAppliance
