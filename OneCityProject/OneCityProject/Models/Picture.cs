using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OneCityProject.Models
{
    public class Picture
    {
        [Key]
        public int ID { get; set; }

        [StringLength(255)]
        public string FileName { get; set; }
        [StringLength(100)]
        public string ContentType { get; set; }
        public byte[] Content { get; set; }

        [ForeignKey("Post")]
        public int PostID { get; set; }
        public virtual Post Post { get; set; }

    }
}