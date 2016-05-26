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

		public bool Anonymous { get; set; }

		public DateTime Time { get; set; }

		public string Status { get; set; }

		public string Picture { get; set; }

		public string GovernmentComment { get; set; }


		[ForeignKey("Vote")]
		public int VotesId { get; set; }
		public virtual ICollection<Vote> Vote { get; set; }


		[ForeignKey("PostLocation")]
		public int PostLocationID { get; set; }

		public virtual PostLocation PostLocation { get; set; }


		[ForeignKey("ApplicationUser")]
		public string UserID { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }








	}
}