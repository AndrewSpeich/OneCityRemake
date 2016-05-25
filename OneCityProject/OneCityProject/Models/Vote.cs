using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OneCityProject.Models
{
    public class Vote
    {

        public int ID { get; set; }

        [Key]
        [ForeignKey("Post")]
        public int PostID { get; set; }

        [Key]
        [ForeignKey("User")]
        public int UserID { get; set; }

        public string Direction { get; set; }

    }
}