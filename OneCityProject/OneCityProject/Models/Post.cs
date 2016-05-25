using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace OneCityProject.Models
{
    public class Post
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }

        public virtual User User { get; set; }

        [ForeignKey("Vote")]
        public int VoteId { get; set; }
        public virtual ICollection<Vote> Votes { get; set; }

        [ForeignKey("PostLocation")]
        public int LocationID { get; set; }

        public virtual PostLocation PostLocation { get; set; }

        public bool Anonymous { get; set; }

        public DateTime Time { get; set; }

        public string Status { get; set; }

        public string Picture { get; set; }

        public string GovernmentComment { get; set; }  

    }
}