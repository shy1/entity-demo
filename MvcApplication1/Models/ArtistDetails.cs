using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class ArtistDetails
    {
        [Key()]
        [ForeignKey("Artist")]
        public int ArtistID { get; set; }

        public String Bio { get; set; }
        public virtual Artist Artist { get; set; }


    }
}