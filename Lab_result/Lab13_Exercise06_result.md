## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-13/assets/144196505/941d74e5-ed17-4019-86a4-32ffe9b32d75)

## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-13/assets/144196505/7efaad1a-de42-4bc2-8ecb-bf4c8274177d)

## อธิบายสิ่งที่พบในการทดลอง
### เกิด Error เนื่องจากมีการเรียกใช้เมทอดที่ไม่ถูกต้องในคลาส Television และ Lamp ซึ่งไม่ได้มีการ override เมทอดจาก IRemoteControl

## หลังแก้โค้ด โดย เพิ่ม method เหล่านั้นให้ตรงกับ method ใน IRemoteControl
```
class Television : PowerAppliance, IRemoteControl
{
    public int Channel { get; set; }

    public void TurnOn() { System.Console.WriteLine("TV Turn on"); PowerStatus = true; }
    public void TurnOff() { System.Console.WriteLine("TV Turn off"); PowerStatus = false; }
    public void ChannelUp() { System.Console.WriteLine("TV Channel up"); }
    public void ChannelDown() { System.Console.WriteLine("TV Channel down"); }
}

class Lamp : PowerAppliance, IRemoteControl
{
    public void TurnOn() { System.Console.WriteLine("Lamp Turn on"); PowerStatus = true; }
    public void TurnOff() { System.Console.WriteLine("Lamp Turn off"); PowerStatus = false; }
    public void ChannelUp() { System.Console.WriteLine("Lamp cannot change channel"); }
    public void ChannelDown() { System.Console.WriteLine("Lamp cannot change channel"); }
}

```  
![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-13/assets/144196505/8bd0ada0-ca18-4827-8c32-899d1ddf4b62)
