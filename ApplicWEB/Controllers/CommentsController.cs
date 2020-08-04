using ApplicWEB.Models;
using ApplicWEB.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace ApplicWEB.Controllers
{
    public class CommentsController : Controller
    {
        [HttpGet]
        public ActionResult Index(long id = 0, string NumPage = "0")
        {
            Service1Client WPF = new Service1Client();
            List<Comment> ListComment = new List<Comment>();
            DTO.FullActor actor = WPF.RecupAllActor(id);
            ViewData["Nombre"] = NumPage;
            ViewData["Id"] = id;

            foreach (DTO.Comment c in actor.Comment)
            {
                string Tmp = "";

                switch (c.Rate)
                {
                    case 1:
                        Tmp = "★";
                        break;
                    case 2:
                        Tmp = "★★";
                        break;
                    case 3:
                        Tmp = "★★★";
                        break;
                    case 4:
                        Tmp = "★★★★";
                        break;
                    case 5:
                        Tmp = "★★★★★";
                        break;

                }
                ListComment.Add(new Comment(c.Name, Tmp, c.IdActor, c.Avatar, c.Date));
            }

            return View(ListComment);
        }

        [HttpPost]
        public ActionResult Index(int  id, string avatar, string content, int rate)
        {
            Service1Client WPF = new Service1Client();
            WPF.AddComment(id, avatar, content, rate);
            return Index(id);
        }
    }
}