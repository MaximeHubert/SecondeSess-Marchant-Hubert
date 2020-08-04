using ApplicWEB.Models;
using ApplicWEB.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApplicWEB.Controllers
{
    public class ActorsController : Controller
    {
        public ActionResult Index (string NumPage ="0")
        {
            Service1Client WPF = new Service1Client();
            List<Actor> ListActors = new List<Actor>();
            ICollection<DTO.Actor> ListActorDTO = WPF.RecupActorByPage(Int32.Parse(NumPage));
            ViewData["Numpage"] = NumPage;
            ViewData["Nombre"] = ListActorDTO.Count.ToString();

            if (ListActorDTO.Count == 0)
            {
                return Index("0");
            }

            foreach (DTO.Actor a in ListActorDTO)
            {
                DTO.FullActor actor = WPF.RecupAllActor(a.Id);
                float nombre = 0;
                float total = 0;
                float moyenne = 0;

                foreach (DTO.Comment c in actor.Comment)
                {
                    total = total + c.Rate;
                    nombre++;
                }

                if (nombre == 0)
                {
                     moyenne = 0;
                }
                else
                {
                     moyenne = total / nombre;
                    moyenne = moyenne * 10;
                }

                ListActors.Add(new Actor(a.Id, a.Name, a.Surname, (int)moyenne));
            }


            return View(ListActors);
        }

    }
}