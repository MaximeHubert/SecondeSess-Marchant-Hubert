using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicWPF
{
    class CommentViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Rate { get; set; }
        public long IdActor { get; set; }
        public string Avatar { get; set; }
        public string Date { get; set; }

        public CommentViewModel()
        {
        }



        public CommentViewModel(string name, string rate, long idActor, string avatar, string date)
        {
            Name = name;
            Rate = rate;
            IdActor = idActor;
            Avatar = avatar;
            Date = date;

        }

    }
}
