using System;
using System.Data.Entity;

namespace L07_Task01
{
    internal class Initializer : DropCreateDatabaseAlways<Model1>
    {
        protected override void Seed(Model1 context)
        {
            base.Seed(context);

            Artist art1 = context.Artists.Add(new Artist { Country = "Ukraine", Name = "ArtistName1", Surname = "ArtistSurname1" });
            Artist art2 = context.Artists.Add(new Artist { Country = "Poland", Name = "ArtistName2", Surname = "ArtistSurname2" });
            Artist art3 = context.Artists.Add(new Artist { Country = "USA", Name = "ArtistName3", Surname = "ArtistSurname3" });
            context.SaveChanges();

            Album al1 = context.Albums.Add(new Album { Name = "AlbumName1", Date = new DateTime(1991, 5, 21), Artist = art1 });
            Album al2 = context.Albums.Add(new Album { Name = "AlbumName2", Date = new DateTime(2019, 7, 11), Artist = art2 });
            Album al3 = context.Albums.Add(new Album { Name = "AlbumName3", Date = new DateTime(2000, 5, 15), Artist = art2 });
            context.SaveChanges();



        }
    }
}