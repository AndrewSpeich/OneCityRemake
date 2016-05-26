using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace OneCityProject.Models
{
    public class PostLocation
    {
		public string Address { get; set; }


		[Key]
		public int ID { get; set; }

		
		[ForeignKey("Post")]
	
		public int PostID { get; set; }

		public virtual Post Post { get; set; }




	}
}