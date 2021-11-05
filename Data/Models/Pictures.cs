using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoCard.Data.Models
{
    public class Pictures
    {
        //public int id { get; set; }
        public string name { get; set; }
        public string img { get; set; }
        public string desc { get; set; }
        public string  sizePx { get; set; }
        public int sizeMB { get; set; }
        public double price { get; set; }
        public int available { get; set; }
        public bool isFavourite { get; set; }
        
    }
}
