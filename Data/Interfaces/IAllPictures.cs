using PhotoCard.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoCard.Data.Interfaces
{
    public interface IAllPictures
    {
        IEnumerable<Pictures> AllPictures { get; }
        IEnumerable<Pictures> getFavPictures { get; set; }
        Pictures getObjectPictures(int picId);
    }
}
