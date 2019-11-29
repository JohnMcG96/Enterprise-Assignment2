using System;
using System.Collections.Generic;
using System.Text;
using Assignment2Data.Animal;

namespace Assignment2Data.Services
{
    public class ServiceSeeder
    {
        public static void Seed(IAnimalDataService service)
        {
            service.Initialise();
            var c1 = service.Insert(new Animals
            {
                AniName = "Rover",
                AniType = "Dog",
                AniBreed = "Alsatian",
                AniDoB = DateTime.Parse("23/09/2016"),
                AniDesc = "Brown and Black, Friendly",
                AniPic = "https://www.puppies.co.uk/wp-content/uploads/2018/03/gsd_88_43FP-wpcf_300x300.jpg"
            });
            var c2 = service.Insert(new Animals
            {
                AniName = "Socks",
                AniType = "Cat",
                AniBreed = "Shorthair",
                AniDoB = DateTime.Parse("23/09/2016"),
                AniDesc = "Black body, White feet",
                AniPic = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQCzBZtJlMh4tiHl_IXk1ZqNIphYleRuPcZhE6z1uz1qcq4buwE"
            });
            var c3 = service.Insert(new Animals
            {
                AniName = "Nibbles",
                AniType = "Ferret",
                AniBreed = "Black Sable Mitt",
                AniDoB = DateTime.Parse("23/09/2016"),
                AniDesc = "Knows several tricks",
                AniPic = "https://www.coopsandcages.com.au/blog/oe-content/uploads/2014/02/3-Ferret-Black-Sable-Mitt_mini.jpg"
            });
            var c4 = service.Insert(new Animals
            {
                AniName = "Flopsy",
                AniType = "Rabbit",
                AniBreed = "Mini Lop",
                AniDoB = DateTime.Parse("23/09/2016"),
                AniDesc = "Will always come when called",
                AniPic = "https://upload.wikimedia.org/wikipedia/commons/0/03/Miniature_Lop_-_Side_View.jpg"
            });
            var c5 = service.Insert(new Animals
            {
                AniName = "Fly",
                AniType = "Dog",
                AniBreed = "German Shorthair Pointer",
                AniDoB = DateTime.Parse("23/09/2016"),
                AniDesc = "Very well trained, former hunting dog",
                AniPic = "https://i.pinimg.com/564x/4b/1a/3a/4b1a3a4f3ad46dd6202701da9a5630d9.jpg"
            });
            var c6 = service.Insert(new Animals
            {
                AniName = "Monty",
                AniType = "Snake",
                AniBreed = "Burmese Python",
                AniDoB = DateTime.Parse("23/09/2016"),
                AniDesc = "Likes to be stroked",
                AniPic = "https://www.nationalgeographic.com/content/dam/animals/pictures/reptiles/b/burmese-python/burmese-python.jpg"
            });
        }

    }
}