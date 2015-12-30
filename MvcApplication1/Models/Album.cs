using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class Album
    {
        public int AlbumID { get; set; }

        [Required()]
        [StringLength(100, MinimumLength = 2)]
        public String Title { get; set; }

        
        public int ArtistID { get; set; }

        public virtual Artist Artist { get; set; }
    }
}