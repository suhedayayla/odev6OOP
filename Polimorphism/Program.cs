using System;

namespace Polimorphism

{
    

    class Program
    {
        static void Main(string[] args)
        {
            Movie movie = new Movie(); //movie türünde nesnemi oluşturdum
            Console.WriteLine(movie.WatchingMovie().ToString()); //watchingmovie metodunu çağırdım

            CartoonMovie cartoon = new CartoonMovie();
            Console.WriteLine(cartoon.WatchingMovie().ToString());

            HorrorMovie horror = new HorrorMovie();
            Console.WriteLine(horror.WatchingMovie().ToString());

            //////////////
            ///
            Product product = new Product();
            Console.WriteLine(product.ProductTotalPrice().ToString());

            Computer computer = new Computer();
            Console.WriteLine(computer.ProductTotalPrice().ToString());

            TV tv = new TV();
            Console.WriteLine(tv.ProductTotalPrice().ToString());

            Console.ReadLine(); 
        }




        ///////////////1. örnek film örneği////////////////77 


        public class Movie
        {

            public virtual string WatchingMovie() //polimorfizm için virtual olması şart.
            {
                return ("Kafa dağıtmak için film izlemek iyi gelir");
            }
        }



        public class CartoonMovie : Movie //cartoonmovie miras aldı
        {
            public override string WatchingMovie() //watching movie miras aldık, override ettiğimiz için returnunu değiştirebildik
            {
                return ("Çocuklar çizgi film izlemeyi çok severler");

            }
        }
        public class HorrorMovie : Movie
        {
            public override string WatchingMovie()
            {
                return ("Korku filmleri yetişkinler içindir");

            }
        }



        ////////////////////////2.Örnek ürün fiyat örneği///////////////////////

        public class Product
        {
            private const Decimal fixedPrice = 1000; //sabit fiyatlarımızı belirledik
            private const Decimal tax = 0.18m; //m bu değerin ondalık olduğunu belirtiyor burada.

            public string ProductName { get; set; }
            protected Decimal ProductPrice { get; set; }

            public Product()
            {
                Console.WriteLine("Ürün bilgileri yükleniyor");
            }

            public virtual Decimal ProductTotalPrice() 
            {
                ProductPrice = fixedPrice * tax;
                return ProductPrice;
            }

        }

        public class Computer : Product
        {
            public Computer()
            {
                Console.WriteLine("Bilgisayar fiyatı hesaplanıyor");
            }
            public override Decimal ProductTotalPrice()
            {
                base.ProductTotalPrice();
                ProductPrice *= 5M;
                return ProductPrice;

            }
        }

        public class TV : Product
        {
            public TV()
            {
                Console.WriteLine("TV fiyatı hesaplanıyor.");
            }
            public override Decimal ProductTotalPrice()
            {
                base.ProductTotalPrice();
                ProductPrice *= 3M;
                return ProductPrice;

            }
        }

    }
    }