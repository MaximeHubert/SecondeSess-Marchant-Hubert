using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApplicWEB.Models
{
    public class Comment : DTO.Comment
    {

        public Comment(string name, int rate, long idActor, string avatar, string date) : base (name,rate,idActor,avatar,date)
        {

        }



    }
}