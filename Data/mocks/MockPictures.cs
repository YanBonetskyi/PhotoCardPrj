using PhotoCard.Data.Interfaces;
using PhotoCard.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoCard.Data.mocks
{
    public class MockPictures : IAllPictures
    {

        public IEnumerable<Pictures> AllPictures
        {
            get
            {
                return new List<Pictures>
                { new Pictures
                    {
                        name = "banana",
                        img = "https://amp.nashzelenyimir.ru/cl_resize/-2LivIupJ5kZoLbNtHJdT9h538LwVQ_mKFl6DfB_60M/rs:fill:500:0/g:ce/q:70/aHR0cHM6Ly9uYXNoemVsZW55aW1pci5ydS93cC1jb250ZW50L3VwbG9hZHMvMjAxNi8wNy8lRDAlOTElRDAlQjAlRDAlQkQlRDAlQjAlRDAlQkQtJUQxJTg0JUQwJUJFJUQxJTgyJUQwJUJFLmpwZw",
                        desc = "nice banana",
                        sizePx = "600x600",
                        sizeMB = 11,
                        price = 1.78,
                        available = 10,
                        isFavourite = true
                    },
                   new Pictures
                   {
                        name = "girl",
                        img = "https://i.pinimg.com/736x/c8/3b/b6/c83bb6a16a13fe7bf2606b53823958c2.jpg",
                        desc = "nice girl",
                        sizePx = "1200x600",
                        sizeMB = 16,
                        price = 3.12,
                        available = 2,
                        isFavourite = true
                    },
                   new Pictures
                   {
                        name = "Toyota",
                        img = "https://i.pinimg.com/originals/a3/0a/15/a30a1546b47c408572faddaf565f2c0a.jpg",
                        desc = "2JZ",
                        sizePx = "1200x2048",
                        sizeMB = 22,
                        price = 4.42,
                        available = 5,
                        isFavourite = true
                   }
                };
            }                
        }



        public IEnumerable<Pictures> getFavPictures { get; set; }

        public Pictures getObjectPictures(int picId)
        {
            throw new NotImplementedException();
        }
    }
      
}
