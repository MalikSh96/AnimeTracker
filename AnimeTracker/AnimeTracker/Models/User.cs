using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace AnimeTracker.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int user_id { get; set; }

        public string username { get; set; }
        public string email { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public bool admin { get; set; }
        public string password { get; set; }
        public string profilepic_path { get; set; }
    }
}
