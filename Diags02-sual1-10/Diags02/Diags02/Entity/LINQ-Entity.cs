using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diags02.Model;

namespace Diags02.Entity
{
    class LINQ_Entity
    {
        public static List<Genre> Genres = new List<Genre>()
        {
            new Genre(){GenreId =1,Name="Pop",Description = "En bomba mahnilar"},
            new Genre(){GenreId =2,Name="Rock",Description = "Deliler"},
            new Genre(){GenreId =3,Name="Rep",Description = "En bomba Repler"}
        };
        public static List<Artist> Artists = new List<Artist>()
        {
            new Artist(){ArtistId = 1,Name = "Coni"},
            new Artist(){ArtistId = 2,Name = "Michael Jackson"},
            new Artist(){ArtistId = 3,Name = "Eminem"}
        };
        public static List<Order> Orders = new List<Order>()
        {
            new Order(){OrderId =1,OrderDate =new DateTime(2018, 6, 18),UserName = "Naib_P106",
                FirstName = "Naib",LastName = "Tehmezli",Address = "28 may AF",City = "Baki",
                State = "Sebail rayonu",PostalCode = "Az1023",Country ="Azerbaijan",Phone = "055",
                Email = "naibtehmezli22@gmail.com",Total =70},

           new Order(){OrderId =2,OrderDate =new DateTime(2018, 6, 14),UserName = "Zamin5525",
               FirstName = "Zamin",LastName = "Hesenov",Address = "Hezi Aslanov ",City = "Sumqayit",
               State = "Xetai",PostalCode = "Az123",Country ="Azerbaijan",Phone = "051",
               Email = "hesenovzamin@gmail.com",Total =90},

           new Order(){OrderId =3,OrderDate =new DateTime(2016, 8, 18),UserName = "Suleyman12",
               FirstName = "Suleyman",LastName = "Suleymanli",Address = "Elmler",City = "Xirdalan",
               State = "Sebail rayonu",PostalCode = "Az1223",Country ="Azerbaijan",Phone = "077",
               Email = "suleyman@gmail.com",Total =1000}
        };
        public static List<OrderDetail> OrderDetails = new List<OrderDetail>()
        {
            new OrderDetail(){OrderDetailId=1, OrderId=1, AlbumId=1, Quantity=70, UnitPrice=100},
            new OrderDetail(){OrderDetailId=2, OrderId=2, AlbumId=2, Quantity=80, UnitPrice=200},
            new OrderDetail(){OrderDetailId=3, OrderId=3, AlbumId=3, Quantity=60, UnitPrice=300}
        };
        public static List<Album> Albums = new List<Album>()
        {
            new Album(){AlbumId=1, GenreId=1, ArtistId=1, Title="Title01", Price=15, AlbumArtUrl="link01"},
            new Album(){AlbumId=2, GenreId=2, ArtistId=2, Title="Title02222", Price=20, AlbumArtUrl="link02"},
            new Album(){AlbumId=3, GenreId=3, ArtistId=3, Title="Title0333333", Price=25, AlbumArtUrl="link03"}
        };
        public static List<Cart> Carts = new List<Cart>()
        {
            new Cart(){RecordId=1, CartId=1, AlbumId=1, Count=1, DateCreated=new DateTime(2015, 8, 18)},
            new Cart(){RecordId=2, CartId=2, AlbumId=2, Count=2, DateCreated=new DateTime(2014, 8, 18)},
            new Cart(){RecordId=3, CartId=3, AlbumId=3, Count=3, DateCreated=new DateTime(2013, 8, 18)}
        };
    }
}
