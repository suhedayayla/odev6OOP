using System;

namespace Inheritance
{

    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.Name = "İnsan ne ile yaşar";
            book.NumberOfPages = 50;
            book.BookFeatures();

            Magazine magazine = new Magazine();
            magazine.Name = "Minik Mucitler";
            magazine.Editor = "Ali Yılmaz";
            magazine.MagazineFeatures();


            ///////////////////////////7
            ///

            Shape shape=new Shape();
            Console.WriteLine(shape.Area().ToString());
            Rectangle rectangle=new Rectangle();
            Console.WriteLine(rectangle.Area().ToString());
            Triangle triangle =new Triangle();
            Console.WriteLine(triangle.Area().ToString());


            ///////////////////////////
            ///
            Vehicle vehicle = new Vehicle();
            vehicle.Brand = "Toyota";
            vehicle.Year = 2024;
            vehicle.Model = "Corolla";
            vehicle.Drive();

            Car car=new Car();
            car.Brand = "Skoda";
            car.Year = 2023;
            car.Model = "Karoq";
            car.Drive();

            Motorcycle motorcycle = new Motorcycle();
            motorcycle.Brand = "Honda";
            motorcycle.Year = 2021;
            motorcycle.Model = "XD100";
            motorcycle.Drive(); 


            Console.ReadLine();
        }

        ////////1. Örnek Kütüphane Kayıtları //////////////
        public class LibraryRecords
        {
            public int Id;
            public string Name;
            public string Description;
            public string Type;
        }

        public class Book : LibraryRecords
        {
            public string Writer;
            public int NumberOfPages;
            public string Language;
            public void BookFeatures()
            {
                Console.WriteLine("Kütüphanede ki kitabın Adı" + " " + Name + " " + "Sayfa sayısı" + " " + NumberOfPages);
            }
        }

        public class Magazine : LibraryRecords
        {
            public string BroadCastPeriod;
            public string Editor;
            public void MagazineFeatures()
            {
                Console.WriteLine("Kütüphanede ki derginin Adı" + " " + Name + " " + "Editörü" + " " + Editor);
            }
        }


        ////////2. Örnek Alan hesaplama /////////////
        ///
        class Shape
        {
            public double Width { get; set; }
            public double Height { get; set; }

            public Shape()
            {
                
            }
            public virtual double Area() //burda aynı zamanda polimorfizm yaptık
            {
                return Width*Height;
            }
        }
        class Rectangle : Shape //inheritance
        {
            public Rectangle()
            {
                Console.WriteLine("Dikdörtgenin alanı hesaplanıyor...");
            }
            public override double Area()
            {
                base.Area();
                Width = 20;
                Height = 30;
                return Width * Height;
            }

        }
        class Triangle: Shape
        {
            public Triangle()
            {
                Console.WriteLine("Üçgenin alanı hesaplanıyor...");


            }
            public override double Area()
            {
                base.Area();
                Width = 12;
                Height = 10;
                return (Width * Height) / 2;
                    
                    }
        }

        ///////// 3. Örnek Araç; Araba ve Motor sınıfları /////////////
        ///

        class Vehicle
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public Vehicle()
            {
                
            }
            public virtual void Drive()
            {
                Console.WriteLine($"This Vehicle's features are {Year} {Brand} {Model}");
            }
        }
         class Car : Vehicle
        {
            public Car()
            {
                
            }
            public override void Drive()
            {
                Console.WriteLine($"This Car's features are {Year} {Brand} {Model}");
            }


        }
        class Motorcycle: Vehicle
        {
            public Motorcycle()
            {
                
            }
            public override void Drive()
            {
                Console.WriteLine($"This Motorcycle's features are {Year} {Brand} {Model}");
            }
        }
    }
}