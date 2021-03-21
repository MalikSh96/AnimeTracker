using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AnimeTracker.Models
{
    [Table("Anime")]
    public class Anime
    {
        [Key]
        public int anime_id { get; set; }

        public string animename { get; set; }
        public string description { get; set; }
        public string release_date { get; set; }

    }
}
