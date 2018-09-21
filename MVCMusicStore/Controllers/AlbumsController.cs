using MVCMusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMusicStore.Controllers
{
    public class AlbumsController : Controller
    {
        // GET: Albums
        public ActionResult Index()
        {
            //create a mock list of type albums
            var albums = new List<Album>();

            for(int i=1; i <= 10; i++)
            {
                albums.Add(new Album { Title = "Album " + i.ToString() });
            }
            //add albums to viewBag for display
            //ViewBag.albums = albums;

            //pass the strongly typed list directly to yhe view


            return View(albums);
        }
    }
}