using System;


// bir sınıfın iç detaylarını gizleyip kullanıcıyansadece belirli arayüz sağlamak encapsulation deriz
//bir sınıfın içindeki verilere ve işlevlere erişim kolaylığı sağlar
namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car=new Car();
            car.Speed = 120;
            car.DisplaySpeed();

            car.SpeedUp(45); //propert olarak çağırdım, fonks gibi parantez içinde çağırdım.
            car.DisplaySpeed();

            car.WaitUp(80);
            car.DisplaySpeed();



        }

        class Car
        {
            private int speed;//arabanın hızını temsil eden alanı oluşturdum private!
            public int Speed //speed için public bir prop içine sınırlamalar yaptım
            {
                get
                {
                    return speed;
                }
                set
                {
                    if (value <= 0 && value < 200)
                    {
                        speed = value;
                    }

                    else
                    {
                        Console.WriteLine("Geçersiz değer");
                    }

                } 
            }
            public void SpeedUp (int increasing)
            {
                speed += increasing;
            }
            public void WaitUp(int decreasing)
            {
                speed -= decreasing;
            }
            public void DisplaySpeed()
            {
                Console.WriteLine("Arabanın hızı :" + Speed);
            }
            

            
        }
    }

}