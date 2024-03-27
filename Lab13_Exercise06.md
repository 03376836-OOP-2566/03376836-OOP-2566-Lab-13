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
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-13/assets/144195611/81d66ccb-1b4d-48bc-875b-90a5db3deaf1)
- มีerror 8ตำแหน่ง
5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab13_Ex06
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-13/assets/144195611/d9829426-c254-4629-8e92-9afe21603c2f)

## โค้ดมีข้อผิดพลาด
มีการรแก้ไขดังนี้
```
using System;

class Program
{
    static void Main(string[] args)
    {
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
    }
}

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

class Television : PowerAppliance, IRemoteControl
{
    public int Channel { get; set; }
    public void TurnOn() { Console.WriteLine("TV Turn on"); PowerStatus = true; }
    public void TurnOff() { Console.WriteLine("TV Turn off"); PowerStatus = false; }
    public void ChannelUp() { Console.WriteLine("TV Channel up"); }
    public void ChannelDown() { Console.WriteLine("TV Channel down"); }
}

class Lamp : PowerAppliance, IRemoteControl
{
    public void TurnOn() { Console.WriteLine("Lamp Turn on"); PowerStatus = true; }
    public void TurnOff() { Console.WriteLine("Lamp Turn off"); PowerStatus = false; }
    public void ChannelUp() { Console.WriteLine("Lamp cannot change channel"); }
    public void ChannelDown() { Console.WriteLine("Lamp cannot change channel"); }
}

class SonyTV : Television
{
}

class DesktopLamp : Lamp
{
}
```
7.อธิบายสิ่งที่พบในการทดลอง
- เพิ่มคลาส Television และ Lamp ให้สืบทอดจาก IRemoteControl จะเป็นการทำให้ทั้ง Television และ Lamp สามารถใช้งานเมทอด IRemoteControl ได้โดยตรงซึ่งในกรณีนี้เมทอด TurnOn() TurnOff() ChannelUp() และ ChannelDown() จะถูกเรียกใช้
- สร้างคลาส Program ซึ่งมีเมธอด Main สำหรับการทดสอบการใช้งานคลาสอื่น ๆ ที่ได้สร้างขึ้นมาแล้ว มีการสร้างอินสแตนซ์ของ SonyTV และ DesktopLamp และเรียกใช้เมทอดต่าง ๆ ที่ได้รับจากอินเทอร์เฟซ IRemoteControl 
