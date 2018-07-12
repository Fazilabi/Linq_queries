using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diags02.Entity;

namespace Diags02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Click_Click(object sender, EventArgs e)
        {

            //var albumid =(from detail in LINQ_Entity.OrderDetails
            //                 where detail.OrderId == 1
            //                 select detail.AlbumId).FirstOrDefault();

            //var artistId = (from album in LINQ_Entity.Albums
            //                where album.AlbumId == albumid
            //                select album.ArtistId).FirstOrDefault();

            //var artistResult = from artist in LINQ_Entity.Artists
            //                   where artist.ArtistId == artistId
            //                   select artist.Name;
            //LINQ_Entity.OrderDetails.Where()
            //foreach (var artist  in artistResult)
            //{
            //    Result.Text += artist+"\r\n";
            //}

            //----------------Question 1
            Result.Text += "Cavab 1:\r\n  ";
            var maxUnitPrice = LINQ_Entity.OrderDetails.OrderByDescending(x => x.UnitPrice).First();
            var albumTitle = LINQ_Entity.Albums.Where(x => x.AlbumId == maxUnitPrice.AlbumId).Select(y => y.Title);

            foreach (var title in albumTitle)
            {
                Result.Text += title + "\r\n";
            }
            Result.Text += "-----------------------------------\r\n";

            //-----------------Question 2
            Result.Text += "Cavab 2:\r\n  ";
            var genreId = LINQ_Entity.Genres.Where(y => y.Name == "Pop").Select(y => y.GenreId).FirstOrDefault();
            var albumDetails = LINQ_Entity.Albums.Where(y => y.GenreId == genreId);

            foreach (var albumDetail in albumDetails)
            {
                Result.Text += albumDetail.AlbumId + " . " + albumDetail.Title + " -- " + albumDetail.Price + " -- " + albumDetail.AlbumArtUrl + "\r\n";
            }

            Result.Text += "-----------------------------------\r\n";


            //-----------------Question 3
            Result.Text += "Cavab 3:\r\n  ";

            var orders = LINQ_Entity.Orders.Where(x => x.OrderDate <= DateTime.Today && x.OrderDate >= new DateTime(DateTime.Today.Year, DateTime.Today.Month - 1, DateTime.Today.Day));

            Result.Text += orders.Count() + "\r\n";
            Result.Text += "-----------------------------------\r\n";


            //-----------------Question 4
            Result.Text += "Cavab 4:\r\n  ";
            var Total = 0;
            var orderIds = LINQ_Entity.Orders.Where(x => x.OrderDate <= DateTime.Today && x.OrderDate >= new DateTime(DateTime.Today.Year, DateTime.Today.Month - 1, DateTime.Today.Day)).Select(y => y.OrderId);

            var unitPriceQuery = from detail in LINQ_Entity.OrderDetails
                                 from orderId in orderIds
                                 where detail.OrderId == orderId
                                 select detail.UnitPrice;
            foreach (var price in unitPriceQuery)
            {
                Total += price;
            }
            Result.Text += Total + "\r\n";
            Result.Text += "-----------------------------------\r\n";


            //-----------------Question 5
            Result.Text += "Cavab 5:\r\n  ";

            var artistIdQuery = from artist in LINQ_Entity.Artists
                                where artist.Name == "Coni"
                                select artist.ArtistId;

            var albumIdQuery = from album in LINQ_Entity.Albums
                               from artistId in artistIdQuery
                               where album.ArtistId == artistId
                               select album.AlbumId;

            var orderIdQuery = from orderDetail in LINQ_Entity.OrderDetails
                               from albumId in albumIdQuery
                               where orderDetail.AlbumId == albumId
                               select orderDetail.OrderId;

            var ordersQuery = from order in LINQ_Entity.Orders
                              from orderId in orderIdQuery
                              where order.OrderId == orderId
                              select order;
            foreach (var order in ordersQuery)
            {
                Result.Text += order
                    .OrderId + ". " + order
                    .UserName + " \\ " + order
                    .FirstName + " \\ " + order
                    .LastName + " \\ " + order
                    .Address + " \\ " + order
                    .Phone + " \\ ";
            }
            Result.Text += "\r\n";

            Result.Text += "-----------------------------------\r\n";
            Result.Text += "Cavab 6:\r\n  ";
            //-----------------Question 6   Price dəyəri Avarage price dəyərindən böyük olan Albomlardan
            //Title dəyəri ən uzun olan Albomun Satış miqdarını (Count) tapın
            var averagePrice = (from price in LINQ_Entity.Albums
                                select price.Price).Average();
            var priceGreatAvePrice = (from _price in LINQ_Entity.Albums
                                      where _price.Price > averagePrice
                                      select _price.Price).FirstOrDefault();
            var titleLength = (from title in LINQ_Entity.Albums
                               select title.Title.Length).Max();
            var album_id_query = from albumid in LINQ_Entity.Albums
                                 select albumid.AlbumId;
            var orderDetail_Id = from orderId in LINQ_Entity.OrderDetails
                                 from album_id in album_id_query
                                 where orderId.AlbumId == album_id
                                 select orderId.Quantity;


            var sumQuantity = 0;
            foreach (var item in orderDetail_Id)
            {
                sumQuantity += item;
                
            }
            Result.Text += sumQuantity;
            Result.Text += "\r\n";





            Result.Text += "-----------------------------------\r\n";
            //-----------------Question 7 --Seçilən ölkədə ən çox satılan Genre adını tapın
            Result.Text += "Cavab 7:\r\n  ";

            //country="Azerbaijan";      
            var orderIdsQuery = from order in LINQ_Entity.Orders
                                where order.Country == "Azerbaijan"
                                select order.OrderId;

            var albumIdsQuery = from orderDetail in LINQ_Entity.OrderDetails
                                from orderId in orderIdsQuery
                                where orderDetail.OrderId == orderId && orderDetail.Quantity == (LINQ_Entity.OrderDetails.Max(x => x.Quantity))
                                select orderDetail.AlbumId;

            var genreIdQuery = from album in LINQ_Entity.Albums
                               from album_id in albumIdsQuery
                               where album.AlbumId == album_id
                               select album.GenreId;

            var genre_name = from genre in LINQ_Entity.Genres
                             from genre_id in genreIdQuery
                             where genre.GenreId == genre_id
                             select genre.Name;

            foreach (var item in genre_name)
            {
                Result.Text += item + "\r\n";
            }



            Result.Text += "-----------------------------------\r\n";
            //----Question 8---Adının uzunluğu 5 - dən böyük olan Artistləri əlifba sırasına görə sıralayın

            Result.Text += "Cavab 8:\r\n  ";
            var artist_name = from _name in LINQ_Entity.Artists
                              where _name.Name.Length > 5
                              orderby _name.Name
                              select _name.Name;

            foreach (var item in artist_name)
            {
                Result.Text += item + "\r\n";
            }


            Result.Text += "-----------------------------------\r\n";
            //----Question 9--Seçilən şəhərə aid olan orderlərdən -
            //UnitPrice dəyəri 5 AZN dən yüksək olan Albom satışlarının cəmini tapın
            Result.Text += "Cavab 9:\r\n  ";
            var sum = 0;
            var orders_Id_query = from city_name in LINQ_Entity.Orders
                                  where city_name.City == "Baki"
                                  select city_name.OrderId;

            var order_detail_query = from order_detail in LINQ_Entity.OrderDetails
                                     from order_id in orders_Id_query
                                     where order_detail.UnitPrice > 5 && order_detail.OrderId == order_id
                                     select order_detail.Quantity;

            foreach (var item in order_detail_query)
            {
                sum += item;
                Result.Text += sum;
            }

            Result.Text += "-----------------------------------\r\n";
            //-----Question 10 --Seçilən sözü Artist adı və ya Genre ad  və description içərisində axtaran sorğu yazın.
            Result.Text += "Cavab 10:\r\n  ";


            var contain_query_in_genre = from genre in LINQ_Entity.Genres
                                where genre.Description.Contains("elil")
                                select genre.Description;
            
            foreach (var item in contain_query_in_genre)
            {
                Result.Text += item+"\r\n";
            }

            var contain_query_in_artist = from artist in LINQ_Entity.Artists
                                          where artist.Name.Contains("Coni")
                                          select artist.Name;

            foreach (var item in contain_query_in_artist)
            {
                Result.Text += item + "\r\n";
            }





        }
    }
}
