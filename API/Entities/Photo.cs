using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    [Table("Photos")]
    public class Photo
    {
        public int id{ get; set; }
        public string Url { get; set; }

        public bool IsMain { get; set; }

        public string PublicId { get; set; }

        public AppUser AppUser {get; set;}

        public int AppUserId {get; set;}
    }
}