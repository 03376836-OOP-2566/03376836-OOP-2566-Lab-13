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

7.อธิบายสิ่งที่พบในการทดลอง
