using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApplicWEB.Models
{
    public class Comment 
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Rate { get; set; }
        public long IdActor { get; set; }
        public string Avatar { get; set; }
        public string Date { get; set; }

        public Comment()
        {
        }



        public Comment(string name, string rate, long idActor, string avatar, string date)
        {
            Name = name;
            Rate = rate;
            IdActor = idActor;
            Avatar = avatar;
            Date = date;

        }



    }
}