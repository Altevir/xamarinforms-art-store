using System.Collections.ObjectModel;
using XFArtStore.Models;

namespace XFArtStore.Services
{
    public class DataService
    {
        public static ObservableCollection<Group> GetGroups()
        {
            var groups = new ObservableCollection<Group>();

            groups.Add(new Group() { name = "All" });
            groups.Add(new Group() { name = "Classical" });
            groups.Add(new Group() { name = "Abstract" });
            groups.Add(new Group() { name = "Artwork" });
            groups.Add(new Group() { name = "Color pencil" });

            return groups;
        }

        public static ObservableCollection<Painting> GetPaintings()
        {
            var paintings = new ObservableCollection<Painting>();

            paintings.Add(new Painting()
            {
                name = "Charles Chaplin",
                description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal",
                image = "chaplin.png",
                rating = 5,
                color = "Oil painting",
                style = "Morden",
                madeIn = "USA",
                price = 5690,
                imageBackground = "chaplin_background.png" }
            );
            paintings.Add(new Painting()
            {
                name = "Abstract",
                description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal",
                image = "background_abstract.png",
                rating = 4,
                color = "Oil painting",
                style = "Morden",
                madeIn = "USA",
                price = 2199,
                imageBackground = "background_abstract.png"
            });
            paintings.Add(new Painting()
            {
                name = "Flower",
                description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal",
                image = "flower.png",
                rating = 3,
                color = "Oil painting",
                style = "Morden",
                madeIn = "USA",
                price = 4299,
                imageBackground = "background_flower.png"
            });

            return paintings;
        }

        public static ObservableCollection<TopArtists> GetTopArtists()
        {
            var artists = new ObservableCollection<TopArtists>();

            artists.Add(new TopArtists() { name = "Alisa", image = "alisa.png" });
            artists.Add(new TopArtists() { name = "Fred", image = "fred.png" });
            artists.Add(new TopArtists() { name = "Randy", image = "randy.png" });
            artists.Add(new TopArtists() { name = "Mandy", image = "mandy.png" });
            artists.Add(new TopArtists() { name = "John", image = "john.png" });

            return artists;
        }

        public static ObservableCollection<ForYou> GetListForYou()
        {
            var list = new ObservableCollection<ForYou>();

            list.Add(new ForYou() { image = "background1.png" });
            list.Add(new ForYou() { image = "background2.png" });
            list.Add(new ForYou() { image = "background3.png" });
            list.Add(new ForYou() { image = "background4.png" });

            return list;
        }
    }
}
