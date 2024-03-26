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

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

![6](https://github.com/Siriratda/03376836-OOP-2566-Lab-13/assets/144195995/bc86a9c8-d64b-4a56-95ea-4490c98d2260)

ไม่สามารถ Build ได้ เพราะ ไม่ได้ระบุ Method แก้โดยให้ทำให้ interface IRemoteControl เป็น public และลบคำว่า public ออกจาก declaration ของ method ภายใน interfaceน class PowerAppliance ให้เพิ่ม property Wattage และ PowerStatus เป็น properties ที่สามารถอ่านและเขียนได้ (get;set;) เพื่อให้เข้ากับการใช้งาน property ใน class Television และ Lamp และ ใน class Television และ Lamp ให้ implement interface IRemoteControl และ implement method ที่ต้องการตาม interface เพื่อให้สอดคล้องกับการใช้งานและการควบคุมอุปกรณ์และเครื่องใช้ไฟฟ้าตามสัญญาของ interface

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab13_Ex06
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![6 1](https://github.com/Siriratda/03376836-OOP-2566-Lab-13/assets/144195995/9bbf3aa6-3109-4c99-afa1-15a8d52c6ecd)


7.อธิบายสิ่งที่พบในการทดลอง

ไม่สามารถ Run ได้ เพราะ ไม่ได้ระบุ Method แก้โดยให้ทำให้ interface IRemoteControl เป็น public และลบคำว่า public ออกจาก declaration ของ method ภายใน interfaceน class PowerAppliance ให้เพิ่ม property Wattage และ PowerStatus เป็น properties ที่สามารถอ่านและเขียนได้ (get;set;) เพื่อให้เข้ากับการใช้งาน property ใน class Television และ Lamp และ ใน class Television และ Lamp ให้ implement interface IRemoteControl และ implement method ที่ต้องการตาม interface เพื่อให้สอดคล้องกับการใช้งานและการควบคุมอุปกรณ์และเครื่องใช้ไฟฟ้าตามสัญญาของ interface

โปรแกรมจะแสดงผล

TV Turn on

TV Channel up

TV Channel down

TV Turn off

Lamp Turn on

Lamp cannot change channel

Lamp cannot change channel

Lamp Turn off
