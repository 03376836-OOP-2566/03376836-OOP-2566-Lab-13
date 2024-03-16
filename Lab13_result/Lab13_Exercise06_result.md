
## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

![image](https://github.com/Phetteepop/03376836-OOP-2566-Lab-13/assets/144197367/50c1a197-c1b1-4151-b17d-1905e6e6793d)


ไม่สามารถ Build ได้ เพราะ ไม่ได้ระบุ Method 

## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

ไม่สามารถ Run ได้ เพราะ ไม่ได้ระบุ Method

![image](https://github.com/Phetteepop/03376836-OOP-2566-Lab-13/assets/144197367/d22f32d3-c9e3-4cbc-b244-5e80ffdadd78)


## อธิบายสิ่งที่พบในการทดลอง 

โปรแกรมจะแสดงผล

- TV Turn on
- TV Channel up
- TV Channel down
- TV Turn off
- Lamp Turn on
- Lamp cannot change channel
- Lamp cannot change channel
- Lamp Turn off

## หลังแก้ไขโปรแกรม

![image](https://github.com/Phetteepop/03376836-OOP-2566-Lab-13/assets/144197367/32ddf5b0-be81-412f-97d1-82c3aab19e20)
![image](https://github.com/Phetteepop/03376836-OOP-2566-Lab-13/assets/144197367/edadfa15-42c5-4b3e-8b11-d42adc0aef74)

- การสืบทอด: คลาส Television และ Lamp สืบทอดจาก PowerAppliance ทั้งคู่ ซึ่งเหมาะสำหรับเนื่องจากพวกเขามีคุณสมบัติเช่น PowerStatus และ Wattage เหมือนกัน
- อินเตอร์เฟซ: การกำหนดอินเตอร์เฟซ IRemoteControl เป็นการปฏิบัติที่ดีสำหรับการบังคับความสม่ำเสมอในคลาสที่สร้างฟังก์ชันควบคุมระยะไกล
- คลาสแบบแอบสมมติ: คลาส PowerAppliance เป็นแบบแอบสมมติ ซึ่งเหมาะสำหรับเนื่องจากไม่ได้ตั้งใจที่จะถูกสร้างขึ้นโดยตรง
- พอลีมอร์ฟิซึม: ทั้ง SonyTV และ DesktopLamp มีการดำเนินการ IRemoteControl ทำให้สามารถใช้งานได้เหมือนกันเมื่อเข้าถึงผ่านอินเตอร์เฟซอ้างอิง
- ตรรกะ: ดูเหมือนไม่จำเป็นต้องมีคุณสมบัติ Channel ในคลาส Television เนื่องจากไม่ได้
~~~c#
using System;

interface IRemoteControl
{
    void TurnOn();
    void TurnOff();
    void ChannelUp();
    void ChannelDown();
}

abstract class PowerAppliance
{
    public bool PowerStatus { get; set; }
    public int Wattage { get; set; }
}

class Television : PowerAppliance
{
}

class Lamp : PowerAppliance
{
}

class SonyTV : Television, IRemoteControl
{
    public void TurnOn()
    {
        Console.WriteLine("TV Turn on");
        PowerStatus = true;
    }

    public void TurnOff()
    {
        Console.WriteLine("TV Turn off");
        PowerStatus = false;
    }

    public void ChannelUp()
    {
        Console.WriteLine("TV Channel up");
    }

    public void ChannelDown()
    {
        Console.WriteLine("TV Channel down");
    }
}

class DesktopLamp : Lamp, IRemoteControl
{
    public void TurnOn()
    {
        Console.WriteLine("Lamp Turn on");
        PowerStatus = true;
    }

    public void TurnOff()
    {
        Console.WriteLine("Lamp Turn off");
        PowerStatus = false;
    }

    public void ChannelUp()
    {
        Console.WriteLine("Lamp cannot change channel");
    }

    public void ChannelDown()
    {
        Console.WriteLine("Lamp cannot change channel");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IRemoteControl myTV = new SonyTV();
        myTV.TurnOn();
        myTV.ChannelUp();
        myTV.ChannelDown();
        myTV.TurnOff();

        IRemoteControl myLamp = new DesktopLamp();
        myLamp.TurnOn();
        myLamp.ChannelUp();
        myLamp.ChannelDown();
        myLamp.TurnOff();
    }
}

~~~
