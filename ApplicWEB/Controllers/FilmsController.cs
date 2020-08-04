using ApplicWEB.Models;
using ApplicWEB.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApplicWEB.Controllers
{
    public class FilmsController : Controller
    {
        public ActionResult Index(long id= 0 , string NumPage ="0")
        {
            Service1Client WPF = new Service1Client();
            List<Film> ListFilms = new List<Film>();
            ICollection<DTO.Film> ListFilmDTO = WPF.RecupFilmActor(id);
            ViewData["Nombre"] = NumPage;

            foreach (DTO.Film f in ListFilmDTO)
            {
                ListFilms.Add(new Film(f.Title, f.ReleaseDate, f.RunTime, f.PosterPath));
            }

            return View(ListFilms);
        }

    }
}