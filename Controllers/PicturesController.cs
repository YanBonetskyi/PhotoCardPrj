using Microsoft.AspNetCore.Mvc;
using PhotoCard.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoCard.Controllers
{
    public class PicturesController : Controller
    {
        private readonly IAllPictures _allPictures;

        public PicturesController(IAllPictures iAllPictures)
        {
            _allPictures = iAllPictures;
        }

        public ViewResult List()
        {
            var pictures = _allPictures.AllPictures;
            return View();
        }
    }
}
