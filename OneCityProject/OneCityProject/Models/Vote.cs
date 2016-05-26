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
		[Key]
        public int ID { get; set; }
		public string Direction { get; set; }


		[ForeignKey("Post")]
		public int PostID { get; set; }
		public virtual Post Post { get; set; }



		[ForeignKey("ApplicationUser")]
		public string UserID { get; set; }

		public virtual ApplicationUser ApplicationUser { get; set; }


	}
}